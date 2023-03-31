using System.Windows;
using System.Windows.Media;

namespace WpfNotepadMvvm.Models
{
    public class FormatModel : ObservableObject
    {
        private FontStyle _style;
        public FontStyle Style
        {
            get { return _style; }
            set
            {
                OnPropertyChanged(ref _style, value);
            }
        }

        private FontWeight _weight;
        public FontWeight Weight
        {
            get { return _weight; }
            set
            {
                OnPropertyChanged(ref _weight, value);
            }
        }

        private FontFamily? _family;
        public FontFamily? Family
        {
            get { return _family; }
            set
            {
                OnPropertyChanged(ref _family, value);
            }
        }

        private bool isWrapped;
        public bool IsWrapped
        {
            get { return isWrapped; }
            set
            {
                OnPropertyChanged(ref isWrapped, value);
            }
        }

        private double _size;
        public double Size
        {
            get { return _size; }
            set
            {
                OnPropertyChanged(ref _size, value);
            }
        }
        private bool _wrap;
        public bool Wrap
        {
            get { return isWrapped; }
            set
            {
                isWrapped = value;
                OnPropertyChanged(ref _wrap, value);
            }
        }

    }
}



