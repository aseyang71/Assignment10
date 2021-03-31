using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SharpenTheSaw.Models;
using SharpenTheSaw.Models.ViewModels;

namespace SharpenTheSaw.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BowlingLeagueContext context;


        public HomeController(ILogger<HomeController> logger, BowlingLeagueContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        public IActionResult Index(int? teamid, string teamname, int pageNum = 0)
        {
            int pageSize = 5;
            //int test = context.Teams.Count();

            return View(new IndexViewModel
            {

                Bowlers = (context.Bowlers

                    //.FromSqlInterpolated($"Select * From Bowlers WHERE TeamId = {teamid} OR {teamid} IS NULL")
                    .Where(t => t.TeamId == teamid || teamid == null)
                    .OrderBy(t => t.BowlerFirstName)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize)
                    .ToList()
                    ),

                PageNumberInfo = new PageNumberInfo
                {
                    ItemsPerPage = pageSize,
                    CurPage = pageNum,

                    // If no team has been selected, then get the full count. Otherwise, only count the number
                    // from the team that has been selected

                    TotalItems = (teamid == null ? context.Bowlers.Count() :
                        context.Bowlers.Where(t => t.TeamId == teamid).Count())
                },

                TeamName = teamname

            });
        }

        public IActionResult Privacy()
        { 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
