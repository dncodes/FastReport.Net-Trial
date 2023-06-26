using FastReport;
using FastReport.BG.Bubble;
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

namespace FastReportBGObjects.BubbleChart
{
    public partial class BubbleEditorForm : BGChartEditorForm
    {
        private BubbleObject BubbleObject => (BubbleObject)ChartObject;

        public BubbleEditorForm(BubbleObject bubbleObject, Report report) : base(bubbleObject, report)
        {
        }

        public override void Localize()
        {
            base.Localize();
            MyRes res = new MyRes("Objects,FastBI,Appearance");
            //labelDir.Text = res.Get("IcicleDirection");
            this.Text = res.Get("BubbleForm");
        }
    }
}
