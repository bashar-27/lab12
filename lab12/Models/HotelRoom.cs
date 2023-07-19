using System.ComponentModel.DataAnnotations.Schema;

namespace lab12.Models
{
    public class HotelRoom
    {
        
        public int HotelId { get; set; }
        public int RoomId { get; set;}
        public string RoomNumber { get; set; }
        public decimal Rate { get; set;}
        public bool PetFriendly { get; set; }

    }
}
