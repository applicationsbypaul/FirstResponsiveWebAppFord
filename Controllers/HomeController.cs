/**************************************************************
* Name        : HomeController
* Author      : Paul Ford
* Created     : 5/30/2000
* Course      : CIS 174 Advance c#
* OS          : Windows 10
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Contorller to show what the view getts.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.
***************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppFord;
using FirstResponsiveWebAppFord.Models;

namespace FirstResponsiveWebAppFord.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "";
            ViewBag.Age = "";
            return View();
        }
        /// <summary>
        /// Comfirms that the input is valid
        /// if not, set the variables to default. 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(Person model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = model.Name;
                ViewBag.Age = model.CalculateAge();
            }
            else
            {
                ViewBag.Name = "";
                ViewBag.Age = "";
            }
            return View(model);
        }
    }
}
