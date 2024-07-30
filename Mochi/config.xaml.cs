using Microsoft.Maui.Controls;

namespace SeuApp
{
    public partial class AtualizacoesPage : ContentPage
    {
        public AtualizacoesPage()
        {
            InitializeComponent();
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            // Ação para o botão de cancelar
            DisplayAlert("Cancelado", "Ação cancelada.", "OK");
        }

        private void OnConfirmClicked(object sender, EventArgs e)
        {
            // Ação para o botão de confirmar
            DisplayAlert("Confirmado", "Ação confirmada.", "OK");
        }
    }
}
