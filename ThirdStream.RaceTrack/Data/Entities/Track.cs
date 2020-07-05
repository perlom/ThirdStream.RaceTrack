using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThirdStream.RaceTrack.Data.Entities
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}