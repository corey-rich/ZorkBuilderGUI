﻿using System.ComponentModel;
using Zork.Common;
using System;

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

    }

}
