using LoginApp.Views;

namespace LoginApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnEntrarClicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "admin" && senha == "1234")
            {
                await Navigation.PushAsync(new WelcomePage());
            }
            else 
            {
                lblMensagem.Text = "Usuario ou senha inválidos!";
            }
        }
    }
}
