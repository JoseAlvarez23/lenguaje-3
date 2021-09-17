using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            string tipo;
        private string Par (int numero)
        {
            
            if (numero % 2 == 0)
            {
                tipo = " Es par";
                
            }
                return tipo;
        }
        private string Impar(int numero)
        {

            if (numero % 2 != 0)
            {
                tipo = " Es impar";


            }
            return tipo;
        }
        int i;
        private string Primo(int numero)
        {
            
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    
                    tipo = " no";
                }
                else
                {
                   tipo = " si";
                }
            }
            

            return tipo;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            txt_tipo.Text = Par(Convert.ToInt32(txt_numero.Text)).ToString();
            txt_tipo.Text = Impar(Convert.ToInt32(txt_numero.Text)).ToString();
            txt_primo.Text = Primo(Convert.ToInt32(txt_numero.Text)).ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_numero.Clear();
            txt_tipo.Clear();
        }
    }
}
