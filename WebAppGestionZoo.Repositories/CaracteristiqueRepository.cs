using GestionDb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppGestionZoo.Entities;

namespace WebAppGestionZoo.Repositories
{
    public class CaracteristiqueRepository : BaseRepository<CaracteristiqueEntity>, IConcreteRepository<CaracteristiqueEntity>
    {
        public CaracteristiqueRepository(string connectionString) : base(connectionString)
        {

        }
        public bool Delete(CaracteristiqueEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<CaracteristiqueEntity> Get()
        {
            string requete = "Select * from Caractéristique";
            return base.Get(requete);
        }

        public CaracteristiqueEntity GetOne(int PK)
        {
            string requete = "Select * from Caractéristique where IdCaractéristique = @id";
            return base.GetOne(PK, requete);
        }

        public bool Insert(CaracteristiqueEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(CaracteristiqueEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
