using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisoresyPrimos
{
    public class Divisores
    {
        int resultado;
        public int numero;

        public void p_numero_set(int valor)
        {
            numero = valor;
        }
        public int p_resultado_get()
        {
            return resultado;
        }
        public void DivisorNumero()
        {
            int i;
            for (i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Estos son los números divisores: " + i);
                }
            }
        }
    }
}
