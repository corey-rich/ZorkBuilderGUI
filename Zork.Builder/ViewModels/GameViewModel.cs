using System.ComponentModel;
using Zork.Common;
using System;
using Newtonsoft.Json;
using System.IO;

namespace Zork.Builder.ViewModels
{
    class GameViewModel : INotifyPropertyChanged
    {
        private World mWorld;

        public event PropertyChangedEventHandler PropertyChanged;
        public string Filename { get; set; }

        public Game Game { get; set; }

        public BindingList<Room> Rooms { get; set; }

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
                        //Items = new BindingList<Item>(mWorld.Items);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                        //Items = new BindingList<Item>(Array.Empty<Item>());
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

    }

}
