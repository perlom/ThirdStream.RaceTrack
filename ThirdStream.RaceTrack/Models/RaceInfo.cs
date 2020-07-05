using System.Collections.Generic;

namespace ThirdStream.RaceTrack.Models
{
    /// <summary>
    /// Class RaceInfo.
    /// </summary>
    public class RaceInfo
    {
        /// <summary>
        /// Gets or sets the selected track.
        /// </summary>
        /// <value>The selected track.</value>
        public Track SelectedTrack { get; set; }
        /// <summary>
        /// Gets or sets the selected track identifier.
        /// </summary>
        /// <value>The selected track identifier.</value>
        public int  SelectedTrackId { get; set; }
        /// <summary>
        /// Gets or sets the tracks.
        /// </summary>
        /// <value>The tracks.</value>
        public List<Track> Tracks { get; set; }
        /// <summary>
        /// Creates new car.
        /// </summary>
        /// <value>The new car.</value>
        public Car NewCar { get; set; }
        /// <summary>
        /// Creates new truck.
        /// </summary>
        /// <value>The new truck.</value>
        public Truck NewTruck { get; set; }
    }
}