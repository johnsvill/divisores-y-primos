using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivisoresyPrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//TextBox
        {
            Divisores numeroDivisores = new Divisores();
            numeroDivisores.p_numero_set(int.Parse(txt_introducir.Text));
            numeroDivisores.DivisorNumero();
        }

        private void txt_introducir_TextChanged(object sender, EventArgs e)//label
        {
           
        }

        private void txt_primos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {           
            bool esPrimo;
            int n = 0;
            string primos = "";

            for (int x = 2; x <= n; x++)
            {
                esPrimo = true;
                for (int y = 2; y < x; y++)
                {
                    if (x % y == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo) primos += x + ", ";
            }
            /*richTextBox.Text = primos;*/
        }
    }
}
