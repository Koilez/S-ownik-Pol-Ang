using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                if (main.index == 0)
                {
                    comboBox1.DataSource = main.dirictEng.Keys.ToList();
                }
                else
                {
                    comboBox1.DataSource = main.dirictPol.Keys.ToList();
                }

            }
        }

        private void DeleteWord_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main.index == 0)
            {
                string s = main.dirictEng[comboBox1.Text];
                main.dirictEng.Remove(comboBox1.Text);
                main.dirictPol.Remove(s);
            }
            else
            {
                string s = main.dirictPol[comboBox1.Text];
                main.dirictPol.Remove(comboBox1.Text);
                main.dirictEng.Remove(s);
            }
            this.Close();
        }
    }
}
