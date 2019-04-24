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
            float A = 0;
            float B = 0;

            try
            {
                A = float.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Número 1 inválido!");
                return;
            }

            try
            {
                B = float.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Número 2 inválido!");
                return;
            }

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
                default:
                    MessageBox.Show("Selecione uma operação");
                    return;
            }
            MessageBox.Show(R.ToString());
        }
    }
}
