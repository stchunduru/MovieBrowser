using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieBrowser.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBrowser.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDbContext _context;
        public ActorController(AppDbContext context)
        {
            this._context = context;
        }

        public async Task <IActionResult> Index()
        {
            var actors = await _context.Actors.ToListAsync();
            return View(actors);
        }
    }
}
