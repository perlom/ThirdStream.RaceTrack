namespace ThirdStream.RaceTrack.Models
{
    /// <summary>
    /// Class Car.
    /// Implements the <see cref="ThirdStream.RaceTrack.Models.BaseVehicle" />
    /// </summary>
    /// <seealso cref="ThirdStream.RaceTrack.Models.BaseVehicle" />
    public class Car : BaseVehicle
    {
        /// <summary>
        /// Gets or sets the tire wear percentage.
        /// </summary>
        /// <value>The tire wear percentage.</value>
        public int TireWearPercentage { get; set; }
    }
}