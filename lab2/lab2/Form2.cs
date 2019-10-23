using System;
using System.Windows.Forms;
using LoadClass;

namespace lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Load loader = new Load("lab2");
            this.comboBox1 = loader.LoadTypeToCombobox(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.type = this.comboBox1.SelectedItem as Type;
            Form1.X = int.Parse(EnterX.Text);
            Form1.Y = int.Parse(EnterY.Text);
            if (IsShowInf.Checked)
                Form1.ShowInf = true;
            else
                Form1.ShowInf = false;
            if (isWorkButt.Checked)
                Form1.Work = true;
            else
                Form1.Work = false;
            Close();
        }

        private void EnterX_TextChanged(object sender, EventArgs e)
        {
            if ((EnterX.Text != "") && (EnterY.Text != ""))
                Create.Enabled = true;
            else
                Create.Enabled = false;
        }
    }
}
