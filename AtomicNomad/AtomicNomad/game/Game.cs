/*
 * The main actual game class, made it seperate from Program.cs so it's not static.
*/

using System;
using System.Collections.Generic;
using AtomicNomad.game.items;
using NomadLibrary;

namespace AtomicNomad.game
{
    class Game
    {
        public static RNG RNG = new RNG();
        public static Items Items = new Items();
        public static Dictionary<string, string> Keywords = new Dictionary<string, string>();

        public Game()
        {
            Console.WriteLine("Welcome to AtomicNomad!\n");

            RegisterKeywords();

            Items.Weapons["sword"].Attack();
            Console.WriteLine(Items["arrow"].Description);

            Console.WriteLine("\ntemporary user input system... try 'items'");

            Input();
        }

        void Input()
        {
            Console.WriteLine("");
            string input = Console.ReadLine().ToLower();
            Console.WriteLine("");
            
            Keywords.TryGetValue(input, out string value);
            if (value != null)
            {
                Console.WriteLine(value);
            } else
            {
                Console.WriteLine($"Unknown input '{input}' Try 'items'.");
            }

            Input();
        }

        void RegisterKeywords()
        {
            Keywords.Add("items",
                $"There are currently {Items.Miscellaneous.Count + Items.Potions.Count + Items.Weapons.Count} total items.\n" +
                $"{Items.Weapons.Count} weapons, {Items.Potions.Count} potions, and {Items.Miscellaneous.Count} miscalaneous items.\n" +
                "Try 'weapons', 'potions', or 'misc'."
            );

            Keywords.Add("weapons", string.Join(", ", Items.Weapons.Keys));
            foreach (var data in Items.Weapons) Keywords.Add(data.Key, $"{data.Value.ID}, {data.Value.Description}. does {data.Value.Damage[0]} - {data.Value.Damage[1]} damage.");

            Keywords.Add("potions", string.Join(", ", Items.Potions.Keys));
            foreach (var data in Items.Potions) Keywords.Add(data.Key, $"{data.Value.ID} {data.Value.Description}");

            Keywords.Add("misc", string.Join(", ", Items.Miscellaneous.Keys));
            foreach (var data in Items.Miscellaneous) Keywords.Add(data.Key, $"{data.Value.ID} is the {data.Value.Description}");

            Console.WriteLine($"Registered {Keywords.Count} total keywords.\n");
        }
    }
}
