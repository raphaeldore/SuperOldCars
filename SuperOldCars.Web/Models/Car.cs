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
        [Range(2000, 2015, ErrorMessage = "Votre voiture est trop vieille. L'année de la voiture doit être entre 2000 et 2015.")]
        public int Annee { get; set; }

        [DisplayName("Propriétaire")]
        [Required(ErrorMessage = "Le champ Propriétaire est requis")]
        public string Proprietaire { get; set; }

        [DisplayName("Téléphone")]
        [Required(ErrorMessage = "Le champ Téléphone est requis")]
        public string Telephone { get; set; }

        [DisplayName("Négociable?")]
        [Required(ErrorMessage = "Le champ Négociable est requis")]
        public bool Negociable { get; set; }

        [DisplayName("Prix")]
        [Required(ErrorMessage = "Le champ Prix est requis")]
        public decimal Prix { get; set; }

        [DisplayName("Information")]
        [Required(ErrorMessage = "Le champ Information est requis")]
        public string Information { get; set; }

        [DisplayName("De condition?")]
        [Required(ErrorMessage = "Le champ De Condition? est requis")]
        public bool Conditions { get; set; }
    }

}