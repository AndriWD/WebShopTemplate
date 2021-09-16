using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebShopStream.Domain.Models.Entities
{
    public abstract class EntityBase
    {
        [Required]
        public Guid Id { get; set; }
        [Display(Name ="Назва (заголовок)")]
        public virtual string Title { get; set; }
        [Display(Name = "Короткий опис")]
        public virtual string SubTitle { get; set; }
        [Display(Name = "Довгий опис")]
        public virtual string Text { get; set; }
        [Display(Name = "Титульна картинка")]
        public virtual string PathToImage { get; set; }
        [Display(Name = "SEO метатег Title")]
        public virtual string MetaTitle { get; set; }
        [Display(Name = "SEO метатег Description")]
        public virtual string MetaDescription { get; set; }
        [Display(Name = "SEO метатег Keywords")]
        public virtual string MetaKeywords { get; set; }
        [DataType(DataType.Time)]
        public DateTime DateAded { get; set; }

        //конструктор
        protected EntityBase()
        {
            DateAded = DateTime.UtcNow;
        }
    }
}
