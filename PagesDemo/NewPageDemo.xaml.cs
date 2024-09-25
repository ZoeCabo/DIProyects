namespace PagesDemo;

public partial class NewPageDemo : ContentPage
{
	public NewPageDemo()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new NewPageDemo());
	}
    private void Button_Clicked2(object sender, EventArgs e)
    {
       Navigation.PopAsync();
    }



}