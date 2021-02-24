using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGestionZoo.Models
{
    public class PhotoModel
    {
        #region Fields 
        private string _small,_haute,_normal;
        #endregion

        #region Properties


        public string Small
        {
            get
            {
                return _small;
            }

            set
            {
                _small = value;
            }
        }

        public string Haute
        {
            get
            {
                return _haute;
            }

            set
            {
                _haute = value;
            }
        }

        public string Normal
        {
            get
            {
                return _normal;
            }

            set
            {
                _normal = value;
            }
        }
        #endregion
    }
}