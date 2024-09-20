using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Laba4_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double n) && n > 0) 
            {
                double result = 0;
                int counter = 1;

                do
                {
                    result += 1.0 / ((2 * counter - 1) * (2 * counter + 1));
                    counter++;
                }
                while (counter <= n);

                textBox2.Text = result.ToString("F6");
            } 
            else
            {
                MessageBox.Show("Нужно корректное значение n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
