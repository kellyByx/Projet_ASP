﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDb.Repositories;
using WebAppGestionZoo.Entities;

namespace WebAppGestionZoo.Repositories
{
    public class SoigneurRepository : BaseRepository<SoigneurEntity>, IConcreteRepository<SoigneurEntity>
    {
        public SoigneurRepository(string connectionString): base(connectionString)
        {

        }
        public bool Delete(SoigneurEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<SoigneurEntity> Get()
        {
            string requete = "Select * from Soigneur";
            return base.Get(requete);
        }

        public SoigneurEntity GetOne(int PK)
        {
            string requete = "Select * from Soigneur where IdSoigneur = @id";
            return base.GetOne(PK, requete);
        }

        public bool Insert(SoigneurEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(SoigneurEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}