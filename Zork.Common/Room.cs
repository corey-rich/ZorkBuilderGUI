using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zork.Common
{

    public class Room : IEquatable<Room>, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty(Order = 1)]
        public string Name { get; set; }

        [JsonProperty(Order = 2)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "Neighbors", Order = 3)]
        private Dictionary<Directions, string> NeighborNames { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors { get; set; }

        //[JsonProperty(PropertyName = "NeighborDirections")]
        //private List<string> NeighborDirections { get; set; }

        public List<Room> RoomNeighbors { get; set; }

        public Room(string name = null, string description = null, List<string> neighborDirections = null, Dictionary<Directions, string> neighborNames = null)
        {
            Name = name;
            Description = description;
            //NeighborDirections = neighborDirections ?? new List<string>();
            NeighborNames = neighborNames;
            RoomNeighbors = new List<Room>();
            Neighbors = new Dictionary<Directions, Room>();
        }

      //  public void BuildNeighborsFromNames(List<World> world)
      //  {
      //      RoomNeighbors = (from roomName in NeighborNames
      //                       let room = world.Find(i => i.Rooms.Equals(roomName, System.StringComparison.InvariantCultureIgnoreCase))
      //                       where room != null
      //                       select room).ToList();
      // 
      //      NeighborNames.Clear();
      //  }

        public static bool operator == (Room lhs, Room rhs)
        {
            if (ReferenceEquals(lhs, rhs))
            {
                return true;
            }

            if (lhs is null || rhs is null)
            {
                return false;
            }

            return lhs.Name == rhs.Name;
        }

        public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);

        public override bool Equals(object obj) => obj is Room room ? this == room : false;

        public bool Equals(Room other) => this == other;

        public override string ToString() => Name;

        public override int GetHashCode() => Name.GetHashCode();

        public void UpdateNeighbors(World world)
        {
            Neighbors = (from entry in NeighborNames
                         let room = world.RoomsByName.GetValueOrDefault(entry.Value)
                         where room != null
                         select (Direction: entry.Key, Room: room))
                         .ToDictionary(pair => pair.Direction, pair => pair.Room);

            NeighborNames.Clear();
        }

        public class RoomConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(Room));
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JObject jsonObject = JObject.Load(reader);
                string name = jsonObject["Name"].Value<string>();
                string description = jsonObject["Description"].Value<string>();

                Dictionary<Directions, string> neighborNames;
                if (jsonObject.TryGetValue("Neighbors", out JToken neighborNamesToken))
                {
                    neighborNames = neighborNamesToken.ToObject<Dictionary<Directions, string>>();
                }
                else
                {
                    neighborNames = new Dictionary<Directions, string>();
                }
                return new Room(name, description);
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                Room room = (Room)value;
                JToken neighborNamesToken = JToken.FromObject(room.Neighbors.ToDictionary(pair => pair.Key, pair => pair.Value), serializer);

                JObject roomObject = new JObject
                {
                    { nameof(Room.Name), room.Name },
                    { nameof(Room.Description), room.Description },
                    { nameof(Room.Neighbors), JToken.FromObject(room.Neighbors.Select(neighbor => room.Name), serializer) }
                };

                roomObject.WriteTo(writer);
            }
        }
    }
}
