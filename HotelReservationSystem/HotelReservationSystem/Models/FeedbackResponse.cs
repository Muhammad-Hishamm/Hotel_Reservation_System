namespace HotelReservationSystem.Models
{
    public class FeedbackResponse: BaseModel
    {
        public Guid FeedbackId { get; set; }
        public Feedback Feedback { get; set; }
        public string ResponseMessage { get; set; }
        public DateTime RespondedOn { get; set; }


    }
}
