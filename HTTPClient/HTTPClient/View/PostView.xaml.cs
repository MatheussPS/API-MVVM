using HTTPClient.ViewModel;
namespace HTTPClient.View;

public partial class PostView : ContentPage
{
	public PostView()
	{
		InitializeComponent();
		BindingContext = new PostViewModels();
	}
}