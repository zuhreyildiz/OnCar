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
    public partial class ContactPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into TableContact (ContactMessage,ContactMail,ContactName) values (@pmsg,@pmail,@pname)", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandAdd.Parameters.AddWithValue("@pmsg", tboxMessage.Text);
            commandAdd.Parameters.AddWithValue("@pmail", tboxMail.Text);
            commandAdd.Parameters.AddWithValue("@pname", tboxName.Text);

            commandAdd.ExecuteNonQuery();
        }

        protected void BntSend_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into TableContact (ContactMessage,ContactMail,ContactName) values (@pmsg,@pmail,@pname)", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandAdd.Parameters.AddWithValue("@pmsg", tboxMessage.Text);
            commandAdd.Parameters.AddWithValue("@pmail", tboxMail.Text);
            commandAdd.Parameters.AddWithValue("@pname", tboxName.Text);

            commandAdd.ExecuteNonQuery();
        }
    }
}