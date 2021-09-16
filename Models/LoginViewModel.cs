using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebShopStream.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Логін")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "пароль")]
        [UIHint("password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Запам'ятати мене?")]
        public bool RememberMe { get; set; }

    }
}
