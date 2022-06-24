using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieBrowser.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBrowser.Controllers
{
    public class TheaterController : Controller
    {
        private readonly AppDbContext _context;

        public TheaterController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var theaters = await _context.Theaters.ToListAsync();
            return View(theaters);
        }
    }
}
