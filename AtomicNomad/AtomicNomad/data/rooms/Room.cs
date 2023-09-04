using System.Collections.Generic;

public class Room
{
    public int RoomID { get; set; }
    public string RoomName { get; set; }
    public string RoomDescription { get; set; }
    public List<string> Items { get; set; }
    public List<string> Enemies { get; set; }
}