using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusAllocationSystem
{
    public partial class manageBusstop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            showInfoMessage.Style.Add("display", "none");
            showErrorMessage.Style.Add("display", "none");

            if (!IsPostBack)
            {
                stateList.Items.Clear();
                stateList.Items.Add("Select State");
                stateList.Items.Add("Abia");
                stateList.Items.Add("Adamawa");
                stateList.Items.Add("Lagos");
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            showInfoMessage.Style.Add("display", "none");
            showErrorMessage.Style.Add("display", "none");

            userDto userd = (userDto)Session["bapuserd"];
            String username = userd.emailAddress;

            String resp = new dbUtil().insertBusstop(busstop.Text, stateList.SelectedValue, username);
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