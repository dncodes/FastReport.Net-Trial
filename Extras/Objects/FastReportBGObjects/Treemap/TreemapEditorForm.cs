using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport.Data;
using FastReport;
using FastReport.Utils;
using FastReport.BG.TreeMap;

namespace FastReportBGObjects.TreemapChart
{
    public partial class TreemapEditorForm : BGChartEditorForm
    {
        private TreeMapObject TreeMapObject => (TreeMapObject)ChartObject;

        public TreemapEditorForm(TreeMapObject treeMapObject, Report report) : base(treeMapObject, report)
        {
        }

        public override void Init()
        {
            base.Init();

            foreach (TreeMapLayoutMode treeMapLayout in Enum.GetValues(typeof(TreeMapLayoutMode)))
            {
                cbDirection.Items.Add(treeMapLayout);
            }
            cbDirection.Text = TreeMapObject.LayoutMode.ToString();
        }

        public override void Localize()
        {
            base.Localize();
            MyRes res = new MyRes("Objects,FastBI,Appearance");
            labelDir.Text = res.Get("LayoutMode");
            this.Text = res.Get("TreeMapForm");
        }

        private void cbDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeMapObject.LayoutMode = (TreeMapLayoutMode)cbDirection.SelectedIndex;
        }
    }
}
