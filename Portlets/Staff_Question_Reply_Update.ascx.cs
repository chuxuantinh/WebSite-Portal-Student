using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;

public partial class Portlets_Staff_Question_Reply_Update : System.Web.UI.UserControl
{
    string strcon = ConfigurationManager.ConnectionStrings["CTConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox_Staff.Text = Session["UIS_MemberID"].ToString();
      //  TextBox2.Text = Session["QuestionID"].ToString();
     //   TextBox_MaCauTraLoi.Text = Session["QuestionReID"].ToString();
      //  GetMaxID();
      //  TextBox_MaCauTraLoi.Enabled = false;
        TextBox_Staff.Enabled = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(strcon);
        con.Open();
        string str = "UPDATE QuestionReply SET QuestionReID=@QuestionReID, QuestionID=@QuestionID, DateReply=@DateReply,QuestionReDescriptions=@QuestionReDescriptions,StaffID=@StaffID, DateComplete=@DateComplete,Stutus=@Stutus where (QuestionReID=@QuestionReID and QuestionID=@QuestionID)";
        SqlCommand cmd = new SqlCommand(str, con);
        cmd.Parameters.AddWithValue("@QuestionReID", TextBox_MaCauTraLoi.Text);
        cmd.Parameters.AddWithValue("@QuestionID", TextBox2.Text);
        cmd.Parameters.AddWithValue("@DateReply", DateTime.Now.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@QuestionReDescriptions", FCKeditor1.Value);
        cmd.Parameters.AddWithValue("@StaffID", TextBox_Staff.Text);
        cmd.Parameters.AddWithValue("@DateComplete", Calendar1.SelectedDate.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@Stutus", CheckBox_HoanThanh.Checked.ToString());
        cmd.ExecuteNonQuery();
        cmd.Dispose();
      //  GetMaxID();
      //  Update_Status_Question();
        Response.Redirect("/");
    }

    private void Update_Status_Question()
    {

        SqlConnection con = new SqlConnection(strcon);
        con.Open();
        string str = "UPDATE Question SET Status=@Status where QuestionID=@QuestionID";
        SqlCommand cmd = new SqlCommand(str, con);
        cmd.Parameters.AddWithValue("@QuestionID", TextBox2.Text);
        cmd.Parameters.AddWithValue("@Status", CheckBox_HoanThanh.Checked.ToString());


        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //  GetMaxID();

    }

    public void GetMaxID()
    {
        // Response.ContentEncoding = Encoding.GetEncoding("Windows-1252");
        //  Response.Charset = "UTF-8";
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


    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox3.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
    }
}