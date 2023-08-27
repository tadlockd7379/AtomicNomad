/*
 * The main actual game class, made it seperate from Program.cs so it's not static.
*/

using System;
using System.Collections.Generic;
using AtomicNomad.game.items;
using AtomicNomad.game.items.weapons;
using NomadLibrary;

namespace AtomicNomad.game
{
    class Game
    {
        public static RNG rng = new RNG();

        public Dictionary<string, dynamic> weapons = new Dictionary<string, dynamic>();

        public Game()
        {
            Console.WriteLine("Welcome to AtomicNomad!");

            RegisterData();

            Weapon sword = weapons["sword"];
            sword.Attack();

            foreach (var weapon in weapons)
            {
                Weapon weaponParsed = weapon.Value;
                weaponParsed.Attack();
            }


            Input();
        }

        void Input()
        {
            Console.ReadLine().ToLower();
            Input();
        }

        void RegisterData()
        {
            RegisterData<MeleeWeapon>("melee-weapons", weapons);
            RegisterData<RangedWeapon>("ranged-weapons", weapons);
        }

        // I'm using reflection that way we don't have to repeat the same code over and over again when we register data
        void RegisterData<T>(string file, Dictionary<string, dynamic> dictionary)
        {
            var method = typeof(T).GetMethod("FromData");
            foreach (var data in JsonUtilities.FromFile(file))
            {
                dictionary.Add(data.Key, (T) method.Invoke(null, new object[] { data.Key, data.Value }));
            }
        }
    }
}
