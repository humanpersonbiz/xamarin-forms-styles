using System.Windows.Input;

namespace Components.ViewModels
{
    public class ComponentsViewModel : BaseViewModel
    {
        public ComponentsViewModel()
        {
            Title = "Components";
        }

        public ICommand OpenWebCommand { get; }
    }
}