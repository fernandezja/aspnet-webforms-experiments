using Starwars.Jedis.Business;
using Starwars.Jedis.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Code;

namespace WebApplication1.Gridview
{
    public partial class Gridview_AutoGenerateColumns : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                JediBusiness jediBusiness = new JediBusiness();

                //Option 1: Direct
                //-----------------------------------------------------------------------
                GridView1.DataSource = jediBusiness.List();
                GridView1.DataBind();

                
                //Option 2: Convert to DataTable
                //-----------------------------------------------------------------------
                var jedis = jediBusiness.List();
                var jedisDataTable = jedis.ToDataTable();

                foreach (DataRow row in jedisDataTable.Rows)
                {
                    var power = double.Parse(row["Power"].ToString());
                    row[4] = $"{power.ToString("0.#00")}% <strong>Custom</strong>";
                }

                GridView2.DataSource = jedisDataTable;
                GridView2.DataBind();

                //Option 3: 
                //-----------------------------------------------------------------------
                GridView3.DataSource = jediBusiness.List();
                GridView3.DataBind();
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //Option 3: RowDataBound
            //-----------------------------------------------------------------------
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var jedi = (Jedi)e.Row.DataItem;
                
                //Cell 4
                e.Row.Cells[4].Text = $"{jedi.Power.ToString("0.#00")}% <strong>Custom</strong>";
                
            }
        }


        

        
    }
}