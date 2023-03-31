using System.Windows.Input;
using WpfNotepadMvvm.Commands;
using WpfNotepadMvvm.Models;

namespace WpfNotepadMvvm.ViewModels
{
    public class HelpViewModel : ObservableObject
    {
        public ICommand HelpCommand { get; }
        public HelpViewModel()
        {
            HelpCommand = new RelayCommand(DisplayAbout); 
        }

        private void DisplayAbout()
        {
            // We Will Open Help Dialog Box //
        }
    }
}
