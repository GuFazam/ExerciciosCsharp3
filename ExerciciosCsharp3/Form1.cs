using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosCsharp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconversao_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            valor1 = Convert.ToDouble(textBox1.Text);
            valor2 = Convert.ToDouble(textBox2.Text);

            label3.Text = Convert.ToString(valor1 * valor2, CultureInfo.InvariantCulture);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Lê a altura digitada pelo usuário na TextBox
            double altura = double.Parse(textBox3.Text);

            // Lê o sexo escolhido pelo usuário no RadioButton
            string sexo = "";
            if (radioButton1.Checked)
            {
                sexo = "M";
            }
            else if (radioButton2.Checked)
            {
                sexo = "F";
            }

            // Calcula o peso ideal de acordo com o sexo
            double pesoIdeal = 0;
            if (sexo == "M")
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else if (sexo == "F")
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }

            // Exibe o resultado no Label
            label4.Text = "O peso ideal é: " + pesoIdeal.ToString("N2") + " kg";
        }
    }
}
