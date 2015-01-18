﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrazzApps.Geolocator.Abstractions
{
    public class Position
    {
        public Position() { }

        // Summary:
        //     Gets or sets the potential position error radius in meters.
        public double? Accuracy { get; set; }
        //
        // Summary:
        //     Gets or sets the altitude in meters relative to sea level.
        public double? Altitude { get; set; }
        //
        // Summary:
        //     Gets or sets the potential altitude error range in meters.
        //
        // Remarks:
        //     Not supported on Android, will always read 0.
        public double? AltitudeAccuracy { get; set; }
        //
        // Summary:
        //     Gets or sets the heading in degrees relative to true North.
        public double? Heading { get; set; }
        //
        // Summary:
        //     Gets or sets the latitude.
        public double Latitude { get; set; }
        //
        // Summary:
        //     Gets or sets the longitude.
        public double Longitude { get; set; }
        //
        // Summary:
        //     Gets or sets the speed in meters per second.
        public double? Speed { get; set; }
        //
        // Summary:
        //     Gets or sets the time of the reading.
        public DateTimeOffset Timestamp { get; set; }
    }
}
