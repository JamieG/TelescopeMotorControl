using System;
using System.Windows.Forms;

namespace TelescopeMotorControl.ControlHelpers
{
    public class RichTextBoxLogger : ILogger
    {
        private readonly RichTextBox _rtb;

        public RichTextBoxLogger(RichTextBox rtb)
        {
            _rtb = rtb;
        }

        public void Info(string message)
        {
            _rtb.AppendText($"{DateTime.Now:h:mm:ss tt}: {message}{Environment.NewLine}");
        }

        public void Error(string message, Exception exception)
        {
            _rtb.AppendText($"{DateTime.Now:h:mm:ss tt}: ERROR {message}{Environment.NewLine}{exception}");
        }
    }
}