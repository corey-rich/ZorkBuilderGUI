using System.ComponentModel;
using Zork.Common;

namespace Zork.Builder.ViewModels
{
    class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Filename { get; set; }

        public Game Game { get; set; }

    }
}
