using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data_Access_Layer.Models
{
    public class Crew
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Pilot Pilot { get; set; }

        [Required]
        public List<Stewardess> Stewardesses { get; set; }
    }
}
