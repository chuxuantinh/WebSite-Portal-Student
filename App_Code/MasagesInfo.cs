
public class Messagesinfo
{
    int _MessageID;
    string _MessageSubject;
    string _MessageNote;
    string _MessageBody;
    string _FileAttach;
    string _SenderID;
    string _CreationDate;
    string _SenderName;
    int _Note;
    int _MessageCateID;
    bool _MessageHot;

    public int MessageID { get { return _MessageID; } set { _MessageID = value; } }
    public string MessageSubject { get { return _MessageSubject; } set { _MessageSubject = value; } }
    public string MessageBody { get { return _MessageBody; } set { _MessageBody = value; } }
    public string MessageNote { get { return _MessageNote; } set { _MessageNote = value; } }
    public string FileAttach { get { return _FileAttach; } set { _FileAttach = value; } }
    public string SenderID { get { return _SenderID; } set { _SenderID = value; } }
    public int Note { get { return _Note; } set { _Note = value; } }
    public string CreationDate { get { return _CreationDate; } set { _CreationDate = value; } }
    public string SenderName { get { return _SenderName; } set { _SenderName = value; } }
    public int MessageCateID { get { return _MessageCateID; } set { _MessageCateID = value; } }
    public bool MessageHot { get { return _MessageHot; } set { _MessageHot = value; } }
}
