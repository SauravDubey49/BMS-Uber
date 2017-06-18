using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HacathonApp
{
    public partial class HomePage : System.Web.UI.Page
    {

        public String CurrentTheatrename
        {
            get
            {
                return TextBox1.Text;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            DropDownList1.Items.Add("Movie");
            DropDownList1.Items.Add("Theatre");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
        

            if(DropDownList1.Text =="Movie")
            {
                Response.Redirect("ListOfTheatre.aspx?moviename="+ Server.UrlEncode(name));
            }
           else
            {
                Response.Redirect("TheatreSelect.aspx?theatrename=" + Server.UrlEncode(name));
            }
            
          
           


        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}