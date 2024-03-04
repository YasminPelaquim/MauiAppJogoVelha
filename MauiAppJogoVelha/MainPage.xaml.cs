namespace MauiAppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "0";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Button disparador = (Button)sender;

            disparador.IsEnabled = false;

            if(vez == "0")
            {
                disparador.Text = "0";
                vez = "X";

            } else
            {
                disparador.Text = "X";
                vez = "0";
            } // Fecha if
        }
    } // Fecha a classe MainPage

} // Fecha o Namespace 
