using FastReport.Web;
using Microsoft.AspNetCore.Mvc;

namespace FastReport.Core.Angular.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SampleDataController : Controller
    {
        private readonly DataSetService _dataSetService;


        public SampleDataController(DataSetService dataSetService)
        {
            _dataSetService = dataSetService;
        }
        [HttpGet("[action]")]
        public IActionResult ShowReport(string name)
        {
            WebReport WebReport = new WebReport();
            WebReport.Width = "1000";
            WebReport.Height = "1000";

            WebReport.Report.Load(Path.Combine(_dataSetService.ReportsPath, name + ".frx"));
            WebReport.Report.RegisterData(_dataSetService.DataSet, "NorthWind");

            WebReport.Toolbar = new ToolbarSettings()
            {
                Position = Positions.Left,
                Exports = new ExportMenuSettings() { ExportTypes = Exports.Pdf }
            };

            ViewBag.WebReport = WebReport;


            return View();
        }
    }
}
