using System;
using System.Collections.Generic;
using System.Text;

namespace LogInn.Domain.Entities
{
    public class Hotel
    {
        public List<Room> roomList { get; set; }

        public int totalRoom { get; set; }

        public int totalSingleRoom { get; set; }

        public int totalRoyalRoom { get; set; }

        public int totalStandardRoom { get; set; }

        public Hotel(int totalSingleRoom, int totalRoyalRoom, int totalStandardRoom)
        {
            this.totalSingleRoom = totalSingleRoom;
            this.totalStandardRoom = totalStandardRoom;
            this.totalRoyalRoom = totalRoyalRoom;
        }
    }
}
