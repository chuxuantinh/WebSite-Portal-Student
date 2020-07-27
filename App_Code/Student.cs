using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using act;


/// <summary>
/// Summary description for Student
/// </summary>
    public class Student : connect
    {
        string _connectionString, _connectString;
        public Student()
        {

            _connectionString = strconn;// ConfigurationManager.ConnectionStrings["CoreUisConnectionString"].ConnectionString;
            _connectString = strwsconn;// ConfigurationManager.ConnectionStrings["WebConnectionString"].ConnectionString;

        }

        public DataSet Studentloggetstudentsdal(string StudentID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlConnection sqlConn = new SqlConnection(_connectionString);
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "sp_psc_ws_Studentloggetstudents";
                sqlComm.CommandType = CommandType.StoredProcedure;
                SqlParameter para;
                para = sqlComm.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                da.SelectCommand = sqlComm;
                da.Fill(ds);
                sqlConn.Close();
                return ds;
            }
            catch
            {
                return ds;
            }

        }

        public int Is_Students(string StudentID)
        {
            SqlConnection sqlConn = new SqlConnection(_connectionString);
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "sp_psc_ws_IsStudents";
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter para;
                para = sqlComm.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;
                SqlParameter paraout;
                paraout = sqlComm.Parameters.Add("@ReVal", SqlDbType.VarChar);
                paraout.Direction = ParameterDirection.Output;
                paraout.Value = 0;

                sqlComm.ExecuteNonQuery();
                return int.Parse(paraout.Value.ToString());
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConn.Close();
            }
        }


        public bool IsStudents(string UserID, string Pass)
        {
            
            return false;
            //}
        }

    }

