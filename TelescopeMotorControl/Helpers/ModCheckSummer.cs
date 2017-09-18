using System.Linq;

namespace TelescopeMotorControl.Helpers
{
    public class ModCheckSummer : ICheckSummer
    {
        public byte Calculate(byte[] data)
        {
            return (byte) (data.Select(x => (int) x).Sum() % byte.MaxValue);
        }
    }
}