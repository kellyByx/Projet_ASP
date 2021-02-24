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
        private string _nom;
        private string _prenom;
        private string _specialisation;
        private string _email;
        private string _loging;
        //[Password]       VARBINARY(50) 
        private string _telephone;

        public int IdSoigneur { get => _idSoigneur; set => _idSoigneur = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Specialisation { get => _specialisation; set => _specialisation = value; }
        public string Email { get => _email; set => _email = value; }
        public string Loging { get => _loging; set => _loging = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }
    }
}
