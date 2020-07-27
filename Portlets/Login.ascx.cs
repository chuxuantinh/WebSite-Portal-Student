using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;

using act;

public partial class Portlets_WebUserControl : System.Web.UI.UserControl
{

    private string UserID = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        int Authenticated;
        Student t = new Student();

        if ((rbtnStudent.Checked) && (IsStudent(txtUserName.Value.Trim(), txtPassword.Text.Trim())))
        {
            Authenticated = 10;
        }
        //else if ((rbtnProfessor.Checked) && (isProfessor(txtUserName.Value.Trim(), txtPassword.Text.Trim())))
        //{
        //    Authenticated = 20;
        //}
        else
        {
            if (rbtnStudent.Checked && Authenticate(txtUserName.Value.Replace("'", "").Trim(), txtPassword.Text.Replace("'", "").Trim()) == 10)
                Authenticated = 10;
            else
                if ((rbtnStaff.Checked) && (Nhanvien(txtUserName.Value.Replace("'", "").Trim(), txtPassword.Text.Replace("'", "").Trim())))
                    Authenticated = 40;
                //else
                //    if (rbtnPrincipal.Checked)
                //        Authenticated = AuthenticatePrincipal(txtUserName.Value.Replace("'", "").Trim(), txtPassword.Text.Replace("'", "").Trim());
                    
                    else
                        Authenticated = 1;
        }
        switch (Authenticated)
        {
            case 1:

                //user trong uis khong ton tai, thong bao loi thanh vien ko ton tai
                tdError.InnerHtml = "&nbsp;&nbsp;<IMG src='Portlets/UIS_MySpace/Images/red-error.gif' align='absMiddle' border=0>Tên đăng nhập và mật khẩu không đúng.<br/><hr size=0.1 color=#0000CC>";
                CommonFunctions.RunJavascript(Page, @"window.onload = function()
        															{
        																document.forms(0). " + txtUserName.ClientID + @".select();
        																document.forms(0)." + txtUserName.ClientID + @".focus();
        															}");
                break;


            case 2:
                //thong bao nhap sai password
                tdError.InnerHtml = "&nbsp;&nbsp;<IMG src='Portlets/UIS_MySpace/Images/red-error.gif' align='absMiddle' border=0>Mật mã truy cập không chính xác.<br/><hr size=0.1 color=#0000CC>";
                CommonFunctions.RunJavascript(Page, @"window.onload = function()
        															{
        																document.forms(0)." + txtPassword.ClientID + @".select();
        																document.forms(0)." + txtPassword.ClientID + @".focus();
        															}");
                break;
            case 10:
                //ghi cookie
                if (cbRemember.Checked == true)
                {
                    CommonFunctions.writeCookie(txtUserName.Value.Replace("'", "").Trim(), "1");
                }
                //cap nhat bien la sinh vien va trang publish cua sinh vien
                Session["UIS_MemberID"] = txtUserName.Value.Replace("'", "").Trim();
                Session["UIS_MemberType"] = "1";
                //redirect
               Response.Redirect(Request.RawUrl, true);
               // Response.Redirect("/Student_Contact.aspx");
               // TextBox1.Text = Session["UIS_MemberID"].ToString(); 

                break;
            case 20:
                //ghi cookie
                if (cbRemember.Checked == true)
                {
                    CommonFunctions.writeCookie(txtUserName.Value.Replace("'", "").Trim(), "2");
                }
                //cap nhat bien la giao su va trang publish cua giao su
                Session["UIS_MemberID"] = UserID;
                Session["UIS_MemberType"] = "2";
                //redirect
                Response.Redirect(Request.RawUrl, true);

                break;
            case 30:
                //ghi cookie
                if (cbRemember.Checked == true)
                {
                    CommonFunctions.writeCookie(txtUserName.Value.Replace("'", "").Trim(), "3");
                }
                Session["UIS_MemberID"] = txtUserName.Value.Replace("'", "").Trim();
                Session["UIS_MemberType"] = "3";
                //redirect
                Response.Redirect(Request.RawUrl, true);
                break;
            case 40:
                if (cbRemember.Checked == true)
                {
                    CommonFunctions.writeCookie(txtUserName.Value.Replace("'", "").Trim(), "4");
                }
                Session["UIS_MemberID"] = txtUserName.Value.Replace("'", "").Trim();
                Session["UIS_MemberType"] = "4";
                //redirect
             //   Response.Redirect(Request.RawUrl, true);
                //TextBox1.Text = Session["UIS_MemberID"].ToString(); 
                Response.Redirect(Request.RawUrl, true);
                break;
        }



      
    }

    //public bool Authenticate( string ID, string Password) 
    //{
    //    int num = 1;

    //    try
    //    {
    //        DataTable Table = new DataTable();
            

    //    }
    //    catch (Exception)
    //    {
            
    //        throw;
    //    }

    //}

    private bool IsStudent(string StudentID, string Pass)
    {
        Student t = new Student();
        //return t.Is_Students(StudentID,Pass);
        return t.IsStudents(StudentID, Pass);

        
    }

    private bool isProfessor(string UserName, string PW)
    {
       Staffbll t = new Staffbll();
        string Pass = Common.Functions.EncodeMD5(PW);
        
        string ID = t.Professor_urm_Sel_ProfessorID(UserName, Pass, PW);
        if (ID != "0")
        {
            UserID = ID;
            return true;
        }
        else
            return false;
    }

    private bool Nhanvien(string SenderID, string PasswordID)
    {
        string Pass = Common.Functions.EncodeMD5(SenderID, PasswordID);
        Messagesbll t = new Messagesbll();
        if (t.Login(SenderID, Pass) == 0)
        {
            Session.RemoveAll();
            return true;

        }
        else
        {
            return false;
        }

    }

    public int Authenticate(string ID, string password)
    {
        int num = 1;
        try
        {
            DataTable table = new DataTable();
            Webservicedal t = new Webservicedal();
            table = t.Authenticated_Sel_UID(ID);
            if (table.Rows.Count <= 0)
            {
                return num;
            }
            if (table.Rows[0]["Password"].ToString() == password)
            {
                if (bool.Parse(table.Rows[0]["IsStudent"].ToString()))
                {
                    return 10;
                }
                return 20;
            }
            else { num = 2; }

        }
        catch
        {
        }
        return num;
    }

    public int AuthenticatePrincipal(string ID, string password)
    {
        int num = 30;
        try
        {
            DataTable table = new DataTable();
            Webservicedal t = new Webservicedal();
            table = t.Authenticated_Sel_Principal(ID);
            if (table.Rows.Count <= 0)
            {
                return num;
            }
            if (table.Rows[0]["IsExists"].ToString() == "1")
            {
                if (table.Rows[0]["Password"].ToString() != password)
                {
                    num = 2;
                }
                return num;
            }
            return 1;
        }
        catch
        {
            return 1;
        }
    }
    protected void rbtnStaff_CheckedChanged(object sender, EventArgs e)
    {

    }
}