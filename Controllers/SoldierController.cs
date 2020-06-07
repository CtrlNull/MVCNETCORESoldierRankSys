using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InterviewExercise.Models;

namespace InterviewExercise.Controllers
{
    public class SoldierController : Controller
    {
        private readonly ILogger<SoldierController> _logger;

        public SoldierController(ILogger<SoldierController> logger) 
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Soldiers()
        {
            return View();
        }

        public SoldierContainer UpdateSoldierRank(SoldierUpdateRequest soldierRequest) 
        {
            SoldierContainer soldierInfo = new SoldierContainer();

            if (soldierRequest == null)
                Error();

            // Send to entity

            return null;
        }


        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}