using FastReport.Web;

namespace FastReport.Core.MVC.DataBase.Models
{
    public class HomeModel
    {
        public WebReport WebReport { get; set; }
        public string[] ReportsList { get; set; }
    }
}
