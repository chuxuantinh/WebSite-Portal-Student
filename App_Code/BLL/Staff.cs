using System;
using System.Data;

namespace act
{
    public class Staffbll
    {
        public DataTable getPlanedStudyUnits_Staff_Improves(string Studentid, string StudyProgramid)
        {
            Staffdal t = new Staffdal();
            return t.getPlanedStudyUnits_Staff_Improves(Studentid, StudyProgramid).Tables[0];
        }

        public DataTable getPlanedStudyUnits_Staff_Regists(string Studentid, string StudyProgramid)
        {
            Staffdal t = new Staffdal();
            return t.getPlanedStudyUnits_Staff_Regists(Studentid, StudyProgramid).Tables[0];
        }

        public DataTable Group_Sel(string UserID)
        {
            Staffdal t = new Staffdal();
            return t.Group_Sel(UserID).Tables[0];
        }

        public DataTable User_Sel()
        {
            Staffdal t = new Staffdal();
            return t.User_Sel().Tables[0];
        }

        public DataTable UserGroup_Sel(string UserID)
        {
            Staffdal t = new Staffdal();
            return t.UserGroup_Sel(UserID).Tables[0];
        }

        public bool UserGroup_Ups(string UserID, int GroupID)
        {
            Staffdal t = new Staffdal();
            return t.UserGroup_Ups(UserID, GroupID);
        }

        public DataTable UserManages_Sel(string UserID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.UserManages_Sel(UserID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable UserManages_Sel_All(string UserID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.UserManages_Sel_All(UserID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public bool UserManage_Ups(string UserID, int GroupID)
        {
            Staffdal t = new Staffdal();
            return t.UserManage_Ups(UserID, GroupID);
        }

        public DataTable UserMessageCate_Sel(string UserID, int GroupCateID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.UserMessageCate_Sel(UserID, GroupCateID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public bool UserMessageCate_Ups(string UserID, int MessageCateID)
        {
            Staffdal t = new Staffdal();
            return t.UserMessageCate_Ups(UserID, MessageCateID);
        }

        public DataTable StudyUnits_Sel_Conditions(string GraduateLevelID, string StudyTypeID, string YearStudy, string TermID, string DepartmentID, string CurriculumGroupID, string CourseID, string OlogyID, int IsDepartmentCurriculums)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.StudyUnits_Sel_Conditions(GraduateLevelID, StudyTypeID, YearStudy, TermID, DepartmentID, CurriculumGroupID, CourseID, OlogyID, IsDepartmentCurriculums);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable StudyUnits_Sel_Conditions(string GraduateLevelID, string StudyTypeID, string YearStudy, string TermID, string DepartmentID, string CurriculumGroupID, int IsDepartmentCurriculums)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.StudyUnits_Sel_Conditions(GraduateLevelID, StudyTypeID, YearStudy, TermID, DepartmentID, CurriculumGroupID, IsDepartmentCurriculums);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable ScheduleStudyUnitWithSchedules_Sel_GraduateLevelID_StudyTypeID_YearStudy_TermID(string GraduateLevelID, string StudyTypeID, string YearStudy, string TermID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.ScheduleStudyUnitWithSchedules_Sel_GraduateLevelID_StudyTypeID_YearStudy_TermID(GraduateLevelID, StudyTypeID, YearStudy, TermID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable Course_Sel_Graduatelevel_Studytype(string GraduateLevelID, string StudyTypeID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.Course_Sel_Graduatelevel_Studytype(GraduateLevelID, StudyTypeID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable Department_Sel_Course(string CourseID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.Department_Sel_Course(CourseID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable Department_Sel()
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.Department_Sel();
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable DepartmentProfessor_sel()
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.DepartmentProfessor_sel();
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable ClassStudent_Sel_Course_Department(string CourseID, string DepartmentID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.ClassStudent_Sel_Course_Department(CourseID, DepartmentID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable Student_Sel_Class(string ClassStudentID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.Student_Sel_Class(ClassStudentID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable Professor_Sel_DepartmentID(string DepartmentID, string SubDepartmentID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            if (SubDepartmentID == "#")
                ds = t.Professor_Sel_DepartmentID(DepartmentID, null);
            else
                ds = t.Professor_Sel_DepartmentID(DepartmentID, SubDepartmentID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable Curriculum_Sel_DepartmentID(string DepartmentID, string SubDepartmentID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.Curriculum_Sel_DepartmentID(DepartmentID, SubDepartmentID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable ListStudentRegisterCurriculum_Sel(string CurriculumID, string YearStudy, string TermID, string GraduateLevelID, string StudyTypeID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.ListStudentRegisterCurriculum_Sel(CurriculumID, YearStudy, TermID, GraduateLevelID, StudyTypeID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable ListStudentRegisterCurriculum_Sel_config(string CurriculumID, string GraduateLevelID, string StudyTypeID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.ListStudentRegisterCurriculum_Sel_config(CurriculumID, GraduateLevelID, StudyTypeID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public bool StaticsRegisterCurriculums_del(string RegistYearStudy, string RegistTermID)
        {
            Staffdal t = new Staffdal();
            return t.StaticsRegisterCurriculums_del(RegistYearStudy, RegistTermID);
        }

        public DataTable Discussion_Sel_ScheduleStudyUnitID(string ScheduleStudyUnitID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.Discussion_Sel_ScheduleStudyUnitID(ScheduleStudyUnitID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable Discussion_Sel_Group(string YearStudy, string TermID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.Discussion_Sel_Group(YearStudy, TermID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable Discussion_Sel_YearStudy()
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.Discussion_Sel_YearStudy();
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public bool Professor_urm_upds(string ProfessorID, string PW)
        {
            Staffdal t = new Staffdal();
            return t.Professor_urm_upds(ProfessorID, PW);
        }

        public DataTable Professor_urm_Sels()
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.Professor_urm_Sels();
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable Professor_urm_Get_ProfessorID(string ProfessorID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.Professor_urm_Get_ProfessorID(ProfessorID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public DataTable Professor_urm_Sel_DepartmentID(string DepartmentID, string SubDepartmentID)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            if (SubDepartmentID == "#")
                ds = t.Professor_urm_Sel_DepartmentID(DepartmentID, null);
            else
                ds = t.Professor_urm_Sel_DepartmentID(DepartmentID, SubDepartmentID);
            if (ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }

        public string Professor_urm_Sel_ProfessorID(string UserName, string PW, string PWold)
        {
            Staffdal t = new Staffdal();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = t.Professor_urm_Sel_ProfessorID(UserName, PW, PWold);
            if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0 && dt.Rows[0]["ProfessorID"].ToString() != string.Empty)
                    return dt.Rows[0]["ProfessorID"].ToString();
                else
                    return "0";

            }
            else
                return "0";
        }

        public string Professor_urm_Add_ProfessorID(string ProfessorID, string UserName, string PW)
        {
            Staffdal t = new Staffdal();
            return t.Professor_urm_Add_ProfessorID(ProfessorID, UserName, PW);

        }

        public string Professor_urm_Upd_ProfessorID(string ProfessorID, string UserName)
        {
            Staffdal t = new Staffdal();
            return t.Professor_urm_Upd_ProfessorID(ProfessorID, UserName);

        }
    }
}
