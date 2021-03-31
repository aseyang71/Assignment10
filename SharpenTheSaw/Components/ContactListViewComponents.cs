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
            return View(context.Teams
                .FromSqlInterpolated($"Select * From Teams")
                .ToList()
                );
        }
    }
}
