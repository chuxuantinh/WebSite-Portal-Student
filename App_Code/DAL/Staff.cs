using System;
using System.Data;
using System.Data.SqlClient;

namespace act
{
    public class Staffdal : connect
    {
        public DataSet getPlanedStudyUnits_Staff_Regists(string Studentid, string StudyProgramid)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_getPlanedStudyUnits_Staff_Regists";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Studentid;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramid;

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

        public DataSet getPlanedStudyUnits_Staff_Improves(string Studentid, string StudyProgramid)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_getPlanedStudyUnits_Staff_Improves";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Studentid;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramid;

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

        public DataSet Group_Sel(string UserID)
        {
            DataSet ds = new DataSet();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Group_Sel";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserID;

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
                wscon.Close();
            }
        }

        public DataSet User_Sel()
        {
            DataSet ds = new DataSet();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_User_Sel";
                //

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
                wscon.Close();
            }
        }

        public DataSet UserGroup_Sel(string UserID)
        {
            DataSet ds = new DataSet();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_UserGroup_Sel";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserID;

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
                wscon.Close();
            }
        }

        public bool UserGroup_Ups(string UserID, int GroupID)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_UserGroup_Ups";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserID;

                para = cmd.Parameters.Add("@GroupID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = GroupID;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                //return ds;
                return false;
            }
            finally
            {
                wscon.Close();
            }
        }

        public DataSet UserManages_Sel(string UserID)
        {
            DataSet ds = new DataSet();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_UserManage_Sel";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserID;
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
                wscon.Close();
            }
        }

        public DataSet UserManages_Sel_All(string UserID)
        {
            DataSet ds = new DataSet();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_UserManage_Sel_all";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserID;
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
                wscon.Close();
            }
        }

        public bool UserManage_Ups(string UserID, int ManageID)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_UserManage_Ups";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserID;

                para = cmd.Parameters.Add("@ManageID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = ManageID;

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

        public DataSet UserMessageCate_Sel(string UserID, int GroupCateID)
        {
            DataSet ds = new DataSet();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_UserMessageCate_Sel";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserID;
                para = cmd.Parameters.Add("@GroupCateID", SqlDbType.TinyInt);
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
                wscon.Close();
            }
        }

        public bool UserMessageCate_Ups(string UserID, int MessageCateID)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_UserMessageCate_Ups";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@UserID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserID;

                para = cmd.Parameters.Add("@MessageCateID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = MessageCateID;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                //return ds;
                return false;
            }
            finally
            {
                wscon.Close();
            }
        }

        public DataSet StudyUnits_Sel_Conditions(string GraduateLevelID, string StudyTypeID, string YearStudy, string TermID, string DepartmentID, string CurriculumGroupID, string CourseID, string OlogyID, int IsDepartmentCurriculums)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_StudyUnits_Sel_Conditions";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@GraduateLevelID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = GraduateLevelID;
                para = cmd.Parameters.Add("@StudyTypeID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyTypeID;
                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;
                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;
                para = cmd.Parameters.Add("@DepartmentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = DepartmentID;
                para = cmd.Parameters.Add("@CurriculumGroupID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = CurriculumGroupID;
                para = cmd.Parameters.Add("@CourseID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = CourseID;
                para = cmd.Parameters.Add("@OlogyID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = OlogyID;
                para = cmd.Parameters.Add("@IsDepartmentCurriculums", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = IsDepartmentCurriculums;
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

        public DataSet StudyUnits_Sel_Conditions(string GraduateLevelID, string StudyTypeID, string YearStudy, string TermID, string DepartmentID, string CurriculumGroupID, int IsDepartmentCurriculums)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_StudyUnits_Sel_Conditions";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@GraduateLevelID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = GraduateLevelID;
                para = cmd.Parameters.Add("@StudyTypeID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyTypeID;
                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;
                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;
                para = cmd.Parameters.Add("@DepartmentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = DepartmentID;
                para = cmd.Parameters.Add("@CurriculumGroupID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = CurriculumGroupID;
                para = cmd.Parameters.Add("@IsDepartmentCurriculums", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = IsDepartmentCurriculums;
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

        public DataSet ScheduleStudyUnitWithSchedules_Sel_GraduateLevelID_StudyTypeID_YearStudy_TermID(string GraduateLevelID, string StudyTypeID, string YearStudy, string TermID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ScheduleStudyUnitWithSchedules_Sel_GraduateLevelID_StudyTypeID_YearStudy_TermID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@GraduateLevelID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = GraduateLevelID;
                para = cmd.Parameters.Add("@StudyTypeID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyTypeID;
                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;
                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;
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

        public DataSet Course_Sel_Graduatelevel_Studytype(string GraduateLevelID, string StudyTypeID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Course_Sel_Graduatelevel_Studytype";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@GraduateLevelID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = GraduateLevelID;
                para = cmd.Parameters.Add("@StudyTypeID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyTypeID;
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

        public DataSet Department_Sel_Course(string CourseID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Department_Sel_Course";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@CourseID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = CourseID;
                //
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

        public DataSet Department_Sel()
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Department_Sel";
                //
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

        public DataSet DepartmentProfessor_sel()
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_DepartmentProfessor_sel";
                //
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

        public DataSet ClassStudent_Sel_Course_Department(string CourseID, string DepartmentID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_ClassStudent_Sel_Course_Department";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@CourseID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = CourseID;
                para = cmd.Parameters.Add("@DepartmentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = DepartmentID;
                //
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

        public DataSet Student_Sel_Class(string ClassStudentID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Student_Sel_Class";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@ClassStudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ClassStudentID;
                //
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

        public DataSet Professor_Sel_DepartmentID(string DepartmentID, string SubDepartmentID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Pro_Professors_Sel_DepartmentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@DepartmentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = DepartmentID;

                para = cmd.Parameters.Add("@SubDepartmentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = SubDepartmentID;
                //
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

        public DataSet Curriculum_Sel_DepartmentID(string DepartmentID, string SubDepartmentID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Curriculum_Sel_DepartmentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@DepartmentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = DepartmentID;

                para = cmd.Parameters.Add("@SubDepartmentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = SubDepartmentID;
                //
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

        public DataSet ListStudentRegisterCurriculum_Sel(string CurriculumID, string YearStudy, string TermID, string GraduateLevelID, string StudyTypeID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ListStudentRegisterCurriculum_Sel";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@CurriculumID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = CurriculumID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = cmd.Parameters.Add("@GraduateLevelID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = GraduateLevelID;

                para = cmd.Parameters.Add("@StudyTypeID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyTypeID;
                //
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

        public DataSet ListStudentRegisterCurriculum_Sel_config(string CurriculumID, string GraduateLevelID, string StudyTypeID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ListStudentRegisterCurriculum_Sel_config";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@CurriculumID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = CurriculumID;

                para = cmd.Parameters.Add("@GraduateLevelID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = GraduateLevelID;

                para = cmd.Parameters.Add("@StudyTypeID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyTypeID;
                //
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

        public bool StaticsRegisterCurriculums_del(string RegistYearStudy, string RegistTermID)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_StaticsRegisterCurriculums_del";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@RegistYearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = RegistYearStudy;

                para = cmd.Parameters.Add("@RegistTermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = RegistTermID;
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

        public DataSet Discussion_Sel_YearStudy()
        {
            DataSet ds = new DataSet();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_discussion_Sel_YearStudy";
                //
                //
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
                wscon.Close();
            }
        }

        public DataSet Discussion_Sel_ScheduleStudyUnitID(string ScheduleStudyUnitID)
        {
            DataSet ds = new DataSet();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_discussion_Sel_ScheduleStudyUnitID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@ScheduleStudyUnitID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ScheduleStudyUnitID;

                //
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
                wscon.Close();
            }
        }

        public DataSet Discussion_Sel_Group(string YearStudy, string TermID)
        {
            DataSet ds = new DataSet();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Discussion_Sel_Group";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                //
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
                wscon.Close();
            }
        }

        public DataSet UserOnline_Sel()
        {
            DataSet ds = new DataSet();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_UserOnlines_Sel";
                //

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
                wscon.Close();
            }
        }

        public DataSet UserOnline_Sel_UserOnlineID(int UserOnlineID)
        {
            DataSet ds = new DataSet();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_UserOnlines_Sel_UserOnlineID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@UserOnlineID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = UserOnlineID;

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
                wscon.Close();
            }
        }

        public bool UserOnline_Del(int UserOnlineID)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_UserOnlines_Dels";
                //

                SqlParameter para;
                para = cmd.Parameters.Add("@UserOnlineID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = UserOnlineID;

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

        public bool UserOnline_Ins(string UserOnlineSubject, string UserOnlineName, string UserOnlineEmail, int UserOnlineOrder)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_UserOnlines_Ins";
                //

                SqlParameter para;
                para = cmd.Parameters.Add("@UserOnlineSubject", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserOnlineSubject;

                para = cmd.Parameters.Add("@UserOnlineName", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserOnlineName;

                para = cmd.Parameters.Add("@UserOnlineEmail", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserOnlineEmail;

                para = cmd.Parameters.Add("@UserOnlineOrder", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = UserOnlineOrder;

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

        public bool UserOnline_Upds(int UserOnlineID, string UserOnlineSubject, string UserOnlineName, string UserOnlineEmail, int UserOnlineOrder)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_UserOnlines_Upds";
                //

                SqlParameter para;
                para = cmd.Parameters.Add("@UserOnlineID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = UserOnlineID;

                para = cmd.Parameters.Add("@UserOnlineSubject", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserOnlineSubject;

                para = cmd.Parameters.Add("@UserOnlineName", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserOnlineName;

                para = cmd.Parameters.Add("@UserOnlineEmail", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserOnlineEmail;

                para = cmd.Parameters.Add("@UserOnlineOrder", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = UserOnlineOrder;

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

        public bool Professor_urm_upds(string ProfessorID, string PW)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Professor_urm_upds";
                //

                SqlParameter para;
                para = cmd.Parameters.Add("@ProfessorID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ProfessorID;

                para = cmd.Parameters.Add("@PW", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = PW;

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

        public DataSet Professor_urm_Sels()
        {
            DataSet ds = new DataSet();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Professor_urm_Sels";
                //


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
                wscon.Close();
            }
        }

        public DataSet Professor_urm_Sel_DepartmentID(string DepartmentID, string SubDepartmentID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Pro_Professors_urm_Sel_DepartmentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@DepartmentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = DepartmentID;

                para = cmd.Parameters.Add("@SubDepartmentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = SubDepartmentID;
                //
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

        public DataSet Professor_urm_Sel_ProfessorID(string UserName, string PW, string PWold)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Professor_urm_Sel_ProfessorID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@UserName", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserName;

                para = cmd.Parameters.Add("@PW", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = PW;

                para = cmd.Parameters.Add("@PWold", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = PWold;

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

        public string Professor_urm_Add_ProfessorID(string ProfessorID, string UserName, string PW)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Professor_urm_Add_ProfessorID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@ProfessorID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ProfessorID;

                para = cmd.Parameters.Add("@UserName", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserName;

                para = cmd.Parameters.Add("@PW", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = PW;

                SqlParameter paraout;
                paraout = cmd.Parameters.Add("@ReVal", SqlDbType.NVarChar, 255);
                paraout.Direction = ParameterDirection.Output;
                paraout.Value = "";

                cmd.ExecuteNonQuery();

                return paraout.Value.ToString();

            }
            catch
            {
                return "";
            }
            finally
            {
                con.Close();
            }
        }

        public string Professor_urm_Upd_ProfessorID(string ProfessorID, string UserName)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Professor_urm_Upd_ProfessorID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@ProfessorID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ProfessorID;

                para = cmd.Parameters.Add("@UserName", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UserName;

                SqlParameter paraout;
                paraout = cmd.Parameters.Add("@ReVal", SqlDbType.NVarChar, 255);
                paraout.Direction = ParameterDirection.Output;
                paraout.Value = "";

                cmd.ExecuteNonQuery();

                return paraout.Value.ToString();

            }
            catch
            {
                return "";
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet Professor_urm_Get_ProfessorID(string ProfessorID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Professor_urm_Get_ProfessorID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@ProfessorID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ProfessorID;

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

    }
}
