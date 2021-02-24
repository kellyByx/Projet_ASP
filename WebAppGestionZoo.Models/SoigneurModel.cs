using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGestionZoo.Models
{
    public class SoigneurModel
    {
        #region Fields 
        private string _nom, _prenom, _specialisation,_photoId;
        #endregion

        #region Properties


        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        public string Specialisation
        {
            get
            {
                return _specialisation;
            }

            set
            {
                _specialisation = value;
            }
        }

        public string PhotoId
        {
            get
            {
                return _photoId;
            }

            set
            {
                _photoId = value;
            }
        }
        #endregion
    }
}