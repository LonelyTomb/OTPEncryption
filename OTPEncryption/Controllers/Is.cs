using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OtpNet;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OTPEncryption.Controllers
{
    
    public class Is : Controller
    {
       
        // GET: /<controller>/
        public IActionResult Index()
        {
            byte[] secretKey = { 211 };
            var topt = new Totp(secretKey);
            var toptCode = topt.ComputeTotp();
            ViewBag.t = toptCode;
            return View();
        }
    }
}
