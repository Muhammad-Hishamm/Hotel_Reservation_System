using HotelReservationSystem.Models.Enums;

namespace HotelReservationSystem.Models
{
    public class User: BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; } 
        public string PhoneNumber { get; set; }

    }
}
