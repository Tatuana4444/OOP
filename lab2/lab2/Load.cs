using System;
using System.Windows.Forms;
using System.Reflection;

namespace LoadClass
{
    public class Load
    {
        private string lib;
        public Load(string Lib)
        {
           lib = Lib;
        }

        public ComboBox LoadTypeToCombobox(ComboBox comboBox)
        {
            Assembly asm = Assembly.Load(lib);
            foreach (Type type in asm.GetTypes())
            {
                if (type.Namespace == "AllPeople")
                {
                    comboBox.Items.Add(type);
                }
            }
            comboBox.SelectedIndex = 0;
            return comboBox;
        }
    }
}
