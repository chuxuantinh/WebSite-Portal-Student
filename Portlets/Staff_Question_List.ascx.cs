using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using act;


public partial class Portlets_Staff_Question_List : System.Web.UI.UserControl
{
    public string chutinh;
    string strcon = ConfigurationManager.ConnectionStrings["CTConnectionString"].ConnectionString;



    private void LoadDepartment()
    {
        SqlConnection con = new SqlConnection(strcon);
        //  con.Open();
        string str = "select Department,DepartmentName from Department";
        SqlCommand cmd = new SqlCommand(str, con);
        SqlDataAdapter da = new SqlDataAdapter(str, con);
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
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadDepartment();
        TextBox1.Text = Session["UIS_MemberID"].ToString();
        GetDepart();
        TextBox1.Enabled = false;
        TextBox2.Enabled = false;
      GridView1.DataSource= BindatatoGridview_not();
      GridView1.DataBind();
      GridView2.DataSource = BindatatoGridview_ok();
      GridView2.DataBind();

      GridView3.DataSource = BindatatoGridview_oking();
      GridView3.DataBind();
//BindatatoGridview_ok();
      //  BindatatoGridview_oking();
    }

    private  DataSet BindatatoGridview_not()
    {
      if((Session["UIS_MemberID"].ToString()== "vukhacchuong"))
      {
          SqlDataAdapter da = new SqlDataAdapter("SELECT Question.QuestionID, Question.QuestionName,  CONVERT(varchar(10), DateCreat,103) as Ngaytao, Question.QuestionInfo, Question.StudentID, Department.DepartmentName FROM Department INNER JOIN Question ON Department.Department = Question.DepartmentID INNER JOIN Staff ON Question.DepartmentID = Staff.DepartmentID WHERE (Status=N'False') ORDER BY Question.QuestionID DESC", strcon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
      }
        else
      {
          SqlDataAdapter da = new SqlDataAdapter("SELECT Question.QuestionID, Question.QuestionName,  CONVERT(varchar(10), DateCreat,103) as Ngaytao, Question.QuestionInfo, Question.StudentID, Department.DepartmentName FROM Department INNER JOIN Question ON Department.Department = Question.DepartmentID INNER JOIN Staff ON Question.DepartmentID = Staff.DepartmentID WHERE (Staff.DepartmentID='" + TextBox2.Text + "') AND (Status=N'False') ORDER BY Question.QuestionID DESC", strcon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

      }

    }

   

     private DataSet BindatatoGridview_ok()

    {
        if ((Session["UIS_MemberID"].ToString() == "vukhacchuong"))
        {
            string strsql = "SELECT QuestionReply.QuestionReID, Question.QuestionID, Question.QuestionName, CONVERT(varchar(10), Question.DateCreat, 103) AS Ngaytao, QuestionReply.QuestionReDescriptions, CONVERT(varchar(10), QuestionReply.DateReply, 103) AS NgayTraloi, CONVERT(varchar(10), QuestionReply.DateComplete, 103) AS Ngayhen, Question.StudentID, Staff.StaffName, Department.DepartmentName, QuestionReply.Stutus FROM Staff INNER JOIN QuestionReply ON Staff.StaffID = QuestionReply.StaffID INNER JOIN Question ON QuestionReply.QuestionID = Question.QuestionID INNER JOIN Department ON Staff.DepartmentID = Department.Department WHERE  (QuestionReply.Stutus = N'True') ORDER BY QuestionReply.QuestionReID DESC";

            SqlDataAdapter da = new SqlDataAdapter(strsql, strcon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
         else
        {
            string strsql = "SELECT QuestionReply.QuestionReID, Question.QuestionID, Question.QuestionName, CONVERT(varchar(10), Question.DateCreat, 103) AS Ngaytao, QuestionReply.QuestionReDescriptions, CONVERT(varchar(10), QuestionReply.DateReply, 103) AS NgayTraloi, CONVERT(varchar(10), QuestionReply.DateComplete, 103) AS Ngayhen, Question.StudentID, Staff.StaffName, Department.DepartmentName, QuestionReply.Stutus FROM Staff INNER JOIN QuestionReply ON Staff.StaffID = QuestionReply.StaffID INNER JOIN Question ON QuestionReply.QuestionID = Question.QuestionID INNER JOIN Department ON Staff.DepartmentID = Department.Department WHERE (Staff.DepartmentID='"+TextBox2.Text+"') AND (QuestionReply.Stutus = N'True') ORDER BY QuestionReply.QuestionReID DESC";

            SqlDataAdapter da = new SqlDataAdapter(strsql, strcon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
    }

     private DataSet BindatatoGridview_oking()
     {
         if ((Session["UIS_MemberID"].ToString() == "vukhacchuong"))
         {

             string strsql = "SELECT QuestionReply.QuestionReID, Question.QuestionID, Question.QuestionName, CONVERT(varchar(10), Question.DateCreat, 103) AS Ngaytao, QuestionReply.QuestionReDescriptions, CONVERT(varchar(10), QuestionReply.DateReply, 103) AS NgayTraloi, CONVERT(varchar(10), QuestionReply.DateComplete, 103) AS Ngayhen, Question.StudentID, Staff.StaffName, Department.DepartmentName, QuestionReply.Stutus FROM Staff INNER JOIN QuestionReply ON Staff.StaffID = QuestionReply.StaffID INNER JOIN Question ON QuestionReply.QuestionID = Question.QuestionID INNER JOIN Department ON Staff.DepartmentID = Department.Department WHERE  (QuestionReply.Stutus = N'False') ORDER BY QuestionReply.QuestionReID DESC";

             SqlDataAdapter da = new SqlDataAdapter(strsql, strcon);
             DataSet ds = new DataSet();
             da.Fill(ds);
             return ds;
         }
         else
         {
             string strsql = "SELECT QuestionReply.QuestionReID, Question.QuestionID, Question.QuestionName, CONVERT(varchar(10), Question.DateCreat, 103) AS Ngaytao, QuestionReply.QuestionReDescriptions, CONVERT(varchar(10), QuestionReply.DateReply, 103) AS NgayTraloi, CONVERT(varchar(10), QuestionReply.DateComplete, 103) AS Ngayhen, Question.StudentID, Staff.StaffName, Department.DepartmentName, QuestionReply.Stutus FROM Staff INNER JOIN QuestionReply ON Staff.StaffID = QuestionReply.StaffID INNER JOIN Question ON QuestionReply.QuestionID = Question.QuestionID INNER JOIN Department ON Staff.DepartmentID = Department.Department WHERE  (Staff.DepartmentID='" + TextBox2.Text + "') AND  (QuestionReply.Stutus = N'False') ORDER BY QuestionReply.QuestionReID DESC";

             SqlDataAdapter da = new SqlDataAdapter(strsql, strcon);
             DataSet ds = new DataSet();
             da.Fill(ds);
             return ds;

         }
         
     }


    public void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView2.SelectedRow;
        
        //TextBox2.Text = GridView2.Rows[row.RowIndex].Cells[1].Text;

        Session["QuestionReID"] = GridView2.Rows[row.RowIndex].Cells[1].Text;
        Response.Redirect("/Staff_Question_Reply.aspx?Name=" + Session["QuestionID"]);
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        GridView2.DataSource = BindatatoGridview_ok();
        GridView2.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

      Session["QuestionID"] = GridView1.SelectedValue;
       // GridViewRow row = GridView1.SelectedRow;

        Response.Redirect("Staff_Question_Reply.aspx?Name=" + Session["QuestionID"]);

       // Session["QuestionID"] = GridView1.Rows[row.RowIndex].Cells[1].Text;
        //Response.Redirect("/Staff_Question_Reply.aspx?Name=" + Session["QuestionID"]);


      //  Session["FirstName"] = GridView1.Rows[row.RowIndex].Cells[1].Text;
    //    Session["LastName"] = GridView1.DataKeys[RowIndex]["QuestionID"].ToString();

      //  Response.Redirect("Staff_Question_Reply.aspx?Name=" + Session["LastName"]);
    }  
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
           //  GridViewRow row = GridView1.SelectedRow;

        //TextBox2.Text = GridView2.Rows[row.RowIndex].Cells[1].Text;

       // Session["QuestionID"] = GridView1.Rows[e.NewSelectedIndex].Cells[1].Text;
       // Session["QuestionID"] = GridView1.Rows[e.NewSelectedIndex].Cells[1].Text;
       // string t = GridView1.Rows[e.NewSelectedIndex].Cells[1].ToString();
           //  Session["QuestionID"] = GridView1.SelectedValue;
      //  Session["QuestionID"] = 20;


     //   GridViewRow row = GridView1.Rows[e.NewSelectedIndex];
      //  Session["QuestionID"] = row.Cells[2].Text;
       // Response.Redirect("Staff_Question_Reply.aspx?Name=" + Session["QuestionID"]);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       // Session["QuestionID"] = GridView1.SelectedRow.Cells[0].Text;
        // string queryString = Session["QuestionID"].ToString();

        //TextBox2.Text = queryString;
        //Response.Redirect("/Staff_Question_Reply.aspx?Name="+ Session["QuestionID"]);
        TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
      
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        if (sender != null)
        {
            GridView GridView1 = sender as GridView;
            GridView1.PageIndex = e.NewPageIndex;
            BindatatoGridview_not();
        }
    }
    protected void GridView2_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        
        Session["QuestionID"] = GridView2.Rows[e.NewSelectedIndex].Cells[2].Text;
        Response.Redirect("/Staff_Question_Reply.aspx?Name=" + Session["QuestionID"]);
    }
    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {
        
    }

  private void GetDepart()
    {
        // Response.ContentEncoding = Encoding.GetEncoding("Windows-1252");
        //  Response.Charset = "UTF-8";
        SqlConnection con = new SqlConnection(strcon);
        DataTable dt = new DataTable();
        string strsql = "SELECT DepartmentID from Staff where (StaffID='" + Session["UIS_MemberID"].ToString() +"')";
        SqlCommand cmd = new SqlCommand(strsql, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {

            for (int i = 1; i <= dt.Rows.Count; i++)
            {

                TextBox2.Text = dt.Rows[0]["DepartmentID"].ToString();
                //idhienhanh = Convert.ToInt32(TextBox_ID.Text);

            }
        }

       // return ds;
    }
  protected void TextBox1_TextChanged(object sender, EventArgs e)
  {

  }
  protected void Button1_Click2(object sender, EventArgs e)
  {
      GridView1.DataSource = null;
      GridView1.DataSource = BindatatoGridview_not_f();
      GridView1.DataBind();
      GridView2.DataSource = BindatatoGridview_ok_f();
      GridView2.DataBind();

      GridView3.DataSource = BindatatoGridview_oking_f();
      GridView3.DataBind();
     
  }

  private DataSet BindatatoGridview_not_f()
  {
      if ((Session["UIS_MemberID"].ToString() == "vukhacchuong"))
      {
          SqlDataAdapter da = new SqlDataAdapter("SELECT Question.QuestionID, Question.QuestionName,  CONVERT(varchar(10), DateCreat,103) as Ngaytao, Question.QuestionInfo, Question.StudentID, Department.DepartmentName FROM Department INNER JOIN Question ON Department.Department = Question.DepartmentID INNER JOIN Staff ON Question.DepartmentID = Staff.DepartmentID WHERE (Staff.DepartmentID='" + Depart_Combo.SelectedValue.ToString() + "') AND (Status=N'False') ORDER BY Question.QuestionID DESC", strcon);
          DataSet ds = new DataSet();
          da.Fill(ds);
          return ds;
      }
      else
      {
          SqlDataAdapter da = new SqlDataAdapter("SELECT Question.QuestionID, Question.QuestionName,  CONVERT(varchar(10), DateCreat,103) as Ngaytao, Question.QuestionInfo, Question.StudentID, Department.DepartmentName FROM Department INNER JOIN Question ON Department.Department = Question.DepartmentID INNER JOIN Staff ON Question.DepartmentID = Staff.DepartmentID WHERE (Staff.DepartmentID='" + TextBox2.Text + "') AND (Status=N'False') ORDER BY Question.QuestionID DESC", strcon);
          DataSet ds = new DataSet();
          da.Fill(ds);
          return ds;

      }

  }



  private DataSet BindatatoGridview_ok_f()
  {
      if ((Session["UIS_MemberID"].ToString() == "vukhacchuong"))
      {
          string strsql = "SELECT QuestionReply.QuestionReID, Question.QuestionID, Question.QuestionName, CONVERT(varchar(10), Question.DateCreat, 103) AS Ngaytao, QuestionReply.QuestionReDescriptions, CONVERT(varchar(10), QuestionReply.DateReply, 103) AS NgayTraloi, CONVERT(varchar(10), QuestionReply.DateComplete, 103) AS Ngayhen, Question.StudentID, Staff.StaffName, Department.DepartmentName, QuestionReply.Stutus FROM Staff INNER JOIN QuestionReply ON Staff.StaffID = QuestionReply.StaffID INNER JOIN Question ON QuestionReply.QuestionID = Question.QuestionID INNER JOIN Department ON Staff.DepartmentID = Department.Department WHERE (Staff.DepartmentID='" + Depart_Combo.SelectedValue.ToString() + "') AND (QuestionReply.Stutus = N'True') ORDER BY QuestionReply.QuestionReID DESC";

          SqlDataAdapter da = new SqlDataAdapter(strsql, strcon);
          DataSet ds = new DataSet();
          da.Fill(ds);
          return ds;
      }
      else
      {
          string strsql = "SELECT QuestionReply.QuestionReID, Question.QuestionID, Question.QuestionName, CONVERT(varchar(10), Question.DateCreat, 103) AS Ngaytao, QuestionReply.QuestionReDescriptions, CONVERT(varchar(10), QuestionReply.DateReply, 103) AS NgayTraloi, CONVERT(varchar(10), QuestionReply.DateComplete, 103) AS Ngayhen, Question.StudentID, Staff.StaffName, Department.DepartmentName, QuestionReply.Stutus FROM Staff INNER JOIN QuestionReply ON Staff.StaffID = QuestionReply.StaffID INNER JOIN Question ON QuestionReply.QuestionID = Question.QuestionID INNER JOIN Department ON Staff.DepartmentID = Department.Department WHERE (Staff.DepartmentID='" + TextBox2.Text + "') AND (QuestionReply.Stutus = N'True') ORDER BY QuestionReply.QuestionReID DESC";

          SqlDataAdapter da = new SqlDataAdapter(strsql, strcon);
          DataSet ds = new DataSet();
          da.Fill(ds);
          return ds;

      }
  }

  private DataSet BindatatoGridview_oking_f()
  {
      if ((Session["UIS_MemberID"].ToString() == "vukhacchuong"))
      {

          string strsql = "SELECT QuestionReply.QuestionReID, Question.QuestionID, Question.QuestionName, CONVERT(varchar(10), Question.DateCreat, 103) AS Ngaytao, QuestionReply.QuestionReDescriptions, CONVERT(varchar(10), QuestionReply.DateReply, 103) AS NgayTraloi, CONVERT(varchar(10), QuestionReply.DateComplete, 103) AS Ngayhen, Question.StudentID, Staff.StaffName, Department.DepartmentName, QuestionReply.Stutus FROM Staff INNER JOIN QuestionReply ON Staff.StaffID = QuestionReply.StaffID INNER JOIN Question ON QuestionReply.QuestionID = Question.QuestionID INNER JOIN Department ON Staff.DepartmentID = Department.Department WHERE (Staff.DepartmentID='" + Depart_Combo.SelectedValue.ToString() + "') AND (QuestionReply.Stutus = N'False') ORDER BY QuestionReply.QuestionReID DESC";

          SqlDataAdapter da = new SqlDataAdapter(strsql, strcon);
          DataSet ds = new DataSet();
          da.Fill(ds);
          return ds;
      }
      else
      {
          string strsql = "SELECT QuestionReply.QuestionReID, Question.QuestionID, Question.QuestionName, CONVERT(varchar(10), Question.DateCreat, 103) AS Ngaytao, QuestionReply.QuestionReDescriptions, CONVERT(varchar(10), QuestionReply.DateReply, 103) AS NgayTraloi, CONVERT(varchar(10), QuestionReply.DateComplete, 103) AS Ngayhen, Question.StudentID, Staff.StaffName, Department.DepartmentName, QuestionReply.Stutus FROM Staff INNER JOIN QuestionReply ON Staff.StaffID = QuestionReply.StaffID INNER JOIN Question ON QuestionReply.QuestionID = Question.QuestionID INNER JOIN Department ON Staff.DepartmentID = Department.Department WHERE  (Staff.DepartmentID='" + TextBox2.Text + "') AND  (QuestionReply.Stutus = N'False') ORDER BY QuestionReply.QuestionReID DESC";

          SqlDataAdapter da = new SqlDataAdapter(strsql, strcon);
          DataSet ds = new DataSet();
          da.Fill(ds);
          return ds;

      }

  }

  
 
  protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
  {
      for (int i = 0; i < e.Row.Cells.Count; i++)
      {
          e.Row.Cells[i].Attributes.Add("style", "white-space:nowrap;");
      }
  }
}
    