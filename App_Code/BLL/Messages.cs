using System;
using System.Data;

namespace act
{
    public class Messagesbll
    {
        public bool MessageUpdate(Messagesinfo x)
        {
            Messagesdal t = new Messagesdal();
            return t.MessageUpdate(x);
        }

        public bool MessageDels(int x)
        {
            Messagesdal t = new Messagesdal();
            return t.MessageDels(x);
        }

        public DataTable Messages_Sel_SenderID(string x)
        {
            Messagesdal t = new Messagesdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.Messages_Sel_SenderID(x);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable Message_Receiver_Sel(string x)
        {
            Messagesdal t = new Messagesdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.Message_Receiver_Sel(x);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public Messagesinfo Messages_Sel_MessageID(int id)
        {
            Messagesinfo x = new Messagesinfo();
            DataTable a = new DataTable();
            Messagesdal t = new Messagesdal();
            a = t.Messages_Sel_MessageID(id).Tables[0];
            x.MessageID = id;
            if (a.Rows[0]["MessageSubject"].ToString() != string.Empty) x.MessageSubject = a.Rows[0]["MessageSubject"].ToString();
            if (a.Rows[0]["MessageBody"].ToString() != string.Empty) x.MessageBody = a.Rows[0]["MessageBody"].ToString();
            if (a.Rows[0]["FileAttach"].ToString() != string.Empty) x.FileAttach = a.Rows[0]["FileAttach"].ToString();
            if (a.Rows[0]["MessageHot"].ToString() != string.Empty) x.MessageHot = bool.Parse(a.Rows[0]["MessageHot"].ToString());

            return x;
        }

        public int Login(string SenderID, string Password)
        {
            Messagesdal t = new Messagesdal();
            return t.Login(SenderID, Password);
        }
        #region "Thêm 2 bảng"
        public bool NewsAdd(Messagesinfo x)
        {
            Messagesdal t = new Messagesdal();
            try
            {
                //t.NewsAdd2(x);
            }
            catch { }
            return t.NewsAdd(x);
        }

        public bool NewsDel(int MessageID)
        {
            Messagesdal t = new Messagesdal();
            try
            {
                // t.NewsDel2(MessageID);
            }
            catch { }
            return t.NewsDel(MessageID);
        }

        public bool NewsUps(Messagesinfo x)
        {
            Messagesdal t = new Messagesdal();
            try
            {
                // t.NewsUpdate2(x);
            }
            catch { }
            return t.NewsUpdate(x);
        }
        #endregion
        public DataTable News_Sel_SenderID(string SenderID)
        {
            Messagesdal t = new Messagesdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.News_Sel_SenderID(SenderID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable News_Sel_Message_MessageCateID(string SenderID, int GroupCateID, string Search)
        {
            Messagesdal t = new Messagesdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.News_Sel_Message_MessageCateID(SenderID, GroupCateID, Search);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public Messagesinfo News_Sel_MessageID(int id)
        {
            Messagesinfo x = new Messagesinfo();
            DataTable a = new DataTable();
            Messagesdal t = new Messagesdal();
            a = t.News_Sel_MessageID(id).Tables[0];
            x.MessageID = id;
            if (a.Rows[0]["MessageSubject"].ToString() != string.Empty) x.MessageSubject = a.Rows[0]["MessageSubject"].ToString();
            if (a.Rows[0]["MessageBody"].ToString() != string.Empty) x.MessageBody = a.Rows[0]["MessageBody"].ToString();
            if (a.Rows[0]["MessageNote"].ToString() != string.Empty) x.MessageNote = a.Rows[0]["MessageNote"].ToString();
            if (a.Rows[0]["FileAttach"].ToString() != string.Empty) x.FileAttach = a.Rows[0]["FileAttach"].ToString();
            if (a.Rows[0]["CreationDate"].ToString() != string.Empty) x.CreationDate = a.Rows[0]["CreationDate"].ToString();
            if (a.Rows[0]["SenderName"].ToString() != string.Empty) x.SenderName = a.Rows[0]["SenderName"].ToString();
            if (a.Rows[0]["MessageCateID"].ToString() != string.Empty) x.MessageCateID = int.Parse(a.Rows[0]["MessageCateID"].ToString());
            if ((a.Rows[0]["Note"].ToString() != string.Empty) && (a.Rows[0]["Note"].ToString() == "1"))
                x.Note = 1;
            else
                x.Note = 0;
            return x;
        }

        public DataTable News_Sel_MessageCateID(int MessageCateID, string Search)
        {
            Messagesdal t = new Messagesdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.News_Sel_MessageCateID(MessageCateID, Search);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable News_Sel_MessageCateID(int MessageCateID)
        {
            Messagesdal t = new Messagesdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.News_Sel_MessageCateID(MessageCateID, "");
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable News_Sel_Top(int GroupCateID, int MessageCateID)
        {
            Messagesdal t = new Messagesdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.News_Sel_Top(GroupCateID, MessageCateID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable News_Sel_Right(int GroupCateID, int MessageCateID)
        {
            Messagesdal t = new Messagesdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.News_Sel_Right(GroupCateID, MessageCateID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable News_Sel_Messages_Sel_Search(int GroupCateID, string Search)
        {
            Messagesdal t = new Messagesdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.News_Sel_Messages_Sel_Search(GroupCateID, Search);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }
    }
}
