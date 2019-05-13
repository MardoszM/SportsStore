using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwę produktu")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać opis.")]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Proszę podać cenę.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Proszę podać dodatnią cenę")]
        [Display(Name = "Cena")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Proszę podać Kategorię.")]
        [Display(Name = "Kategoria")]
        public string Category { get; set; }
    }
}





