using System.Collections.Generic;
using System.ComponentModel;

namespace TelescopeMotorControl.ControlHelpers
{
    public class ComboBoxItemList : BindingList<ComboBoxItem>
    {
        public const string DisplayMember = nameof(ComboBoxItem.Display);
        public const string ValueMember = nameof(ComboBoxItem.Value);

        public static ComboBoxItemList Create(params ComboBoxItem[] list)
        {
            return new ComboBoxItemList(list);
        }

        public ComboBoxItemList()
        {
        }

        public ComboBoxItemList(IList<ComboBoxItem> list) : base(list)
        {
        }
    }
}