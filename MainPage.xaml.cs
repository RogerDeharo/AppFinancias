namespace AppFinancias
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();

            AppShell.SetNavBarIsVisible(this, false);
        }

        private void btn_criarconta_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Register());
        }

        private void btn_Login_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Login());
        }
    }

}
