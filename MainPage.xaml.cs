namespace AppFinancias
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
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
