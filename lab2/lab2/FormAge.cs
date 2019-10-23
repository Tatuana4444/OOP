using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class FormAge : Form
    {
        public FormAge()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Form1.Age = int.Parse(EnterAge.Text);
            Close();
        }

        private void EnterAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((EnterAge.Text!="") && (int.Parse(EnterAge.Text) >= 0) && (int.Parse(EnterAge.Text) < 4))
                    Create.Enabled = true;
                else
                    Create.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Введите число");
                EnterAge.Text = "";
            }
        }
    }
}
