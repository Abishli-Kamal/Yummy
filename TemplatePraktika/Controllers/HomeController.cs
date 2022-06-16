using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplatePraktika.DAL;
using TemplatePraktika.ViewModels;

namespace TemplatePraktika.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Images = await _context.Images.FirstOrDefaultAsync(),
                Abouts = await _context.Abouts.FirstOrDefaultAsync(),
                AboutCards=await _context.AboutCards.ToListAsync(),
            };
            return View(model);
        
        }
    }
}
