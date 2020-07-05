using System.Web.Mvc;
using ThirdStream.RaceTrack.Services;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace ThirdStream.RaceTrack
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<ITrackService, TrackService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}