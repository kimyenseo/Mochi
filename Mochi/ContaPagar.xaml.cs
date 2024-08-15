using Microsoft.Maui.Controls;

namespace Mochi
{
    public partial class ContaPage : ContentPage
    {
        public ContaPage()
        {
            InitializeComponent();
        }

        private void Voltar1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SelecionarPage();
        }

        private void LixeiraButton(object sender, EventArgs e)
        {
            
        }

        private void AdicionarButton(object sender, EventArgs e)
        {
            
        }
    }
}
