using System.Collections.Generic;
using System.Data.Entity;
using ThirdStream.RaceTrack.Data.Entities;

namespace ThirdStream.RaceTrack.Data
{
    public class RaceTrackInitializer : DropCreateDatabaseIfModelChanges<RaceTrackContext>
    {
        protected override void Seed(RaceTrackContext context)
        {
            var tracks = new List<Track>
            {
            new Track{Name ="Small Cars Track", Type = "Car"},
            new Track{Name ="Big Trucks Track", Type = "Truck"},
            };

            tracks.ForEach(s => context.Tracks.Add(s));
            context.SaveChanges();
            var vehicles = new List<Vehicle>
            {
            new Vehicle{HasTowStrap = true, TireWearPercentage = 77, TrackId = 1, Type = "Car"},
            new Vehicle{HasTowStrap = true, TireWearPercentage = 44, TrackId = 1, Type = "Car"},
            new Vehicle{HasTowStrap = true, TireWearPercentage = 10, TrackId = 1, Type = "Car"},

            new Vehicle{HasTowStrap = true, Lift = 1, TrackId = 2, Type = "Truck"},
            new Vehicle{HasTowStrap = true, Lift = 3, TrackId = 2, Type = "Truck"},
            new Vehicle{HasTowStrap = true, Lift = 4, TrackId = 2, Type = "Truck"},
            };
            vehicles.ForEach(s => context.Vehicles.Add(s));
            context.SaveChanges();
        }
    }
}