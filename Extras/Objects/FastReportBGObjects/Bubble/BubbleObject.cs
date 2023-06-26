using System.ComponentModel;
using FastReport;
using FastReport.Utils;
using FastReport.BG.Bubble;

namespace FastReportBGObjects.BubbleChart
{

    public partial class BubbleObject : ChartBaseBG
    {
        private Bubble Bubble
        {
            get { return (Bubble)baseChart; }
        }
        public BubbleObject() : base(new Bubble())
        {
        }


    }
}
