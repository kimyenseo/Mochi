using System;
using Microsoft.Maui.Controls;

namespace Mochi
{
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
        }

        private void OnCadastroButtonClicked(object sender, EventArgs e)
        {
            // Lógica para navegar para a tela de cadastro
            // Navigation.PushAsync(new CadastroPage()); // Exemplo de navegação
        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de cancelar
            entryNome.Text = string.Empty;
            entrySenha.Text = string.Empty;
        }

        private void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            // Lógica para o botão de confirmar
            // Validar os campos e fazer login
        }
    }
}
