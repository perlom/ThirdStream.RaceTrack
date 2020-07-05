using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ThirdStream.RaceTrack.Data;
using ThirdStream.RaceTrack.Mappers;
using ThirdStream.RaceTrack.Models;

namespace ThirdStream.RaceTrack.Services
{
    /// <summary>
    /// Class TrackService.
    /// Implements the <see cref="ThirdStream.RaceTrack.Services.ITrackService" />
    /// Implements the <see cref="System.IDisposable" />
    /// </summary>
    /// <seealso cref="ThirdStream.RaceTrack.Services.ITrackService" />
    /// <seealso cref="System.IDisposable" />
    public class TrackService : ITrackService, IDisposable
    {
        /// <summary>
        /// The is disposed
        /// </summary>
        private bool isDisposed;

        /// <summary>
        /// The database context
        /// </summary>
        private RaceTrackContext DbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackService"/> class.
        /// </summary>
        public TrackService()
        {
            DbContext = new RaceTrackContext();
        }

        /// <summary>
        /// Gets all tracks.
        /// </summary>
        /// <returns>List&lt;Track&gt;.</returns>
        public List<Track> GetAllTracks()
        {
            var result = DbContext.Tracks.Include(x => x.Vehicles).ToList();
             return result.Select(x => x.MapToDto()).ToList();
        }

        /// <summary>
        /// Gets the track by identifier.
        /// </summary>
        /// <param name="trackId">The track identifier.</param>
        /// <returns>Track.</returns>
        public Track GetTrackById(int trackId)
        {
            var result = DbContext.Tracks.Include(x => x.Vehicles).FirstOrDefault(x => x.Id == trackId);
            return result.MapToDto();
        }

        /// <summary>
        /// Adds the car.
        /// </summary>
        /// <param name="newCar">The new car.</param>
        public void AddCar(Car newCar)
        {
            DbContext.Vehicles.Add(newCar.MapToEntity());
            DbContext.SaveChanges();
        }

        /// <summary>
        /// Adds the truck.
        /// </summary>
        /// <param name="newTruck">The new truck.</param>
        public void AddTruck(Truck newTruck)
        {
            DbContext.Vehicles.Add(newTruck.MapToEntity());
            DbContext.SaveChanges();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // Implement IDispose Pattern
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;

            if (disposing)
            {
                // free managed resources
                DbContext?.Dispose();
            }
            isDisposed = true;
        }
    }
}