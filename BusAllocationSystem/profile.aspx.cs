using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusAllocationSystem
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["bapuserd"] != null)
            {
                userDto userd = (userDto)Session["bapuserd"];
                firstName.Text = userd.firstName;
                lastName.Text = userd.lastName;
                emailAddress.Text = userd.emailAddress;
                address.Text = userd.address;
                allocatedBus.Text = userd.busNumber;
                allocatedBusStop.Text = userd.busStop;
            }
        }
    }
}