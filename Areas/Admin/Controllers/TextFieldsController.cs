using Microsoft.AspNetCore.Mvc;
using NewWebShopStream.Domain.Models;
using NewWebShopStream.Domain.Models.Entities;
using NewWebShopStream.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebShopStream.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly DataManager dataManager;
        public TextFieldsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Edit(string codeWord)
        {
            var textFields = dataManager.TextFields.GetTextFieldByCodeWord(codeWord);
            return View(textFields);
        }
        [HttpPost]
        public IActionResult Edit(TextField textField)
        {
            if(ModelState.IsValid)
            {
                dataManager.TextFields.SaveTextField(textField);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(textField);
        }
    }
}
