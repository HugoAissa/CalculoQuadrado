using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoQuadrado.View
{
    public partial class FormularioQuadrado : Form
    {
        public FormularioQuadrado()
        {
            InitializeComponent();
        }
        private int quadrado(int num)
        {
            int resultado;
            resultado = num * num;

            return resultado;

        }
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(tbx_Valor.Text);

            lbl_Resultado.Text = "O valor quadrado de " + num + " é " + quadrado(num);
            tbx_Valor.Focus();
            tbx_Valor.SelectAll();

        }
    }
}
