using Bartender_App.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender_App.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DrinkController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allDrinks = await _context.Drinks.ToListAsync();
            return View(allDrinks);
        }
    }
}
