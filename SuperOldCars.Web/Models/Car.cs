using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public string TitreAnnonce { get; set; }

        [DisplayName("Marque")]
        public string Marque { get; set; }

        [DisplayName("Modèle")]
        public string Modele { get; set; }

        [DisplayName("Année")]
        public int Annee { get; set; }

        [DisplayName("Propriétaire")]
        public string Proprietaire { get; set; }

        [DisplayName("Téléphone")]
        public string Telephone { get; set; }

        [DisplayName("Négociable?")]
        public bool Negociable { get; set; }

        [DisplayName("Prix")]
        public decimal Prix { get; set; }

        [DisplayName("Information")]
        public string Information { get; set; }

        [DisplayName("De condition?")]
        public bool Conditions { get; set; }
    }
}