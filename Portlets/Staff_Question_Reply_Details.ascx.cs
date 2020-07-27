using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Portlets_Staff_Question_Reply_Details : System.Web.UI.UserControl
{

    string strcon = ConfigurationManager.ConnectionStrings["CTConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private  void LoadData()
    {

        SqlConnection con = new SqlConnection(strcon);
        DataTable dt = new DataTable();
        string strsql = "SELECT max(QuestionReID) as idmax from QuestionReply";
        SqlCommand cmd = new SqlCommand(strsql, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {

            for (int i = 1; i <= dt.Rows.Count; i++)
            {

                TextBox_MaCauTraLoi.Text = dt.Rows[0]["idmax"].ToString();
                //idhienhanh = Convert.ToInt32(TextBox_ID.Text);

            }
        }

        int t = Convert.ToInt32(TextBox_MaCauTraLoi.Text);
        t = t + 1;
        TextBox_MaCauTraLoi.Text = Convert.ToString(t);
        //return Max;
    }
}