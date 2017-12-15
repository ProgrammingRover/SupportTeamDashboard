using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportTeamDashboard.Models
{
    public class YTD_SupportLog
    {
        public int ID { get; set; }
        public string Project { get; set; }
        public DateTime SupportTicketDate { get; set; }
        public string SupportTicketType { get; set; }
        public string AfterHours { get; set; }
        public string Quarter { get; set; }
        public string TicketStatus { get; set; }
        public string PartnerName { get; set; }
        public string EnvironmentAffected { get; set; }
        public string Urgency { get; set; }
        public string SupportTeamMember { get; set; } 
        public string WhoIsCaller { get; set; }
        public string CallerNumber { get; set; }
        public string CallerEmail { get; set; }
        public string TicketDescription { get; set; }
        public string TicketResolution { get; set; }
        public string SupportTicketCategory { get; set; }
        public string SupportTicketSubCategory { get; set; }
        public int QATimeSpent { get; set; }
        public int PTTimeSpent { get; set; }
        public int DevTimeSpent { get; set; }
        public int TotalTimeSpent { get; set; }


    }
}
