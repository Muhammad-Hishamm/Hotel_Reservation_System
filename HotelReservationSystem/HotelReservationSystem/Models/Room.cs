using HotelReservationSystem.Models.Enums;

namespace HotelReservationSystem.Models
{
    public class Room: BaseModel
    {
        public string RoomNumber { get; set; }
        public RoomType Type { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; }
        public int Capacity { get; set; }     //i recommend to use RoomType to determine capacity instead
        public List<string> ImageUrls { get; set; } // change this to table 
        public string Description { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Offer> Offers { get; set; }// possible to change this relationship to many-to-many if needed
        public List<Feedback> Feedbacks { get; set; }
        public Guid RoomFacilitiesId { get; set; }
        public RoomFacilities RoomFacilities { get; set; }


    }
}
