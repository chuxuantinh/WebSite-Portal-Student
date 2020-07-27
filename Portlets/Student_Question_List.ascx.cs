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
public partial class Portlets_Student_Question_List : System.Web.UI.UserControl
{
    string strcon = ConfigurationManager.ConnectionStrings["CTConnectionString"].ConnectionString;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.Page.IsPostBack)
        {
            TextBox1.Text = Session["UIS_MemberID"].ToString();
            TextBox1.Enabled = false;
           // BindatatoGridview_not();
          //  GridView1.PageIndex = 1;
            //GridView2.PageIndex = 2;
          
            GridView1.DataSource = BindatatoGridview_not();
            GridView1.DataBind();
            GridView2.DataSource = BindatatoGridview_ok();
            GridView2.DataBind();

        }
    }

    public DataSet BindatatoGridview_not()
    {

        
            SqlDataAdapter da = new SqlDataAdapter("select QuestionID, QuestionName, QuestionInfo, CONVERT(varchar(10), DateCreat,103) as Ngaygui from Question where (StudentID='" + TextBox1.Text + "') and (Status=N'False') ORDER BY QuestionID DESC", strcon);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;

    }

    public DataSet BindatatoGridview_ok()
    {
       
     
            string strsql1;
            strsql1 = "SELECT QuestionReply.QuestionReID, Question.QuestionID, Question.QuestionName, QuestionReply.QuestionReDescriptions, Staff.StaffName, CONVERT(varchar(10), QuestionReply.DateReply,103) as NgayTraloi, CONVERT(varchar(10), QuestionReply.DateComplete, 103) as Ngayhen, QuestionReply.Stutus FROM  Staff INNER JOIN QuestionReply ON Staff.StaffID = QuestionReply.StaffID INNER JOIN Question ON QuestionReply.QuestionID = Question.QuestionID WHERE (Question.StudentID='" + TextBox1.Text + "') AND (QuestionReply.Stutus = N'True')";
        
            SqlDataAdapter da = new SqlDataAdapter(strsql1, strcon);
         //   SqlCommand cmd = new SqlCommand(strsql1,strcon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        

    }

   
    
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        GridView2.DataSource = BindatatoGridview_ok();
        GridView2.DataBind();
           
    }
   

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = BindatatoGridview_not();
        GridView1.DataBind();

    }
  
}