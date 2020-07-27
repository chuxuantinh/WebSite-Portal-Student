using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using act;

public partial class Portlets_WebUserControl : System.Web.UI.UserControl


{
    string strcon = ConfigurationManager.ConnectionStrings["CTConnectionString"].ConnectionString;
   
    protected void Page_Load(object sender, EventArgs e)
    {
       
        TextBox3.Text = Session["UIS_MemberID"].ToString(); 
        LoadDepartment();
        GetMaxID();
        TextBox4.Text = DateTime.Now.ToString("hh:mm:ss tt");
      
      //  ASPxDateEdit1.Value = DateTime.Now.ToString();
     
     //   ASPxDateEdit1.Enabled = false;
        TextBox5.Enabled = false;
        TextBox3.Enabled = false;

       
    }
  
   
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("/Default.aspx");
    }

   
  
    private void LoadDepartment()
    {
        SqlConnection con = new SqlConnection(strcon);
      //  con.Open();
        string str = "select Department,DepartmentName from Department";
        SqlCommand cmd = new SqlCommand(str, con);
        SqlDataAdapter da = new SqlDataAdapter(str,con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        Depart_Combo.DataSource = dt;
        Depart_Combo.DataBind();
        Depart_Combo.DataTextField = "DepartmentName";
        Depart_Combo.DataValueField = "Department";
        Depart_Combo.DataBind();
       // cmd.ExecuteNonQuery();
     //   con.Close();
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int t = Convert.ToInt32(TextBox5.Text);
     //   string date = Convert.ToString(ASPxDateEdit1.Value);
        SqlConnection con = new SqlConnection(strcon);
         con.Open();
         string str = "INSERT INTO Question(QuestionID,QuestionName,QuestionDate,QuestionInfo,DateCreat,DepartmentID,StudentID,Fileattack,Status) VALUES (@QuestionID,@QuestionName,@QuestionDate,@QuestionInfo,@DateCreat,@DepartmentID,@StudentID,@Fileattack,@Status)";
        SqlCommand cmd = new SqlCommand(str, con);
        cmd.Parameters.AddWithValue("@QuestionID", TextBox_Macauhoi.Text);
        cmd.Parameters.AddWithValue("@QuestionName", TextBox1.Text);
        cmd.Parameters.AddWithValue("@QuestionDate", TextBox4.Text);
        cmd.Parameters.AddWithValue("@QuestionInfo", fckDiscussion.Value);
        cmd.Parameters.AddWithValue("@DateCreat", DateTime.Now.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@DepartmentID",Depart_Combo.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("@StudentID", TextBox3.Text);
        cmd.Parameters.AddWithValue("@Fileattack", "");
        cmd.Parameters.AddWithValue("@Status", 0);
        cmd.ExecuteNonQuery();
     
        cmd.Dispose();
        GetMaxID();
        
    }

    public void GetMaxID()
    {
        // Response.ContentEncoding = Encoding.GetEncoding("Windows-1252");
        //  Response.Charset = "UTF-8";
        SqlConnection con = new SqlConnection(strcon);
        DataTable dt = new DataTable();
        string strsql = "SELECT max(QuestionID) as idmax from Question";
        SqlCommand cmd = new SqlCommand(strsql, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {

            for (int i = 1; i <= dt.Rows.Count; i++)
            {
                
               TextBox5.Text = dt.Rows[0]["idmax"].ToString();
                //idhienhanh = Convert.ToInt32(TextBox_ID.Text);

            }
        }

        int t = Convert.ToInt32(TextBox5.Text);
        t = t + 1;
        TextBox_Macauhoi.Text = Convert.ToString(t);
        //return Max;
 
    }

   

    public int MaxID(int st)
    {
        // Response.ContentEncoding = Encoding.GetEncoding("Windows-1252");
        //  Response.Charset = "UTF-8";
        SqlConnection con = new SqlConnection(strcon);
        DataTable dt = new DataTable();
        string strsql = "SELECT max(QuestionID) as idmax from Question";
        SqlCommand cmd = new SqlCommand(strsql, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {

            for (int i = 1; i <= dt.Rows.Count; i++)
            {

                TextBox5.Text = dt.Rows[0]["idmax"].ToString();
                //idhienhanh = Convert.ToInt32(TextBox_ID.Text);

            }
        }

        int t = Convert.ToInt32(TextBox5.Text);
        return t;
       // TextBox_Macauhoi.Text = Convert.ToString(t + 1);
        //return Max;

    }
   
}
