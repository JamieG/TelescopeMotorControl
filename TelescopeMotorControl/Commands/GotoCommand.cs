using System;
using System.IO;
using TelescopeMotorControl.Helpers;
using TelescopeMotorControl.Senders;

namespace TelescopeMotorControl.Commands
{
    public class GotoCommand : Command
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

        /// <summary>
        /// Required Azimuth Motor Speed
        /// </summary>
        public UInt16 AziS { get; set; }

        /// <summary>
        /// Required Altitude Motor Speed
        /// </summary>
        public UInt16 AltS { get; set; }

        /// <summary>
        /// Required Acceleration for Azimuth Motor
        /// </summary>
        public UInt16 AziA { get; set; }

        /// <summary>
        /// Required Acceleration for Altitude Motor
        /// </summary>
        public UInt16 AltA { get; set; }

        /// <summary>
        /// Required Deceleration for Azimuth Motor
        /// </summary>
        public UInt16 AziD { get; set; }

        /// <summary>
        /// Required Deceleration for Altitude Motor
        /// </summary>
        public UInt16 AltD { get; set; }

        public GotoCommand(ICheckSummer checkSummer, ISender sender)
        {
            _checkSummer = checkSummer;
            _sender = sender;
        }

        public override void Send()
        {
            using (var data = new MemoryStream())
            {
                data.WriteByte((byte)CommandIds.Goto);

                data.Write(BitConverter.GetBytes(AziB), 0, 4);
                data.Write(BitConverter.GetBytes(AltB), 0, 4);
                data.Write(BitConverter.GetBytes(AziS), 0, 2);
                data.Write(BitConverter.GetBytes(AltS), 0, 2);
                data.Write(BitConverter.GetBytes(AziA), 0, 2);
                data.Write(BitConverter.GetBytes(AltA), 0, 2);
                data.Write(BitConverter.GetBytes(AziD), 0, 2);
                data.Write(BitConverter.GetBytes(AziS), 0, 2);
                data.Write(BitConverter.GetBytes(AltD), 0, 2);

                byte crc = _checkSummer.Calculate(data.ToArray());
                data.WriteByte(crc);

                _sender.Send("Goto", data.ToArray());
            }
        }
    }
}