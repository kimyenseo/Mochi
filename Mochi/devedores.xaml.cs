using System;
using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class DevedoresPage : ContentPage
    {
        public DevedoresPage()
        {
            InitializeComponent();
        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de cancelar
            entryNome.Text = string.Empty;
            entryValor.Text = string.Empty;
        }

        private void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de confirmar
            // Validar os campos e salvar as informações
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
            // Navigation.PopAsync(); // Exemplo de navegação para voltar à página anterior
        }
    }
}
