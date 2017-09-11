using System;
namespace SWARM_App
{
    public class CalendarItem
    {
        public string Date { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Memo { get; set; }
        public string ClientID { get; set; }
        public string EmployeeID { get; set; }

        public CalendarItem()
        {
        }
    }
}
