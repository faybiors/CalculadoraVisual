using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float A = int.Parse(textBox1.Text);
            float B = int.Parse(textBox2.Text);

            float R = 0;

            switch (comboBox1.Text)
            {
                case "Adição":
                    R = A + B;
                    break;
                case "Subtração":
                    R = A - B;
                    break;
                case "Multiplicação":
                    R = A * B;
                    break;
                case "Divisão":
                    R = A / B;
                    break;
            }
            MessageBox.Show(R.ToString());
        }
    }
}
