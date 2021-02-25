using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGestionZoo.Models
{
    public class AnimalModel
    {
        #region Fields 
        private string _image,_espece,_classe,_famille,_typeAlimentaire;
        #endregion

        #region Properties


        public string Image
        {
            get
           {
               return _image;
           }

            set
          {
                _image = value;
            }
        }

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

        #endregion
    }
}