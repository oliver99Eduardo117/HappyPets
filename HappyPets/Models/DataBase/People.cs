using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyPets.Models.DataBase
{
    public class People
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
