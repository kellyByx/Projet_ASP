using GestionDb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppGestionZoo.Entities;

namespace WebAppGestionZoo.Repositories
{
    public class AnimalRepository : BaseRepository<AnimalEntity>, IConcreteRepository<AnimalEntity>
    {
        public AnimalRepository(string connectionString) : base(connectionString)
        {

        }
        public bool Delete(AnimalEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<AnimalEntity> Get()
        {
            string requete = "Select * from Animal";
            return base.Get(requete);
        }

        public AnimalEntity GetOne(int PK)
        {
            string requete = "Select * from Animal where IdAnimal = @id"; 
            return base.GetOne(PK, requete);
        }

        public bool Insert(AnimalEntity toInsert)
        {
            string requete = @"INSERT INTO Animal (Nom, Sexe, TypeAlimentaire, Famille, Classe, Espece)
                               VALUES (@Nom, @Sexe, @TypeAlimentaire, @Famille, @Class, @Espece";
            return base.Insert(toInsert, requete);

        }

        public bool Update(AnimalEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
