using flashcard_mobile.Models;

namespace flashcard_mobile.Views;

public partial class ViewAccountPage : ContentPage
{
    public ViewAccountPage(object userData)
    {
        InitializeComponent();
        BindingContext = userData;
    }
}
