using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace AtomicNomad.game
{
    public class Rooms
    {
        public Dictionary<string, Room> RoomsData { get; private set; }

        public Rooms()
        {
            LoadRooms(@"..\..\data\rooms\Rooms.json");
        }

        public void LoadRooms(string jsonFilePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(jsonFilePath);
                RoomsData = JsonConvert.DeserializeObject<Dictionary<string, Room>>(jsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading rooms data: " + ex.Message);
            }
        }

        public void ListRoomNames()
        {
            Console.WriteLine("List of available rooms:");
            foreach (var roomName in RoomsData.Keys)
            {
                Console.WriteLine(roomName);
            }
        }

        public void DisplayRoomData(string roomName)
        {
            if (RoomsData.TryGetValue(roomName, out Room room))
            {
                Console.WriteLine($"Room Name: {room.RoomName}");
                Console.WriteLine($"Room Description: {room.RoomDescription}");
                Console.WriteLine("Items in the Room:");
                foreach (var item in room.Items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Enemies in the Room:");
                foreach (var enemy in room.Enemies)
                {
                    Console.WriteLine(enemy);
                }
            }
            else
            {
                Console.WriteLine($"Room '{roomName}' not found.");
            }
        }
        public string GetRoomList()
        {
            List<string> roomNames = new List<string>(RoomsData.Keys);
            return string.Join(", ", roomNames);
        }
        public class Room
        {
            public int RoomID { get; set; }
            public string RoomName { get; set; }
            public string RoomDescription { get; set; }
            public List<string> Items { get; set; }
            public List<string> Enemies { get; set; }
        }


    }
}