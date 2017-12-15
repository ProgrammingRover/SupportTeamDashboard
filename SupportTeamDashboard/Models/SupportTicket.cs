using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportTeamDashboard.Models
{
    public class SupportTicket
    {
        public int ID { get; set; }
        public DateTime TicketDate { get; set; }
        public string ProjectType { get; set; }
        public string TicketStatus { get; set; }
        public string TicketUrgency { get; set; }
        public string SupportTeamMember { get; set; }
        public string WhoIsCaller { get; set; }
        public int CallerNumber { get; set; }
        public string CallerEmail { get; set; }
        public string TicketSubject { get; set; }
        public string TicketDescription { get; set; }
        public string TicketResolution { get; set; }
        public bool FollowUpRequired { get; set; }
        public bool VoicemailCallback { get; set; }
        public string TicketCategory { get; set; }
        public string TicketSubCategory { get; set; }
        public int TotalTimeSpent { get; set; }

    }
}
