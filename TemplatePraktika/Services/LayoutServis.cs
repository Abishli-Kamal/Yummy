using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplatePraktika.DAL;
using TemplatePraktika.Models;

namespace TemplatePraktika.Services
{
    public class LayoutServis
    {
        private readonly AppDbContext _context;

        public LayoutServis(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Setting>> Getdatas()
        {
            List<Setting> settings = await _context.Settings.ToListAsync();
            return settings;
        }
    }
}
