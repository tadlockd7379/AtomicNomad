using AtomicNomad.game.items.weapons;
using AtomicNomad.game.items.potions;
using NomadLibrary;
using System.Collections.Generic;

namespace AtomicNomad.game.items
{
    class Items
    {
        public Dictionary<string, dynamic> AllItems = new Dictionary<string, dynamic>();

        public Dictionary<string, Weapon> Weapons = new Dictionary<string, Weapon>();
        public Dictionary<string, Potion> Potions = new Dictionary<string, Potion>();
        public Dictionary<string, GameObject> Miscellaneous = new Dictionary<string, GameObject>();

        public Items()
        {
            // Weapons
            LoadItems<MeleeWeapon>("items/weapons/melee-weapons", Weapons);
            LoadItems<RangedWeapon>("items/weapons/ranged-weapons", Weapons);

            // Potions
            LoadItems<HealingPotion>("items/potions/healing-potions", Potions);

            // Misc Items
            LoadItems<GameObject>("items/miscellaneous", Miscellaneous);
        }

        public void LoadItems<T>(string file, dynamic dictionary)
        {
            foreach (var data in JsonUtilities.DictionaryFromFile<T>(file))
            {
                AllItems.Add(data.Key, data.Value);
                dictionary.Add(data.Key, data.Value);
            }
        }

        public GameObject this[string id] => AllItems[id];
    }
}