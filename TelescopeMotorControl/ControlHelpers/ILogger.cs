using System;

namespace TelescopeMotorControl.ControlHelpers
{
    public interface ILogger
    {
        void Info(string message);
        void Error(string message, Exception exception);
    }
}