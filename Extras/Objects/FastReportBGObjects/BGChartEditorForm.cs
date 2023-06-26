using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using FastReport;
using FastReport.Data;
using FastReport.Forms;
using FastReport.Utils;
using FastReport.BG.Styling;

namespace FastReportBGObjects
{
    public partial class BGChartEditorForm : BaseDialogForm
    {
        private Report report;
        private ChartBaseBG originalChartObject;
        private ChartBaseBG chartObject;
        private bool updating = false;

        public ChartBaseBG ChartObject
        {
            get { return chartObject; }
            set
            {
                originalChartObject = value;
                ConstructorInfo ctor = value.GetType().GetConstructor(Type.EmptyTypes);
                chartObject = (ChartBaseBG)ctor.Invoke(null);

                chartObject.AssignAll(originalChartObject);
                chartObject.SetReport(report);
            }
        }

        protected Report Report => report;

        public BGChartEditorForm()
        {
            // not used - for designed only
            InitializeComponent();
        }

        public BGChartEditorForm(ChartBaseBG chart, Report report) : base()
        {
            this.report = report;
            this.ChartObject = chart;
            InitializeComponent();
            Init();
            Localize();
        }

        public override void Localize()
        {
            base.Localize();
            MyRes res = new MyRes("Objects,FastBI,Data");
            pgGeneral.Text = res.Get("");
            labelValue.Text = res.Get("ValueColumn");

            gbExpressions.Text = res.Get("TextColumns");
            btnAdd.Text = res.Get("Add");
            btnDelete.Text = res.Get("Delete");
            btnEdit.Text = res.Get("Edit");
            btnUp.Image = Res.GetImage(208, 96);
            btnDown.Image = Res.GetImage(209, 96);

            labelRoot.Text = res.Get("RootText");
            labelData.Text = res.Get("DataSource");
            labelDepth.Text = res.Get("MaxDepth");
            res = new MyRes("Objects,FastBI,Appearance");
            pgStyle.Text = res.Get("");
            labelPalette.Text = res.Get("Palette");
        }

        public virtual void Init()
        {
            updating = true;
            // set palette
            cbPalette.Items.Clear();
            foreach (string paletteName in Enum.GetNames(typeof(PaletteType)))
            {
                cbPalette.Items.Add(paletteName);
            }
            cbPalette.SelectedIndex = Convert.ToInt32(ChartObject.Palette.PaletteType);

            // set max depth
            tbDepth.Value = ChartObject.MaxDepth;

            // set data
            tbRoot.Text = ChartObject.RootText;
            cbValueColumn.Report = Report;
            cbValueColumn.Text = ChartObject.ValueColumn;
            populateTextColumns();

            cbData.Items.Clear();
            cbData.Items.Add(Res.Get("Misc,None"));
            cbData.SelectedIndex = 0;
            foreach (Base c in Report.Dictionary.AllObjects)
            {
                DataSourceBase ds = c as DataSourceBase;
                if (ds != null && ds.Enabled)
                {
                    cbData.Items.Add(ds.Alias);
                    if (ChartObject.DataSource == ds)
                        cbData.SelectedIndex = cbData.Items.Count - 1;
                }
            }

            ChartObject.BGChart.Parent = panelView;
            ChartObject.BGChart.Dock = DockStyle.Fill;
            updating = false;
        }

        private string CurrentTextColumn
        {
            get
            {
                if (lvExpressions.SelectedItems.Count == 0)
                    return null;
                return lvExpressions.SelectedItems[0].Text;
            }
        }
        private void UpdateControls()
        {
            bool enabled = CurrentTextColumn != null;
            btnDelete.Enabled = enabled;
            btnEdit.Enabled = enabled;
            btnUp.Enabled = enabled;
            btnDown.Enabled = enabled;
        }

        private void populateTextColumns()
        {
            foreach (string str in ChartObject.TextColumns)
            {
                ListViewItem li = lvExpressions.Items.Add(str);
            }
            if (lvExpressions.Items.Count > 0)
                lvExpressions.Items[0].Selected = true;
            UpdateControls();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string expression = Editors.EditExpression(Report, string.Empty);
            if (!string.IsNullOrEmpty(expression))
            {
                ChartObject.TextColumns.Add(expression);

                ListViewItem li = lvExpressions.Items.Add(expression);
                lvExpressions.SelectedItems.Clear();
                li.Selected = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            while (lvExpressions.SelectedItems.Count > 0)
            {
                int idx = lvExpressions.SelectedItems[0].Index;
                ChartObject.TextColumns.RemoveAt(idx);
                lvExpressions.Items.RemoveAt(idx);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvExpressions.SelectedItems.Count == 1)
            {
                string expression = Editors.EditExpression(Report, CurrentTextColumn);
                if (expression != CurrentTextColumn)
                {
                    int idx = lvExpressions.SelectedItems[0].Index;
                    ChartObject.TextColumns[idx] = expression;
                    lvExpressions.Items[idx].Text = expression;
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lvExpressions.SelectedItems.Count != 1)
                return;
            int index = lvExpressions.SelectedIndices[0];
            if (index > 0)
            {
                ListViewItem li = lvExpressions.SelectedItems[0];
                lvExpressions.Items.Remove(li);
                lvExpressions.Items.Insert(index - 1, li);

                string expression = CurrentTextColumn;
                ChartObject.TextColumns.RemoveAt(index);
                ChartObject.TextColumns.Insert(index - 1, expression);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lvExpressions.SelectedItems.Count != 1)
                return;
            int index = lvExpressions.SelectedIndices[0];
            if (index < lvExpressions.Items.Count - 1)
            {
                ListViewItem li = lvExpressions.SelectedItems[0];
                lvExpressions.Items.Remove(li);
                lvExpressions.Items.Insert(index + 1, li);

                string expression = CurrentTextColumn;
                ChartObject.TextColumns.RemoveAt(index);
                ChartObject.TextColumns.Insert(index + 1, expression);
            }
        }

        protected void tbDepth_ValueChanged(object sender, EventArgs e)
        {
            if (updating) return;
            ChartObject.MaxDepth = (int)tbDepth.Value;
        }

        protected void tbRoot_TextChanged(object sender, EventArgs e)
        {
            if (updating) return;
            ChartObject.RootText = tbRoot.Text;
        }

        private void cbPalette_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updating) return;
            ChartObject.Palette.PaletteType = (PaletteType)cbPalette.SelectedIndex;
        }

        private void cbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updating) return;
            DataSourceBase dsSelect = Report.GetDataSource((string)cbData.Items[cbData.SelectedIndex]);
            ChartObject.DataSource = dsSelect;
            cbValueColumn.DataSource = dsSelect;
        }

        private void cbValueColumn_Leave(object sender, EventArgs e)
        {
            ChartObject.ValueColumn = cbValueColumn.Text;
        }

        private void panelView_Paint(object sender, PaintEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                e.Graphics.ResetClip();
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(ex.Message, Font, Brushes.Red, panelView.DisplayRectangle, sf);
                }
            }
        }

        private void BGChartEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                originalChartObject.AssignAll(ChartObject);
            }
        }

        private void lvExpressions_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }
    }
}
