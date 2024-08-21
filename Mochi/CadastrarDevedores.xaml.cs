using Microsoft.Maui.Controls;

namespace Mochi
{
    public partial class CadastrarDevedoresPage : ContentPage
    {

        public Devedores devedores { get; set; }
        Controles.DevControle devControle = new Controles.DevControle();
        public CadastrarDevedoresPage()
        {
            InitializeComponent();
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            var dv = new Devedores();
            dv.Id = 0;
            dv.Nome = NomeEntry.Text;
            dv.Valor = ValorEntry.Text;
            devControle.CriarOuAtualizar(dv);

            Application.Current.MainPage = new DevedoresPage();

            DisplayAlert("Salvo", "Informações salvas com sucesso!", "OK");
        }

        private void OnDeletarClicked(object sender, EventArgs e)
        {
            // Lógica para deletar as informações
            DisplayAlert("Deletado", "Informações deletadas com sucesso!", "OK");
        }

        private void voltarbutton(object sender, EventArgs e)
        {
            Application.Current.MainPage = new DevedoresPage();

        }

         private async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            IdLabel.Text = devedores.Id.ToString();
            NomeEntry.Text = string.Empty;
            ValorEntry.Text = string.Empty;

            if (devedores == null)
                await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
            else if (await DisplayAlert("Excluir", "Tem certeza que deseja excluir esse cliente?", "Excluir Cliente", "cancelar"))
            {
                devControle.Apagar(devedores.Id);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (devedores != null)
            {
                 IdLabel.Text        = devedores.Id
                 .ToString();
                NomeEntry.Text = devedores.Nome;
                ValorEntry.Text = devedores.Valor;
            }
        }
    }
}
