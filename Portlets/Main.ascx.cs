using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Portlets_Main : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Session["UIS_MemberID"] == null) || (Session["UIS_MemberID"].ToString().Trim() == "") || (Session["UIS_MemberType"] == null) || (Session["UIS_MemberType"].ToString().Trim() == ""))
           
            LoadLoginForm();
           
        else
        {
            switch (Session["UIS_MemberType"].ToString())
            {
                case "1":
                    //Load trang Sinh viên
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(this.LoadControl("Student/Mainsv.ascx"));
                    break;
               
                case "4":
                    //Load trang nhân viên
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(this.LoadControl("Staff/Mainnv.ascx"));
                    break;
              
                default:
                    LoadLoginForm();
                    // PlaceHolder1.Controls.Clear();
                    //PlaceHolder1.Controls.Add(this.LoadControl("Login.aspx"));
                    break;
            }
        }
    }

    private void LoadLoginForm()
    {
        //đọc lại cookies
        string MemberID = "", Role = "";
        CommonFunctions.getCookie(ref MemberID, ref Role);
        //check does cookie store authenticated user info.
        Student t = new Student();
        if (MemberID != "")
        {
            Session["UIS_MemberID"] = MemberID;
            Session["UIS_MemberType"] = Role;
            switch (Role)
            {
                case "1":
                    //Load trang Sinh viên
                   PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(this.LoadControl("Student/Mainsv.ascx"));
                    break;
                case "2":
                    //Load trang Giáo viên
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(this.LoadControl("Professor/Main.ascx"));
                    break;
                case "4":
                    //Load trang nhân viên
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(this.LoadControl("Staff/Mainnv.ascx"));
                    break;
                //default:
                   
                //    PlaceHolder1.Controls.Clear();
                //   PlaceHolder1.Controls.Add(this.LoadControl("Login.aspx"));
                //    break;
            }
        }
        else
        {
            //if ((Session["UIS_MemberType"] != null) && (Session["UIS_MemberType"].ToString().Trim() == "5"))
            //{
                PlaceHolder1.Controls.Clear();
                PlaceHolder1.Controls.Add(this.LoadControl("Login.ascx"));
          //  }
            //else
            //{
            //    PlaceHolder1.Controls.Clear();
            //    PlaceHolder1.Controls.Add(this.LoadControl("Mainct.ascx"));
            //}
        }
    }
}