namespace Mochi;

public partial class InicioPage : ContentPage
{
    public InicioPage()
    {
        InitializeComponent();
    }

    private void InicioButton(object sender, EventArgs e)
    {
        Application.Current.MainPage = new SelecionarPage();
    } 
}
