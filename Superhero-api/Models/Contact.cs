using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Superhero_api.Models
{
    public class Contact
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string Place { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;


    }
}
