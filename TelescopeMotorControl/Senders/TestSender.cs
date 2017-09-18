using System.Text;
using TelescopeMotorControl.ControlHelpers;

namespace TelescopeMotorControl.Senders
{
    public class TestSender : ISender
    {
        private readonly ILogger _logger;

        public TestSender(ILogger logger)
        {
            _logger = logger;
        }

        public void Send(string command, byte[] data)
        {
            var outputBuilder = new StringBuilder();

            outputBuilder.AppendLine();
            outputBuilder.AppendLine($"Command: {command}");
            outputBuilder.AppendLine("Index | Dec | Hex ");

            outputBuilder.AppendLine("=======================");

            for (int i = 0; i < data.Length; i++)
            {
                outputBuilder.AppendLine($"{i:000} | {data[i]:000} | {data[i]:x8}");
            }

            outputBuilder.AppendLine("=======================");

            _logger.Info(outputBuilder.ToString());
        }
    }
}