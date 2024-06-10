namespace AppFinancias.Views;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();

		AppShell.SetNavBarIsVisible(this, false);
	}

    private void criar_conta_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.FinalizarCadastro());
    }

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}