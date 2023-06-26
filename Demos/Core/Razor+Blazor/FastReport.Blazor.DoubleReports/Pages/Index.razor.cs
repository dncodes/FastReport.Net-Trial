using FastReport.Web;
using System;
using System.Data;
using System.Drawing;
using System.IO;

namespace FastReport.Blazor.DoubleReports.Pages
{
    public partial class Index
    {
        readonly string directory;
        const string DEFAULT_REPORT = "Filter Employees.frx";
        public Report Report1 { get; set; }
        public Report Report2 { get; set; }
        public WebReport UserWebReport { get; set; }

        public WebReport UserWebReport2 { get; set; }

        DataSet DataSet { get; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            string path1 = Path.Combine(directory, string.IsNullOrEmpty(firstReport) ? DEFAULT_REPORT : firstReport);
            string path2 = Path.Combine(directory, string.IsNullOrEmpty(secondReport) ? DEFAULT_REPORT : secondReport);

            if (Report1 == null || path1 != Report1.BaseReportAbsolutePath)
            {
                Report1 = Report.FromFile(path1);
                Report1.RegisterData(DataSet, "NorthWind");
            }

            if (Report2 == null || path2 != Report2.BaseReportAbsolutePath)
            {
                Report2 = Report.FromFile(path2);
                Report2.RegisterData(DataSet, "NorthWind");
            }

            ToolbarSettings toolbarSettings1 = new ToolbarSettings()
            {
                Color = Color.Red,
                IconColor = IconColors.White,
                Position = Positions.Left,
            };

            ToolbarSettings toolbarSettings2 = new ToolbarSettings()
            {
                Color = Color.Black,
                IconColor = IconColors.White,
                Position = Positions.Right,
            };

            UserWebReport = new WebReport
            {
                Report = Report1,
                Toolbar = toolbarSettings1,
            };
            UserWebReport2 = new WebReport
            {
                Report = Report2,
                Toolbar = toolbarSettings2,
            };
        }
        private string FindReportsFolder(string startDir)
        {
            string path = Path.Combine(startDir, "Reports");
            if (Directory.Exists(path))
                return path;

            for (int i = 0; i < 6; i++)
            {
                startDir = Path.Combine(startDir, "..");
                path = Path.Combine(startDir, "Reports");
                if (Directory.Exists(path))
                    return path;
            }

            throw new Exception("Demos/Reports directory is not found");
        }
        public Index()
        {
            directory = FindReportsFolder(Environment.CurrentDirectory);

            DataSet = new DataSet();
            DataSet.ReadXml(Path.Combine(directory, "nwind.xml"));

        }

    }
}
