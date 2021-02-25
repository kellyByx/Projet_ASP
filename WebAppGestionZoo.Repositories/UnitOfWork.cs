using GestionDb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppGestionZoo.Entities;
using WebAppGestionZoo.Models;

namespace WebAppGestionZoo.Repositories
{
    public class UnitOfWork
    {
        IConcreteRepository<SoigneurEntity> _soigneurRepo;
        IConcreteRepository<MessageEntity> _messageRepo;

        public UnitOfWork(string connectionString) 
        {
            _soigneurRepo = new SoigneurRepository(connectionString);
            _messageRepo = new MessageRepository(connectionString);
        } 

        public List<SoigneurModel> GetSoigneur()
        {
            //section des soigneurs
          
            List< SoigneurEntity> soigneurFromDb = _soigneurRepo.Get();

            List<SoigneurModel> soigneurs = new List<SoigneurModel>();
            //Soigneur.Add(new SoigneurModel() { Nom = soigneurFromDb.Nom, Prenom = soigneurFromDb.Prenom, 
            foreach (SoigneurEntity item in soigneurFromDb)
            {

                //mapping:
                SoigneurModel Soigneur = new SoigneurModel();//new List<SoigneurModel>();

                Soigneur.Nom = item.Nom;
                Soigneur.Prenom = item.Prenom;
                Soigneur.Specialisation = item.Specialisation;
                Soigneur.PhotoId = "/images/" + item.Photo;

                soigneurs.Add(Soigneur);
                


            }

            return soigneurs;
        }

        #region Contact

        public bool SaveContact(ContactModel cm)
        {
            MessageEntity me = new MessageEntity();
            me.Nom = cm.Nom;
            me.Email = cm.Email;
            me.Sujet = cm.Sujet;
            me.Information = cm.Message;
            return _messageRepo.Insert(me);
        }
        #endregion

    }
}
