using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class EnterprisesCoverMediaModel
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
        public string CoverMediaUrl
        {
            get;
            set;
        }
        public string CoverMediaName
        {
            get;
            set;
        }
        public string CoverMediaType
        {
            get;
            set;
        }
        public string CoverMediaSequence
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }
        public string CreatedBy
        {
            get;
            set;
        }
        public string CreatedDate
        {
            get;
            set;
        }

        public string ModifiedBy
        {
            get;
            set;
        }
        public string ModifiedDate
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


        public string Note
        {
            get;
            set;
        }
        public string isLikeStatus
        {
            get;
            set;
        }

        public string CountLike
        {
            get;
            set;
        }

        public int CountOnlineStore
        {
            get;
            set;
        }


        public int CountMembershipCard
        {
            get;
            set;
        }
        
        public EnterprisesCoverMediaModel() { }

        public static List<EnterprisesCoverMediaModel> EnterprisesCoverMedia_LoadByEnterpriseAccNo(string EnterpriseAccNo, string Today, string SubscriberAccNo)
        {
            List<EnterprisesCoverMediaModel> _Value = new List<EnterprisesCoverMediaModel>();

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
                        _SQLCommand.CommandText = "EnterprisesCoverMedia_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@WorkingDay", Today);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterprisesCoverMediaModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterprisesCoverMediaModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.CoverMediaUrl = _SQLDataReader["CoverMediaUrl"].ToString();
                            _result.CoverMediaName = _SQLDataReader["CoverMediaName"].ToString();
                            _result.CoverMediaType = _SQLDataReader["CoverMediaType"].ToString();
                            _result.CoverMediaSequence = _SQLDataReader["CoverMediaSequence"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();


                            _result.isWorkingDay = _SQLDataReader["isWorkingDay"].ToString();
                            _result.WorkingDay = _SQLDataReader["WorkingDay"].ToString();
                            _result.WorkingHourStart = _SQLDataReader["WorkingHourStart"].ToString();
                            _result.WorkingHourStartAMPM = _SQLDataReader["WorkingHourStartAMPM"].ToString();
                            _result.WorkingHourEnd = _SQLDataReader["WorkingHourEnd"].ToString();
                            _result.WorkingHourEndAMPM = _SQLDataReader["WorkingHourEndAMPM"].ToString();
                            _result.Note = _SQLDataReader["Note"].ToString();
                            _result.isLikeStatus = _SQLDataReader["isLikeStatus"].ToString();
                            _result.CountLike = _SQLDataReader["CountLike"].ToString();
                            _result.CountOnlineStore = Convert.ToInt32(_SQLDataReader["CountOnlineStore"].ToString());
                            _result.CountMembershipCard = Convert.ToInt32(_SQLDataReader["CountMembershipCard"].ToString());
                            
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