using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAPI.Model
{
    public class Usuarios
    {
        
        public int id { get; set; }

        [Required]
        public String UserName { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Email { get; set; }

        public String Telefono { get; set; }
    }
}
//example link
