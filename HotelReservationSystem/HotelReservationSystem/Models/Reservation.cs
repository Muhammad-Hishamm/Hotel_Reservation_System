using HotelReservationSystem.Models.Enums;

namespace HotelReservationSystem.Models
{
    public class Reservation: BaseModel
    {
        public Guid? CreatedById { get; set; }
        public Staff? CreatedBy { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer{ get; set; }
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public ReservationStatus Status { get; set; }


        public Feedback Feedback { get; set; }
        public Payment Payment { get; set; }
       

    }
}
