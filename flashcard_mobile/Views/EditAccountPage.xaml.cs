using flashcard_mobile.ViewModels;

namespace flashcard_mobile.Views;

public partial class EditAccountPage : ContentPage
{
    public EditAccountPage()
    {
        InitializeComponent();
        BindingContext = new EditAccountViewModel();
    }
}
