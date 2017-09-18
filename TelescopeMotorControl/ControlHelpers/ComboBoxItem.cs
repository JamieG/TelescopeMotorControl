namespace TelescopeMotorControl.ControlHelpers
{
    public class ComboBoxItem
    {
        public static ComboBoxItem Create(string value, string display)
        {
            return new ComboBoxItem
            {
                Value = value,
                Display = display
            };
        }

        public string Value { get; set; }
        public string Display { get; set; }
    }
}