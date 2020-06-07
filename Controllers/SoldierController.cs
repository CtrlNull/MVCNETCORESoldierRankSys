using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InterviewExercise.Models;
using Microsoft.Extensions.Configuration;


namespace InterviewExercise.Controllers
{


    public class SoldierController : Controller
    {
        private readonly ILogger<SoldierController> _logger;
        private readonly IConfiguration _configuration;
        public SoldierController(ILogger<SoldierController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }



        public IActionResult Index()
        {
            SoldierContainer soldierInfo = new SoldierContainer();


            // Lets attach to local main images
            AttachLocalImage(soldierInfo);
            
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

        #region Functions

        public SoldierContainer AttachLocalImage(SoldierContainer cont)
        {
            foreach (var soldier in cont.SoldierList)
            {
                switch (soldier.SoliderId)
                {
                    case 1:
                        soldier.SoldierImage = _configuration["soldierOneImage"];
                        break;
                    case 2:
                        soldier.SoldierImage = _configuration["soldierTwoImage"];
                        break;

                    case 3:
                        soldier.SoldierImage = _configuration["soldierThreeImage"];
                        break;
                    default:
                        break;
                }
            }
            return cont;
        }

        #endregion Functions
    }
}