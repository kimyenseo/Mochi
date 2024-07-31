using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class InboxPage : ContentPage
    {
        public InboxPage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página anterior
            Navigation.PopAsync();
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Implementar ação de exclusão
        }

        private void OnCheckButtonClicked(object sender, EventArgs e)
        {
            // Implementar ação de confirmação
        }
    }
}
