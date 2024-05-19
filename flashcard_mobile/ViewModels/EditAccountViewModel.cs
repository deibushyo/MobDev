using flashcard_mobile.Models;
using System.Windows.Input;

namespace flashcard_mobile.ViewModels;

public class EditAccountViewModel : BaseViewModel
{
    private string _username = UserData.Username;
    private string _email = UserData.Email;

    public string Username
    {
        get => _username;
        set => SetProperty(ref _username, value);
    }

    public string Email
    {
        get => _email;
        set => SetProperty(ref _email, value);
    }

    public ICommand SaveCommand { get; }

    public EditAccountViewModel()
    {
        SaveCommand = new Command(OnSave);
    }

    private void OnSave()
    {
        UserData.Username = _username;
        UserData.Email = _email;
        // Optionally navigate back or show a confirmation message
    }
}