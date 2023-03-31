using WpfNotepadMvvm.Models;

namespace WpfNotepadMvvm.ViewModels
{
    public class MainViewModel
    {
        // Document that is saved, loaded and hold editor text //
        private DocumentModel _document; 

        // Manages user input for document and format styles //
        public EditorViewModel Editor { get; set; }

        // Manages saving and loading text files
        public FileViewModel File { get; set; }

        // Manages help dialog //
        public HelpViewModel Help { get; set; }

        // CTOR //
        public MainViewModel()
        {
            _document= new DocumentModel(); 
            Help = new HelpViewModel();
            Editor = new EditorViewModel(_document);
            File = new FileViewModel(_document); 
        }
    }
}
