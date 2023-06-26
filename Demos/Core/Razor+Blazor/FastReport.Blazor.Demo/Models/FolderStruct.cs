using System.Collections.Generic;

namespace FastReport.Blazor.Demo.Models
{
    public class FolderStruct
    {
        /// <summary>
        /// List of reports in folder
        /// </summary>
        public List<ReportStruct> Reports { get; set; }

        public bool Hiden { get; set; } = true;

        /// <summary>
        /// Name of the folder
        /// </summary>
        public string FolderName { get; set; }

        /// <summary>
        /// Description of the folder
        /// </summary>
        public string Description { get; set; }


        public FolderStruct()
        {
            Reports = new List<ReportStruct>();
        }
    }
}
