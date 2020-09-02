using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2HerenciaPOO
{
    public partial class btncalcular : Form
    {
        Salario salario = new Salario();
        Descuento descuento = new Descuento();
        public btncalcular()
        {
            InitializeComponent();
        }

        private void btncalcularsalariobase_Click(object sender, EventArgs e)
        {
            salario.setCantidadhoras(double.Parse(txthoras.Text));
            lblsalariobase.Visible = true;
            lblsalariobase.Text = Convert.ToString(salario.calcularSalarioBase());
            btncalculardescuento.Enabled = true;

        }

        private void btncalculardescuento_Click(object sender, EventArgs e)
        {
            descuento.setCantidadhoras(double.Parse(txthoras.Text));
            lblvalorsalud.Visible = true;
            lblvalorsalud.Text = Convert.ToString(descuento.calcularSalud());
            lblvalorpension.Visible = true;
            lblvalorpension.Text = Convert.ToString(descuento.calcularPension());
            lblvalorccp.Visible = true;
            lblvalorccp.Text = Convert.ToString(descuento.calcularCcf());
            lblvalorsalariofinal.Visible = true;
            lblvalorsalariofinal.Text = Convert.ToString(descuento.calcularSalarioConDescuento());
        }
    }
}
