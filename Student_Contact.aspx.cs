using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Student_Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PlaceHolder1.Controls.Add(this.LoadControl("~/Portlets/Student_Question_Regist.ascx"));
    }
}