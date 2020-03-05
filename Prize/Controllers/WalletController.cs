using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prize.data;

namespace Prize.Controllers
{
    public class WalletController : Controller
    {
        private readonly ElPrizeContext _context;

        public WalletController(ElPrizeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Valyuta()
        {
            int UserId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid).Value);
            ViewBag.cash = _context.Users.Where(c => c.Id == UserId).First().Cash;
            return View();
        }
        public IActionResult Udush()
        {
            int UserId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid).Value);
            ViewBag.cash = _context.Users.Where(c => c.Id == UserId).First().Cash;
            return View();
        }
    }
}