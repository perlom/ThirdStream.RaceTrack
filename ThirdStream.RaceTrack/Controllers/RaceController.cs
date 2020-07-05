using System.Web.Mvc;
using ThirdStream.RaceTrack.Models;
using ThirdStream.RaceTrack.Services;

namespace ThirdStream.RaceTrack.Controllers
{
    /// <summary>
    /// Class RaceController.
    /// Implements the <see cref="System.Web.Mvc.Controller" />
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class RaceController : Controller
    {
        /// <summary>
        /// The track service
        /// </summary>
        private readonly ITrackService trackService;

        /// <summary>
        /// Initializes a new instance of the <see cref="RaceController"/> class.
        /// </summary>
        /// <param name="trackService">The track service.</param>
        public RaceController(ITrackService trackService)
        {
            this.trackService = trackService;
        }
        
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Index()
        {
            var tracks = trackService.GetAllTracks();
            var raceInfo = new RaceInfo
            {
                Tracks = tracks,
                SelectedTrack = tracks[0],
                SelectedTrackId = tracks[0].Id,
            };
            return View("Race", raceInfo);
        }

        /// <summary>
        /// Called when [track change].
        /// </summary>
        /// <param name="SelectedTrackId">The selected track identifier.</param>
        /// <returns>ActionResult.</returns>
        [HttpPost]
        public ActionResult OnTrackChange(int SelectedTrackId)
        {
            return PartialView("_TrackDetails", trackService.GetTrackById(SelectedTrackId));
        }

        /// <summary>Called when [add car].</summary>
        /// <param name="trackId">The track identifier.</param>
        /// <param name="hasTowStrap">if set to <c>true</c> [has tow strap].</param>
        /// <param name="tireWear">The tire wear.</param>
        /// <returns>ActionResult.</returns>
        [HttpPost]
        public ActionResult OnAddCar(int trackId, bool hasTowStrap, int tireWear)
        {
            if (hasTowStrap && tireWear < 85)
            {
                trackService.AddCar(new Car
                {
                    HasTowStrap = hasTowStrap,
                    TireWearPercentage = tireWear,
                    TrackId = trackId
                });

                return Json(new { ReturnStatus = "success"}, JsonRequestBehavior.AllowGet);
            }
            return Json(new { ReturnStatus = "error", ReturnData = "Car did not pass the inspection!" }, 
                JsonRequestBehavior.AllowGet);
        }

        /// <summary>Called when [add truck].</summary>
        /// <param name="trackId">The track identifier.</param>
        /// <param name="hasTowStrap">if set to <c>true</c> [has tow strap].</param>
        /// <param name="lift">The lift.</param>
        /// <returns>ActionResult.</returns>
        [HttpPost]
        public ActionResult OnAddTruck(int trackId, bool hasTowStrap, int lift)
        {
            if (hasTowStrap && lift < 5)
            {
                trackService.AddTruck(new Truck
                {
                    HasTowStrap = hasTowStrap,
                    Lift = lift,
                    TrackId = trackId
                });

                return Json(true, JsonRequestBehavior.AllowGet);
            }
            return Json(new { ReturnStatus = "error", ReturnData = "Truck did not pass the inspection!" },
                JsonRequestBehavior.AllowGet);
        }
    }
}