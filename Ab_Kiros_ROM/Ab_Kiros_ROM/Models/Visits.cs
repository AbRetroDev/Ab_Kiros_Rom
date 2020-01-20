using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ab_Kiros_ROM.Models
{
    public class Visits
    {
        public int visits_ID { get; set; }
        [ForeignKey("Doctor")]        
        public int doctor_ID { get; set; }
        [ForeignKey("Client")]
        public int client_ID { get; set; }
    }
}
