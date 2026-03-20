using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class EnterprisesWorkingHourModel
    {
        public int ID
        {
            get;
            set;
        }

        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string isWorkingDay
        {
            get;
            set;
        }
        public string WorkingDay
        {
            get;
            set;
        }
        public string WorkingHourStart
        {
            get;
            set;
        }
        public string WorkingHourStartAMPM
        {
            get;
            set;
        }




        public string WorkingHourEnd
        {
            get;
            set;
        }
        public string WorkingHourEndAMPM
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }
        public string Note
        {
            get;
            set;
        }

        public int WorkingDaySequence
        {
            get;
            set;
        }

        public string WorkingMode
        {
            get;
            set;
        }
        public EnterprisesWorkingHourModel() { }


        public static List<EnterprisesWorkingHourModel> EnterprisesWorkingHour_LoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<EnterprisesWorkingHourModel> _Value = new List<EnterprisesWorkingHourModel>();

            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            using (SqlConnection _DBConnection = _SQLConnection)
            {
                SqlCommand _SQLCommand = new SqlCommand();
                _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
                _SQLCommand.CommandTimeout = 0;
                using (_SQLCommand)
                {
                    try
                    {
                        _SQLCommand.Connection = _DBConnection;
                        _SQLCommand.CommandText = "EnterprisesWorkingHour_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesWorkingHourModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesWorkingHourModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.isWorkingDay = _SQLDataReader["isWorkingDay"].ToString();
                            _result.WorkingDay = _SQLDataReader["WorkingDay"].ToString();
                            _result.WorkingHourStart = _SQLDataReader["WorkingHourStart"].ToString();
                            _result.WorkingHourStartAMPM = _SQLDataReader["WorkingHourStartAMPM"].ToString();
                            _result.WorkingHourEnd = _SQLDataReader["WorkingHourEnd"].ToString();
                            _result.WorkingHourEndAMPM = _SQLDataReader["WorkingHourEndAMPM"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.Note = _SQLDataReader["Note"].ToString();
                            _result.WorkingDaySequence = Convert.ToInt32(_SQLDataReader["WorkingDaySequence"].ToString());
                            _result.WorkingMode = _SQLDataReader["WorkingMode"].ToString();                            
                            _Value.Add(_result);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                    finally
                    {
                        _DBConnection.Close();

                    }

                }

            }
            return _Value;
        }

    }
}