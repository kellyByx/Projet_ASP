using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGestionZoo.Models
{
    public class SoigneurModel
    {
        #region Fields 
        private string _nom, _prenom, _specialisation,_photoId, _email, _login, _password,_telephone;
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

        public string Email { get => _email; set => _email = value; }
        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }
        #endregion
    }
}