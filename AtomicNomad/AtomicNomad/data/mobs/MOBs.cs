/**
* 9/17/2023
* CSC 253
* Group 1
* Group Members:Daniel Parks, Drew Tadlock
* Mud Game for CSC 253. DUNGON CRAWLER MEETS ATOMIC DISASTER
* 
* Moduel 1
* 
* 
*/


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace AtomicNomad.game
{
    public class MOBs
    {
        public Dictionary<string, Mob> MobsData { get; private set; }

        public MOBs()
        {
            LoadMobs(@"..\..\data\mobs\Mobs.json");
        }

        public void LoadMobs(string jsonFilePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(jsonFilePath);
                MobsData = JsonConvert.DeserializeObject<Dictionary<string, Mob>>(jsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading mobs data: " + ex.Message);
            }
        }

        public void ListMobs()
        {
            Console.WriteLine("List of available mobs:");
            foreach (var mobName in MobsData.Keys)
            {
                Console.WriteLine(mobName);
            }
        }

        public void DisplayMobData(string mobName)
        {
            if (MobsData.TryGetValue(mobName, out Mob mob))
            {
                Console.WriteLine($"Mob Name: {mob.Name}");
                Console.WriteLine($"Health: {mob.Health}");
                Console.WriteLine($"Attack: {mob.Attack}");
                Console.WriteLine($"Description: {mob.Description}");
            }
            else
            {
                Console.WriteLine($"Mob '{mobName}' not found.");
            }
        }

        public class Mob
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int Attack { get; set; }
            public string Description { get; set; }
        }
    }
}