using System;

namespace Ejercicio1
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {                
                double monto = Convert.ToDouble(this.TxtMontoCalcular.Text);
                int porcentaje = 0;

                if (monto > 600.1)
                    porcentaje = 25;
                else if (monto > 400.01)
                    porcentaje = 20;
                else if (monto > 100.01)
                    porcentaje = 15;
                else porcentaje = 10;

                double descuento = monto * porcentaje / 100;
                double totalPagar = monto - descuento;

                LimpiarTextBox();
                this.TxtDescuento.Text = descuento.ToString();
                this.TxtTotalPagar.Text = totalPagar.ToString();
                this.TxtPorcentaje.Text = porcentaje.ToString();
                this.TxtMonto.Text = monto.ToString();                
            }
            catch (Exception)
            {
                LimpiarTextBox();
                this.LblError.Text = "Monto ingresado no es válido.";
            }
        }

        private void LimpiarTextBox()
        {
            this.LblError.Text = "";            
            this.TxtDescuento.Text = "";
            this.TxtTotalPagar.Text = "";
            this.TxtPorcentaje.Text = "";
            this.TxtMonto.Text = "";
        }
    }
}
