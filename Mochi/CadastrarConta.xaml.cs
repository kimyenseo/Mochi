using Microsoft.Maui.Controls;

namespace Mochi
{
    public partial class CadastroDeContaPage : ContentPage
    {
        public CadastroDeContaPage()
        {
            InitializeComponent();
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            // Implementar a lógica de salvar
        }

        private void OnDeletarClicked(object sender, EventArgs e)
        {
            // Implementar a lógica de deletar
        }

        private void VoltarButton(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ContaPage();
        }
    }
}
