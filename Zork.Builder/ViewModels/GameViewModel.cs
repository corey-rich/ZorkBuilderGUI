using System.ComponentModel;
using Zork.Common;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;


namespace Zork.Builder.ViewModels
{
    class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }
        public Game Game { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Room> Description { get; set; }
        public List<Room> Neighbors { get; set; }
        public GameViewModel()
        {
            Rooms = new List<Room>();
            Description = new List<Room>();
            Neighbors = new List<Room>();
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
                        Rooms = new List<Room>(mWorld.Rooms);
                        Description = new List<Room>(mWorld.Rooms);
                        Neighbors = new List<Room>(mWorld.Rooms);
                    }
                    else
                    {
                        Rooms = new List<Room>(Array.Empty<Room>());
                        Description = new List<Room>(Array.Empty<Room>());
                        Neighbors = new List<Room>(Array.Empty<Room>());
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
