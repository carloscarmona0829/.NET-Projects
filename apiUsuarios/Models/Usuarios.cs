using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiUsuarios.Models
{
    public class Usuarios
    {
        //la palabra key representa la primary key
        [Key]
        public int id { get; set; }
        public string cedula { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
    }
}
