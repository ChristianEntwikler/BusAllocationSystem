using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusAllocationSystem
{
    public partial class busAllocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showInfoMessage.Style.Add("display", "none");
            showErrorMessage.Style.Add("display", "none");

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

                if (!IsPostBack)
                {
                    loadbustStops();
            }
        }

        public void loadbustStops()
        {
            busstopList.Items.Clear();
            busstopList.Items.Add("Select Bus Stop");
            List<busStopDto> busStops = new dbUtil().fetchBusStop();

            foreach(busStopDto busstop in busStops)
            {
                busstopList.Items.Add(busstop.busStop);
            }
        }

        public void loadbuses(String selectedBusStop)
        {
            busList.Items.Clear();
            busList.Items.Add("Select Bus");
            List<busDto> busStops = new dbUtil().fetchBusesByBusStop(selectedBusStop);

            foreach(busDto busstop in busStops)
            {
                busList.Items.Add(busstop.regNo);
            }
        }

        protected void busstopList_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadbuses(busstopList.SelectedValue);

        }

            protected void submit_Click(object sender, EventArgs e)
        {
            showInfoMessage.Style.Add("display", "none");
            showErrorMessage.Style.Add("display", "none");

            userDto userd = (userDto)Session["bapuserd"];
            String username = userd.emailAddress;

            String resp = new dbUtil().updateUserBus(busList.SelectedValue, busstopList.SelectedValue, username);
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