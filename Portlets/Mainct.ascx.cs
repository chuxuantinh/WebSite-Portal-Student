using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Portlets_Mainct : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            LoadForm();
        }
        catch { }


    }
    private void LoadForm()
    {
        if (Session["UIS_MemberType"] == null)
        {
            PlaceHolder1.Controls.Clear();
            PlaceHolder1.Controls.Add(this.LoadControl("News/Main.ascx"));
        }
        else
        {
            switch (Session["UIS_MemberType"].ToString().Trim())
            {
                case "6":
                    //Load trang chủ
                    Removesession();
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(this.LoadControl("News/Main.ascx"));
                    break;
                case "7":
                    //Load trang ngành
                    Removesession();
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(this.LoadControl("Branchs/Main.ascx"));
                    break;
                case "8":
                    //Load trang Bộ môn
                    Removesession();
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(this.LoadControl("Subjects/Main.ascx"));
                    break;
                case "9":
                    //Load trang Văn bản
                    Removesession();
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(this.LoadControl("Text/Main.ascx"));
                    break;
                case "10":
                    //Load trang quản trị
                    Removesession();
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(this.LoadControl("Admin/Main.ascx"));
                    break;
                case "20":
                    //Load trang quản trị
                    Removesession();
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(this.LoadControl("Enrollments/Main.ascx"));
                    break;
                case "21":
                    //Load trang quản trị
                    Removesession();
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(this.LoadControl("Graduations/Main.ascx"));
                    break;
            }
        }
    }
    private void Removesession()
    {
        //Session["MessageCateID"] = null;
        //Session["MessageID"] = null;
        //Session["ID"] = null;
    }


}