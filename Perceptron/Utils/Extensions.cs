using System;
using System.Windows.Forms;

namespace bballesteros.PNN.Utils
{
    public static class ControlExtensions
    {
        public static void AsyncUpdate(this Control control, Action code)
        {
            if(control.InvokeRequired)
            {
                control.Invoke(code);
            }else
            {
                code.Invoke();
            }
        }
    }
}
