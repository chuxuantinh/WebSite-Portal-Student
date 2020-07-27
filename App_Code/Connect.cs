using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace act
{
    
    public class connect
    {
        #region Attribute
        public SqlConnection objconn;
        public string strconn;
        public SqlConnection objwsconn;
        public string strwsconn;
        public SqlConnection objws_conn;
        public string strws_conn;
        public SqlConnection objsrconn;
        public string strsrconn;
        
        public SqlConnection objct;
        public string strct;
        #endregion
        public SqlConnection con
        {
            get { return objconn; }
            set { objconn = value; }
        }
        public SqlConnection wscon
        {
            get { return objwsconn; }
            set { objwsconn = value; }
        }
        public SqlConnection ws_con
        {
            get { return objws_conn; }
            set { objws_conn = value; }
        }
        public SqlConnection srcon
        {
            get { return objsrconn; }
            set { objsrconn = value; }
        }

        public SqlConnection ctcon
        {
            get { return objct; }
            set { objct = value; }
        }
        #region Method

        public string connectct = "";
        public connect()
        {
            try
            {
                //strconn = ConfigurationSettings.AppSettings.Get("strconn");   

                strconn = ConfigurationManager.ConnectionStrings["CoreUisConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(strconn);
                objconn=conn;

                strwsconn =ConfigurationManager.ConnectionStrings[""].ConnectionString;
                SqlConnection wsconn = new SqlConnection(strwsconn);
                objwsconn = wsconn;

                

                strws_conn = ConfigurationManager.ConnectionStrings["WSConnectionString"].ConnectionString;
                SqlConnection ws_conn = new SqlConnection(strws_conn);
                objws_conn = ws_conn;

                strsrconn = ConfigurationManager.ConnectionStrings["SrConnectionString"].ConnectionString;
                SqlConnection srconn = new SqlConnection(strsrconn);
                objsrconn = srconn;

                strct = ConfigurationManager.ConnectionStrings["CTConnectionString"].ConnectionString;
                SqlConnection ctcon = new SqlConnection(strct);
                objct = ctcon;
            }
            catch
            {
            }
        }
        private string DecodeString(string s)
        {
            string result = string.Empty;
            if (s == string.Empty) return string.Empty;
            for (int i = 0; i < s.Length; i += 16)
            {
                string temp = string.Empty;
                for (int j = 0; j < 16; j++)
                {
                    temp += s[i + j].ToString();
                }
                result += ConvertFromBinaryToCharacter(temp);
            }
            return result;
        }
        private static string ConvertFromBinaryToCharacter(string b)
        {
            double result = 0;
            for (int i = 0; i < 16; i++)
            {
                if (b[i] == '1') result += Math.Pow(2, 15 - i);
            }
            return Convert.ToChar(Convert.ToInt32(result)).ToString();
        }

        #region Parametter
        public void SqlCommand_(SqlConnection con_, SqlCommand cmd, string sp_name)
        {
            cmd.Connection = con_;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp_name;// Ten store Procedure
        }
        public void SqlParameterInput(SqlCommand cmd, string Parameter, SqlDbType type, object Value)
        {
            SqlParameter para;
            para = cmd.Parameters.Add(Parameter, type);
            para.Direction = ParameterDirection.Input;
            para.Value = Value;
        }
        public void SqlParameterOutput(SqlCommand cmd, string Parameter, SqlDbType type, object Value)
        {
            SqlParameter para;
            para = cmd.Parameters.Add(Parameter, type);
            para.Direction = ParameterDirection.Output;
            para.Value = Value;
        }
        //Lay gia tri output sau khi thuc hien viec thuc thi den CSDL
        public object SqlParameterOutput(SqlCommand cmd, string Parameter)
        {
            object value_;
            value_ = cmd.Parameters[Parameter].Value;
            return value_;
        }
        // Gan gia tri lay ve vao DataSet 
        public DataSet ReturnData(SqlCommand cmd)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        //Danh cho update - Insert - Delete
        public bool ReturnBool(SqlCommand cmd)
        {
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }
        //Danh cho update - Insert - Delete
        public int ReturnInt(SqlCommand cmd)
        {
            int kq = 0;
            try
            {
                kq = cmd.ExecuteNonQuery();
                return kq;
            }
            catch { return kq; }
        }
        #endregion

        #endregion
    }


}
