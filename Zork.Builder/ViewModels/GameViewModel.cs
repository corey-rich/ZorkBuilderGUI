using System.ComponentModel;
using Zork.Common;
using System;
using Newtonsoft.Json;
using System.IO;

namespace Zork.Builder.ViewModels
{
    class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }
        public Game Game { get; set; }
        public BindingList<Room> Rooms { get; set; }
        //public BindingList<Room> Description { get; set; }
        //public BindingList<Room> Neighbors { get; set; }
      public GameViewModel()
      {
          Rooms = new BindingList<Room>();
          //Description = new BindingList<Room>();
          //Neighbors = new BindingList<Room>();
      }

       public GameViewModel(World world = null) => World = world;

        public World World
        {
            set
            {
                if (mWorld != value)
                {
                    mWorld = value;
                    if (mWorld != null)
                    {
                       Rooms = new BindingList<Room>(mWorld.Rooms);
                       //Description = new BindingList<Room>(mWorld.Rooms);
                       //Neighbors = new BindingList<Room>(mWorld.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                       // Description = new BindingList<Room>(Array.Empty<Room>());
                       // Neighbors = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public void SaveWorld()
        {
            if (string.IsNullOrEmpty(Filename))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(Filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, mWorld);
            }
        }

        private World mWorld;

        public static implicit operator GameViewModel(Room v)
        {
            throw new NotImplementedException();
        }
    }

}
