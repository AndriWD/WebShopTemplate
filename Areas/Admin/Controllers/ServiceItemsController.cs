using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewWebShopStream.Domain.Models;
using NewWebShopStream.Domain.Models.Entities;
using NewWebShopStream.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebShopStream.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment webHost;
        public ServiceItemsController(DataManager dataManager, IWebHostEnvironment webHost)
        {
            this.dataManager = dataManager;
            this.webHost = webHost;
        }
        public IActionResult Edit(Guid id)
        {
            var editOrCreateItem = id == default ? new ServiceItem() : dataManager.ServiceItems.GetServiceItemById(id);
            return View(editOrCreateItem);
        }
        [HttpPost]
        public IActionResult Edit(ServiceItem serviceItem, IFormFile file)
        {
            if(ModelState.IsValid)
            {
                if(file != null)
                {
                    serviceItem.PathToImage = file.FileName;
                    using(var fileStream = new FileStream(Path.Combine(webHost.WebRootPath, "images/", file.FileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }
                dataManager.ServiceItems.SaveServiceItem(serviceItem);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(serviceItem);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.ServiceItems.DeleteServiceItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
