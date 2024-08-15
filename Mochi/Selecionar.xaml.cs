namespace Mochi;

public partial class SelecionarPage : ContentPage
{
    public SelecionarPage()
    {
        InitializeComponent();
    }

     private void VoltarButton(object sender, EventArgs e)
    {
        Application.Current.MainPage = new InicioPage();
    } 

    private void DevedorButton(object sender, EventArgs e)
    {
        Application.Current.MainPage = new DevedoresPage();
    }

        private void ContaButton(object sender, EventArgs e)
    {
        Application.Current.MainPage = new ContaPage();
    }
}
