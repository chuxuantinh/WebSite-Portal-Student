using System;
using System.Data;
using System.Data.SqlClient;

namespace act
{
    public class Messagesdal : connect
    {
        public bool MessageUpdate(Messagesinfo x)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Message_Ups";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("MessageID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = x.MessageID;
                para = cmd.Parameters.Add("MessageSubject", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                if (x.MessageSubject == null)
                    para.Value = "";
                else
                    para.Value = x.MessageSubject;

                para = cmd.Parameters.Add("MessageBody", SqlDbType.NText);
                para.Direction = ParameterDirection.Input;
                if (x.MessageBody == null)
                    para.Value = "";
                else
                    para.Value = x.MessageBody;

                para = cmd.Parameters.Add("FileAttach", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                if (x.FileAttach == null)
                    para.Value = DBNull.Value;
                else
                    para.Value = x.FileAttach;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool MessageDels(int MessageID)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Message_Dels";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("MessageID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = MessageID;


                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet Messages_Sel_SenderID(string SenderId)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Messages_Sel_SenderID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("SenderId", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = SenderId;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;


            }
            catch
            {
                return ds;
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet Messages_Sel_MessageID(int MessageID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Messages_Sel_MessageID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("MessageID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = MessageID;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;


            }
            catch
            {
                return ds;
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet Message_Receiver_Sel(string ReceiverID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Message_Receiver_Sel";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("ReceiverID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ReceiverID;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;


            }
            catch
            {
                return ds;

            }
            finally
            {
                con.Close();
            }
        }

        public int Login(string SenderID, string Password)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Login";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StaffID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = SenderID;

                para = cmd.Parameters.Add("@Password", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Password;

                SqlParameter paraout;
                paraout = cmd.Parameters.Add("@ReVal1", SqlDbType.Int);
                paraout.Direction = ParameterDirection.Output;
                paraout.Value = int.MaxValue;

                cmd.ExecuteNonQuery();
                return int.Parse(paraout.Value.ToString());


            }
            catch
            {
                return 0;
            }
            finally
            {
                con.Close();

            }
        }

        public bool NewsUpdate(Messagesinfo x)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Message_Ups";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("MessageID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = x.MessageID;
                para = cmd.Parameters.Add("MessageSubject", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                if (x.MessageSubject == null)
                    para.Value = "";
                else
                    para.Value = x.MessageSubject;

                para = cmd.Parameters.Add("MessageNote", SqlDbType.NText);
                para.Direction = ParameterDirection.Input;
                if (x.MessageBody == null)
                    para.Value = "";
                else
                    para.Value = x.MessageNote;

                para = cmd.Parameters.Add("MessageBody", SqlDbType.NText);
                para.Direction = ParameterDirection.Input;
                if (x.MessageBody == null)
                    para.Value = "";
                else
                    para.Value = x.MessageBody;

                para = cmd.Parameters.Add("MessageHot", SqlDbType.Bit);
                para.Direction = ParameterDirection.Input;
                para.Value = x.MessageHot;

                para = cmd.Parameters.Add("FileAttach", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                if (x.FileAttach == null)
                    para.Value = DBNull.Value;
                else
                    para.Value = x.FileAttach;

                para = cmd.Parameters.Add("MessageCateID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                if (x.MessageCateID == null)
                    para.Value = "";
                else
                    para.Value = x.MessageCateID;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                wscon.Close();
            }
        }

        public bool NewsAdd(Messagesinfo x)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Message_Adds";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("MessageSubject", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                if (x.MessageSubject == null)
                    para.Value = "";
                else
                    para.Value = x.MessageSubject;

                para = cmd.Parameters.Add("MessageNote", SqlDbType.NText);
                para.Direction = ParameterDirection.Input;
                if (x.MessageNote == null)
                    para.Value = "";
                else
                    para.Value = x.MessageNote;

                para = cmd.Parameters.Add("MessageBody", SqlDbType.NText);
                para.Direction = ParameterDirection.Input;
                if (x.MessageBody == null)
                    para.Value = "";
                else
                    para.Value = x.MessageBody;

                para = cmd.Parameters.Add("MessageHot", SqlDbType.Bit);
                para.Direction = ParameterDirection.Input;
                para.Value = x.MessageHot;

                para = cmd.Parameters.Add("FileAttach", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                if (x.FileAttach == null)
                    para.Value = DBNull.Value;
                else
                    para.Value = x.FileAttach;

                para = cmd.Parameters.Add("Note", SqlDbType.TinyInt);
                para.Direction = ParameterDirection.Input;
                if (x.Note == null)
                    para.Value = DBNull.Value;
                else
                    para.Value = x.Note;

                para = cmd.Parameters.Add("SenderID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                if (x.SenderID == null)
                    para.Value = DBNull.Value;
                else
                    para.Value = x.SenderID;

                para = cmd.Parameters.Add("MessageCateID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                if (x.MessageCateID == null)
                    para.Value = "";
                else
                    para.Value = x.MessageCateID;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                wscon.Close();
            }
        }

        public bool NewsDel(int MessageID)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Message_Dels";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("MessageID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = MessageID;


                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                wscon.Close();
            }
        }

        public bool NewsUpdate2(Messagesinfo x)
        {
            try
            {
                ws_con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = ws_con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Message_Ups";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("MessageID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = x.MessageID;
                para = cmd.Parameters.Add("MessageSubject", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                if (x.MessageSubject == null)
                    para.Value = "";
                else
                    para.Value = x.MessageSubject;

                para = cmd.Parameters.Add("MessageNote", SqlDbType.NText);
                para.Direction = ParameterDirection.Input;
                if (x.MessageBody == null)
                    para.Value = "";
                else
                    para.Value = x.MessageNote;

                para = cmd.Parameters.Add("MessageBody", SqlDbType.NText);
                para.Direction = ParameterDirection.Input;
                if (x.MessageBody == null)
                    para.Value = "";
                else
                    para.Value = x.MessageBody;

                para = cmd.Parameters.Add("MessageHot", SqlDbType.Bit);
                para.Direction = ParameterDirection.Input;
                para.Value = x.MessageHot;

                para = cmd.Parameters.Add("FileAttach", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                if (x.FileAttach == null)
                    para.Value = DBNull.Value;
                else
                    para.Value = x.FileAttach;

                para = cmd.Parameters.Add("MessageCateID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                if (x.MessageCateID == null)
                    para.Value = "";
                else
                    para.Value = x.MessageCateID;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                ws_con.Close();
            }
        }

        public bool NewsAdd2(Messagesinfo x)
        {
            try
            {
                ws_con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = ws_con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Message_Adds";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("MessageSubject", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                if (x.MessageSubject == null)
                    para.Value = "";
                else
                    para.Value = x.MessageSubject;

                para = cmd.Parameters.Add("MessageNote", SqlDbType.NText);
                para.Direction = ParameterDirection.Input;
                if (x.MessageNote == null)
                    para.Value = "";
                else
                    para.Value = x.MessageNote;

                para = cmd.Parameters.Add("MessageBody", SqlDbType.NText);
                para.Direction = ParameterDirection.Input;
                if (x.MessageBody == null)
                    para.Value = "";
                else
                    para.Value = x.MessageBody;

                para = cmd.Parameters.Add("MessageHot", SqlDbType.Bit);
                para.Direction = ParameterDirection.Input;
                para.Value = x.MessageHot;

                para = cmd.Parameters.Add("FileAttach", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                if (x.FileAttach == null)
                    para.Value = DBNull.Value;
                else
                    para.Value = x.FileAttach;

                para = cmd.Parameters.Add("Note", SqlDbType.TinyInt);
                para.Direction = ParameterDirection.Input;
                if (x.Note == null)
                    para.Value = DBNull.Value;
                else
                    para.Value = x.Note;

                para = cmd.Parameters.Add("SenderID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                if (x.SenderID == null)
                    para.Value = DBNull.Value;
                else
                    para.Value = x.SenderID;

                para = cmd.Parameters.Add("MessageCateID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                if (x.MessageCateID == null)
                    para.Value = "";
                else
                    para.Value = x.MessageCateID;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                ws_con.Close();
            }
        }

        public bool NewsDel2(int MessageID)
        {
            try
            {
                ws_con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = ws_con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Message_Dels";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("MessageID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = MessageID;


                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                ws_con.Close();
            }
        }

        public DataSet News_Sel_SenderID(string SenderId)
        {
            DataSet ds = new DataSet();
            try
            {
                ws_con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = ws_con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Messages_Sel_SenderID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("SenderId", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = SenderId;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;


            }
            catch
            {
                return ds;
            }
            finally
            {
                ws_con.Close();
            }
        }

        public DataSet News_Sel_Message_MessageCateID(string SenderId, int GroupCateID)
        {
            DataSet ds = new DataSet();
            try
            {
                ws_con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = ws_con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Messages_Sel_Message_MessageCateID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("SenderId", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = SenderId;
                para = cmd.Parameters.Add("GroupCateID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = GroupCateID;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;


            }
            catch
            {
                return ds;
            }
            finally
            {
                ws_con.Close();
            }
        }

        public DataSet News_Sel_Message_MessageCateID(string SenderId, int GroupCateID, string Search)
        {
            DataSet ds = new DataSet();
            try
            {
                ws_con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = ws_con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Messages_Sel_Message_MessageCateID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@SenderId", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = SenderId;
                para = cmd.Parameters.Add("@GroupCateID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = GroupCateID;

                para = cmd.Parameters.Add("@Search", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Search;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;


            }
            catch
            {
                return ds;
            }
            finally
            {
                ws_con.Close();
            }
        }

        public DataSet News_Sel_MessageID(int MessageID)
        {
            DataSet ds = new DataSet();
            try
            {
                ws_con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = ws_con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Messages_Sel_MessageID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("MessageID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = MessageID;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;


            }
            catch
            {
                return ds;
            }
            finally
            {
                ws_con.Close();
            }
        }

        public DataSet News_Sel_MessageCateID(int MessageCateID, string Search)
        {
            DataSet ds = new DataSet();
            try
            {
                ws_con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = ws_con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Messages_Sel_MessageCateID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@MessageCateID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = MessageCateID;

                para = cmd.Parameters.Add("@Search", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Search;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;


            }
            catch
            {
                return ds;

            }
            finally
            {
                ws_con.Close();
            }
        }

        public DataSet News_Sel_Top(int GroupCateID, int MessageCateID)
        {
            DataSet ds = new DataSet();
            try
            {
                ws_con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = ws_con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Messages_Sel_Top";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("GroupCateID", SqlDbType.TinyInt);
                para.Direction = ParameterDirection.Input;
                para.Value = GroupCateID;

                para = cmd.Parameters.Add("MessageCateID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = MessageCateID;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;


            }
            catch
            {
                return ds;

            }
            finally
            {
                ws_con.Close();
            }
        }

        public DataSet News_Sel_Right(int GroupCateID, int MessageCateID)
        {
            DataSet ds = new DataSet();
            try
            {
                ws_con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = ws_con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Messages_Sel_Right";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("GroupCateID", SqlDbType.TinyInt);
                para.Direction = ParameterDirection.Input;
                para.Value = GroupCateID;

                para = cmd.Parameters.Add("MessageCateID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = MessageCateID;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;


            }
            catch
            {
                return ds;

            }
            finally
            {
                ws_con.Close();
            }
        }

        public DataSet News_Sel_Messages_Sel_Search(int GroupCateID, string Search)
        {
            DataSet ds = new DataSet();
            try
            {
                ws_con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = ws_con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Messages_Sel_Search";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@GroupCateID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = GroupCateID;

                para = cmd.Parameters.Add("@Search", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Search;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;


            }
            catch
            {
                return ds;

            }
            finally
            {
                ws_con.Close();
            }
        }
    }
}
