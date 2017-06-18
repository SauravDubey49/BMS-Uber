using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HacathonApp
{
    public partial class MessageWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           Label1.Text = (Server.UrlDecode(Request.QueryString["price"]));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookingDetails.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SeatsLayout.aspx");
        }
    }
}