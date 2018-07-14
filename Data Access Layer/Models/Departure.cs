using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class Departure
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Flight Flight { get; set; }

        [Required]
        public DateTime TimeOfDeparture { get; set; }

        [Required]
        public Crew Crew { get; set; }

        [Required]
        public Plane Plane { get; set; }
    }
}
