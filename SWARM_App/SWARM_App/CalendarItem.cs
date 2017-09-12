using System;
namespace SWARM_App
{
    public class CalendarItem
    {
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Memo { get; set; }
        public string ClientID { get; set; }
        public string EmployeeID { get; set; }
        public string TimeToString { get; set; }

        public CalendarItem(string date, string starttime, string endtime, string memo, string clientid, string employeeid)
        {
            Date = date;
            StartTime = starttime;
            EndTime= endtime;
            Memo = memo;
            ClientID = clientid;
            EmployeeID = employeeid;
            TimeToString = StartTime + " - " + EndTime;
        }
    }
}
