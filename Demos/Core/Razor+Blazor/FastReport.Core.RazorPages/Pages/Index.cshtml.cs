using FastReport.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace FastReportCore.RazorPages.Net6.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(Name = "report", SupportsGet = true)]
        public int ReportIndex { get; set; } = 0;
        public WebReport WebReport { get; set; } = new WebReport();

        public string[] ReportsList { get; set; } = new[]
        {
            "Simple List",
            "Labels",
            "Master-Detail",
            "Badges",
            "Advanced Matrix",
            "Interactive Report, 2-in-1",
            "Hyperlinks, Bookmarks",
            "Outline",
            "Complex (Hyperlinks, Outline, TOC)",
            "Drill-Down Groups",
            "Mail Merge",
            "Polygon",
            "Chart",
            "Hello, FastReport!",
            "Print Entered Value",
            "Filtering with CheckedListBox",
            "Filtering with Ranges",
            "Cascaded Data Filtering",
            "Handle Dialog Forms",
            "Dialog Elements",
            "Barcode",
        };

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var reportToLoad = ReportsList[0];
            if (ReportIndex >= 0 && ReportIndex < ReportsList.Length)
                reportToLoad = ReportsList[ReportIndex];

            string dir = FindReportsFolder(Environment.CurrentDirectory);

            WebReport.Report.Load(Path.Combine(dir, $"{reportToLoad}.frx"));

            var dataSet = new DataSet();
            dataSet.ReadXml(Path.Combine(dir, "nwind.xml"));
            WebReport.Report.RegisterData(dataSet, "NorthWind");
        }
        private string FindReportsFolder(string startDir)
        {
            string directory = Path.Combine(startDir, "Reports");
            if (Directory.Exists(directory))
                return directory;

            for (int i = 0; i < 6; i++)
            {
                startDir = Path.Combine(startDir, "..");
                directory = Path.Combine(startDir, "Reports");
                if (Directory.Exists(directory))
                    return directory;
            }

            throw new Exception("Demos/Reports directory is not found");
        }
    }
}