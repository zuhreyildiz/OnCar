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
    public partial class AddCars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserOnline"]) == true)
            {
                if (Page.IsPostBack == false)
                {

                    SqlCommand commandListBrands = new SqlCommand("Select * from brand", SqlConnectionClass.connection);

                    SqlConnectionClass.CheckConnection();

                    SqlDataReader dr = commandListBrands.ExecuteReader();

                    DropDownMarka.DataTextField = "brandName";

                    DropDownMarka.DataValueField = "brandID";

                    DropDownMarka.DataSource = dr;

                    DropDownMarka.DataBind();

                    dr.Close();


                }

            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into TableCar_1 (CarModel,CarBrandID,CarFuelType,CarDescription,CarContact,CarSeller,CarPhoto,CarPrice) values (@pmodel,@pbrand,@pfuel,@pdes,@pcontact,@pseller,@pphoto,@pprice)", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandAdd.Parameters.AddWithValue("@pmodel", tboxModel.Text);
            commandAdd.Parameters.AddWithValue("@pbrand", Convert.ToInt32(DropDownMarka.SelectedValue));
            commandAdd.Parameters.AddWithValue("@pfuel", tboxFuel.Text);
            commandAdd.Parameters.AddWithValue("@pdes", tboxDescription.Text);
            commandAdd.Parameters.AddWithValue("@pcontact", tboxContact.Text);
            commandAdd.Parameters.AddWithValue("@pseller", tboxSeller.Text);
            commandAdd.Parameters.AddWithValue("@pphoto", tboxPhoto.Text);
            commandAdd.Parameters.AddWithValue("@pprice", tboxPrice.Text);

            commandAdd.ExecuteNonQuery();

        }
    }
}