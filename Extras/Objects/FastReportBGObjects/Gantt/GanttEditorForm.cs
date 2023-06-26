using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using FastReport;
using FastReport.Data;
using FastReport.Forms;
using FastReport.Utils;

namespace FastReportBGObjects.Gantt
{
    public partial class GanttEditorForm : FastReport.BG.Forms.GanttEditorForm
    {
        private Report report;
        private bool isInit = false;
        protected Report Report => report;
        protected GanttObject GanttObject;
        public GanttEditorForm()
        {
            InitializeComponent();
            Setup();
        }
        public GanttEditorForm(GanttObject Gantt, Report report) : base(Gantt.GanttChart)
        {
            InitializeComponent();
            this.report = report;
            GanttObject = Gantt;
            Setup();
        }

        protected override void Setup()
        {
            isInit = true;
            base.Setup();
            
            cbNameColumn.Report = Report;
            cbStartDateColumn.Report = Report;
            cbEndDateColumn.Report = Report;
            cbResourceColumn.Report = Report;
            cbData.Items.Clear();
            cbData.Items.Add(Res.Get("Misc,None"));
            cbData.SelectedIndex = 0;
            foreach (Base c in Report.Dictionary.AllObjects)
            {
                DataSourceBase ds = c as DataSourceBase;
                if (ds != null && ds.Enabled)
                {
                    cbData.Items.Add(ds.Alias);
                    if (GanttObject.DataSource == ds)
                        cbData.SelectedIndex = cbData.Items.Count - 1;
                }
                //GanttObject.DataSource = ds;
            }
            
            cbNameColumn.Text = GanttObject.NameColumn;
            cbStartDateColumn.Text = GanttObject.StartDateColumn;
            cbEndDateColumn.Text = GanttObject.EndDateColumn;
            cbResourceColumn.Text = GanttObject.ResourceColumn;
            
            isInit = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Apply();
            DialogResult = DialogResult.OK;
            
            DataSourceBase dsSelect = Report.GetDataSource((string)cbData.Items[cbData.SelectedIndex]);
            GanttObject.DataSource = dsSelect;
            GanttObject.NameColumn = cbNameColumn.Text;
            GanttObject.StartDateColumn = cbStartDateColumn.Text;
            GanttObject.EndDateColumn = cbEndDateColumn.Text;
            GanttObject.ResourceColumn = cbResourceColumn.Text;
            
            Close();
        }

        private void cbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInit) return;
            
            DataSourceBase dsSelect = Report.GetDataSource((string)cbData.Items[cbData.SelectedIndex]);            
            GanttObject.DataSource = dsSelect;
            cbNameColumn.DataSource = dsSelect;
            cbStartDateColumn.DataSource = dsSelect;
            cbEndDateColumn.DataSource = dsSelect;
            cbResourceColumn.DataSource = dsSelect;            
        }
    }
}
