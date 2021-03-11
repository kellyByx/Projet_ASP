using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppGestionZoo.Entities
{
    public class AnimalEntity
    {
        private int _idAnimal, _idEnclos;
        private string _nom, _sexe, _typeAlimentaire, _famille, _class, _espece;

        public int IdAnimal { get => _idAnimal; set => _idAnimal = value; }
        public int IdEnclos { get => _idEnclos; set => _idEnclos = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Sexe { get => _sexe; set => _sexe = value; }
        public string TypeAlimentaire { get => _typeAlimentaire; set => _typeAlimentaire = value; }
        public string Famille { get => _famille; set => _famille = value; }
        public string Class { get => _class; set => _class = value; }
        public string Espece { get => _espece; set => _espece = value; }
    }
}
