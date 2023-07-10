using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusAllocationSystem
{
    public partial class userRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showInfoMessage.Style.Add("display", "none");
            showErrorMessage.Style.Add("display", "none");

            if (!IsPostBack)
            {

            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            showInfoMessage.Style.Add("display", "none");
            showErrorMessage.Style.Add("display", "none");
            if (pwd.Text.Equals(cpwd.Text))
            {
                String resp = new dbUtil().insertUser(firstName.Text, lastName.Text, emailAddress.Text, address.Text, pwd.Text);
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
            else
            {
                this.showErrorMessage.InnerHtml = "Password Mismatch";
                showInfoMessage.Style.Add("display", "none");
                showErrorMessage.Style.Add("display", "block");
            }
        }
    }
}