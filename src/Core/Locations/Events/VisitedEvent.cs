using System;

namespace Rocket.Surgery.Airframe.Locations.Events
{
    /// <summary>
    /// Notification of a region being visited.
    /// </summary>
    public class VisitedEvent
    {
        public VisitedEvent(CLVisit visit)
        {
            GeoLocation = visit.Location;
            ArrivalDate = visit.ArrivalDate;
            DepartureDate = visit.DepartureDate;
            HorizontalAccuracy = visit.HorizontalAccuracy;
        }

        public DateTimeOffset ArrivalDate { get; }
        public GeoLocation GeoLocation { get; }
        public DateTimeOffset DepartureDate { get; }
        public double HorizontalAccuracy { get; }
    }
}