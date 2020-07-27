using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Portlets_Student_Mainsv : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // Put user code to initialize the page here
            if (Session["UIS_CurrentPage"] == null)
                Session["UIS_CurrentPage"] = "Home";
            if (Session["UIS_CurrentPage"] != null)
                if (Session["UIS_CurrentPage"].ToString().Trim() != "")
                    switch (Session["UIS_CurrentPage"].ToString().Trim())
                    {
                        case "Home":
                            plhWorkingArea.Controls.Clear();
                            plhWorkingArea.Controls.Add(this.LoadControl("../Student_Question_Regist.ascx"));
                            break;
                        case "GuiHoi":
                            plhWorkingArea.Controls.Clear();
                            plhWorkingArea.Controls.Add(this.LoadControl("../Student_Question_Regist.ascx"));
                            break;
                        case "DangKyHocPhan":
                            plhWorkingArea.Controls.Clear();
                            plhWorkingArea.Controls.Add(this.LoadControl("../Student_Question_List.ascx"));
                            break;
                       
                    }
        }
        catch { }

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

            case "lnkHoiDap":
                Session["UIS_CurrentPage"] = "GuiHoi";
                Response.Redirect(Request.RawUrl, true);
                break;

            case "lnkInfo":
                
               Response.Redirect("http://saigonact.vn:8012");
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