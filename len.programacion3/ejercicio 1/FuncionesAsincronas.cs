using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1
{
    public partial class FuncionesAsincronas : Form
    {
        public FuncionesAsincronas()
        {
            InitializeComponent();
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = " COMENZO EL PROCESO";
            HornearPizzaAsync();
            lbl_resultado.Text = " FINALIZO EL PROCESO";
        }

        private void HornearPizza()
        {

            Thread.Sleep(10000);
        }

        private Task HornearPizzaAsync() 
        {
            return Task.Delay(10000);
        }

        private async void btn_calcular_Click(object sender, EventArgs e)
        {
            lbl_suma.Text = Convert.ToString (await SumarAsync(50M, 50M));
        }
        private async Task<decimal> SumarAsync(decimal num1, decimal num2)
        {
            decimal resultado = await Task.Run(() =>
             {
                 return num1 + num2;
             });
            return resultado;
        }
    }
}
