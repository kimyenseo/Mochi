using Microsoft.Maui.Controls;

namespace Mochi
{
    public partial class CadastrarDevedoresPage : ContentPage
    {
        public CadastrarDevedoresPage()
        {
            InitializeComponent();
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            // Lógica para salvar as informações
            DisplayAlert("Salvo", "Informações salvas com sucesso!", "OK");
        }

        private void OnDeletarClicked(object sender, EventArgs e)
        {
            // Lógica para deletar as informações
            DisplayAlert("Deletado", "Informações deletadas com sucesso!", "OK");
        }
    }
}
