using System.Collections.Generic;

namespace TelescopeMotorControl.Senders
{
    /// <summary>
    /// Send to a collection of senders at the same time, i.e debug output and usb output
    /// </summary>
    public class MultiSender : ISender
    {
        private readonly IList<ISender> _senders;

        public MultiSender(IList<ISender> senders)
        {
            _senders = senders;
        }

        public void Send(string command, byte[] data)
        {
            foreach (ISender sender in _senders)
            {
                sender.Send(command, data);
            }
        }
    }
}