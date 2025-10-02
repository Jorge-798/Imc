namespace Imc.Gui
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            LimpiarInformacion();
        }

        private void Calcular_Button_Clicked(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(PesoEntry.Text);
            decimal estatura = Convert.ToDecimal(EstaturaEntry.Text);

            decimal imc = IndiceDeMasaCorporal(peso, estatura);

            ImcLabel.Text = imc.ToString("G6"); /*El G6 es para poner tener 4 decimales*/
   
            SituacionNutricionalLabel.Text = SituacionNutricional(imc);
        }

        private static string SituacionNutricional(decimal imc)
        {
            string estadoNutricional;
            if (imc < 18.5M)
            {
                estadoNutricional = "Peso bajo";
            }
            else if (imc < 25.0M)
            {
                estadoNutricional = "Peso normal";
            }
            else if (imc < 30.0M)
            {
                estadoNutricional = "Sobrepeso";
            }
            else if (imc < 40.0M)
            {
                estadoNutricional = "Obesidad";
            }
            else
            {
                estadoNutricional = "Obesidad Estrema";
            }

            return estadoNutricional;
        }

        private static decimal IndiceDeMasaCorporal(decimal peso, decimal estatura)
        {
            return peso / (estatura * estatura);
        }

        private void Limpiar_Button_Clicked(object sender, EventArgs e)
        {
            LimpiarInformacion();
        }

        private void LimpiarInformacion()
        {
            PesoEntry.Text = string.Empty;
            EstaturaEntry.Text = string.Empty;
            ImcLabel.Text = string.Empty;
            SituacionNutricionalLabel.Text = string.Empty;
        }
    }

}
