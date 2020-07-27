using System;
using System.Data;
using System.Data.SqlClient;

namespace act
{
    public class Webservicedal : connect
    {
        #region Professors

        #region DataTable GetScheduleStudyUnitRequirements(string ProfessorID, string TermID, string YearStudy)
        public DataTable GetScheduleStudyUnitRequirements(string ProfessorID, string TermID, string YearStudy)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_ScheduleStudyUnitRequirements";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@ProfessorID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ProfessorID;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }
        #endregion

        #region DataTable GetScheduleStudyUnitsAssignedToProfessor(string ProfessorID, string TermID, string YearStudy)
        public DataTable GetScheduleStudyUnitsAssignedToProfessor(string ProfessorID, string TermID, string YearStudy)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_ScheduleStudyUnitsAssignedToProfessor";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@ProfessorID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ProfessorID;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                SqlDataAdapter da = new SqlDataAdapter();

                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;


            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }
        #endregion

        #region GetSchedulebyInspector(string inspectorID, string  fromDate , string todate , int shiftID, string buildingID)
        public DataTable GetSchedulebyInspector(string inspectorID, string fromDate, string todate, int shiftID, string buildingID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_GetScheduleByInspector";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@InspectorID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = inspectorID;

                para = cmd.Parameters.Add("@ShiftID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = shiftID;

                para = cmd.Parameters.Add("@FromDate", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = fromDate;

                para = cmd.Parameters.Add("@ToDate", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = todate;

                para = cmd.Parameters.Add("@BuildingID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = buildingID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;


            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GetScheduleForStudentbyInspector(string inspectorID, string  fromDate , string todate , int shiftID, string buildingID)
        public DataTable GetScheduleForStudentbyInspector(string inspectorID, string fromDate, string todate, int shiftID, string buildingID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_GetScheduleForStudentByInspector";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@InspectorID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = inspectorID;

                para = cmd.Parameters.Add("@ShiftID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = shiftID;

                para = cmd.Parameters.Add("@FromDate", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = fromDate;

                para = cmd.Parameters.Add("@ToDate", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = todate;

                para = cmd.Parameters.Add("@BuildingID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = buildingID;

                SqlDataAdapter da = new SqlDataAdapter();

                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;


            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GetSumTeachPeriods(string  fromDate , string todate )
        public DataTable GetSumTeachPeriods(string fromDate, string todate)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_SumProfessorWeek";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@FromDate", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = fromDate;

                para = cmd.Parameters.Add("@ToDate", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = todate;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;


            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region GetProfessorWeekSchedules(string professorID, string fromDate, string toDate)
        public DataTable GetProfessorWeekSchedules(string professorID, string YearStudy, string TermID)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.sp_psc_ProfessorWeekSchedules_Sel_ProfessorID_YearSTudy_TermID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@ProfessorID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = professorID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }
        #endregion

        #endregion

        #region Configs
        #region DataTable GetYearStudyAndTermID(string StudentID)
        public DataTable GetYearStudyAndTermID(string StudentID)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_GetYearStudyAndTerm";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();

                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }
        #endregion

        #region DataTable GetYearStudyAndTermID(string StudentID)
        public DataTable GetYearStudyAndTermID()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_GetYearStudyAndTerm_All";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }
        #endregion
        #endregion

        #region Students
        #region string UpdateStudentScheduleStudyUnit(Entities.StudentClassStudyUnits _studentClassStudyUnits)
       
        public string CurriculumSelection_check(string StudentID, string StudyUnitID, string StudyProgramID)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_CurriculumSelection_check";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyUnitID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyUnitID;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

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
        #endregion

      
        #endregion

        public DataTable SearchCurriculums(string strFilter)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_SearchCurriculums";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@strFilter", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = strFilter;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }
        public DataTable StudentStudyUnitAssignmentdetails(string StudentID, string StudyUnitID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_StudentStudyUnitAssignmentdetails";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyUnitID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyUnitID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

      

        #region "Dataset"
        public DataTable GetPlanedStudyUnits_Repeat(string StudentID, string StudyProgramID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_getPlanedStudyUnitforRepayments";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetPlanedScheduleStudyUnits_Repeat(string StudentID, string StudyUnitID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ListScheduleStudyUnitForRepayment_Sel_StudyUnitID_StudentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyUnitID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyUnitID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable NewListRegisteredScheduleStudyUnitsByStudentID(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "NewListRegisteredScheduleStudyUnitsByStudentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable NewListRegisteredScheduleStudyUnitsByStudentID(string StudentID, string StudyProgramID, string Option)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "NewListRegisteredScheduleStudyUnitsByStudentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

                para = cmd.Parameters.Add("@Option", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Option;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable getNotAccumulateCurriculums(string StudentID, string StudyProgramID)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_getNotAccumulateCurriculums";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable StudyPrograms_Sel_StudentID(string StudentID)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_StudyPrograms_Sel_StudentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetAccountInfoByID(string AccountID)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAccountInfoByID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@AccountID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = AccountID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetAccountBalanceByID(string AccountID)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAccountBalanceByID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@AccountID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = AccountID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetTransactionByAccountID(string AccountID)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetTransactionByAccountID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@AccountID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = AccountID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetTransactions(string AccountID)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_GetTransactions";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@AccountID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = AccountID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable NewListRegisteredScheduleStudyUnitsByStudentID_print(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "NewListRegisteredScheduleStudyUnitsByStudentID_print";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetListRegisteredScheduleStudyUnitsByStudentID(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "NewListRegisteredScheduleStudyUnitsByStudentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetListRegisteredScheduleStudyUnitsByStudentID_print(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "NewListRegisteredScheduleStudyUnitsByStudentID_print";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable NewListRegisteredScheduleStudyUnitsByStudentID_Bill(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "NewListRegisteredScheduleStudyUnitsByStudentID_Bill";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetListScheduleStudyUnitByStudyUnitIDStudentID(string StudyUnitID, string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ListScheduleStudyUnit_Sel_StudyUnitID_StudentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyUnitID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyUnitID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetListScheduleStudyUnit_Sel_StudyUnitID_StudentID_Staff(string StudyUnitID, string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ListScheduleStudyUnit_Sel_StudyUnitID_StudentID_Staff";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyUnitID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyUnitID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetListScheduleStudyUnit_Sel_Curriculum_StudentID(string CurriculumID, string YearStudy, string TermID, string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ListScheduleStudyUnit_Sel_Curriculum_StudentID";
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

                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetPlanedStudyUnits(string StudentID, string StudyProgramID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_getPlanedStudyUnits";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetNotPlanedStudyUnits(string StudentID, string StudyProgramID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_getNotPlanedStudyUnits";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetPlanedStudyUnits_improve(string StudentID, string StudyProgramID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_getPlanedStudyUnits_improve";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetCurriculumStudyProgramsByStudentID(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_CurriculumStudyPrograms_Sel_StudentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetCurriculumStudyProgramsByStudentID_2(string StudyProgramID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEB_CurriculumStudyPrograms_Sel_StudyProgramID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetCurriculumStudyProgramsByStudentID_3(string StudyProgramID, string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEB_CurriculumStudyPrograms_Sel_StudyProgramID_StudentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }


        public DataTable GraduateLevels_Sel()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Dic_GraduateLevels_Sel";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable StudyTypes_Sel()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Dic_StudyTypes_Sel";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Departments_Sel()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Dic_Departments_Sel";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Dic_Terms_Sel()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Dic_Terms_Sel";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Dic_Campus_Sel()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Dic_Campus_Sel";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Dic_Periods_Sel()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Dic_Periods_Sel";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable CourseInfo_Sel()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_CourseInfo_Sel";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Dic_Buildings_Sel()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Dic_Buildings_Sel";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Dic_Buildings_Sel_CampusID(string CampusID)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Dic_Buildings_Sel_CampusID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@CampusID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = CampusID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Rooms_Sel_BuildingID(string BuildingID)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Rooms_SelByBuildingID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@BuildingID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = BuildingID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable CurriculumGroups_Sel()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_CurriculumGroups_Sel";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable rpt_QLDT0022(string Year)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_rpt_QLDT0022";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@year", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Year;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable rpt_QLDT0018(string Year)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_rpt_QLDT0018";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@year", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Year;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable rpt_QLDT0016(string Year)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_rpt_QLDT0016";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@year", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Year;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable rpt_QLDT0011()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_rpt_QLDT0011";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable rpt_QLDT0010()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_rpt_QLDT0010";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ReportConfig()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ReportConfig";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Weeks_Sel()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_Weeks_Sel";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetStudentInfomationByID(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_GetStudentInfomationByID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetStudyProgramsByStudentID(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_StudyPrograms_Sel_StudentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable Authenticated_Sel_UID(string ID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_UID_Authenticated_Sel_UID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetStudentInfoByID(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_GetStudentInfoByID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetBehaviorScoresByParentIDNull(string TermID, string StudentID, string ClassStudentID, string YearStudy)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetBehaviorScoresByParentIDNull";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@ClassStudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ClassStudentID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetBehaviorScoresByParentID(string TermID, string StudentID, string ClassStudentID, string YearStudy)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetBehaviorScoresByParentIDNull";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@ClassStudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ClassStudentID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetClassStudentsByID(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ClassStudents_Sel_StudentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public bool StudentBehaviorScore_Save(string StudentID, string ClassStudentID, string YearStudy, string TermID, int EvaluateID, int IndividualScore)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_StudentBehaviorScore_Save";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@ClassStudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ClassStudentID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = cmd.Parameters.Add("@EvaluateID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = EvaluateID;

                para = cmd.Parameters.Add("@IndividualScore", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = IndividualScore;

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

        public DataTable GetStudentScoresByID(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetStudentScoresByID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetStudentScheduleByID(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_GetStudentScheduleByID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetStudentScoresByID_Sum(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetStudentScoresByID_Sum";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetStudentScoresNoteByID(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetStudentScoresNoteByID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetStudentScoresStudyProgramByID(string StudentID, string StudyProgramID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetStudentScoresStudyProgramByID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetStudentScoresStudyProgramByID_2(string StudentID, string StudyProgramID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetStudentScoresStudyProgramByID_2";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable Online_LayMonHocPhucKhao(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Online_LayMonHocPhucKhao";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable Online_DanhSachDangKyPhucKhao_SinhVien_sel(string StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Online_DanhSachDangKyPhucKhao_SinhVien_sel";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable Online_TraCuuDangKyPhucKhao_sel(string TuNgay, string DenNgay)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Online_TraCuuDangKyPhucKhao_sel";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@TuNgay", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TuNgay;

                para = cmd.Parameters.Add("@DenNgay", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = DenNgay;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public int Online_DangKyPhucKhao_ups(string XmlData, string UpdateStaff)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Online_DangKyPhucKhao_ups";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@XmlData", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = XmlData;

                para = cmd.Parameters.Add("@UpdateStaff", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UpdateStaff;

                SqlParameter paraout;
                paraout = cmd.Parameters.Add("@ReVal", SqlDbType.NVarChar, 255);
                paraout.Direction = ParameterDirection.Output;
                paraout.Value = DBNull.Value;

                cmd.ExecuteNonQuery();
                return int.Parse(paraout.Value.ToString());

            }
            catch
            {
                return 1;
            }
            finally
            {
                con.Close();
            }

        }



        public DataTable sp_Web_KiemTraHocKyDaCoDiemHetChua(string StudentID, string StudyProgramID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Web_KiemTraHocKyDaCoDiemHetChua";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }


        public DataTable GetStudentScoresStudyProgramByID_Sum(string StudentID, string StudyProgramID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetStudentScoresStudyProgramByID_Sum";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetStudentScoresStudyProgramNoteByID(string StudentID, string StudyProgramID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetStudentScoresStudyProgramNoteByID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@StudyProgramID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyProgramID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetCurriculumLiteraturesByCurriculumID(string CurriculumID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_CurriculumLiteratures_Sel_CurriculumID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@CurriculumID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = CurriculumID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable Authenticated_Sel_Principal(string ID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Authenticated_Sel_Principal";

                SqlParameter para;
                para = cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable GetProfessorsByID(string ProfessorID)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Professors_Sel_ProfessorID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@ProfessorID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ProfessorID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable SystemConfig_Sel()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_SystemConfig_String_Sel";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Professor_Search(string Search)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Professor_Search";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@Search", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Search;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Students_Sel_Search(string Search)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc1_Students_Sel_Search";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@Search", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Search;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }

        public DataSet Student_Sel_Ology_Year_Term(string YearStudy, string Term, string Ology)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Student_Sel_Ology_Year_Term";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@Term", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Term;

                para = cmd.Parameters.Add("@Ology", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Ology;

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

        public DataSet ProfessorScheduleStudyUnits_Sel_ByTerms(string ProfessorID, string YearStudy, string Term)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Sch_ProfessorScheduleStudyUnits_Sel_ByTerms";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@Term", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Term;

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

        public DataSet WeeksStudy_Sel_YearStudy_TermID(string YearStudy, string Term)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_WeeksStudy_Sel_YearStudy_TermID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@Term", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Term;

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

        public DataSet ProfessorWeekSchedules_Sel_ProfessorID_FromDate_ToDate(string ProfessorID, string FromDate, string ToDate)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ProfessorWeekSchedules_Sel_ProfessorID_FromDate_ToDate";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@ProfessorID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ProfessorID;

                para = cmd.Parameters.Add("@FromDate", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = FromDate;

                para = cmd.Parameters.Add("@ToDate", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ToDate;

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

        #endregion

        #region KhaoSatMonHoc
        public DataTable sp_WEBKS_PhieuKhaoSat_sel(string MaPhieu)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_PhieuKhaoSat_sel";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable sp_WEBKS_NhomKhaoSat_sel(string MaPhieuKhaoSat)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_NhomKhaoSat_sel";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaPhieuKhaoSat", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieuKhaoSat;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable sp_WEBKS_CauHoiKhaoSat_sel(string MaNhom, string MaPhieu)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_CauHoiKhaoSat_sel";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaNhom", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaNhom;

                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable Sp_WEBKS_CauTraLoiKhaoSat_sel(string MaCauHoi)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_WEBKS_CauTraLoiKhaoSat_sel";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaCauHoi", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaCauHoi;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public bool sp_WEBKS_LuuDuLieuKhaoSat_2(string MaSinhVien
           , string MaCauHoi
           , string MaDapAn
           , DateTime NgayTraLoi
           , string GhiChuTraLoiMo
           , string MaPhieuKhaoSat)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_LuuDuLieuKhaoSat_2";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaSinhVien", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaSinhVien;

                para = cmd.Parameters.Add("@MaCauHoi", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaCauHoi;

                para = cmd.Parameters.Add("@MaDapAn", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaDapAn;

                para = cmd.Parameters.Add("@NgayTraLoi", SqlDbType.SmallDateTime);
                para.Direction = ParameterDirection.Input;
                para.Value = NgayTraLoi;

                para = cmd.Parameters.Add("@GhiChuTraLoiMo", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = GhiChuTraLoiMo;

                para = cmd.Parameters.Add("@MaPhieuKhaoSat", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieuKhaoSat;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                wscon.Close();
            }

        }
        //Sp_WEBKS_CauTraLoiKhaoSat_sel(@MaCauHoi int)
        public bool sp_WEBKS_NhomKhaoSat_ups(string MaNhom, string TenNhom, string ThuTu, string TieuDe)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_NhomKhaoSat_ups";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaNhom", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaNhom;

                para = cmd.Parameters.Add("@TenNhom", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TenNhom;

                para = cmd.Parameters.Add("@ThuTu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ThuTu;

                para = cmd.Parameters.Add("@TieuDe", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TieuDe;



                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                wscon.Close();
            }

        }
        /// <summary>
        /// MaNhom =-1 đê lấy tất cả
        /// </summary>
        /// <param name="MaNhom"></param>
        /// <returns></returns>
        public DataTable sp_WEBKS_NhomKhaoSat_MaNhom_sel(string MaNhom)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_NhomKhaoSat_MaNhom_sel";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaNhom", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaNhom;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        /// <summary>
        /// MaNhom =-1 đê xóa tất cả
        /// </summary>
        /// <param name="MaNhom"></param>
        /// <returns></returns>
        public bool sp_WebKS_NhomKhaoSat_del(string MaNhom)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WebKS_NhomKhaoSat_del";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaNhom", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaNhom;

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

        public DataTable sp_WEBKS_CauHoiKhaoSat_MaCauHoi_sel(string MaCauHoi)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_CauHoiKhaoSat_MaCauHoi_sel";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaCauHoi", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaCauHoi;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public bool sp_WEBKS_CauHoiKhaoSat_MaCauHoi_ups(string MaCauHoi, string MaNhom, string TenCauHoi, bool HienThi, string LoaiCauHoi, string ThuTu)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_CauHoiKhaoSat_MaCauHoi_ups";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaCauHoi", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaCauHoi;

                para = cmd.Parameters.Add("@MaNhom", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaNhom;

                para = cmd.Parameters.Add("@TenCauHoi", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TenCauHoi;


                para = cmd.Parameters.Add("@HienThi", SqlDbType.Bit);
                para.Direction = ParameterDirection.Input;
                para.Value = HienThi;

                para = cmd.Parameters.Add("@LoaiCauHoi", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = LoaiCauHoi;

                para = cmd.Parameters.Add("@ThuTu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ThuTu;

                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable sp_WEBKS_DapAnKhaoSat_sel(string MaDapAn)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_DapAnKhaoSat_sel";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaDapAn", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaDapAn;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch (Exception exx)
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable sp_psc_Courses_Sel()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Courses_Sel";


                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch (Exception exx)
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }


        public bool sp_WEBKS_DapAnKhaoSat_ups(string MaDapAn
           , string TenDapAn
           , string MaCauHoi
           , string Cap)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_DapAnKhaoSat_ups";

                SqlParameter para;

                para = cmd.Parameters.Add("@MaDapAn", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaDapAn;

                para = cmd.Parameters.Add("@TenDapAn", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TenDapAn;

                para = cmd.Parameters.Add("@MaCauHoi", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaCauHoi;

                para = cmd.Parameters.Add("@Cap", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Cap;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                wscon.Close();
            }

        }

        public bool sp_WEBKS_PhieuKhaoSat_ups(string MaPhieu, string Tenphieu, string KhoaHoc, DateTime NgayBatDau, DateTime NgayKetThuc
    , string NamHoc, string HocKy)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_PhieuKhaoSat_ups";

                SqlParameter para;

                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;

                para = cmd.Parameters.Add("@Tenphieu", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Tenphieu;

                para = cmd.Parameters.Add("@KhoaHoc", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = KhoaHoc;

                para = cmd.Parameters.Add("@NgayBatDau", SqlDbType.SmallDateTime);
                para.Direction = ParameterDirection.Input;
                para.Value = NgayBatDau;

                para = cmd.Parameters.Add("@NgayKetThuc", SqlDbType.SmallDateTime);
                para.Direction = ParameterDirection.Input;
                para.Value = NgayKetThuc;

                para = cmd.Parameters.Add("@NamHoc", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = NamHoc;

                para = cmd.Parameters.Add("@HocKy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = HocKy;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                wscon.Close();
            }

        }


        public DataTable Sp_WEBKS_CauHoiVaoPhieuKhaoSat(string MaPhieu)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_WEBKS_CauHoiVaoPhieuKhaoSat";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch (Exception exx)
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public bool sp_WEBKS_LuuCauHoiPhieuKhaoSat(string MaPhieu, string MaCauHoi, string ThuTuCauHoi, string isDelete)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_LuuCauHoiPhieuKhaoSat";

                SqlParameter para;

                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;

                para = cmd.Parameters.Add("@MaCauHoi", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaCauHoi;

                para = cmd.Parameters.Add("@ThuTuCauHoi", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ThuTuCauHoi;

                para = cmd.Parameters.Add("@isDelete", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = isDelete;


                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                wscon.Close();
            }

        }

        ///////////////////////////////////////
        public DataTable sp_WEBKS_Thongtinkhaosat(string MaLopHocPhan, string MaPhieu)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_Thongtinkhaosat";

                SqlParameter para;

                para = cmd.Parameters.Add("@MaLopHocPhan", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaLopHocPhan;

                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;


                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch (Exception exx)
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable sp_WEB_KetQuaKhaoSatMo(string MaPhieu, string MaLopHocPhan)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEB_KetQuaKhaoSatMo";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;

                para = cmd.Parameters.Add("@MaLopHocPhan", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaLopHocPhan;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch (Exception exx)
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable sp_WEBKS_CauHoiKhaoSatTheoLoai(string LoaiCauHoi, string MaPhieu)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_CauHoiKhaoSatTheoLoai";

                SqlParameter para;
                para = cmd.Parameters.Add("@LoaiCauHoi", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = LoaiCauHoi;

                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch (Exception exx)
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable SP_WEBKS_LIETKECAUHOI_THONGKE(string MaPhieu)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_WEBKS_LIETKECAUHOI_THONGKE";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch (Exception exx)
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable sp_WEBKS_SinhVienTrongDotKhaoSat(string MaPhieu)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_SinhVienTrongDotKhaoSat";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch (Exception exx)
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable sp_WEBKS_SinhVienKetQuaDotKhoaSat(string MaPhieu)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_WEBKS_SinhVienKetQuaDotKhoaSat";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch (Exception exx)
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable sp_WEBKS_CauHinhKhaoSat(string maCauHinh)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_WEBKS_CauHinhKhaoSat";

                SqlParameter para;
                para = cmd.Parameters.Add("@maCauHinh", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = maCauHinh;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch (Exception exx)
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public string sp_psc_WEBKS_CauHinhKhaoSat_up(string MaCauHinh, string Noidung)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_WEBKS_CauHinhKhaoSat_up";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaCauHinh", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaCauHinh;

                para = cmd.Parameters.Add("@Noidung", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = Noidung;

                SqlParameter paraout;
                paraout = cmd.Parameters.Add("@Reval", SqlDbType.NVarChar, 255);
                paraout.Direction = ParameterDirection.Output;
                paraout.Value = "";

                cmd.ExecuteNonQuery();
                return paraout.Value.ToString();

            }
            catch (Exception exx)
            {
                return "ERROR";
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable Districts_Sel()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Districts_Sel";
                //

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable Provinces_Sel()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_Provinces_Sel";
                //

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable SP_WEBKS_THONGKE(string MaPhieu)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_WEBKS_THONGKE";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch (Exception exx)
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable Sp_WEBKS_XuatKetQuaKhaoSatMo(string MaPhieu)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_WEBKS_XuatKetQuaKhaoSatMo";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch (Exception exx)
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }

        public DataTable Sp_WEBKS_TongSinhVienDaThucHienKhaoSat(string MaPhieu)
        {
            DataTable dt = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_WEBKS_TongSinhVienDaThucHienKhaoSat";

                SqlParameter para;
                para = cmd.Parameters.Add("@MaPhieu", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MaPhieu;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;

            }
            catch (Exception exx)
            {
                return dt;
            }
            finally
            {
                wscon.Close();
            }

        }
        #endregion

        #region sinh vien ghi
        public DataTable sp_web_psc_ConfigStudentEnrolls(String StudentID)
        {
            DataSet ds = new DataSet();
            DataTable tb = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_web_psc_ConfigStudentEnrolls";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);

                tb = ds.Tables.Count > 0 ? ds.Tables[0] : tb;
                return tb;


            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return tb;
            }
            finally
            {
                wscon.Close();
            }
        }

        public DataTable sp_web_ListCurriculumStudentEnrolls(String YearStudy, string TermID, string StudentID, string StrFilter, int FindID)
        {
            DataSet ds = new DataSet();
            DataTable tb = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_web_ListCurriculumStudentEnrolls";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;


                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;


                para = cmd.Parameters.Add("@StrFilter", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StrFilter;


                para = cmd.Parameters.Add("@FindID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = FindID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);

                tb = ds.Tables.Count > 0 ? ds.Tables[0] : tb;
                return tb;

            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return tb;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable sp_web_psc_ConfigStudentEnrolls_sel()
        {
            DataSet ds = new DataSet();
            DataTable tb = new DataTable();
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_web_psc_ConfigStudentEnrolls_sel";
                //

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);

                tb = ds.Tables.Count > 0 ? ds.Tables[0] : tb;
                return tb;


            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return tb;
            }
            finally
            {
                wscon.Close();
            }
        }

        public bool sp_web_ConfigStudentEnrolls_up(string GraduateLevelID, string StudyTypeID, string YearStudy, string TermID, string BeginDate, string EndDate, int IsDelete)
        {
            try
            {
                wscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = wscon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_web_ConfigStudentEnrolls_up";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@GraduateLevelID", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = GraduateLevelID;

                para = cmd.Parameters.Add("@StudyTypeID", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudyTypeID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = cmd.Parameters.Add("@BeginDate", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = BeginDate;

                para = cmd.Parameters.Add("@EndDate", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = EndDate;

                para = cmd.Parameters.Add("@IsDelete", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = IsDelete;


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

        public bool sp_ws_psc_ws_StudentEnrolls_ins(string StudentID, string YearStudy, string TermID, string CurriculumID, int IsDelete)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ws_psc_ws_StudentEnrolls_ins";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@StudentID", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = cmd.Parameters.Add("@CurriculumID", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = CurriculumID;

                para = cmd.Parameters.Add("@IsDelete", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = IsDelete;

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

        public DataTable sp_ws_ThongKeSinhVienGhiDanh(string YearStudy, string TermID)
        {
            DataSet ds = new DataSet();
            DataTable tb = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ws_ThongKeSinhVienGhiDanh";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);

                tb = ds.Tables.Count > 0 ? ds.Tables[0] : tb;
                return tb;


            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return tb;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable sp_ws_ListStudentEnrollByCurriculumID_sel(string YearStudy, string TermID, string CurriculumID)
        {
            DataSet ds = new DataSet();
            DataTable tb = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ws_ListStudentEnrollByCurriculumID_sel";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = cmd.Parameters.Add("@CurriculumID", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = CurriculumID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);

                tb = ds.Tables.Count > 0 ? ds.Tables[0] : tb;
                return tb;


            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return tb;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable sp_ws_DanhSachGhiDanhCuaSinhVien(string StudentID)
        {
            DataSet ds = new DataSet();
            DataTable tb = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ws_DanhSachGhiDanhCuaSinhVien";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@StudentID", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);

                tb = ds.Tables.Count > 0 ? ds.Tables[0] : tb;
                return tb;


            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return tb;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region "StudentBehaviorScores"
        #region public string StudentBehaviorScoresbyStudentID_Insert(string StudentID, string xml)
        public string StudentBehaviorScoresbyStudentID_Insert(string StudentID, string xml)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_StudentBehaviorScoresbyStudentID_Insert";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@Xml", SqlDbType.Xml);
                para.Direction = ParameterDirection.Input;
                para.Value = xml;

                SqlParameter paraout;
                paraout = cmd.Parameters.Add("@ReVal", SqlDbType.NVarChar, 255);
                paraout.Direction = ParameterDirection.Output;
                paraout.Value = "";

                cmd.ExecuteNonQuery();

                return paraout.Value.ToString();
            }
            catch
            {
                //throw new Exception(ex.Message);
                return "";
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region public string StudentBehaviorScoresbyStudentIDClassScore_Insert(string StudentID, string xml)
        public string StudentBehaviorScoresbyStudentIDClassScore_Insert(string StudentID, string xml)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_StudentBehaviorScoresbyStudentIDClassScore_Insert";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@Xml", SqlDbType.Xml);
                para.Direction = ParameterDirection.Input;
                para.Value = xml;

                SqlParameter paraout;
                paraout = cmd.Parameters.Add("@ReVal", SqlDbType.NVarChar, 255);
                paraout.Direction = ParameterDirection.Output;
                paraout.Value = "";

                cmd.ExecuteNonQuery();

                return paraout.Value.ToString(); ;
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
        #endregion

        #region public DataTable StudentBehaviorScoreDetailsbyStudent_sel(string StudentID, string YearStudy, string TermID, string BehaviorDetailID, string MemberType)
        public DataTable StudentBehaviorScoreDetailsbyStudent_sel(string StudentID, string YearStudy, string TermID, string BehaviorDetailID, string MemberType)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_StudentBehaviorScoreDetailsbyStudent_sel";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = cmd.Parameters.Add("@BehaviorDetailID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = BehaviorDetailID;

                para = cmd.Parameters.Add("@MemberType", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = MemberType;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region public DataTable BehaviorScoreDetailbyID_sel(string BehaviorDetailID)
        public DataTable BehaviorScoreDetailbyID_sel(string BehaviorDetailID)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_BehaviorScoreDetailbyID_sel";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@BehaviorDetailID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = BehaviorDetailID;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region public bool StudentBehaviorScoreDetailsbyStudent_Add(string StudentID, string YearStudy, string TermID, string BehaviorDetailID, string StudentBSDetailName, string StudentBSDetailType)
        public bool StudentBehaviorScoreDetailsbyStudent_Add(string StudentID, string YearStudy, string TermID, string BehaviorDetailID, string StudentBSDetailName, string StudentBSDetailType)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_StudentBehaviorScoreDetailsbyStudent_Add";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = cmd.Parameters.Add("@BehaviorDetailID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = BehaviorDetailID;

                para = cmd.Parameters.Add("@StudentBSDetailName", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentBSDetailName;

                para = cmd.Parameters.Add("@StudentBSDetailType", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentBSDetailType;

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                //throw new Exception(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region public bool StudentBehaviorScoreDetailsbyStudent_Del(int StudentBSDetailID)
        public bool StudentBehaviorScoreDetailsbyStudent_Del(int StudentBSDetailID)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_StudentBehaviorScoreDetailsbyStudent_Del";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@StudentBSDetailID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentBSDetailID;

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
        #endregion

        #region public DataTable StudentClassRolebyStudentID_sel(string StudentID, string YearStudy, string TermID)
        public DataTable StudentClassRolebyStudentID_sel(string StudentID, string YearStudy, string TermID)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_StudentClassRolebyStudentID_sel";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region public DataTable getSumStudentBehaviorScores_sel(string StudentID, string YearStudy, string TermID, int Type)
        public DataTable getSumStudentBehaviorScores_sel(string StudentID, string YearStudy, string TermID, int Type)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_getSumStudentBehaviorScores_sel";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = cmd.Parameters.Add("@Type", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = Type;

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region public string StudentBehaviorScoresbyStudentIDClassScore_Update(string ClassStudentID, string StudentID, string YearStudy, string TermID, int StudentBSDetailType)
        public string StudentBehaviorScoresbyStudentIDClassScore_Update(string ClassStudentID, string StudentID, string YearStudy, string TermID, int StudentBSDetailType)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_StudentBehaviorScoresbyStudentIDClassScore_Update";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@ClassStudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ClassStudentID;

                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = cmd.Parameters.Add("@StudentBSDetailType", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentBSDetailType;

                SqlParameter paraout;
                paraout = cmd.Parameters.Add("@ReVal", SqlDbType.NVarChar, 255);
                paraout.Direction = ParameterDirection.Output;
                paraout.Value = "";

                cmd.ExecuteNonQuery();

                return paraout.Value.ToString(); ;
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
        #endregion

        #region public DataTable StudentBehaviorScore_Sel(string StudentID)
        public DataTable StudentBehaviorScore_Sel(string StudentID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable a = new DataTable();
            SqlConnection sqlConn = con;
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "sp_psc_ws_StudentBehaviorScore_Sel";
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter para;
                para = sqlComm.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;


                da.SelectCommand = sqlComm;
                da.Fill(ds);
                sqlConn.Close();
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                else
                    return a;
            }
            catch
            {
                return a;
            }
            finally
            {
                sqlConn.Close();
            }

        }
        #endregion

        #region public DataTable getStudentbehaviorScorebyStudentID(string StudentID, string YearStudy, string TermID, int StudentBSDetailType)
        public DataTable getStudentbehaviorScorebyStudentID(string StudentID, string YearStudy, string TermID, int StudentBSDetailType)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable a = new DataTable();
            SqlConnection sqlConn = con;
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "sp_psc_ws_getStudentbehaviorScorebyStudentID";
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter para;
                para = sqlComm.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = sqlComm.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = sqlComm.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = sqlComm.Parameters.Add("@StudentBSDetailType", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentBSDetailType;

                da.SelectCommand = sqlComm;
                da.Fill(ds);
                sqlConn.Close();
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                else
                    return a;
            }
            catch
            {
                return a;
            }
            finally
            {
                sqlConn.Close();
            }

        }
        #endregion

        #region  public DataTable StudentProfessor_Sel(string StudentID)
        public DataTable StudentProfessor_Sel(string StudentID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable a = new DataTable();
            SqlConnection sqlConn = con;
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "sp_psc_ws_StudentProfessor_Sel";
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter para;
                para = sqlComm.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;


                da.SelectCommand = sqlComm;
                da.Fill(ds);
                sqlConn.Close();
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                else
                    return a;
            }
            catch
            {
                //throw new Exception(ex.Message);
                return a;
            }
            finally
            {
                sqlConn.Close();
            }

        }
        #endregion

        #region public DataTable sp_psc_ws_GetYearStudyAndTerm(string StudentID)
        public DataTable sp_psc_ws_GetYearStudyAndTerm(string StudentID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable a = new DataTable();
            SqlConnection sqlConn = con;
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "sp_psc_ws_GetYearStudyAndTerm";
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter para;
                para = sqlComm.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;


                da.SelectCommand = sqlComm;
                da.Fill(ds);
                sqlConn.Close();
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                else
                    return a;
            }
            catch
            {
                //throw new Exception(ex.Message);
                return a;
            }
            finally
            {
                sqlConn.Close();
            }
        }
        #endregion

        #region public DataTable sp_psc_ws_StudentProfessor_Sel(string StudentID)
        public DataTable sp_psc_ws_StudentProfessor_Sel(string StudentID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable a = new DataTable();
            SqlConnection sqlConn = con;
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "sp_psc_ws_StudentProfessor_Sel";
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter para;
                para = sqlComm.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;


                da.SelectCommand = sqlComm;
                da.Fill(ds);
                sqlConn.Close();
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                else
                    return a;
            }
            catch
            {
                //throw new Exception(ex.Message);
                return a;
            }
            finally
            {
                sqlConn.Close();
            }
        }
        #endregion

        #region public DataTable sp_psc_ws_GetStudentInfos(string StudentID)
        public DataTable sp_psc_ws_GetStudentInfos(string StudentID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable a = new DataTable();
            SqlConnection sqlConn = con;
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "sp_psc_ws_GetStudentInfos";
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter para;
                para = sqlComm.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;


                da.SelectCommand = sqlComm;
                da.Fill(ds);
                sqlConn.Close();
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                else
                    return a;
            }
            catch
            {
                //throw new Exception(ex.Message);
                return a;
            }
            finally
            {
                sqlConn.Close();
            }
        }
        #endregion

        #region public DataTable StudentClassStudents_Sel_BehaviorScore
        public DataTable StudentClassStudents_Sel_BehaviorScore(string ClassStudentID, string YearStudy, string TermID)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_StudentClassStudents_Sel_BehaviorScore";

                SqlDataAdapter da = new SqlDataAdapter();
                SqlParameter para;
                para = cmd.Parameters.Add("@ClassStudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = ClassStudentID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region public DataTable sp_Online_LayCauHinhThoiHanNhapDiemOnline(string StudentID, string YearStudy, string TermID)
        public bool Online_LayCauHinhThoiHanNhapDiemOnline(string StudentID, string YearStudy, string TermID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable a = new DataTable();
            SqlConnection sqlConn = con;
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "sp_Online_LayCauHinhThoiHanNhapDiemOnline";
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter para;
                para = sqlComm.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = sqlComm.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = sqlComm.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                da.SelectCommand = sqlComm;
                da.Fill(ds);
                sqlConn.Close();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                        return true;
                }
                return false;

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConn.Close();
            }

        }
        #endregion

        #region public DataTable Online_BehaviorGroup_sel
        public DataTable Online_BehaviorGroup_sel()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Online_BehaviorGroup_sel";

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region public DataTable sp_online_StudentBehaviorGroupDetail_sel(string StudentID, string YearStudy, string TermID)
        public DataTable online_StudentBehaviorGroupDetail_sel(string StudentID, string YearStudy, string TermID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection sqlConn = con;
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "sp_online_StudentBehaviorGroupDetail_sel";
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter para;
                para = sqlComm.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = sqlComm.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = sqlComm.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                da.SelectCommand = sqlComm;
                da.Fill(dt);
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                sqlConn.Close();
            }

        }
        #endregion

        #region public string online_StudentBehaviorGroupDetail_up(string BehaviorGroupDetailID, string BehaviorGroupID, string BehaviorGroupDetailName, string StudentID, string YearStudy, string TermID, int Opt)
        public string online_StudentBehaviorGroupDetail_up(string BehaviorGroupDetailID, string BehaviorGroupID, string BehaviorGroupDetailName, string StudentID, string YearStudy, string TermID, int Opt)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_online_StudentBehaviorGroupDetail_up";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@BehaviorGroupDetailID", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = BehaviorGroupDetailID;

                para = cmd.Parameters.Add("@BehaviorGroupID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = BehaviorGroupID;

                para = cmd.Parameters.Add("@BehaviorGroupDetailName", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = BehaviorGroupDetailName;

                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = cmd.Parameters.Add("@Opt", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = Opt;

                SqlParameter paraout;
                paraout = cmd.Parameters.Add("@ReVal", SqlDbType.NVarChar, 255);
                paraout.Direction = ParameterDirection.Output;
                paraout.Value = DBNull.Value;

                cmd.ExecuteNonQuery();

                return paraout.Value.ToString(); ;
            }
            catch
            {
                return "1";
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region  public string Online_ClassStudentByStudentBehaviorGroupDetail_up(string StrXML)
        public string Online_ClassStudentByStudentBehaviorGroupDetail_up(string StrXML, string StudentID, string YearStudy, string TermID)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Online_ClassStudentByStudentBehaviorGroupDetail_up";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@StrXML", SqlDbType.NText);
                para.Direction = ParameterDirection.Input;
                para.Value = StrXML;


                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;


                SqlParameter paraout;
                paraout = cmd.Parameters.Add("@ReVal", SqlDbType.NVarChar, 255);
                paraout.Direction = ParameterDirection.Output;
                paraout.Value = DBNull.Value;

                cmd.ExecuteNonQuery();

                return paraout.Value.ToString(); ;
            }
            catch
            {
                return "1";
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region  public string Online_StudentBehaviorSubMark_up(string StudentID, int Score, string Note, string YearStudy, string TermID, string UpdateStaff)
        public string Online_StudentBehaviorSubMark_up(string StudentID, int Score, string Note, string YearStudy, string TermID, string UpdateStaff)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Online_StudentBehaviorSubMark_up";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = cmd.Parameters.Add("@Score", SqlDbType.Int);
                para.Direction = ParameterDirection.Input;
                para.Value = Score;

                para = cmd.Parameters.Add("@Note", SqlDbType.NText);
                para.Direction = ParameterDirection.Input;
                para.Value = Note;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                para = cmd.Parameters.Add("@UpdateStaff", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UpdateStaff;

                SqlParameter paraout;
                paraout = cmd.Parameters.Add("@ReVal", SqlDbType.NVarChar, 255);
                paraout.Direction = ParameterDirection.Output;
                paraout.Value = DBNull.Value;

                cmd.ExecuteNonQuery();

                return paraout.Value.ToString(); ;
            }
            catch
            {
                return "1";
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region public DataTable Online_StudentBehaviorSubMark_sel(string StudentID, string YearStudy, string TermID)
        public DataTable Online_StudentBehaviorSubMark_sel(string StudentID, string YearStudy, string TermID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection sqlConn = con;
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "sp_Online_StudentBehaviorSubMark_sel";
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter para;
                para = sqlComm.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                para = sqlComm.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = sqlComm.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                da.SelectCommand = sqlComm;
                da.Fill(dt);
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                sqlConn.Close();
            }

        }
        #endregion

        #region public DataTable Online_BehaviorActivities_sel(string YearStudy, string TermID)
        public DataTable Online_BehaviorActivities_sel(string YearStudy, string TermID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection sqlConn = con;
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "sp_Online_BehaviorActivities_sel";
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter para;
                para = sqlComm.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = sqlComm.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                da.SelectCommand = sqlComm;
                da.Fill(dt);
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                sqlConn.Close();
            }

        }
        #endregion

        #region public DataTable Online_GetStudentAverageScores_MarkLetter(string StudentID)
        public DataTable Online_GetStudentAverageScores_MarkLetter(string StudentID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection sqlConn = con;
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = sqlConn.CreateCommand();
                sqlComm.CommandText = "sp_Online_GetStudentAverageScores_MarkLetter";
                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlParameter para;
                para = sqlComm.Parameters.Add("@StudentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                da.SelectCommand = sqlComm;
                da.Fill(dt);
                return dt;

            }
            catch
            {
                return dt;
            }
            finally
            {
                sqlConn.Close();
            }

        }
        #endregion

        #region public string Online_DepartmentScoreStudentBehaviorScores_up(string StudentID, string XmlData, string UpDateStaff,string YearStudy,string TermID)
        public string Online_DepartmentScoreStudentBehaviorScores_up(string XmlData, string UpDateStaff, string YearStudy, string TermID)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Online_DepartmentScoreStudentBehaviorScores_up";
                //
                SqlParameter para;

                para = cmd.Parameters.Add("@XmlData", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = XmlData;

                para = cmd.Parameters.Add("@UpDateStaff", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = UpDateStaff;

                para = cmd.Parameters.Add("@YearStudy", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = YearStudy;

                para = cmd.Parameters.Add("@TermID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = TermID;

                SqlParameter paraout;
                paraout = cmd.Parameters.Add("@ReVal", SqlDbType.NVarChar, 255);
                paraout.Direction = ParameterDirection.Output;
                paraout.Value = "";

                cmd.ExecuteNonQuery();

                return paraout.Value.ToString();
            }
            catch
            {
                //throw new Exception(ex.Message);
                return "";
            }
            finally
            {
                con.Close();
            }
        }
        #endregion


        #endregion

        #region Tài khoản sinh viên



        #region public DataTable sp_psc_GetTransactions(string AccountID)
        public DataTable sp_psc_GetTransactions(string AccountID)
        {
            DataTable tb = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_GetTransactions";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@AccountID", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = AccountID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(tb);
                return tb;

            }
            catch (Exception ex)
            {
                return tb;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region public DataTable sp_psc_ws_GetYearStudyAndTerm_All()
        public DataTable sp_psc_ws_GetYearStudyAndTerm_All()
        {
            DataTable tb = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_GetYearStudyAndTerm_All";
                //
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(tb);
                return tb;
            }
            catch (Exception ex)
            {
                return tb;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region public DataTable sp_psc_tblTransactionDebts_GetByStudentTransactionForBank(string StudentID)
        public DataTable sp_psc_tblTransactionDebts_GetByStudentTransactionForBank(string StudentID)
        {
            DataTable tb = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_tblTransactionDebts_GetByStudentTransactionForBank";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(tb);
                return tb;

            }
            catch (Exception ex)
            {
                return tb;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region public DataTable sp_psc_tblTransactionDebts_GetByStudentTransactionForBank(string StudentID)
        public DataTable StudentTransactionForBank(string StudentID)
        {
            DataTable tb = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_psc_ws_StudentTransactionForBank";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@StudentID", SqlDbType.NVarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = StudentID;

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(tb);
                return tb;

            }
            catch (Exception ex)
            {
                return tb;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion


        #endregion

        #region sinh vien lop hoc phan

        public DataTable Online_Professors_Sel_DepartmentID(string DepartmentID)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Online_Professors_Sel_DepartmentID";
                //
                SqlParameter para;
                para = cmd.Parameters.Add("@DepartmentID", SqlDbType.VarChar);
                para.Direction = ParameterDirection.Input;
                para.Value = DepartmentID;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;

            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}