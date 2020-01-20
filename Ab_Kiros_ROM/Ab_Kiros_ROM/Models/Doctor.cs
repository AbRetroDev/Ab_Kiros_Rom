using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ab_Kiros_ROM.Models
{
    public class Doctor : Person
    {
        [Key]
        public int doctor_ID { get; set; }
        Dictionary<String, String> dr_speciality { get; set; }
        public String country_Code { get; set; }
    }
}
