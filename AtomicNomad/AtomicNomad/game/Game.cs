using AtomicNomad.game;
using AtomicNomad.game.items;
using NomadLibrary;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace AtomicNomad.game
{
    class Game
    {
        public static RNG RNG = new RNG();
        public static Items Items = new Items();
        public static Dictionary<string, string> Keywords = new Dictionary<string, string>();

        public Rooms RoomManager { get; private set; }
        public MOBs MobManager { get; private set; } // Add this property

        public Game()
        {
            Console.WriteLine("Welcome to AtomicNomad!\n");

            // Create an instance of the Rooms class and assign it to RoomManager
            RoomManager = new Rooms();

            MobManager = new MOBs(); // Create an instance of MOBs

            RegisterKeywords();

            Items.Weapons["sword"].Attack();
            Console.WriteLine(Items["arrow"].Description);

            Console.WriteLine("\ntemporary user input system... try 'items' or 'rooms'");

            Input();
        }

        void Input()
        {
            Console.WriteLine("Enter a command:");
            string input = Console.ReadLine().Trim().ToLower();

            if (Keywords.TryGetValue(input, out string value))
            {
                Console.WriteLine(value);
            }
            else if (input == "rooms")
            {
                RoomManager.ListRoomNames();
            }
            else if (input == "mobs")
            {
                
                MobManager.ListMobs(); 
            }
            else if (MobManager.MobsData.ContainsKey(input))
            {
                MobManager.DisplayMobData(input); // Display mob data for a specific mob
            }
            else if (RoomManager.RoomsData.ContainsKey(input))
            {
                RoomManager.DisplayRoomData(input);
            }
            else
            {
                Console.WriteLine($"Unknown input '{input}'. Try 'items', 'rooms', 'mobs', or a valid room/mob name.");
            }

            Input();
        }

        void RegisterKeywords()
        {
            Keywords.Add("items",
                $"There are currently {Items.Miscellaneous.Count + Items.Potions.Count + Items.Weapons.Count} total items.\n" +
                $"{Items.Weapons.Count} weapons, {Items.Potions.Count} potions, and {Items.Miscellaneous.Count} miscellaneous items.\n" +
                "Try 'weapons', 'potions', or 'misc'."
            );

            Keywords.Add("weapons", string.Join(", ", Items.Weapons.Keys));
            foreach (var data in Items.Weapons) Keywords.Add(data.Key, $"{data.Value.ID}, {data.Value.Description}. does {data.Value.Damage[0]} - {data.Value.Damage[1]} damage.");

            Keywords.Add("potions", string.Join(", ", Items.Potions.Keys));
            foreach (var data in Items.Potions) Keywords.Add(data.Key, $"{data.Value.ID} {data.Value.Description}");

            Keywords.Add("misc", string.Join(", ", Items.Miscellaneous.Keys));
            foreach (var data in Items.Miscellaneous) Keywords.Add(data.Key, $"{data.Value.ID} is the {data.Value.Description}");

            Keywords.Add("rooms", "List of available rooms:\n" + RoomManager.GetRoomList());









            Console.WriteLine($"Registered {Keywords.Count} total keywords.\n");
        }



    }
}
