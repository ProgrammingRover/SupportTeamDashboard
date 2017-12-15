using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SupportTeamDashboard.Models
{
    public class SupportTeamDashboardContext : DbContext
    {
        public SupportTeamDashboardContext (DbContextOptions<SupportTeamDashboardContext> options)
            : base(options)
        {
        }

        public DbSet<SupportTeamDashboard.Models.SupportTicket> SupportTicket { get; set; }
    }
}
