using HotelReservationSystem.Models.Enums;

namespace HotelReservationSystem.Models
{
    public class Report: BaseModel
    {
        // break this model into three types booking , revenue , customer  without inheritance
        public string Title { get; set; }
        public ReportType Type { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        // add a specific period for the report per month


    }
}
