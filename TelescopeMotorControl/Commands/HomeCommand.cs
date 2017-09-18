using System;
using System.IO;
using TelescopeMotorControl.Helpers;
using TelescopeMotorControl.Senders;

namespace TelescopeMotorControl.Commands
{
    public class HomeCommand : Command
    {
        private readonly ICheckSummer _checkSummer;
        private readonly ISender _sender;

        /// <summary>
        /// Required Azimuth bearing
        /// </summary>
        public Single AziB { get; set; }

        /// <summary>
        /// Required Altitude bearing
        /// </summary>
        public Single AltB { get; set; }

        public HomeCommand(ICheckSummer checkSummer, ISender sender)
        {
            _checkSummer = checkSummer;
            _sender = sender;
        }

        public override void Send()
        {
            using (var data = new MemoryStream())
            {
                data.WriteByte((byte)CommandIds.Home);

                data.Write(BitConverter.GetBytes(AziB), 0, 4);
                data.Write(BitConverter.GetBytes(AltB), 0, 4);
                data.Write(BitConverter.GetBytes(UInt16.MinValue), 0, 2);
                data.Write(BitConverter.GetBytes(UInt16.MinValue), 0, 2);
                data.Write(BitConverter.GetBytes(UInt16.MinValue), 0, 2);
                data.Write(BitConverter.GetBytes(UInt16.MinValue), 0, 2);
                data.Write(BitConverter.GetBytes(UInt16.MinValue), 0, 2);
                data.Write(BitConverter.GetBytes(UInt16.MinValue), 0, 2);
                data.Write(BitConverter.GetBytes(UInt16.MinValue), 0, 2);

                byte crc = _checkSummer.Calculate(data.ToArray());
                data.WriteByte(crc);

                _sender.Send("Home", data.ToArray());
            }
        }
    }
}