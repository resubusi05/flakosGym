using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flakosGym.Models
{
    public class UserModel 
    { 
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Obejetivo { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }

    }
}
