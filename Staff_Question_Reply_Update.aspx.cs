using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Staff_Question_Reply_Update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PlaceHolder1.Controls.Add(this.LoadControl("~/Portlets/Staff_Question_Reply_Update.ascx"));
    }
}