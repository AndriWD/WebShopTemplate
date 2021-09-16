﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebShopStream.Domain.Models.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage ="Заповніть назву послуги")]
        [Display(Name = "Назва послуги (заголовок)")]
        public override string Title { get; set; } 
        [Display(Name = "Короткий опис послуги")]
        public override string SubTitle { get; set; }
        [Display(Name = "Повний опис послуги")]
        public override string Text { get; set; }
    }
}
