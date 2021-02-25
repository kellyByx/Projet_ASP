﻿using GestionDb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppGestionZoo.Entities;

namespace WebAppGestionZoo.Repositories
{
    public class MessageRepository : BaseRepository<MessageEntity>, IConcreteRepository<MessageEntity>
    {
        public MessageRepository(string connectionString): base(connectionString)
        {

        }
       

        public List<MessageEntity> Get()
        {
            throw new NotImplementedException();
        }

        public MessageEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(MessageEntity toInsert)
        {
            string requete = @"INSERT INTO Message (Nom, Email, Sujet, Information, DateEnvoie)
                               VALUES (@Nom, @Email, @Sujet, @Message, GETDATE())";
            return base.Insert(toInsert, requete);
        }

        public bool Update(MessageEntity toUpdate)
        {
            throw new NotImplementedException();
        }
        public bool Delete(MessageEntity toDelete)
        {
            throw new NotImplementedException();
        }
    }
}
