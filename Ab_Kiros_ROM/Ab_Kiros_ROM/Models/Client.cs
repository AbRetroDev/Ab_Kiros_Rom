using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ab_Kiros_ROM.Models
{
    public class Client:Person
    {
        
        public int client_ID { get; set; }
        [ForeignKey("Illness")]
        public int illness_ID { get; set; }
    }
}
