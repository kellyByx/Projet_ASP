using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppGestionZoo.Entities
{
    public class SoigneurEntity
    {
        private int _idSoigneur;
        private string _nom, _prenom, _specialisation, _email, _login,_password, _telephone, _photo;

        public int IdSoigneur { get => _idSoigneur; set => _idSoigneur = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Specialisation { get => _specialisation; set => _specialisation = value; }
        public string Email { get => _email; set => _email = value; }
        public string Login { get => _login; set => _login = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }
        public string Photo { get => _photo; set => _photo = value; }
        //public string Salt { get => _salt; set => _salt = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
