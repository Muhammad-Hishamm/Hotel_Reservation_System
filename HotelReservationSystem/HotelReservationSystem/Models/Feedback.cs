namespace HotelReservationSystem.Models
{
    public class Feedback: BaseModel
    {
        //public Guid ReservationId { get; set; } //  نحطها ولا نشيلها نسال فيها
        //public Reservation Reservation { get; set; } 
        public int Rating { get; set; }
        public string Comments { get; set; }
        public FeedbackResponse Response { get; set; }
        public Guid CustomerID { get; set; }
        public Customer Customer { get; set; } 
        public Guid RoomID { get; set; }
        public Room Room { get; set; }


    }
}
