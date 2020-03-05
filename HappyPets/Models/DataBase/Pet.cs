using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyPets.Models.DataBase
{
    public class Pet
    {
        public int Id { get; set; }
        public string  Nombre { get; set; }
        public int PeopleId { get; set; }
        public People People { get; set; }
    }
}
