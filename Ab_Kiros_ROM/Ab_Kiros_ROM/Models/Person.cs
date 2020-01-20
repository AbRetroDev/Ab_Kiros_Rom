using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ab_Kiros_ROM.Models
{
    public class Person
    {
        [Key]
        public Guid person_ID { get; set; }
        public string first_name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public string Id_Number { get; set; }
        public string email { get; set; }
        public string contact_No { get; set; }
        public char active { get; set; }
    }
}
