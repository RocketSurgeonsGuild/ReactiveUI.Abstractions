using System;
using CoreLocation;
using Foundation;

namespace Rocket.Surgery.Airframe.Apple
{
    /// <summary>
    /// Interface representing a <see cref="CLLocationManager"/>.
    /// </summary>
    public interface ILocationManager
    {
        /// <summary>
        /// Event handler for authorization changes events.
        /// </summary>
        event EventHandler<CLAuthorizationChangedEventArgs> AuthorizationChanged;

        /// <summary>
        /// Event handler for deferred updates finished events.
        /// </summary>
        event EventHandler<NSErrorEventArgs> DeferredUpdatesFinished;

        /// <summary>
        /// Event handler for did determine state events.
        /// </summary>
        event EventHandler<CLRegionStateDeterminedEventArgs> DidDetermineState;

        /// <summary>
        /// Event handler for did fail ranging beacons events.
        /// </summary>
        event EventHandler<CLRegionBeaconsConstraintFailedEventArgs> DidFailRangingBeacons;

        /// <summary>
        /// Event handler for did range beacon events.
        /// </summary>
        event EventHandler<CLRegionBeaconsRangedEventArgs> DidRangeBeacons;

        /// <summary>
        /// Event handler for did range beacons satisfy constraint events.
        /// </summary>
        event EventHandler<CLRegionBeaconsConstraintRangedEventArgs> DidRangeBeaconsSatisfyingConstraint;

        /// <summary>
        /// Event handler for did start monitor for region events.
        /// </summary>
        event EventHandler<CLRegionEventArgs> DidStartMonitoringForRegion;

        /// <summary>
        /// Event handler for did visit events.
        /// </summary>
        event EventHandler<CLVisitedEventArgs> DidVisit;

        /// <summary>
        /// Event handler for failed events.
        /// </summary>
        event EventHandler<NSErrorEventArgs> Failed;

        /// <summary>
        /// Event handler for location updates paused events.
        /// </summary>
        event EventHandler LocationUpdatesPaused;

        /// <summary>
        /// Event handler for location updates resumed events.
        /// </summary>
        event EventHandler LocationUpdatesResumed;

        /// <summary>
        /// Event handler for locations updated events.
        /// </summary>
        event EventHandler<CLLocationsUpdatedEventArgs> LocationsUpdated;

        /// <summary>
        /// Event handler for region error events.
        /// </summary>
        event EventHandler<CLRegionErrorEventArgs> MonitoringFailed;

        /// <summary>
        /// Event handler for region beacons failed events.
        /// </summary>
        event EventHandler<CLRegionBeaconsFailedEventArgs> RangingBeaconsDidFailForRegion;

        /// <summary>
        /// Event handler for region entered.
        /// </summary>
        event EventHandler<CLRegionEventArgs> RegionEntered;

        /// <summary>
        /// Event handler for
        /// </summary>
        event EventHandler<CLRegionEventArgs> RegionLeft;

        /// <summary>
        /// Event handler for
        /// </summary>
        event EventHandler<CLHeadingUpdatedEventArgs> UpdatedHeading;

        /// <summary>
        /// Event handler for
        /// </summary>
        event EventHandler<CLLocationUpdatedEventArgs> UpdatedLocation;
    }
}