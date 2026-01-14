using HotelReservationSystem.Models.Enums;

namespace HotelReservationSystem.Models
{
    public class Payment : BaseModel
    {
        public Guid ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        public Guid?StaffId { get; set; }
        public Staff? Staff { get; set; }

        public decimal Amount { get; set; }
        public DateTime IssuedOn { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }
        public string? TransactionId { get; set; } // for external payment gateway reference

    }
}
