using FastReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastReportBGObjects.BubbleChart
{
    public partial class BubbleObject : ChartBaseBG, IHasEditor
    {
        public bool InvokeEditor()
        {
            using (BubbleEditorForm form = new BubbleEditorForm(this, Report))
            {
                return form.ShowDialog() == DialogResult.OK;
            }
        }
    }
}
