using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusAllocationSystem
{
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["bapuserd"] = null;
            Session["BASROLE"] = null;
            Session.RemoveAll();        
        }

        protected void login_Click(object sender, EventArgs e)
        {
            errorMsg.Text = "";
            try
            {
                userDto userd = new dbUtil().fetchUser(email.Text);
                if (userd.pwd.Equals(password.Text))
                {
                    String userRole = new dbUtil().fetchUserRole(email.Text);
                    Session["bapuserd"] = userd;
                    if (userRole != null && !userRole.Equals(""))
                    {
                        Session["BASROLE"] = userRole;
                    }
                    else
                    {
                        Session["BASROLE"] = "";
                    }
                    Response.Redirect("default.aspx");
                }
                else
                {
                    errorMsg.Text = "Invalid username and/or password";
                }
            }
            catch(Exception ex)
            {
                new Util().WriteToFile("ERROR: " + ex.Message + " " + DateTime.Now);
                new Util().WriteToFile("ERROR: " + ex.StackTrace + " " + DateTime.Now);
            }
        }
    }
}