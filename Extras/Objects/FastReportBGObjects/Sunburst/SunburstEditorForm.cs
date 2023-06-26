using FastReport;
using FastReport.BG.Styling;
using FastReport.Data;
using FastReport.Utils;
using FastReportBGObjects.SunburstChart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastReportBGObjects.SunburstChart
{
    public partial class SunburstEditorForm : BGChartEditorForm
    {
        private SunburstObject SunburstObject => (SunburstObject)ChartObject;

        public SunburstEditorForm(SunburstObject sunburstObject, Report report) : base(sunburstObject, report)
        {
        }

        public override void Init()
        {
            base.Init();

            tbAngle.Text = SunburstObject.StartAngle.ToString();

            foreach (TextArcDirection textArc in Enum.GetValues(typeof(TextArcDirection)))
            {
                cbDirection.Items.Add(textArc);
            }
            cbDirection.Text = SunburstObject.TextDirection.ToString();
        }

        public override void Localize()
        {
            base.Localize();
            MyRes res = new MyRes("Objects,FastBI,Appearance");
            labelAngle.Text = res.Get("StartAngle");
            labelDir.Text = res.Get("TextDirection");
            this.Text = res.Get("SunburstForm");
        }

        private void tbAngle_ValueChanged(object sender, EventArgs e)
        {
            SunburstObject.StartAngle = (int)tbAngle.Value;
        }

        private void cbDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            SunburstObject.TextDirection = (TextArcDirection)cbDirection.SelectedIndex;
        }
    }
}
