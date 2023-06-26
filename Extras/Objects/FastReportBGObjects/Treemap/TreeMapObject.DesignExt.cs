using FastReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastReportBGObjects.TreemapChart
{
    public partial class TreeMapObject : ChartBaseBG, IHasEditor
    {
        public bool InvokeEditor()
        {
            using (TreemapEditorForm form = new TreemapEditorForm(this, Report))
            {
                return form.ShowDialog() == DialogResult.OK;
            }
        }
    }
}
