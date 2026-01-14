namespace HotelReservationSystem.Models
{
    public class RoomFacilities: BaseModel
    {
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
        public Guid FacilityId { get; set; }
        public Facility Facility { get; set; }
    }
}
