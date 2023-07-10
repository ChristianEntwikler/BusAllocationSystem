using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusAllocationSystem
{
    public partial class busStops : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            List<busStopDto> resp = new dbUtil().fetchBusStop();

            String tableholder = "<table class='table table-striped table-bordered no-wrap'><tr><th id='tbcolor'>ID</th><th id='tbcolor'>Bus Stop</th><th id='tbcolor'>State</th><th id='tbcolor'>Maker ID</th><th id='tbcolor'>Date Created</th></tr>";
            String appender = "";
            appender += tableholder;
            int counter = 1;
            foreach (busStopDto Response in resp)
            {
                String fetcher = "<tr><td id='tbcolor2' > " + counter + "  </td><td id='tbcolor2' > " + Response.busStop + "  </td><td id='tbcolor2' > " + Response.stateName + "  </td><td id='tbcolor2' > " + Response.makerId + "  </td><td id='tbcolor2' > " + Response.makeStamp + "  </td></tr>";
                appender += fetcher;
                counter++;
            }

            String clostable = "   </table> ";
            appender += clostable;

            showtable.InnerHtml = appender;
        }

    }
}