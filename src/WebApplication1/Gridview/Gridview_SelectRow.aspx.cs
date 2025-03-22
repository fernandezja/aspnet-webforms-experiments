using Starwars.Jedis.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Gridview
{
    public partial class Gridview_SelectRow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var jediBusiness = new JediBusiness();
                    
                GridView1.DataSource = jediBusiness.List();
                GridView1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GridView1.SelectedIndex;

            // Get the DataKey value (primary key) of the selected row
            string selectedID = GridView1.DataKeys[selectedIndex].Value.ToString();


            // Access selected row cells by index
            string value1 = GridView1.SelectedRow.Cells[1].Text; // First visible column (after select button)
            string value2 = GridView1.SelectedRow.Cells[2].Text; // Second visible column

            //Set labels value
            Index.Text = selectedIndex.ToString();
            JediId.Text = selectedID;
        }
    }
}