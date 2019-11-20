using Newtonsoft.Json;
using System;

namespace Zork.Common
{
    public class Player
    {
        public event EventHandler<int> ScoreChanged;

        public event EventHandler<string> LocationChanged;

        public event EventHandler<int> MovesChanged;

        public World World { get; }

        [JsonIgnore]
        public Room Location
        {
            get => mLocation;
            
            set
            {
                mLocation = value;
                LocationChanged?.Invoke(this, mLocation.ToString());
            }
        }

        public int Moves
        {
            get => mMoves;

            set
            {
                mMoves = value;
                MovesChanged?.Invoke(this, mMoves);
            }
        }

        public int Score
        {
            get => mScore;

            set
            {
                mScore = value;
                ScoreChanged?.Invoke(this, mScore);
            }
        }

        [JsonIgnore]
        public string LocationName
        {
            get
            {
                return Location?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
            {
                Location = destination;
            }

            return isValidMove;
        }

        private int mScore;
        private int mMoves;
        private Room mLocation;
    }
}
