using System.Collections.Generic;
using ThirdStream.RaceTrack.Models;

namespace ThirdStream.RaceTrack.Services
{
    /// <summary>
    /// Interface ITrackService
    /// </summary>
    public interface ITrackService
    {
        /// <summary>
        /// Gets all tracks.
        /// </summary>
        /// <returns>List&lt;Track&gt;.</returns>
        List<Track> GetAllTracks();
        /// <summary>
        /// Gets the track by identifier.
        /// </summary>
        /// <param name="trackId">The track identifier.</param>
        /// <returns>Track.</returns>
        Track GetTrackById(int trackId);
        /// <summary>
        /// Adds the car.
        /// </summary>
        /// <param name="newCar">The new car.</param>
        void AddCar(Car newCar);
        /// <summary>
        /// Adds the truck.
        /// </summary>
        /// <param name="newTruck">The new truck.</param>
        void AddTruck(Truck newTruck);
    }
}


