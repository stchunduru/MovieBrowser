using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieBrowser.Data;
using Microsoft.EntityFrameworkCore;

namespace MovieBrowser.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movie.Include(t => t.Theater).OrderBy(t => t.Name).ToListAsync();
            return View(movies);
        }
    }
}
