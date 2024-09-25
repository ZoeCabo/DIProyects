namespace PagesDemo
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Cliked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPageDemo());
        }
    }

}
