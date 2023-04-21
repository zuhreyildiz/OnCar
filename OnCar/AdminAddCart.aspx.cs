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
    public partial class AdminAddCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserAdmin"]) == true)
            {
                SqlCommand commandList = new SqlCommand("Select * from TableCar where CarConfirmation=@pcon", SqlConnectionClass.connection);

                SqlConnectionClass.CheckConnection();

                commandList.Parameters.AddWithValue("@pcon", false);

                SqlDataReader dr = commandList.ExecuteReader();

                DataList1.DataSource = dr;

                DataList1.DataBind();

                dr.Close();
            }
       
            
        }
    }
}