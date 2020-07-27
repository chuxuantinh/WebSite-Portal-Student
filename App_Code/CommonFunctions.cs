using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for CommonFunctions
/// </summary>
public class CommonFunctions
{
    #region Cookies
    static public void writeCookie(string MemberID, string Role)
    {
        //encrypt.
        string encryptMemberID = Encrypt_Decrypt.Instance().Encrypt(MemberID);
        string encryptRole = Encrypt_Decrypt.Instance().Encrypt(Role);
        //set cookies.
        HttpContext.Current.Response.Cookies["PSC_UIS"]["1"] = encryptMemberID;
        HttpContext.Current.Response.Cookies["PSC_UIS"]["2"] = encryptRole;
        HttpContext.Current.Response.Cookies["PSC_UIS"].Expires = DateTime.Now.AddYears(1);
    }

    //ham lay gi tri cua mot cookie tu may client
    static public void getCookie(ref string MemberID, ref string Role)
    {
        if (HttpContext.Current.Request.Cookies["PSC_UIS"] != null)
        {
            MemberID = Encrypt_Decrypt.Instance().Decrypt(HttpContext.Current.Request.Cookies["PSC_UIS"]["1"].ToString());
            Role = Encrypt_Decrypt.Instance().Decrypt(HttpContext.Current.Request.Cookies["PSC_UIS"]["2"].ToString());
        }
    }

    //ham dung de xoa mot cookie.
    static public void deleteCookie()
    {
        if (HttpContext.Current.Request.Cookies["PSC_UIS"] != null)
        {
            HttpContext.Current.Response.Cookies["PSC_UIS"].Expires = DateTime.Now.AddYears(-30);
        }
    }

    #endregion

    #region Regist Javascript
    /// <summary>
    /// 
    /// </summary>
    /// <param name="ScriptRegister">Javascript can thuc thi khi ham chay</param>
    /// <param name="page">Page thi hanh</param>
    static public void RunJavascript(System.Web.UI.Page page, string ScriptRegister)
    {
        string alertScript = "<script language=javascript>"
            + ScriptRegister
            + "</script>";
        if (!page.IsClientScriptBlockRegistered("alert"))
            page.RegisterClientScriptBlock("alert", alertScript);
    }

    static public string BuildAlert(string alertMessage)
    {
        return "alert('" + alertMessage + "');";
    }

    static public string BuildConfirm(string Message, string ActionTrue, string ActionFalse)
    {
        return @"var yes = confirm('" + Message + @"');
					if (yes)
					{
					" + ActionTrue + @"
					}
					else
					{
					" + ActionFalse + @"
					}";
    }

    static public string BuildRedirectPage(string url)
    {
        return "window.location='" + url + "';";
    }
    #endregion
}
