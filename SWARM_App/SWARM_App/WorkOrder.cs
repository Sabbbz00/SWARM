using System;
namespace SWARM_App
{
    public class WorkOrder
    {
        public string WorkOrderID { get; set; }
        public string ClientID { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndDate { get; set; }
        public string Memo { get; set; }
        public string Chem1 { get; set; }
        public string Chem2 { get; set; }
        public string Chem3 { get; set; }
        public string Trap1 { get; set; }
        public string Trap2 { get; set; }
        public string Trap3 { get; set; }
        public double TotalCost { get; set; }

        public WorkOrder()
        {
        }
    }
}
