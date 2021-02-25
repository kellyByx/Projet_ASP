using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using WebAppGestionZoo.Repositories;

namespace WebAppGestionZoo.Models
{
    public class CoulisseViewModel
    {
        private UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

           
        private List<SoigneurModel> _soigneur;

        public CoulisseViewModel()
        {
           Soigneur = ctx.GetSoigneur();
        }                   

        public List<SoigneurModel> Soigneur
        {
            get
            {
                return _soigneur;
            }

            set
            {
                _soigneur = value;
            }
        }


    }

   
}