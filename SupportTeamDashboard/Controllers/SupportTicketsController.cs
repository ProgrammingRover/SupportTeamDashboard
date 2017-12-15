using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SupportTeamDashboard.Models;

namespace SupportTeamDashboard.Controllers
{
    public class SupportTicketsController : Controller
    {
        private readonly SupportTeamDashboardContext _context;

        public SupportTicketsController(SupportTeamDashboardContext context)
        {
            _context = context;
        }

        // GET: SupportTickets
        public async Task<IActionResult> Index()
        {
            return View(await _context.SupportTicket.ToListAsync());
        }

        // GET: SupportTickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supportTicket = await _context.SupportTicket
                .SingleOrDefaultAsync(m => m.ID == id);
            if (supportTicket == null)
            {
                return NotFound();
            }

            return View(supportTicket);
        }

        // GET: SupportTickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SupportTickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TicketDate,ProjectType,TicketStatus,TicketUrgency,SupportTeamMember,WhoIsCaller,CallerNumber,CallerEmail,TicketSubject,TicketDescription,TicketResolution,FollowUpRequired,VoicemailCallback,TicketCategory,TicketSubCategory,TotalTimeSpent")] SupportTicket supportTicket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supportTicket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(supportTicket);
        }

        // GET: SupportTickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supportTicket = await _context.SupportTicket.SingleOrDefaultAsync(m => m.ID == id);
            if (supportTicket == null)
            {
                return NotFound();
            }
            return View(supportTicket);
        }

        // POST: SupportTickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TicketDate,ProjectType,TicketStatus,TicketUrgency,SupportTeamMember,WhoIsCaller,CallerNumber,CallerEmail,TicketSubject,TicketDescription,TicketResolution,FollowUpRequired,VoicemailCallback,TicketCategory,TicketSubCategory,TotalTimeSpent")] SupportTicket supportTicket)
        {
            if (id != supportTicket.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supportTicket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupportTicketExists(supportTicket.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(supportTicket);
        }

        // GET: SupportTickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supportTicket = await _context.SupportTicket
                .SingleOrDefaultAsync(m => m.ID == id);
            if (supportTicket == null)
            {
                return NotFound();
            }

            return View(supportTicket);
        }

        // POST: SupportTickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supportTicket = await _context.SupportTicket.SingleOrDefaultAsync(m => m.ID == id);
            _context.SupportTicket.Remove(supportTicket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupportTicketExists(int id)
        {
            return _context.SupportTicket.Any(e => e.ID == id);
        }
    }
}
