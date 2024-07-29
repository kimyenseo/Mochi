using System;
using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class ConfigPage : ContentPage
    {
        public ConfigPage()
        {
            InitializeComponent();
        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de cancelar
            entryField1.Text = string.Empty;
            entryField2.Text = string.Empty;
            entryField3.Text = string.Empty;
            entryField4.Text = string.Empty;
        }

        private void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de confirmar
            // Validar os campos e salvar as configurações
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de voltar
            // Navigation.PopAsync(); // Exemplo de navegação para voltar à página anterior
        }
    }
}
