using System;
using System.Windows;
using System.Windows.Input;
using WpfNotepadMvvm.Commands;
using WpfNotepadMvvm.Models;
using WpfNotepadMvvm.View;

namespace WpfNotepadMvvm.ViewModels
{
    public class EditorViewModel : ObservableObject
    {
        public ICommand FormatCommand { get; set; } 
        public ICommand WrapCommand { get; set; }
        public FormatModel Format { get; set; } 
        public DocumentModel Document { get; set; }

        public EditorViewModel(DocumentModel document)
        {
            Document = document;
            Format = new FormatModel();
            FormatCommand = new RelayCommand(OpenStyleDialog);
            WrapCommand = new RelayCommand(ToggleWrap); 

        }

        private void OpenStyleDialog()
        {
            // Open a Style Dialog //
            var fontDialog = new FontDialong();
            fontDialog.DataContext = Format; 
            fontDialog.ShowDialog();
        }
        private void ToggleWrap()
        {
            Format.IsWrapped = !Format.IsWrapped;
            Format = Format; 
        }



    }
}
