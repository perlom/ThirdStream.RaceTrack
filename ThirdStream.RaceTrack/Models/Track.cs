using System.Collections.Generic;

namespace ThirdStream.RaceTrack.Models
{
    /// <summary>
    /// Class Track.
    /// </summary>
    public class Track
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the type of the track.
        /// </summary>
        /// <value>The type of the track.</value>
        public string TrackType { get; set; }
        /// <summary>
        /// Gets or sets the vehicles.
        /// </summary>
        /// <value>The vehicles.</value>
        public List<BaseVehicle> Vehicles { get; set; }
    }
}