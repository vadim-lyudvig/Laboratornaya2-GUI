using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labaratornaya.GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            a.Text = Properties.Settings.Default.Text1;
            b.Text = Properties.Settings.Default.Text2;
            c.Text = Properties.Settings.Default.Text3;

        }
        private void button1_Click(object sender, EventArgs e)
        {
           try
           {
               int a, b, c;
                a = int.Parse(this.a.Text);
                b = int.Parse(this.b.Text);
                c = int.Parse(this.c.Text);
                Properties.Settings.Default.Text1 = a.ToString();
                Properties.Settings.Default.Text2 = b.ToString();
                Properties.Settings.Default.Text3 = c.ToString();
                Properties.Settings.Default.Save();
                MessageBox.Show(Logic.Compare(a, b, c));
                this.a.Clear();
                this.b.Clear();
                this.c.Clear();
            }
           catch (FormatException)
           {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
           }
        }

        private void a_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                b.Focus();
            }
        }

        private void b_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                c.Focus();
            }
        }

        private void c_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Результат.Focus();
            }
        }

        private void Результат_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                a.Focus();
            }
        }

        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms[0];
            form1.Show();
        }
    }
    public class Logic
    {

        public static string Compare(int a, int b, int c)
        {
            string outMessage = "";
            if ((b + c > a) && (a + c > b) && (b + a > c))
            {


                if ((a * a + b * b == c * c) || (c * c + b * b == a * a) || (a * a + c * c == b * b))
                {
                    outMessage = "Треугольник прямоугольный";
                }
                else
                {
                    outMessage = "Треугольник не прямоугольный";
                }
            }
            else
            {

                outMessage = "Треугольник не существует";
            }
            return outMessage;
        }
        
    }
}