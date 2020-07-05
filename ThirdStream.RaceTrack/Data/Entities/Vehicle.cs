using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThirdStream.RaceTrack.Data.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public bool HasTowStrap { get; set; }
        public int TireWearPercentage { get; set; }
        public int Lift { get; set; }
        public string Type { get; set; }
        public int TrackId { get; set; }

        public virtual Track Track { get; set; }
    }
}