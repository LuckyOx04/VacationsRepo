using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vacations.Models
{
    public class VacationsModel
    {
        [Display(Name = "Number of people")]
        public int NumberOfPeople { get; set; }
        public string Destination { get; set; }
        [Display(Name = "Transport type")]
        public string TransportType { get; set; }
        [Display(Name = "Hotel stars")]
        public int HotelStars { get; set; }
        public string Rooms { get; set; }
        [Display(Name = "Is the room free?")]
        public bool IsRoomFree { get; set; }
        [Display(Name = "Price of bed for adult")]
        public decimal PriceOfBedForAdult { get; set; }
        [Display(Name = "Price of bed for children")]
        public decimal PriceOfBedForChildren { get; set; }
        [Display(Name = "Number of vacation")]
        public int Number { get; set; }
    }
}
