using FastReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastReportBGObjects.SunburstChart
{
    public partial class SunburstObject : IHasEditor
    {
        public bool InvokeEditor()
        {
            using (SunburstEditorForm form = new SunburstEditorForm(this, Report))
            {
                return form.ShowDialog() == DialogResult.OK;
            }
        }
    }
}
