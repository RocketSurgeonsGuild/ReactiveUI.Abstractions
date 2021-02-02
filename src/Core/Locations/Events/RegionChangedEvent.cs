using Rocket.Surgery.Airframe.Geofence;

namespace Rocket.Surgery.Airframe.Locations.Events
{
    public class RegionChangedEvent
    {
        public RegionChangedEvent(GeoRegion region, RegionState? state = null)
        {
            Region = region;
            State = state;
        }

        public GeoRegion Region { get; }

        public RegionState? State { get; }
    }
}