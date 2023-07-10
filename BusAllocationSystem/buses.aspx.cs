using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusAllocationSystem
{
    public partial class buses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {

            //String resp = new dbUtil().insertUser(firstName.Text, lastName.Text, emailAddress.Text, address.Text);
            List<busDto> resp = new dbUtil().fetchBuses();

            String tableholder = "<table class='table table-striped table-bordered no-wrap'><tr><th id='tbcolor'>ID</th><th id='tbcolor'>Tag Id</th><th id='tbcolor'>Reg No</th><th id='tbcolor'>Total Seat</th><th id='tbcolor'>Occupied Seat</th><th id='tbcolor'>Maker ID</th><th id='tbcolor'>Date Created</th></tr>";
            String appender = "";
            appender += tableholder;
            int counter = 1;
            foreach (busDto Response in resp)
            {
                String fetcher = "<tr><td id='tbcolor2' > " + counter + "  </td><td id='tbcolor2' > " + Response.tagId + "  </td><td id='tbcolor2' > " + Response.regNo + "  </td><td id='tbcolor2' > " + Response.totalSeat + "  </td><td id='tbcolor2' > " + Response.takenSeat + "  </td><td id='tbcolor2' > " + Response.makerId + "  </td><td id='tbcolor2' > " + Response.makeStamp + "  </td></tr>";
                appender += fetcher;
                counter++;
            }

            String clostable = "   </table> ";
            appender += clostable;

            showtable.InnerHtml = appender;
        }

    }
}