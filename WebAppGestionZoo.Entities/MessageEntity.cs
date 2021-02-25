using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppGestionZoo.Entities
{
     public class MessageEntity
    {
        int _idMessage;
        string _nom, _email, _sujet, _information;

public string Nom { get => _nom; set => _nom = value; }
        public string Email { get => _email; set => _email = value; }
        public string Sujet { get => _sujet; set => _sujet = value; }
        public string Information { get => _information; set => _information = value; }
    }
}
