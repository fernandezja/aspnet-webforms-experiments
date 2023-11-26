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
    }
}