using Microsoft.Maui.Controls;

namespace Mochi
{
    public partial class DevedoresPage : ContentPage
    {

        Controles.DevControle devControle = new Controles.DevControle();
        public DevedoresPage()
        {
            InitializeComponent();
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SelecionarPage();

        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastrarDevedoresPage();

        }

        void Dev(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CadastrarDevedoresPage();
            page.devedores = e.SelectedItem as Devedores;
            Application.Current.MainPage = page;
        }
    }
}



