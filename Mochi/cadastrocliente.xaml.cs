using Microsoft.Maui.Controls;

namespace Mochi
{
    public partial class CadastroClientePage : ContentPage
    {
        public CadastroClientePage()
        {
            InitializeComponent();
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            // Navega de volta ou limpa os campos
            Navigation.PopAsync(); // Volta para a página anterior
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            // Obtém os valores dos campos
            var nome = NomeEntry.Text;
            var endereco = EnderecoEntry.Text;
            var telefone = TelefoneEntry.Text;

            // Adicione sua lógica de salvamento aqui
            // Por exemplo, salve os dados em um banco de dados ou envie para uma API

            // Mostra uma mensagem de confirmação
            DisplayAlert("Sucesso", "Cliente cadastrado com sucesso", "OK");

            // Navega de volta ou limpa os campos
            Navigation.PopAsync(); // Volta para a página anterior
        }
    }
}
