namespace Frecuencia_Cardiaca
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public void Btn_Calcular(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Latidos.Text))
            {
                var latidos = Int32.Parse(Latidos.Text);

                var total = latidos * 4;
                Total.Text = total.ToString();

                string resultado = "";
                if (total < 60)
                {
                    resultado = "Frecuencia cardiaca baja";
                }
                else if (total > 100)
                {
                    resultado = "Frecuencia cardiaca alta";
                }
                else
                {
                    resultado = "Frecuencia cardiaca normal";
                }
                DisplayAlert("Resultado", resultado, "Quitar");
            }else
            {
                DisplayAlert("Error", "Por favor, ingrese valores válidos", "Quitar");
            }
        }
    }
}
