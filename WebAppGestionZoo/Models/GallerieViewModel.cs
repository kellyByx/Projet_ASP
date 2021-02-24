using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGestionZoo.Models
{
    public class GallerieViewModel
    {
        private List<PhotoModel> _photoGallerie;

       
        public GallerieViewModel()
        {
            // la gallerie:
            PhotoGallerie = new List<PhotoModel>();
            PhotoGallerie.Add(new PhotoModel() { Normal= "/images/photos/normal//g1.jpg" });
            PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g2.jpg" });
            PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g3.jpg" });
            PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g4.jpg" });
            PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g5.jpg" });
            PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g6.jpg" });
            PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g7.jpg" });
            PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g8.jpg" });
            PhotoGallerie.Add(new PhotoModel() { Normal = "/images/photos/normal//g9.jpg" });

        }

        public List<PhotoModel> PhotoGallerie { get => _photoGallerie; set => _photoGallerie = value; }
    }
}