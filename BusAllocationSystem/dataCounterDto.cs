using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusAllocationSystem
{
    public class dataCounterDto
    {
        public String countUsers { get; set; }
        public String countBuses { get; set; }
        public String countBusStops { get; set; }
        public String countAvailableBuses { get; set; }
        public String countOccupiedBuses { get; set; }
        public String countDrivers { get; set; }

    }
}