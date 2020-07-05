namespace ThirdStream.RaceTrack.Models
{
    /// <summary>
    /// Class BaseVehicle.
    /// </summary>
    public class BaseVehicle
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance has tow strap.
        /// </summary>
        /// <value><c>true</c> if this instance has tow strap; otherwise, <c>false</c>.</value>
        public bool HasTowStrap { get; set; }
        /// <summary>
        /// Gets or sets the track identifier.
        /// </summary>
        /// <value>The track identifier.</value>
        public int TrackId { get; set; }
    }
}