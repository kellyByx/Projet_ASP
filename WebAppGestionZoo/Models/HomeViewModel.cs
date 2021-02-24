using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGestionZoo.Models
{
    public class HomeViewModel
    {
        private List<PhotoModel> _photoSlider;

        public HomeViewModel()
        {
            //slider home:
            PhotoSlider = new List<PhotoModel>();
            PhotoSlider.Add(new PhotoModel() {Small= "/images/photos/small/m1.jpg" });
            PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m2.jpg" });
            PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m3.jpg" });
            PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m4.jpg" });
            PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m5.jpg" });
            PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m1.jpg" });
            PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m2.jpg" });
            PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m3.jpg" });
            PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m4.jpg" });
            PhotoSlider.Add(new PhotoModel() { Small = "/images/photos/small/m5.jpg" });
          
        }

        public List<PhotoModel> PhotoSlider { get => _photoSlider; set => _photoSlider = value; }
    }
}