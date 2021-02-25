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
           Animal.Add(new AnimalModel() {  Classe = "Oiseaux", Espece = "Aras", Famille = "Psittacidés"});
            Animal[0].PhotoAnimal.Haute = "/images/photos/haute/s1.jpg";
           Animal.Add(new AnimalModel() {  Classe = "Primates", Espece = "XXX", Famille = "YYYY" });
            Animal[1].PhotoAnimal.Haute = "/images/photos/haute/s2.jpg";
            Animal.Add(new AnimalModel() {  Classe = "Mammifère", Espece = "XXX", Famille = "YYYY" });
            Animal[2].PhotoAnimal.Haute = "/images/photos/haute/s3.jpg";
            Animal.Add(new AnimalModel() {  Classe = "Mammifère", Espece = "XXX", Famille = "YYYY" });
            Animal[3].PhotoAnimal.Haute = "/images/photos/haute/s4.jpg";
            Animal.Add(new AnimalModel() { Classe = "Oiseaux", Espece = "Aras", Famille = "Psittacidés" });
            Animal[4].PhotoAnimal.Haute = "/images/photos/haute/s1.jpg";
            Animal.Add(new AnimalModel() { Classe = "Primates", Espece = "XXX", Famille = "YYYY" });
            Animal[5].PhotoAnimal.Haute = "/images/photos/haute/s2.jpg";
            Animal.Add(new AnimalModel() { Classe = "Mammifère", Espece = "XXX", Famille = "YYYY" });
            Animal[6].PhotoAnimal.Haute = "/images/photos/haute/s3.jpg";
            Animal.Add(new AnimalModel() { Classe = "Mammifère", Espece = "XXX", Famille = "YYYY" });
            Animal[7].PhotoAnimal.Haute = "/images/photos/haute/s4.jpg";

        }


        public List<AnimalModel> Animal 
        { get => _animal; set => _animal = value; }
   
    }

   
}