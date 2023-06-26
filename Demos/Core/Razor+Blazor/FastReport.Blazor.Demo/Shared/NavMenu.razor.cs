using FastReport.Blazor.Demo.Data;
using FastReport.Blazor.Demo.Models;
using System.Collections.Generic;
using System.Linq;

namespace FastReport.Blazor.Demo.Shared
{
    public partial class NavMenu
    {
        private readonly IReadOnlyList<FolderStruct> Groups;

        public NavMenu()
        {
            Groups = new ReportList().Folders;
            Groups.FirstOrDefault().Hiden = false;
        }

        private void FolderClick(FolderStruct folder)
        {
            folder.Hiden = !folder.Hiden;
        }

    }
}
