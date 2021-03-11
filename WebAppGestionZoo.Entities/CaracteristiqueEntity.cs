using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppGestionZoo.Entities
{
    public class CaracteristiqueEntity
    {
        private int _idCaractéristique, _idAnimal, _dateNaissance, _dateDécè, _poid, _taille;
        private string _description, _photo;

        public int IdCaractéristique { get => _idCaractéristique; set => _idCaractéristique = value; }
        public int IdAnimal { get => _idAnimal; set => _idAnimal = value; }
        public int DateNaissance { get => _dateNaissance; set => _dateNaissance = value; }
        public int DateDécè { get => _dateDécè; set => _dateDécè = value; }
        public int Poid { get => _poid; set => _poid = value; }
        public int Taille { get => _taille; set => _taille = value; }
        public string Description { get => _description; set => _description = value; }
        public string Photo { get => _photo; set => _photo = value; }
    }
}
