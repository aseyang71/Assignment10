using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharpenTheSaw.Models;

namespace SharpenTheSaw.Components
{
    public class ContactListViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;

        public ContactListViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            // Set ViewBag value to the routedata from the view to set the condition deciding what Bootstrap class to apply 
            ViewBag.TeamName = RouteData?.Values["TeamName"];

            return View(context.Teams
                .FromSqlInterpolated($"Select * From Teams")
                .ToList()
                );
        }
    }
}
