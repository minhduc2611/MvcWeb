using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using project.Models;

namespace project.Controllers
{
    public class AdminController: Controller
    {
        public MyDbContext ctx;

        public AdminController(MyDbContext context)
        {
            this.ctx = context;
        }
        public IActionResult Index()
        {
            var dsLoai = ctx.Loai.OrderBy(p => p.MaLoai);
            return View(dsLoai);
        }

        public IActionResult Create()
        {
            ViewData["MaLoai"] = new SelectList(ctx.Loai, "MaLoai", "TenLoai");
            return View();
        }
         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHh,TenLoai,MoTa,Hinh")] Loai Loai)
        {
            if (ModelState.IsValid)
            {
                ctx.Add(Loai);
                await ctx.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Loai);
        }
    }
}