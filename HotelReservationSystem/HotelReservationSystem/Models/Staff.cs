namespace HotelReservationSystem.Models
{
    public class Staff: User
    {
        public string? EmployeeID { get; set; }
        public string Position { get; set; }
        public DateTime HireDate { get; set; }

        public List<FeedbackResponse> FeedbackResponses { get; set; }
        public List<Reservation> ManagedReservations { get; set; }
        public List<Payment> ProcessedPayments { get; set; }


    }
}
