using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusAllocationSystem
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string value = Session["bapuserd"] as string;

            if (String.IsNullOrEmpty(value))
            {
                userDto userd = (userDto)Session["bapuserd"];
                username.Text = userd.firstName + " " + userd.lastName;

                String RoleID = Session["BASROLE"].ToString();

                if (RoleID == "BAS00001")
                {

                    admin.Style.Add("display", "block");
                    manageBus.Style.Add("display", "block");
                    manageBusstop.Style.Add("display", "block");
                    manageBusstopAllocation.Style.Add("display", "block");
                    reports.Style.Add("display", "block");
                }
                else if (RoleID == "BAS00002")
                {
                    admin.Style.Add("display", "none");
                    manageBus.Style.Add("display", "none");
                    manageBusstop.Style.Add("display", "none");
                    manageBusstopAllocation.Style.Add("display", "none");
                    reports.Style.Add("display", "block");
                }
                else
                {
                    admin.Style.Add("display", "none");
                    manageBus.Style.Add("display", "none");
                    manageBusstop.Style.Add("display", "none");
                    manageBusstopAllocation.Style.Add("display", "none");
                    reports.Style.Add("display", "none");
                }
            }

            else
            {
                Response.Redirect("login.aspx");
            }
            
        }
    }
}