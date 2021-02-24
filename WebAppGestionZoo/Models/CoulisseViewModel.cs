using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGestionZoo.Models
{
    public class CoulisseViewModel
    {
        private List<SoigneurModel> _soigneur;

        public CoulisseViewModel()
        {
            //section des soigneurs
            Soigneur = new List<SoigneurModel>();
            Soigneur.Add(new SoigneurModel() {Nom="Grosh", Prenom="Bradley", Specialisation="Les oiseaux", PhotoId="/images/t1.jpg" });
            Soigneur.Add(new SoigneurModel() { Nom="Peters", Prenom="Dayle", Specialisation="Les reptiles", PhotoId ="/images/t2.jpg" });
            Soigneur.Add(new SoigneurModel() { Nom="Pool", Prenom="Marie", Specialisation="Les Ongulés", PhotoId ="/images/t3.jpg" });
            Soigneur.Add(new SoigneurModel() { Nom="Kyu", Prenom="Nathan", Specialisation="Les primates", PhotoId ="/images/t4.jpg" });
        }                   

        public List<SoigneurModel> Soigneur
        {
            get
            {
                return _soigneur;
            }

            set
            {
                _soigneur = value;
            }
        }


    }

   
}