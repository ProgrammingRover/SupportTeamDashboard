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
    public class YTD_SupportLogController : Controller
    {
        private readonly SupportTeamDashboardContext _context;

        public YTD_SupportLogController(SupportTeamDashboardContext context)
        {
            _context = context;
        }

        // GET: YTD_SupportLog
        public async Task<IActionResult> Index()
        {
            return View(await _context.YTD_SupportLog.ToListAsync());
        }

        // GET: YTD_SupportLog/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yTD_SupportLog = await _context.YTD_SupportLog
                .SingleOrDefaultAsync(m => m.ID == id);
            if (yTD_SupportLog == null)
            {
                return NotFound();
            }

            return View(yTD_SupportLog);
        }

        // GET: YTD_SupportLog/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: YTD_SupportLog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Quarter,SupportTicketDate,AfterHours,SupportTicketType,PartnerName,EnvironmentAffected,SupportTeamMember,SupportTicketCategory,SupportTicketSubCategory,SupportTicketIssueDetails,SupportTicketResolutionDetails,QATimeSpent,PTTimeSpent,DevTimeSpent,TotalTimeSpent")] YTD_SupportLog yTD_SupportLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yTD_SupportLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(yTD_SupportLog);
        }

        // GET: YTD_SupportLog/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yTD_SupportLog = await _context.YTD_SupportLog.SingleOrDefaultAsync(m => m.ID == id);
            if (yTD_SupportLog == null)
            {
                return NotFound();
            }
            return View(yTD_SupportLog);
        }

        // POST: YTD_SupportLog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Quarter,SupportTicketDate,AfterHours,SupportTicketType,PartnerName,EnvironmentAffected,SupportTeamMember,SupportTicketCategory,SupportTicketSubCategory,SupportTicketIssueDetails,SupportTicketResolutionDetails,QATimeSpent,PTTimeSpent,DevTimeSpent,TotalTimeSpent")] YTD_SupportLog yTD_SupportLog)
        {
            if (id != yTD_SupportLog.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yTD_SupportLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YTD_SupportLogExists(yTD_SupportLog.ID))
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
            return View(yTD_SupportLog);
        }

        // GET: YTD_SupportLog/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yTD_SupportLog = await _context.YTD_SupportLog
                .SingleOrDefaultAsync(m => m.ID == id);
            if (yTD_SupportLog == null)
            {
                return NotFound();
            }

            return View(yTD_SupportLog);
        }

        // POST: YTD_SupportLog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yTD_SupportLog = await _context.YTD_SupportLog.SingleOrDefaultAsync(m => m.ID == id);
            _context.YTD_SupportLog.Remove(yTD_SupportLog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YTD_SupportLogExists(int id)
        {
            return _context.YTD_SupportLog.Any(e => e.ID == id);
        }
    }
}
