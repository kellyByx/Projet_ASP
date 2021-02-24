using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGestionZoo.Models
{
    public class AnimauxViewModel
    {
        private List<AnimalModel> _animal;

        public AnimauxViewModel()
        {
            //section Animaux
            Animal = new List<AnimalModel>();
            Animal.Add(new AnimalModel() { Image = "/images/photos/haute//s1.jpg", Classe = "Oiseaux", Espece = "Aras", Famille = "Psittacidés" });
            Animal.Add(new AnimalModel() { Image = "/images/photos/haute//s2.jpg", Classe = "Primates", Espece = "XXX", Famille = "YYYY" });
            Animal.Add(new AnimalModel() { Image = "/images/photos/haute//s3.jpg", Classe = "Mammifère", Espece = "XXX", Famille = "YYYY" });
            Animal.Add(new AnimalModel() { Image = "/images/photos/haute//s4.jpg", Classe = "Mammifère", Espece = "XXX", Famille = "YYYY" });
            Animal.Add(new AnimalModel() { Image = "/images/photos/haute//s1.jpg", Classe = "Oiseaux", Espece = "Aras", Famille = "Psittacidés" });
            Animal.Add(new AnimalModel() { Image = "/images/photos/haute//s2.jpg", Classe = "Primates", Espece = "XXX", Famille = "YYYY" });
            Animal.Add(new AnimalModel() { Image = "/images/photos/haute//s3.jpg", Classe = "Mammifère", Espece = "XXX", Famille = "YYYY" });
            Animal.Add(new AnimalModel() { Image = "/images/photos/haute//s4.jpg", Classe = "Mammifère", Espece = "XXX", Famille = "YYYY" });

        }
    

        public List<AnimalModel> Animal 
        { get => _animal; set => _animal = value; }
    }

   
}