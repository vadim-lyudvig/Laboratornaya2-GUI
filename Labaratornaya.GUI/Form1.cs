using System;
using System.Windows.Forms;

namespace Labaratornaya.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
