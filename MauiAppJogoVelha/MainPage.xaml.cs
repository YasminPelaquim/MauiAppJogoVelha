namespace MauiAppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "0";
        int cont = 0;
        int v;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Button disparador = (Button)sender;
            v = cont;
            cont = v + 1;

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

            // Verificando se o X ganhou na 1 linha
            if(btn10.Text == "X"
                && btn11.Text == "X"
                && btn12.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            // Verificando se o X ganhou na 2 linha 
            if(btn20.Text == "X"
                && btn21.Text == "X"
                && btn22.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            // Verificando se o X ganhou na 3 linha 
            if(btn30.Text == "X"
                && btn31.Text == "X"
                && btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            // Verificando se o X ganhou na 1 coluna
            if(btn10.Text == "X"
                && btn20.Text == "X"
                && btn30.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            // Verificando se o X ganhou na 2 coluna
            if(btn11.Text == "X"
                && btn21.Text == "X"
                && btn31.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            // Verificando se o X ganhou na 3 coluna
            if(btn12.Text == "X"
                && btn22.Text == "X"
                && btn32.Text== "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            // Verificando se o X ganhou na diagonal da E para D
            if(btn10.Text== "X"
                && btn21.Text == "X"
                && btn32.Text== "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            // Verificando se o X ganhou na diagonal da D para E 
            if(btn12.Text== "X"
                && btn21.Text == "X"
                && btn30.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            // Verificando se o 0 ganhou na 1 linha
            if (btn10.Text == "0"
                && btn11.Text == "0"
                && btn12.Text == "0")
            {
                DisplayAlert("Parabéns!", "A 0 ganhou!", "OK");
                limpar();
            }

            // Verificando se o 0 ganhou na 2 linha 
            if (btn20.Text == "0"
                && btn21.Text == "0"
                && btn22.Text == "0")
            {
                DisplayAlert("Parabéns!", "A 0 ganhou!", "OK");
                limpar();
            }

            // Verificando se o 0 ganhou na 3 linha 
            if (btn30.Text == "0"
                && btn31.Text == "0"
                && btn32.Text == "0")
            {
                DisplayAlert("Parabéns!", "A 0 ganhou!", "OK");
                limpar();
            }

            // Verificando se o 0 ganhou na 1 coluna
            if (btn10.Text == "0"
                && btn20.Text == "0"
                && btn30.Text == "0")
            {
                DisplayAlert("Parabéns!", "A 0 ganhou!", "OK");
                limpar();
            }

            // Verificando se o 0 ganhou na 2 coluna
            if (btn11.Text == "0"
                && btn21.Text == "0"
                && btn31.Text == "0")
            {
                DisplayAlert("Parabéns!", "A 0 ganhou!", "OK");
                limpar();
            }

            // Verificando se o 0 ganhou na 3 coluna
            if (btn12.Text == "0"
                && btn22.Text == "0"
                && btn32.Text == "0")
            {
                DisplayAlert("Parabéns!", "A 0 ganhou!", "OK");
                limpar();
            }

            // Verificando se o 0 ganhou na diagonal da E para D
            if (btn10.Text == "0"
                && btn21.Text == "0"
                && btn32.Text == "0")
            {
                DisplayAlert("Parabéns!", "A 0 ganhou!", "OK");
                limpar();
            }

            // Verificando se o 0 ganhou na diagonal da D para E 
            if (btn12.Text == "0"
                && btn21.Text == "0"
                && btn30.Text == "0")
            {
                DisplayAlert("Parabéns!", "A 0 ganhou!", "OK");
                limpar();
            }

            if (cont == 9)
            {
                DisplayAlert("VELHA!", "Os dois perderam!", "OK" );
            }


        } // Fecha o Button_Clicked

        private void limpar()
        {
            cont = 0;

            btn10.Text = "";
            btn10.IsEnabled = true;

            btn11.Text = "";
            btn11.IsEnabled = true;

            btn12.Text = "";
            btn12.IsEnabled = true;

            btn20.Text = "";
            btn20.IsEnabled = true;

            btn21.Text = "";
            btn21.IsEnabled = true;

            btn22.Text = "";
            btn22.IsEnabled = true;

            btn30.Text = "";
            btn30.IsEnabled = true;

            btn31.Text = "";
            btn31.IsEnabled = true;

            btn32.Text = "";
            btn32.IsEnabled = true;
        }





    } // Fecha a classe MainPage

} // Fecha o Namespace 
