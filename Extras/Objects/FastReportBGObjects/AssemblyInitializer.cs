using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FastReport.Utils;
using FastReportBGObjects.IcicleChart;
using FastReportBGObjects.SunburstChart;
using FastReportBGObjects.TreemapChart;
using FastReportBGObjects.BubbleChart;
//using FastReportBGObjects.Gantt;

namespace FastReportBGObjects
{
    public class AssemblyInitializer : AssemblyInitializerBase
    {
        public AssemblyInitializer()
        {
            Bitmap bg = ResourceLoader.GetBitmap("FastReportBGObjects", "bg.png");
            RegisteredObjects.AddCategory("ReportPage,FastBI", bg, Res.Get("Objects,FastBI"));
            RegisteredObjects.Add(typeof(SunburstObject), "ReportPage,FastBI", bg, Res.Get("Objects,FastBI,Sunburst"), 0);
            RegisteredObjects.Add(typeof(IcicleObject), "ReportPage,FastBI", bg, Res.Get("Objects,FastBI,Icicle"), 0);
            RegisteredObjects.Add(typeof(TreeMapObject), "ReportPage,FastBI", bg, Res.Get("Objects,FastBI,TreeMap"), 0);
            RegisteredObjects.Add(typeof(BubbleObject), "ReportPage,FastBI", bg, Res.Get("Objects,FastBI,Bubble"), 0);

            //RegisteredObjects.Add(typeof(GanttObject), "ReportPage,FastBI", ResourceLoader.GetBitmap("FastReportBGObjects", "GanttLogo.png"), Res.Get("Objects,FastBI,Gantt"), 0);
        }
    }
}
