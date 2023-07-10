using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusAllocationSystem
{
    public partial class manageBusstopAllocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showInfoMessage.Style.Add("display", "none");
            showErrorMessage.Style.Add("display", "none");
            if (!IsPostBack)
            {
                loadbustStops();
                loadbuses();
            }
        }

        public void loadbustStops()
        {
            busstopList.Items.Clear();
            busstopList.Items.Add("Select Bus Stop");
            List<busStopDto> busStops = new dbUtil().fetchBusStop();

            foreach (busStopDto busstop in busStops)
            {
                busstopList.Items.Add(busstop.busStop);
            }
        }

        public void loadbuses()
        {
            busList.Items.Clear();
            busList.Items.Add("Select Bus");
            List<busDto> buses = new dbUtil().fetchBuses();

            foreach (busDto bus in buses)
            {
                busList.Items.Add(bus.regNo);
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            showInfoMessage.Style.Add("display", "none");
            showErrorMessage.Style.Add("display", "none");

            userDto userd = (userDto)Session["bapuserd"];
            String username = userd.emailAddress;

            String resp = new dbUtil().insertBusstopAllocation(busList.SelectedValue, busstopList.SelectedValue, username);
            if (resp.Equals("SUCCESSFUL"))
            {
                this.showInfoMessage.InnerHtml = resp;
                showInfoMessage.Style.Add("display", "block");
                showErrorMessage.Style.Add("display", "none");
            }
            else
            {
                this.showErrorMessage.InnerHtml = resp;
                showInfoMessage.Style.Add("display", "none");
                showErrorMessage.Style.Add("display", "block");
            }
        }

    }
}