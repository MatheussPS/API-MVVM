using HTTPClient.ViewModel;

namespace HTTPClient.View;

public partial class CreatePostView : ContentPage
{
	public CreatePostView()
	{
		InitializeComponent();
		BindingContext = new CreatePostViewModel();
    }
}