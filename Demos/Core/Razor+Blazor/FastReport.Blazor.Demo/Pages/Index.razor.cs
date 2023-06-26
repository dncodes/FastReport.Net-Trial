using FastReport.Web;
using System.Data;
using System.IO;

namespace FastReport.Blazor.Demo.Pages
{
    public partial class Index
    {
        readonly string directory;
        const string DEFAULT_REPORT = "Simple List.frx";

        DataSet DataSet { get; }


        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            var report = Report.FromFile(
                Path.Combine(
                    directory,
                    string.IsNullOrEmpty(ReportName) ? DEFAULT_REPORT : ReportName));

            // Registers the application dataset
            report.RegisterData(DataSet, "NorthWind");

            UserWebReport = new WebReport
            {
                Report = report
            };
        }

        public Index()
        {
            directory = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    Path.Combine("..", "..", "..", "Reports"));

            DataSet = new DataSet();
            DataSet.ReadXml(Path.Combine(directory, "nwind.xml"));
        }

    }
}
