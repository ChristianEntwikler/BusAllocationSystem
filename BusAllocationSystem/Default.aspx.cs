using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusAllocationSystem
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dataCounterDto counterDto = new dbUtil().fetchCounts();
            usersCount.Text = counterDto.countUsers;
            busesCount.Text = counterDto.countBuses;
            busStopsCount.Text = counterDto.countBusStops;
            availableBusesCount.Text = counterDto.countAvailableBuses;
            occupiedBusesCount.Text = counterDto.countOccupiedBuses;
            driversCount.Text = counterDto.countDrivers;
        }
    }
}