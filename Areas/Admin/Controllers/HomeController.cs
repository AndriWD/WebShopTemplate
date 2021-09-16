using Microsoft.AspNetCore.Mvc;
using NewWebShopStream.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebShopStream.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            return View(dataManager.ServiceItems.GetServiceItems());
        }

    }
}
