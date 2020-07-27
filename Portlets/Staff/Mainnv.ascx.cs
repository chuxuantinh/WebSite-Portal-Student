using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Portlets_Staff_Mainnv : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           

            if ((Session["UIS_MemberType"] == null) || (Session["UIS_MemberType"].ToString().Trim() == ""))
            {
                Session["UIS_MemberType"] = "5";
                Response.Redirect(Request.RawUrl, true);
            }
            Loadform();
        }
        catch { }
    }

    private void Loadform()
    {
        if ((Session["UIS_CurrentPage"] == null) || (Session["UIS_CurrentPage"].ToString() == ""))
            Session["UIS_CurrentPage"] = "Home";

        switch (Session["UIS_CurrentPage"].ToString())
        {
            case "Home":
                plhWorkingArea.Controls.Clear();
                plhWorkingArea.Controls.Add(this.LoadControl("../Staff_Question_List.ascx"));
                break;
            case "DangKyHocPhan":
                plhWorkingArea.Controls.Clear();
                plhWorkingArea.Controls.Add(this.LoadControl("../Staff_Question_Reply.ascx"));
                break;
            case "Thongkedangky":
                plhWorkingArea.Controls.Clear();
                plhWorkingArea.Controls.Add(this.LoadControl("../Staff_Question_Reply_Details.ascx"));
                break;
            case "TraLoi":
                plhWorkingArea.Controls.Clear();
                plhWorkingArea.Controls.Add(this.LoadControl("../Staff_Question_List.ascx"));
                break;
           
           
        }
       
    }

    public void lnkNavigate_Click(object sender, System.EventArgs e)
    {
        LinkButton lnk = (LinkButton)sender;
        switch (lnk.ID)
        {
            case "lnkHome":
                Session["UIS_CurrentPage"] = "Home";
                Response.Redirect(Request.RawUrl, true);
                break;
            case "lnkDangKy":
                Session["UIS_CurrentPage"] = "DangKyHocPhan";
                Response.Redirect(Request.RawUrl, true);
                break;

            case "lnkStudyProgram":
                Session["UIS_CurrentPage"] = "TraLoi";
                Response.Redirect(Request.RawUrl, true);
                break;
            case "lnkThoat":
                Session.Remove("UIS_MemberID");
                Session.Remove("UIS_MemberType");
                Session.Remove("UIS_CurrentPage");
                Response.Redirect(Request.RawUrl, true);

                break;
        }
    }

}