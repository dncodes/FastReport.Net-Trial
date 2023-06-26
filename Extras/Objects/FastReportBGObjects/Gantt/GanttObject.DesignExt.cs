using FastReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FastReportBGObjects.Gantt
{
    public partial class GanttObject: IHasEditor
    {
        public bool InvokeEditor()
        {
            using (GanttEditorForm form = new GanttEditorForm(this, Report))
            {
                return form.ShowDialog() == DialogResult.OK;
            }
        }
    }
}
