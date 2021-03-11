using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using WebAppGestionZoo.Repositories;

namespace WebAppGestionZoo.Models
{
    public class AnimauxViewModel
    {
        private UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        private List<AnimalModel> _animal;
        

        public AnimauxViewModel()
        {
            Animal = ctx.GetAnimal();
        

        }


        public List<AnimalModel> Animal 
        { get => _animal; set => _animal = value; }
   
    }

   
}