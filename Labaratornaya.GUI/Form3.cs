using System;
using System.Windows.Forms;

namespace Labaratornaya.GUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            array.Text = Properties.Settings.Default.Array;
            Lenght.Text = Properties.Settings.Default.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int n = (int)Lenght.Value;
                int[] array = new int[n];
                string numbers = this.array.Text;
                string[] space = numbers.Split(' ');
                if (space.Length > n)
                {
                    MessageBox.Show(" Вы ввели много чисел ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (space.Length < n)
                {
                    MessageBox.Show(" Вы ввели мало чисел ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(space[i]);
                }
                Properties.Settings.Default.Array = this.array.Text;
                Properties.Settings.Default.Size = Lenght.Value.ToString();
                MessageBox.Show(Logic.CountingArray(array));
                Properties.Settings.Default.Save();
               
                this.array.Clear();
            }
        }

        private void lehgth_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                array.Focus();
            }
        }

        private void array_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }
        public class Logic
        {
            public static string CountingArray(int[] array)
            {
                int minIndex = 0;
                int min = array[0];
                int maxIndex = 0;
                int max = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        maxIndex = i;
                    }
                    if (array[i] < min)
                    {
                        min = array[i];
                        minIndex = i;
                    }
                }
                if (maxIndex < minIndex)
                {
                    return "Максимальное число " + max + " левее " + min + " на " + (minIndex-maxIndex) + " позиций ";
                }
                else
                {
                    return "Минимальное число " + min + " левее " + max + " на " + (maxIndex - minIndex) + " позиций ";
                }
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms[0];
            form1.Show();
        }
    }
}
