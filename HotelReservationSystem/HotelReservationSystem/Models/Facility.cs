namespace HotelReservationSystem.Models
{
    public class Facility: BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid RoomFacilitiesId { get; set; }
        public RoomFacilities RoomFacilities { get; set; }
    }
}
