using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StudentInfo
/// </summary>
public class StudentInfo
{
	public StudentInfo()
	{
		//
		// TODO: Add constructor logic here
		//

	}
    string _StudentID;
    string _StudentPhone;
    string _StudentMobile;
    string _StudentEmail;
    string _StudentContactAdress;
    string _StudentContactWards;
    string _StudentContactDistricts;
    string _StudentContactProvinces;
    string _ContactPersonName;
    string _ContactPersonPhone;
    string _ContactPersonAddress;
    string _Note;
    string _SMSAccount1;
    string _SMSAccount2;
    bool _Boarding;
    string _Passport;
    string _HomePhone;
    string _RoomPhone;
    string _RoomNumber;
    string _FloorID;
    string _Campus;
    public string StudentID
    { get { return _StudentID; } set { _StudentID = value; } }
    public string StudentPhone
    { get { return _StudentPhone; } set { _StudentPhone = value; } }
    public string StudentMobile
    { get { return _StudentMobile; } set { _StudentMobile = value; } }
    public string StudentEmail
    { get { return _StudentEmail; } set { _StudentEmail = value; } }
    public string StudentContactAdress
    { get { return _StudentContactAdress; } set { _StudentContactAdress = value; } }
    public string StudentContactWards
    { get { return _StudentContactWards; } set { _StudentContactWards = value; } }
    public string StudentContactDistricts
    { get { return _StudentContactDistricts; } set { _StudentContactDistricts = value; } }
    public string StudentContactProvinces
    { get { return _StudentContactProvinces; } set { _StudentContactProvinces = value; } }
    public string ContactPersonName
    { get { return _ContactPersonName; } set { _ContactPersonName = value; } }
    public string ContactPersonPhone
    { get { return _ContactPersonPhone; } set { _ContactPersonPhone = value; } }
    public string ContactPersonAddress
    { get { return _ContactPersonAddress; } set { _ContactPersonAddress = value; } }
    public string Note
    { get { return _Note; } set { _Note = value; } }
    public string SMSAccount1
    { get { return _SMSAccount1; } set { _SMSAccount1 = value; } }
    public string SMSAccount2
    { get { return _SMSAccount2; } set { _SMSAccount2 = value; } }
    public bool Boarding
    { get { return _Boarding; } set { _Boarding = value; } }
    public string Passport
    { get { return _Passport; } set { _Passport = value; } }
    public string HomePhone
    { get { return _HomePhone; } set { _HomePhone = value; } }
    public string RoomPhone
    { get { return _RoomPhone; } set { _RoomPhone = value; } }
    public string RoomNumber
    { get { return _RoomNumber; } set { _RoomNumber = value; } }
    public string FloorID
    { get { return _FloorID; } set { _FloorID = value; } }
    public string Campus
    { get { return _Campus; } set { _Campus = value; } }
}