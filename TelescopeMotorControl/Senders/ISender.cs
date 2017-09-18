namespace TelescopeMotorControl.Senders
{
    public interface ISender
    {
        void Send(string command, byte[] data);
    }
}