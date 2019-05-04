using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult index()
        {
            var dsLoai = ctx.Loai.OrderBy(p => p.TenLoai);
            return View(dsLoai);
        }
    }
}