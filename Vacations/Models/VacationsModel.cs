using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vacations.Models
{
    public class VacationsModel
    {
        public int NumberOfPeople { get; }
        public string Destination { get; }
        public string TransportType { get; }
        public int HotelStars { get; }
        public string Rooms { get; }
        public bool IsRoomFree { get; }
        public decimal PriceOfBedForAdult { get; }
        public decimal PriceOfBedForChildren { get; }
        public int Number { get; }
    }
}
