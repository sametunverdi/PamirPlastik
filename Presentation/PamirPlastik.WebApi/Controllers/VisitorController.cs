using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Persistence.Context;
using System;
using System.Linq;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly PamirPlastikContext _context;

        public VisitorController(PamirPlastikContext context)
        {
            _context = context;
        }

        [HttpPost("Increment")]
        public IActionResult IncrementVisitor()
        {
            try
            {
                var today = DateTime.Today;
                var stat = _context.VisitorStatistics.FirstOrDefault(x => x.VisitDate == today);
                
                if (stat == null)
                {
                    _context.VisitorStatistics.Add(new PamirPlastik.Domain.Entities.VisitorStatistic
                    {
                        VisitDate = today,
                        VisitorCount = 1
                    });
                }
                else
                {
                    stat.VisitorCount += 1;
                }
                _context.SaveChanges();
                
                return Ok();
            }
            catch (Exception)
            {
                // Silently fail, do not crash the frontend
                return Ok();
            }
        }

        [HttpGet("GetStats")]
        public IActionResult GetStats()
        {
            var today = DateTime.Today;
            var startOfWeek = today.AddDays(-(int)today.DayOfWeek);
            var startOfMonth = new DateTime(today.Year, today.Month, 1);

            var allStats = _context.VisitorStatistics.ToList();

            var todayCount = allStats.Where(x => x.VisitDate == today).Sum(x => x.VisitorCount);
            var weeklyCount = allStats.Where(x => x.VisitDate >= startOfWeek).Sum(x => x.VisitorCount);
            var monthlyCount = allStats.Where(x => x.VisitDate >= startOfMonth).Sum(x => x.VisitorCount);
            var totalCount = allStats.Sum(x => x.VisitorCount);

            return Ok(new
            {
                Today = todayCount,
                Weekly = weeklyCount,
                Monthly = monthlyCount,
                Total = totalCount
            });
        }
    }
}
