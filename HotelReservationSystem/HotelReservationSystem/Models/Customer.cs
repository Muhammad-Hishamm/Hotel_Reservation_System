namespace HotelReservationSystem.Models
{
    public class Customer: User
    {
        // criedit card info 
        // 
        public List<Reservation> Reservations { get; set; }
        public List<Payment> Payments { get; set; }
        public List<Feedback> Feedbacks { get; set; }

    }
}
