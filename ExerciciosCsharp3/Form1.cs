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
    }
}
