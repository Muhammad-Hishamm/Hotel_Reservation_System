namespace HotelReservationSystem.Models
{
    public class Offer:BaseModel
    {
        // m - m with Room 
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal DiscountPercentage { get; set; }
        public bool IsActive { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
