using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusAllocationSystem
{
    public partial class manageBus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            showInfoMessage.Style.Add("display", "none");
            showErrorMessage.Style.Add("display", "none");

            if (!IsPostBack)
            {
                seatList.Items.Clear();
                seatList.Items.Add("Select Number of Seats");
                seatList.Items.Add("3");
                seatList.Items.Add("5");
                seatList.Items.Add("6");
                seatList.Items.Add("7");
                seatList.Items.Add("8");
                seatList.Items.Add("10");
                seatList.Items.Add("15");
                seatList.Items.Add("16");
                seatList.Items.Add("18");
                seatList.Items.Add("20");
                seatList.Items.Add("22");
                seatList.Items.Add("30");
                seatList.Items.Add("50");
                seatList.Items.Add("100");
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            showInfoMessage.Style.Add("display", "none");
            showErrorMessage.Style.Add("display", "none");

            userDto userd = (userDto)Session["bapuserd"];
            String username = userd.emailAddress;

            String resp = new dbUtil().insertBus(tagid.Text, regno.Text, seatList.SelectedValue, username);
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