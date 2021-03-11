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
        IConcreteRepository<AnimalEntity> _animalRepo;

        public UnitOfWork(string connectionString) 
        {
            _soigneurRepo = new SoigneurRepository(connectionString);
            _messageRepo = new MessageRepository(connectionString);
            _animalRepo = new AnimalRepository(connectionString);
        }


        #region Soigneur
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
        #endregion

        #region Animal
        public List<AnimalModel> GetAnimal()
        {
           

            List<AnimalEntity> animalFromDb = _animalRepo.Get();

            List<AnimalModel> animaux = new List<AnimalModel>();
            
            foreach (AnimalEntity elem in animalFromDb)
            {
                //mapping:
                AnimalModel Animal = new AnimalModel();

                Animal.Nom = elem.Nom;
                Animal.Sexe = elem.Sexe;
                Animal.TypeAlimentaire = elem.TypeAlimentaire;
                Animal.Famille = elem.Famille;
                Animal.Classe = elem.Class;
                Animal.Espece = elem.Espece;

                //section Animaux
                // Animal = new List<AnimalModel>();
                //Animal.Add(new AnimalModel() {  Classe = "Oiseaux", Espece = "Aras", Famille = "Psittacidés"});
                // Animal[0].PhotoAnimal.Haute = "/images/photos/haute/s1.jpg";
                //Animal.Add(new AnimalModel() {  Classe = "Primates", Espece = "XXX", Famille = "YYYY" });
                // Animal[1].PhotoAnimal.Haute = "/images/photos/haute/s2.jpg";
                // Animal.Add(new AnimalModel() {  Classe = "Mammifère", Espece = "XXX", Famille = "YYYY" });
                // Animal[2].PhotoAnimal.Haute = "/images/photos/haute/s3.jpg";
                // Animal.Add(new AnimalModel() {  Classe = "Mammifère", Espece = "XXX", Famille = "YYYY" });
                // Animal[3].PhotoAnimal.Haute = "/images/photos/haute/s4.jpg";
                // Animal.Add(new AnimalModel() { Classe = "Oiseaux", Espece = "Aras", Famille = "Psittacidés" });
                // Animal[4].PhotoAnimal.Haute = "/images/photos/haute/s1.jpg";
                // Animal.Add(new AnimalModel() { Classe = "Primates", Espece = "XXX", Famille = "YYYY" });
                // Animal[5].PhotoAnimal.Haute = "/images/photos/haute/s2.jpg";
                // Animal.Add(new AnimalModel() { Classe = "Mammifère", Espece = "XXX", Famille = "YYYY" });
                // Animal[6].PhotoAnimal.Haute = "/images/photos/haute/s3.jpg";
                // Animal.Add(new AnimalModel() { Classe = "Mammifère", Espece = "XXX", Famille = "YYYY" });
                // Animal[7].PhotoAnimal.Haute = "/images/photos/haute/s4.jpg";

                animaux.Add(Animal);
            }

            return animaux;
        }

        // debut ajouter animal :  
        public bool AddAnimal(AnimalModel am)
        {
            AnimalEntity ae = new AnimalEntity();
            ae.Nom = am.Nom;
            ae.Sexe = am.Sexe;
            ae.TypeAlimentaire = am.TypeAlimentaire;
            ae.Famille = am.Famille;
            ae.Class = am.Classe;
            ae.Espece = am.Espece;
            return _animalRepo.Insert(ae);
        }
    #endregion
    #region Caractéristique
    //// la gallerie:
    //PhotoGallerie = new List<PhotoModel>();
    //PhotoGallerie.Add(new PhotoModel() { Normal= "/images/photos/normal//g1.jpg" });
    //PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g2.jpg" });
    //PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g3.jpg" });
    //PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g4.jpg" });
    //PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g5.jpg" });
    //PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g6.jpg" });
    //PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g7.jpg" });
    //PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g8.jpg" });
    //PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g9.jpg" });

    //slider home:
    //PhotoSlider = new List<PhotoModel>();
    //PhotoSlider.Add(new PhotoModel() {Small= "/images/photos/small/m1.jpg" });
    //PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m2.jpg" });
    //PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m3.jpg" });
    //PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m4.jpg" });
    //PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m5.jpg" });
    //PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m1.jpg" });
    //PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m2.jpg" });
    //PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m3.jpg" });
    //PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m4.jpg" });
    //PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m5.jpg" });


    #endregion

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




//public HeaderMovie GetHeaderMovie()
//{
//    //Récupération de mon entity
//    MovieEntity movieFromDB = _movieRepo.GetOne(330457);
//    List<GenreEntity> genresFromDb = ((GenreRepository)_genreRepo).GetFromMovie(330457);
//    string genres = "";
   
//    genres = genres.Substring(0, genres.Length - 1);
//    List<CrewEntity> DirectorsFromDb = ((CrewRepository)_crewRepo).GetDirectors(330457);
//    string directors = "";
   
//    directors = directors.Substring(0, directors.Length - 1);

//    //Mapping de l'entity vers le model
//    HeaderMovie movieForController = new HeaderMovie();
//    movieForController.Title = movieFromDB.Title; //"Frozen II";
 
//    movieForController.Directors = directors;

//    movieForController.Genres = genres;
//    movieForController.Release = movieFromDB.ReleaseDate.Value; //new DateTime(2019, 11, 22);
//    movieForController.Description = movieFromDB.Summary; 
//    movieForController.VideoLink = movieFromDB.Trailer; //"#";
//    movieForController.BigPicture = "https://www.themoviedb.org/t/p/original" + movieFromDB.Picture; //"FrozenII.jpg";

//    return movieForController;
//}