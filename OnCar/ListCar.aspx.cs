using OnCar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnCar.Classes;
using System.Data.SqlClient;


namespace OnCar
{
    public partial class ListCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandList = new SqlCommand("Select CarID,CarModel,CarBrandID,CarFuelType,CarDescription,CarContact,CarSeller,CarPhoto,CarPrice,CarConfirmation,BrandID,BrandName from TableCar_1 inner join brand on TableCar.CarBrandID=TableBrand.BrandID where CarConfirmation=@pcon", SqlConnectionClass.connection);

            commandList.Parameters.AddWithValue("@pcon", true);

            SqlDataReader dr = commandList.ExecuteReader();

            DataList1.DataSource = dr;

            DataList1.DataBind();

            dr.Close();



        }
    }
}