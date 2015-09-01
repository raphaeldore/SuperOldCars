using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace SuperOldCars.Web.Models
{
    public class Car
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [DisplayName("Titre Annonce")]
        [Required(ErrorMessage = "Le champ Titre Annonce est requis")]
        public string TitreAnnonce { get; set; }

        [DisplayName("Marque")]
        [Required(ErrorMessage = "Le champ Marque est requis")]
        public string Marque { get; set; }

        [DisplayName("Modèle")]
        [Required(ErrorMessage = "Le champ Modèle est requis")]
        public string Modele { get; set; }

        [DisplayName("Année")]
        [Required(ErrorMessage = "Le champ Année est requis")]
        [YearRange(ErrorMessage = "L'année de la voiture doit être entre {1} et {2}")]

        public int Annee { get; set; }

        [DisplayName("Propriétaire")]
        [Required(ErrorMessage = "Le champ Propriétaire est requis")]
        public string Proprietaire { get; set; }

        [DisplayName("Téléphone")]
        [Required(ErrorMessage = "Le champ Téléphone est requis")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [DisplayName("Négociable?")]
        [Required(ErrorMessage = "Le champ Négociable est requis")]
        public bool Negociable { get; set; }

        [DisplayName("Prix")]
        [Required(ErrorMessage = "Le champ Prix est requis")]
        // 
        // ^\d+.\d{0,2}$
        // [RegularExpression(@"^\$?\d+(\.\d{2})?$", ErrorMessage = "Le prix doit être dans le format 9999.99% peut avoir plus de 2 chiffres après le point")]
        public decimal Prix { get; set; }

        [DisplayName("Information")]
        [Required(ErrorMessage = "Le champ Information est requis")]
        [DataType(DataType.MultilineText)]
        public string Information { get; set; }

        [DisplayName("De condition?")]
        [Required(ErrorMessage = "Le champ De Condition? est requis")]
        public bool Conditions { get; set; }
    }

    public class YearRangeAttribute : RangeAttribute
    {
        private const int MAX_NB_ANNEES = 15;

        public YearRangeAttribute()
            : base(DateTime.Now.AddYears(-MAX_NB_ANNEES).Year, DateTime.Now.Year) { }
    }

}