using FastReport;
using FastReport.BG.Icicle;
using FastReport.BG.Styling;
using FastReport.Data;
using FastReport.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastReportBGObjects.IcicleChart
{
    public partial class IcicleEditorForm : BGChartEditorForm
    {
        private IcicleObject IcicleObject => (IcicleObject)ChartObject;

        public IcicleEditorForm(IcicleObject icicleObject, Report report) : base(icicleObject, report)
        {
        }

        public override void Init()
        {
            base.Init();

            foreach (IcicleDirection icicleDirection in Enum.GetValues(typeof(IcicleDirection)))
            {
                cbDirection.Items.Add(icicleDirection);
            }
            cbDirection.Text = IcicleObject.Direction.ToString();
        }

        public override void Localize()
        {
            base.Localize();
            MyRes res = new MyRes("Objects,FastBI,Appearance");
            labelDir.Text = res.Get("IcicleDirection");
            this.Text = res.Get("IcicleForm");
        }

        private void cbDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            IcicleObject.Direction = (IcicleDirection)cbDirection.SelectedIndex;
        }
    }
}
