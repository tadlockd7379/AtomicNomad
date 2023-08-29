using AtomicNomad.game.items.weapons;
using AtomicNomad.game.items.potions;
using NomadLibrary;
using System.Collections.Generic;

namespace AtomicNomad.game.items
{
    class Items
    {
        public Dictionary<string, Weapon> Weapons = new Dictionary<string, Weapon>();
        public Dictionary<string, Potion> Potions = new Dictionary<string, Potion>();

        public Dictionary<string, Item> Miscellaneous = new Dictionary<string, Item>();

        public Dictionary<string, string> ItemInputs = new Dictionary<string, string>();

        public Items()
        {
            // Weapons
            foreach (var data in JsonUtilities.DictionaryFromFile<MeleeWeapon>("items/weapons/melee-weapons")) Weapons.Add(data.Key, data.Value);
            foreach (var data in JsonUtilities.DictionaryFromFile<RangedWeapon>("items/weapons/ranged-weapons")) Weapons.Add(data.Key, data.Value);

            // Potions
            foreach (var data in JsonUtilities.DictionaryFromFile<HealingPotion>("items/potions/healing-potions")) Potions.Add(data.Key, data.Value);

            // Misc Items
            foreach (var data in JsonUtilities.DictionaryFromFile<Item>("items/miscellaneous")) Miscellaneous.Add(data.Key, data.Value);
        }
    }
}
