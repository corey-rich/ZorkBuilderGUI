using System.ComponentModel;
using Zork.Common;
using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace Zork.Builder.ViewModels
{
    class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }

        public Game Game { get; set; }
        public BindingList<Room> Rooms { get; set; }
      public GameViewModel()
      {
          Rooms = new BindingList<Room>();
      }

       public GameViewModel(World room = null) => World = room;

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
                    }
                    else
                    {
                       Rooms = new BindingList<Room>(Array.Empty<Room>());
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
    }

}
