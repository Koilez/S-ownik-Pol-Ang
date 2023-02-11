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
    public partial class Form3 : Form
    {
        int[] SID = new int[10];
        int a = 0;
        int b = 0;
        int c = 0;
        public Form3()
        {
            InitializeComponent();
        }
        
        public bool checkValue(int[] array, int value)
        {
           
            foreach(var n in array)
            {
                if(n == value)
                {
                    return false;
                }
            }
            return true;
        }

        public int[] randomNumbers(int[] array, int count)
        {
            Random random = new Random();

            int value = 0;

            for (int i = 0; i < 10; i++)
            {
                value = random.Next(0,count);

                if (checkValue(array, value))
                {
                    array[i] = value;
                }
                else
                {
                    i--;
                }
                         
            }

            return array;
        }

        public static string FirstUpper(string str)
        {
            string[] s = str.Split(' ');

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > 1)
                    s[i] = s[i].Substring(0, 1).ToUpper() + s[i].Substring(1, s[i].Length - 1).ToLower();
                else s[i] = s[i].ToUpper();
            }
            return string.Join(" ", s);
        }


        private void Form3_Load(object sender, EventArgs e)
        {
           Random random = new Random();
            Form1 main = this.Owner as Form1;
            
            randomNumbers(SID, main.dirictEng.Count());
            if (main.index == 0)
            {

                textBox1.Text = main.dirictEng.ElementAt(SID[0]).Key;
            }
            else
            {
                textBox1.Text = main.dirictPol.ElementAt(SID[0]).Key;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main.index == 0)
            {
                if (FirstUpper(textBox2.Text) == main.dirictEng.ElementAt(SID[a]).Value)
                {
                    b++;
                    c++;
                    label2.Text = b.ToString();
                    label4.Text = c.ToString();
                }
                else
                {
                    c++;
                    label4.Text = c.ToString();
                }
                a++;
                if (a < 10)
                {
                    textBox1.Text = main.dirictEng.ElementAt(SID[a]).Key;
                }
                textBox2.Text = "";
            }
            else
            {
                if (FirstUpper(textBox2.Text) == main.dirictPol.ElementAt(SID[a]).Value)
                {
                    b++;
                    c++;
                    label2.Text = b.ToString();
                    label4.Text = c.ToString();
                }
                else
                {
                    c++;
                    label4.Text = c.ToString();
                }
                a++;
                if (a < 10)
                {
                    textBox1.Text = main.dirictPol.ElementAt(SID[a]).Key;
                }
                textBox2.Text = "";
            }
            if (c == 10)
            {
                if(b >= 8)
                {
                    MessageBox.Show("You are BigMac");
                }else if(b <= 7 && b >= 4)
                {
                    MessageBox.Show("You are normal");
                }else if (b <= 3)
                {
                    MessageBox.Show("You lose this test");
                }
                Close();
            }
           
        }
    }
}
