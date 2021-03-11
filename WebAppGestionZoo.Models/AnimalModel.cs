using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGestionZoo.Models
{
    public class AnimalModel
    {
        #region Fields 
        private string _nom, _sexe, _espece,_classe,_famille,_typeAlimentaire;
        private PhotoModel _photoAnimal= new PhotoModel();
        //id enclos?
        #endregion

        #region Properties

        public string Espece
        {
            get
            {
                return _espece;
            }

            set
            {
                _espece = value;
            }
        }

        public string Classe
        {
            get
            {
                return _classe;
            }

            set
            {
                _classe = value;
            }
        }

        public string Famille
        {
            get
            {
                return _famille;
            }

            set
            {
                _famille = value;
            }
        }

        public string TypeAlimentaire
        {
            get
            {
                return _typeAlimentaire;
            }

            set
            {
                _typeAlimentaire = value;
            }
        }

        public PhotoModel PhotoAnimal { get => _photoAnimal; set => _photoAnimal = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Sexe { get => _sexe; set => _sexe = value; }
        public string Espece1 { get => _espece; set => _espece = value; }

        #endregion
    }
}