using FastReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastReportBGObjects.IcicleChart
{
    public partial class IcicleObject : ChartBaseBG, IHasEditor
    {
        public bool InvokeEditor()
        {
            using (IcicleEditorForm form = new IcicleEditorForm(this, Report))
            {
                return form.ShowDialog() == DialogResult.OK;
            }
        }
    }
}
