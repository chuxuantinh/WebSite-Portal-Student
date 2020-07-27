using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
      //  ltrTieude.Text = Tieude();
        if (Session["UIS_MemberID"] != null && Session["UIS_MemberID"].ToString() != "")
        {
            lbtDangnhap.Text = "Thoát";
        }
        else
        {
            lbtDangnhap.Text = "Đăng nhập";
             
        }
       //ContentPlaceHolder1.Controls.Add(this.LoadControl("Portlets/Login.ascx"));
    }

    protected void lbtHome_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session["UIS_MemberType"] = "6";
        Response.Redirect("~/", true);
    }


    protected void lbtDangnhap_Click(object sender, EventArgs e)
    {
        if (lbtDangnhap.Text == "Đăng nhập")
        {
            Session.RemoveAll();
            Session["UIS_MemberType"] = "5";
        }
        else
        {
            Session.RemoveAll();
        }
        Response.Redirect("~/", true);
    }

    protected void lbtThoat_Click(object sender, EventArgs e)
    {

        Session.RemoveAll();
        Response.Redirect(Request.RawUrl, true);


    }

}
