using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace ArtLibrary.ControlLogic
{
    public class AdderItems
    {
        public void AddComboBoxItem(List<ComboBox> comboBoxList)
        {
            foreach (var comboBox in comboBoxList)
            {
                AddComboBoxItem(comboBox);
            }
        }

        public void AddComboBoxItem(ComboBox comboBox)
        {
            if (!comboBox.Items.Contains(comboBox.Text))
            {
                comboBox.SelectedIndex = comboBox.Items.Add(comboBox.Text);
                using (var stream = new StreamWriter($@"C:\Users\artem\source\repos\AdderInBD\UserData\{comboBox.Name}" , true))
                {
                    stream.WriteLine(comboBox.Text);
                }
            }
        }
    }
}
