using OnCar.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnCar
{
    public partial class MessageDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(Request.QueryString["id"]);

            SqlCommand commandDelete = new SqlCommand("Delete from TableContact where ContactID=@pid", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandDelete.Parameters.AddWithValue("@pid", selectedID);

            commandDelete.ExecuteNonQuery();

            Response.Redirect("Messages.aspx");
        }
    }
}