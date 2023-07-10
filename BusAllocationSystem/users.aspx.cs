using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusAllocationSystem
{
    public partial class users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {

            //String resp = new dbUtil().insertUser(firstName.Text, lastName.Text, emailAddress.Text, address.Text);
            List<userDto> resp = new dbUtil().fetchUsers();

            String tableholder = "<table class='table table-striped table-bordered no-wrap'><tr><th id='tbcolor'>ID</th><th id='tbcolor'>Full Name</th><th id='tbcolor'>Email Address</th><th id='tbcolor'>Address</th><th id='tbcolor'>Date Created</th><th id='tbcolor'>Bus Stop</th><th id='tbcolor'>Bus Number</th><th id='tbcolor'>Date Allocated</th></tr>";
            String appender = "";
            appender += tableholder;
            int counter = 1;
            foreach (userDto userResp in resp)
            {
                String fetcher = "<tr><td id='tbcolor2' > " + counter + "  </td><td id='tbcolor2' > " + userResp.firstName + " " + userResp.lastName + "  </td><td id='tbcolor2' > " + userResp.emailAddress + "  </td><td id='tbcolor2' > " + userResp.address + "  </td><td id='tbcolor2' > " + userResp.DateCreated + "  </td><td id='tbcolor2' > " + userResp.busStop + "  </td><td id='tbcolor2' > " + userResp.busNumber + "  </td><td id='tbcolor2' > " + userResp.DateUpdated + "  </td></tr>";
                appender += fetcher;
                counter++;
            }

            String clostable = " </table> ";
            appender += clostable;

            showtable.InnerHtml = appender;
        }

        }
}