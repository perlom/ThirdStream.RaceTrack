namespace ThirdStream.RaceTrack.Models
{
    /// <summary>
    /// Class Truck.
    /// Implements the <see cref="ThirdStream.RaceTrack.Models.BaseVehicle" />
    /// </summary>
    /// <seealso cref="ThirdStream.RaceTrack.Models.BaseVehicle" />
    public class Truck : BaseVehicle
    {
        /// <summary>
        /// Gets or sets the lift.
        /// </summary>
        /// <value>The lift.</value>
        public int Lift { get; set; }
    }
}