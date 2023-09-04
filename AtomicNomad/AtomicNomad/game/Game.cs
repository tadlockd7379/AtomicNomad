using System;
using System.Collections.Generic;
using AtomicNomad.game.items;
using NomadLibrary;
using Newtonsoft.Json;
using System.IO;

namespace AtomicNomad.game
{
    class Game
    {
        public static RNG RNG = new RNG();
        public static Items Items = new Items();
        public static Dictionary<string, string> Keywords = new Dictionary<string, string>();
        public static List<Room> RoomsData = new List<Room>();

        public Game()
        {
            Console.WriteLine("Welcome to AtomicNomad!\n");

            LoadRooms(@"..\..\..\..\..\..\..\..\data\rooms\Rooms.json");

            RegisterKeywords();

            Items.Weapons["sword"].Attack();
            Console.WriteLine(Items["arrow"].Description);

            Console.WriteLine("\ntemporary user input system... try 'items' or 'rooms'");

            Input();
        }

        void Input()
        {
            Console.WriteLine("");
            string input = Console.ReadLine().ToLower();
            Console.WriteLine("");

            if (Keywords.TryGetValue(input, out string value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine($"Unknown input '{input}' Try 'items' or 'rooms'.");
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

            Keywords.Add("rooms", "List of available rooms:\n" + GetRoomList());

            Console.WriteLine($"Registered {Keywords.Count} total keywords.\n");
        }

        string GetRoomList()
        {
            List<string> roomNames = new List<string>();
            foreach (var room in RoomsData)
            {
                roomNames.Add(room.RoomName);
            }
            return string.Join(", ", roomNames);
        }

        void LoadRooms(string jsonFilePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(jsonFilePath);
                RoomsData = JsonConvert.DeserializeObject<List<Room>>(jsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading rooms data: " + ex.Message);
            }
        }
    }
}