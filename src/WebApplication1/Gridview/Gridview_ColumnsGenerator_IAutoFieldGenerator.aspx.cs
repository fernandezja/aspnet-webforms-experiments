using Starwars.Jedis.Business;
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
    public partial class Gridview_ColumnsGenerator_IAutoFieldGenerator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                JediBusiness jediBusiness = new JediBusiness();

                GridView1.ColumnsGenerator = new StarwarsGridViewColumnsGenerator();

                GridView1.DataSource = jediBusiness.List();
                GridView1.DataBind();

            }
        }
    }
}