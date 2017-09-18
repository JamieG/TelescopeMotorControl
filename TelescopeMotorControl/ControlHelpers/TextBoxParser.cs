using System;
using System.Drawing;
using System.Windows.Forms;

namespace TelescopeMotorControl.ControlHelpers
{
    public class TextBoxParser
    {
        public T Parse<T>(TextBox control, Func<string, T> parser, Action<Exception> failureHandler = null)
        {
            return Parse(control, parser, Color.Red, Color.White, failureHandler);
        }

        public T Parse<T>(TextBox control, Func<string, T> parser, Color failureBackColor, Color failureForeColor, Action<Exception> failureHandler = null)
        {
            try
            {
                return parser(control.Text);
            }
            catch (Exception exception)
            {
                control.BackColor = failureBackColor;
                control.ForeColor = failureForeColor;
                failureHandler?.Invoke(exception);
                return default(T);
            }
        }
    }
}