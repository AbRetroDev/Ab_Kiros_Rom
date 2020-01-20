using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ab_Kiros_ROM.Models
{
    public class Illness
    {
        [Key]
        public int illness_ID { get; set; }
        public String illness_Name { get; set; }
    }
}
