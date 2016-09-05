﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using OpenCharityAuction.Web.Models.Interfaces;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OpenCharityAuction.Web.Controllers
{
    [Authorize]
    public class MealController : Controller
    {
        private readonly IAuctionService AuctionService;
        private readonly IUserService UserService; 

        public MealController(IAuctionService auctionService, IUserService userService)
        {
            UserService = userService;
            AuctionService = auctionService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Index");
        }
        
        public IActionResult AddMeal(string errorMessage = null)
        {
            ViewData["ErrorMessage"] = errorMessage;
            return View("AddMeal");
        }
    }
}
