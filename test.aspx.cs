using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class test : System.Web.UI.Page
{

    string strcon = ConfigurationManager.ConnectionStrings["CTConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = Data();
        GridView1.DataBind();
    }


    public DataSet Data()
    {

        
            string strsql1;
            strsql1 = "SELECT QuestionReply.QuestionReID, Question.QuestionID, Question.QuestionName, QuestionReply.QuestionReDescriptions, Staff.StaffName, CONVERT(varchar(10), QuestionReply.DateReply,103) as NgayTraloi, CONVERT(varchar(10), QuestionReply.DateComplete, 103) as Ngayhen, QuestionReply.Stutus FROM  Staff INNER JOIN QuestionReply ON Staff.StaffID = QuestionReply.StaffID INNER JOIN Question ON QuestionReply.QuestionID = Question.QuestionID WHERE (Question.StudentID=214080096) AND (QuestionReply.Stutus = N'True')";

            SqlDataAdapter da = new SqlDataAdapter(strsql1, strcon);
            //   SqlCommand cmd = new SqlCommand(strsql1,strcon);
            DataSet ds = new DataSet();
            da.Fill(ds);

        
        
             return ds;

    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
     //   BindatatoGridview_ok();
     
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["QuestionReID"] = GridView1.SelectedRow.Cells[1].Text;
    }
}