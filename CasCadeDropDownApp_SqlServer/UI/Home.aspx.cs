using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CasCadeDropDownApp_SqlServer.UI
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! Page.IsPostBack)
            {
                ddl_division.DataSource = getDivision();
                ddl_division.DataBind();
                ListItem listItem = new ListItem("--select--", "-1");

                ddl_division.Items.Insert(0, listItem);
                ddl_district.Enabled = false;
                ddl_sub_district.Enabled = false;
            }
          
        }
        List<string> getDivision()
        {
            List<string> list = new List<string>();
            list.Add("Dhaka");
            list.Add("Khulna");
            list.Add("Chittagong");
            list.Add("Rajshahi");
            list.Add("Barishal");
            return list;
        }

        protected void ddl_division_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          ddl_district.DataSource=  get_District();
            ddl_district.DataBind();
            ListItem listItem = new ListItem("--select--", "-1");
            ddl_district.Items.Insert(0, listItem);
            ddl_district.Enabled = true;
            ddl_sub_district.ClearSelection();
        }
        List<string> get_District()
        {
            List<string> list = new List<string>();
            //list.Add("abc");
            //list.Add("efg");
            //list.Add("hij");
            if (ddl_division.SelectedIndex == 1)
            {
                list.Add("Dhaka Sadar");
                list.Add("Faridpur");
                list.Add("Manikganj");
                list.Add("Rajbari");
                list.Add("Munshiganj");
            }
            else if (ddl_division.SelectedIndex ==2 )
            {
                list.Add("Magura");
                list.Add("Jessore");
                list.Add("Khulna");
                list.Add("Kushtia");
                list.Add("Narail");
            }

            return list;
        }

       

        List<string> getSubDistrict()
        {
            List<string> list = new List<string>();


            if (ddl_division.SelectedIndex==2 &&  ddl_district.SelectedIndex == 1)
            {
                list.Add("Salikha");
                list.Add("Magura Sadar");
                list.Add("Mohammadpur");
                list.Add("Sreepur");
                list.Add("Munshiganj");
            }
            else if (ddl_division.SelectedIndex == 2 && ddl_district.SelectedIndex == 2)
            {
                list.Add("Moniram Pur");
                list.Add("Baghar Para");
                list.Add("Jessore Sadar");
                list.Add("Noa Para");
               
            }

            else if (ddl_division.SelectedIndex == 1 && ddl_district.SelectedIndex == 1)
            {
                list.Add("Savar");
                list.Add("Mirpur");
                list.Add("Dhanmondi");
                list.Add("Uttara");

            }


            return list;
        }

        protected void ddl_district_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_sub_district.DataSource = getSubDistrict();
            ddl_sub_district.DataBind();
            ListItem listItem = new ListItem("--select--", "-1");
            ddl_sub_district.Items.Insert(0, listItem);
            ddl_sub_district.Enabled = true;
        }
    }
}