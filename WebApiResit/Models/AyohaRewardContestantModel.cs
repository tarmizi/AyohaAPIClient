using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaRewardContestantModel
    {
          public int ID
        {
            get;
            set;
        }
        
        public string ContestCode
        {
            get;
            set;
        }
        public string SubscriberAccNo
        {
            get;
            set;
        }



        public string JoinDate
        {
            get;
            set;
        }


        public string JoinDate_TimeOnly
        {
            get;
            set;
        }

        
        public string RowStatus
        {
            get;
            set;
        }



        public string JoinStatus
        {
            get;
            set;
        }


        public string Descriptions
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


























        public string AdvertisementImgPath
        {
            get;
            set;
        }



        public string StartDate
        {
            get;
            set;
        }
        public string EndDate
        {
            get;
            set;
        }



        public string ContestStatus
        {
            get;
            set;
        }


        public string ContestDescription
        {
            get;
            set;
        }


        public string ContestFees
        {
            get;
            set;
        }


        public string ContestName
        {
            get;
            set;
        }
       

        public AyohaRewardContestantModel() { }


        public static string AyohaRewardContestant_InsertUpdate(int ID, string ContestCode, string SubscriberAccNo,
    string RowStatus, string JoinStatus, string Descriptions, string ModifiedBy)
        {



            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            string _value = "true";
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
                        _SQLCommand.CommandText = "AyohaRewardContestant_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@ContestCode", ContestCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                           _SQLCommand.Parameters.AddWithValue("@JoinStatus", JoinStatus);
                        _SQLCommand.Parameters.AddWithValue("@Descriptions", Descriptions);
                        _SQLCommand.Parameters.AddWithValue("@ModifiedBy", ModifiedBy);
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }





                    catch (Exception ex)
                    {
                        _value = "false," + ex.ToString(); ;
                        // _value = ex.ToString();
                    }

                    finally
                    {

                        _DBConnection.Close();



                    }

                }

            }



            return _value;
        }












        public static List<AyohaRewardContestantModel> AyohaRewardContestant_LoadByContestCode(string ContestCode, string SubscriberAccNo)
        {
            List<AyohaRewardContestantModel> _Value = new List<AyohaRewardContestantModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardContestant_LoadByContestCode";
                        _SQLCommand.Parameters.AddWithValue("@ContestCode", ContestCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardContestantModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardContestantModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());                       
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











        public static List<AyohaRewardContestantModel> AyohaRewardContestant_LoadBySubscriberAccNo(string SubscriberAccNo)
        {
            List<AyohaRewardContestantModel> _Value = new List<AyohaRewardContestantModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardContestant_LoadBySubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardContestantModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardContestantModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ContestCode = _SQLDataReader["ContestCode"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.JoinDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["JoinDate"]);
                            _result.JoinDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["JoinDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.JoinStatus = _SQLDataReader["JoinStatus"].ToString();
                            _result.Descriptions = _SQLDataReader["Descriptions"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();

                            _result.AdvertisementImgPath = _SQLDataReader["AdvertisementImgPath"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.ContestStatus = _SQLDataReader["ContestStatus"].ToString();
                            _result.ContestDescription = _SQLDataReader["ContestDescription"].ToString();
                            _result.ContestFees = _SQLDataReader["ContestFees"].ToString();
                            _result.ContestName = _SQLDataReader["ContestName"].ToString();
                            
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