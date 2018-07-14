using System.Collections.Generic;

namespace Data_Access_Layer.Models
{
    public class Crew
    {
        
        public int Id { get; set; }

        public Pilot Pilot { get; set; }

        public List<Stewardess> Stewardesses { get; set; }
    }
}
