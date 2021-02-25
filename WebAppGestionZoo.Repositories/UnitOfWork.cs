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

        public SoigneurModel GetSoigneur()
        {
            //section des soigneurs
          
            SoigneurEntity soigneurFromDb = _soigneurRepo.GetOne(1);


            //mapping:
            SoigneurModel Soigneur = new SoigneurModel();//new List<SoigneurModel>();
            //Soigneur.Add(new SoigneurModel() { Nom = soigneurFromDb.Nom, Prenom = soigneurFromDb.Prenom, 
            Soigneur.Nom = soigneurFromDb.Nom;
            Soigneur.Prenom = soigneurFromDb.Prenom;
            Soigneur.Specialisation = soigneurFromDb.Specialisation;
            Soigneur.PhotoId = "/images/t1.jpg" + soigneurFromDb.Photo;

            //Soigneur.Add(new SoigneurModel() {Nom="Grosh", Prenom="Bradley", Specialisation="Les oiseaux", PhotoId="/images/t1.jpg" });
            //Soigneur.Add(new SoigneurModel() { Nom = "Peters", Prenom = "Dayle", Specialisation = "Les reptiles", PhotoId = "/images/t2.jpg" });
            //Soigneur.Add(new SoigneurModel() { Nom = "Pool", Prenom = "Marie", Specialisation = "Les Ongulés", PhotoId = "/images/t3.jpg" });
            //Soigneur.Add(new SoigneurModel() { Nom = "Kyu", Prenom = "Nathan", Specialisation = "Les primates", PhotoId = "/images/t4.jpg" });
            return Soigneur;
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
