using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class LoyaltyStampModel : StampCampaignModel
    {

        public int ID
        {
            get;
            set;
        }
        public string SubscriberAccNo
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string StampCode
        {
            get;
            set;
        }
        public string StampQrCode
        {
            get;
            set;
        }

        public string StampedBy
        {
            get;
            set;
        }
        public string StampedByDate
        {
            get;
            set;
        }
        public string StampedByPhoneModel
        {
            get;
            set;
        }
        public string StampedByUserAccNo
        {
            get;
            set;
        }

        public string StampedByPhoneSerialNo
        {
            get;
            set;
        }
        public string StampedByPhoneManufacturer
        {
            get;
            set;
        }
        public string StampedByPhonePlatform
        {
            get;
            set;
        }
        public string StampedByOneSignalID
        {
            get;
            set;
        }

        public string StampedByPhoneRawInfo
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }

        public int CountsStamp
        {
            get;
            set;
        }

        public string StampedCampaignCode
        {
            get;
            set;
        }


        public string StampCampaignName
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

        public string EnterpriseName
        {
            get;
            set;
        }
        
            

         public int CountStampCardRowShow
        {
            get;
            set;
        }
         public int CountLoyaltyStamped
        {
            get;
            set;
        }


         public int Batch
         {
             get;
             set;
         }

         public int CurrentBatch
         {
             get;
             set;
         }
        

         public string StampClaimStatus
         {
             get;
             set;
         }
         public string PlayerID
         {
             get;
             set;
         }
        public LoyaltyStampModel() { }





        public static string LoyaltyStamp_InsertLog(string SubscriberAccNo, string EnterpriseAccNo, string StampCode, string StampQrCode, string StampedBy, string StampedByPhoneModel,
          string StampedByUserAccNo, string StampedByPhoneSerialNo, string StampedByPhoneManufacturer, string StampedByPhonePlatform, string StampedByOneSignalID, string StampedByPhoneRawInfo,
          string StampedCampaignCode, string EnterpriseName,string PlayerID)
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
                        _SQLCommand.CommandText = "LoyaltyStamp_InsertLog";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@StampCode", StampCode);


                        _SQLCommand.Parameters.AddWithValue("@StampQrCode", StampQrCode);
                        _SQLCommand.Parameters.AddWithValue("@StampedBy", StampedBy);
                        _SQLCommand.Parameters.AddWithValue("@StampedByPhoneModel", StampedByPhoneModel);


                        _SQLCommand.Parameters.AddWithValue("@StampedByUserAccNo", StampedByUserAccNo);
                        _SQLCommand.Parameters.AddWithValue("@StampedByPhoneSerialNo", StampedByPhoneSerialNo);
                        _SQLCommand.Parameters.AddWithValue("@StampedByPhoneManufacturer", StampedByPhoneManufacturer);


                        _SQLCommand.Parameters.AddWithValue("@StampedByPhonePlatform", StampedByPhonePlatform);
                        _SQLCommand.Parameters.AddWithValue("@StampedByOneSignalID", StampedByOneSignalID);
                        _SQLCommand.Parameters.AddWithValue("@StampedByPhoneRawInfo", StampedByPhoneRawInfo);
                        _SQLCommand.Parameters.AddWithValue("@StampedCampaignCode", StampedCampaignCode);

                        
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = "false," + ex.ToString(); ;
                    }

                    finally
                    {

                        _DBConnection.Close();
                        OneSignalModel.onesignalAPI_AyohaNotification_SendPointNotification_Stamp(PlayerID, EnterpriseName, "5");

                    }

                }

            }



            return _value;
        }

















        public static bool LoyaltyStamp_Insert(string SubscriberAccNo, string EnterpriseAccNo, string StampCode,string StampQrCode, string StampedBy,string StampedByPhoneModel,
            string StampedByUserAccNo,string StampedByPhoneSerialNo, string StampedByPhoneManufacturer,string StampedByPhonePlatform, string StampedByOneSignalID, string StampedByPhoneRawInfo
            )
        {

            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            bool _value = true;
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
                        _SQLCommand.CommandText = "LoyaltyStamp_Insert";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@StampCode", StampCode);

                        
                        _SQLCommand.Parameters.AddWithValue("@StampQrCode", StampQrCode);
                        _SQLCommand.Parameters.AddWithValue("@StampedBy", StampedBy);
                        _SQLCommand.Parameters.AddWithValue("@StampedByPhoneModel", StampedByPhoneModel);

                        
                        _SQLCommand.Parameters.AddWithValue("@StampedByUserAccNo", StampedByUserAccNo);
                        _SQLCommand.Parameters.AddWithValue("@StampedByPhoneSerialNo", StampedByPhoneSerialNo);
                        _SQLCommand.Parameters.AddWithValue("@StampedByPhoneManufacturer", StampedByPhoneManufacturer);


                        _SQLCommand.Parameters.AddWithValue("@StampedByPhonePlatform", StampedByPhonePlatform);
                        _SQLCommand.Parameters.AddWithValue("@StampedByOneSignalID", StampedByOneSignalID);
                        _SQLCommand.Parameters.AddWithValue("@StampedByPhoneRawInfo", StampedByPhoneRawInfo);
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = false;
                    }

                    finally
                    {

                        _DBConnection.Close();

                    }

                }

            }



            return _value;
        }






        public static List<LoyaltyStampModel> LoyaltyStamp_LoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<LoyaltyStampModel> _Value = new List<LoyaltyStampModel>();

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
                        _SQLCommand.CommandText = "LoyaltyStamp_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyStampModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new LoyaltyStampModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCode = _SQLDataReader["StampCode"].ToString();
                            _result.StampQrCode = _SQLDataReader["StampQrCode"].ToString();
                            _result.StampedBy = _SQLDataReader["StampedBy"].ToString();
                            _result.StampedByDate = _SQLDataReader["StampedByDate"].ToString();
                            _result.StampedByPhoneModel = _SQLDataReader["StampedByPhoneModel"].ToString();
                            _result.StampedByUserAccNo = _SQLDataReader["StampedByUserAccNo"].ToString();
                            _result.StampedByPhoneSerialNo = _SQLDataReader["StampedByPhoneSerialNo"].ToString();
                            _result.StampedByPhoneManufacturer = _SQLDataReader["StampedByPhoneManufacturer"].ToString();
                            _result.StampedByPhonePlatform = _SQLDataReader["StampedByPhonePlatform"].ToString();
                            _result.StampedByOneSignalID = _SQLDataReader["StampedByOneSignalID"].ToString();
                            _result.StampedByPhoneRawInfo = _SQLDataReader["StampedByPhoneRawInfo"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CountsStamp = Convert.ToInt32(_SQLDataReader["CountsStamp"].ToString());
                            _result.StampedCampaignCode = _SQLDataReader["StampedCampaignCode"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.Batch = Convert.ToInt32(_SQLDataReader["Batch"].ToString());
                            _result.StampClaimStatus = _SQLDataReader["StampClaimStatus"].ToString();
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








        public static List<LoyaltyStampModel> LoyaltyStamp_LoadByStampedByUserAccNo_And_EnterpriseAccNo(string StampedByUserAccNo,string EnterpriseAccNo)
        {
            List<LoyaltyStampModel> _Value = new List<LoyaltyStampModel>();

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
                        _SQLCommand.CommandText = "LoyaltyStamp_LoadByStampedByUserAccNo_And_EnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@StampedByUserAccNo", StampedByUserAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyStampModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new LoyaltyStampModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCode = _SQLDataReader["StampCode"].ToString();
                            _result.StampQrCode = _SQLDataReader["StampQrCode"].ToString();
                            _result.StampedBy = _SQLDataReader["StampedBy"].ToString();
                            _result.StampedByDate = _SQLDataReader["StampedByDate"].ToString();
                            _result.StampedByPhoneModel = _SQLDataReader["StampedByPhoneModel"].ToString();
                            _result.StampedByUserAccNo = _SQLDataReader["StampedByUserAccNo"].ToString();
                            _result.StampedByPhoneSerialNo = _SQLDataReader["StampedByPhoneSerialNo"].ToString();
                            _result.StampedByPhoneManufacturer = _SQLDataReader["StampedByPhoneManufacturer"].ToString();
                            _result.StampedByPhonePlatform = _SQLDataReader["StampedByPhonePlatform"].ToString();
                            _result.StampedByOneSignalID = _SQLDataReader["StampedByOneSignalID"].ToString();
                            _result.StampedByPhoneRawInfo = _SQLDataReader["StampedByPhoneRawInfo"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CountsStamp = Convert.ToInt32(_SQLDataReader["CountsStamp"].ToString());
                            _result.StampedCampaignCode = _SQLDataReader["StampedCampaignCode"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.Batch = Convert.ToInt32(_SQLDataReader["Batch"].ToString());
                            _result.StampClaimStatus = _SQLDataReader["StampClaimStatus"].ToString();
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







        public static List<LoyaltyStampModel> LoyaltyStamp_LoadBySubscriberAccNo_And_EnterpriseAccNo(string SubscriberAccNo, string EnterpriseAccNo)
        {
            List<LoyaltyStampModel> _Value = new List<LoyaltyStampModel>();

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
                        _SQLCommand.CommandText = "LoyaltyStamp_LoadBySubscriberAccNo_And_EnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyStampModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new LoyaltyStampModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCode = _SQLDataReader["StampCode"].ToString();
                            _result.StampQrCode = _SQLDataReader["StampQrCode"].ToString();
                            _result.StampedBy = _SQLDataReader["StampedBy"].ToString();
                            _result.StampedByDate = _SQLDataReader["StampedByDate"].ToString();
                            _result.StampedByPhoneModel = _SQLDataReader["StampedByPhoneModel"].ToString();
                            _result.StampedByUserAccNo = _SQLDataReader["StampedByUserAccNo"].ToString();
                            _result.StampedByPhoneSerialNo = _SQLDataReader["StampedByPhoneSerialNo"].ToString();
                            _result.StampedByPhoneManufacturer = _SQLDataReader["StampedByPhoneManufacturer"].ToString();
                            _result.StampedByPhonePlatform = _SQLDataReader["StampedByPhonePlatform"].ToString();
                            _result.StampedByOneSignalID = _SQLDataReader["StampedByOneSignalID"].ToString();
                            _result.StampedByPhoneRawInfo = _SQLDataReader["StampedByPhoneRawInfo"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CountsStamp = Convert.ToInt32(_SQLDataReader["CountsStamp"].ToString());
                            _result.StampedCampaignCode = _SQLDataReader["StampedCampaignCode"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.Batch = Convert.ToInt32(_SQLDataReader["Batch"].ToString());
                            _result.StampClaimStatus = _SQLDataReader["StampClaimStatus"].ToString();
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






        public static List<LoyaltyStampModel> LoyaltyStamp_LoadBySubscriberAccNo_And_EnterpriseAccNo_History(string SubscriberAccNo, string EnterpriseAccNo)
        {
            List<LoyaltyStampModel> _Value = new List<LoyaltyStampModel>();

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
                        _SQLCommand.CommandText = "LoyaltyStamp_LoadBySubscriberAccNo_And_EnterpriseAccNo_History";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyStampModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new LoyaltyStampModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCode = _SQLDataReader["StampCode"].ToString();
                            _result.StampQrCode = _SQLDataReader["StampQrCode"].ToString();
                            _result.StampedBy = _SQLDataReader["StampedBy"].ToString();
                            _result.StampedByDate = _SQLDataReader["StampedByDate"].ToString();
                            _result.StampedByPhoneModel = _SQLDataReader["StampedByPhoneModel"].ToString();
                            _result.StampedByUserAccNo = _SQLDataReader["StampedByUserAccNo"].ToString();
                            _result.StampedByPhoneSerialNo = _SQLDataReader["StampedByPhoneSerialNo"].ToString();
                            _result.StampedByPhoneManufacturer = _SQLDataReader["StampedByPhoneManufacturer"].ToString();
                            _result.StampedByPhonePlatform = _SQLDataReader["StampedByPhonePlatform"].ToString();
                            _result.StampedByOneSignalID = _SQLDataReader["StampedByOneSignalID"].ToString();
                            _result.StampedByPhoneRawInfo = _SQLDataReader["StampedByPhoneRawInfo"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CountsStamp = Convert.ToInt32(_SQLDataReader["CountsStamp"].ToString());
                            _result.StampedCampaignCode = _SQLDataReader["StampedCampaignCode"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.Batch = Convert.ToInt32(_SQLDataReader["Batch"].ToString());
                            _result.StampClaimStatus = _SQLDataReader["StampClaimStatus"].ToString();
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








        public static List<LoyaltyStampModel> LoyaltyStamp_LoadBySubscriberAccNo(string SubscriberAccNo)
        {
            List<LoyaltyStampModel> _Value = new List<LoyaltyStampModel>();

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
                        _SQLCommand.CommandText = "LoyaltyStamp_LoadBySubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyStampModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new LoyaltyStampModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCode = _SQLDataReader["StampCode"].ToString();
                            _result.StampQrCode = _SQLDataReader["StampQrCode"].ToString();
                            _result.StampedBy = _SQLDataReader["StampedBy"].ToString();
                            _result.StampedByDate = _SQLDataReader["StampedByDate"].ToString();
                            _result.StampedByPhoneModel = _SQLDataReader["StampedByPhoneModel"].ToString();
                            _result.StampedByUserAccNo = _SQLDataReader["StampedByUserAccNo"].ToString();
                            _result.StampedByPhoneSerialNo = _SQLDataReader["StampedByPhoneSerialNo"].ToString();
                            _result.StampedByPhoneManufacturer = _SQLDataReader["StampedByPhoneManufacturer"].ToString();
                            _result.StampedByPhonePlatform = _SQLDataReader["StampedByPhonePlatform"].ToString();
                            _result.StampedByOneSignalID = _SQLDataReader["StampedByOneSignalID"].ToString();
                            _result.StampedByPhoneRawInfo = _SQLDataReader["StampedByPhoneRawInfo"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CountsStamp = Convert.ToInt32(_SQLDataReader["CountsStamp"].ToString());
                            _result.StampedCampaignCode = _SQLDataReader["StampedCampaignCode"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.StampClaimStatus = _SQLDataReader["StampClaimStatus"].ToString();
                            //_result.StartDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["StartDate"]);
                            //_result.EndDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["EndDate"]);
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                           _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                           _result.CountStampCardRowShow = Convert.ToInt32(_SQLDataReader["CountStampCardRowShow"].ToString());
                         _result.CountLoyaltyStamped = Convert.ToInt32(_SQLDataReader["CountLoyaltyStamped"].ToString());
                         ((StampCampaignModel)_result).StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                         ((StampCampaignModel)_result).isStampRulePopUp = _SQLDataReader["isStampRulePopUp"].ToString();
                         _result.Batch = Convert.ToInt32(_SQLDataReader["Batch"].ToString());
                         _result.CurrentBatch = Convert.ToInt32(_SQLDataReader["CurrentBatch"].ToString());
                            
                         //_result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                         //_result.isStampRulePopUp = _SQLDataReader["isStampRulePopUp"].ToString();


                         //_result.CheckInDateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["DateDT"]);
                         //_result.CheckInTimeOnly = String.Format("{0:T}", _SQLDataReader["DateDT"]);
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






        public static List<LoyaltyStampModel> LoyaltyStamp_LoadBySubscriberAccNoAndMembershipCardCode(string SubscriberAccNo, string MembershipCardCode)
        {
            List<LoyaltyStampModel> _Value = new List<LoyaltyStampModel>();

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
                        _SQLCommand.CommandText = "LoyaltyStamp_LoadBySubscriberAccNoAndMembershipCardCode";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyStampModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new LoyaltyStampModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCode = _SQLDataReader["StampCode"].ToString();
                            _result.StampQrCode = _SQLDataReader["StampQrCode"].ToString();
                            _result.StampedBy = _SQLDataReader["StampedBy"].ToString();
                            _result.StampedByDate = _SQLDataReader["StampedByDate"].ToString();
                            _result.StampedByPhoneModel = _SQLDataReader["StampedByPhoneModel"].ToString();
                            _result.StampedByUserAccNo = _SQLDataReader["StampedByUserAccNo"].ToString();
                            _result.StampedByPhoneSerialNo = _SQLDataReader["StampedByPhoneSerialNo"].ToString();
                            _result.StampedByPhoneManufacturer = _SQLDataReader["StampedByPhoneManufacturer"].ToString();
                            _result.StampedByPhonePlatform = _SQLDataReader["StampedByPhonePlatform"].ToString();
                            _result.StampedByOneSignalID = _SQLDataReader["StampedByOneSignalID"].ToString();
                            _result.StampedByPhoneRawInfo = _SQLDataReader["StampedByPhoneRawInfo"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CountsStamp = Convert.ToInt32(_SQLDataReader["CountsStamp"].ToString());
                            _result.StampedCampaignCode = _SQLDataReader["StampedCampaignCode"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.StampClaimStatus = _SQLDataReader["StampClaimStatus"].ToString();
                            //_result.StartDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["StartDate"]);
                            //_result.EndDate = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["EndDate"]);
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CountStampCardRowShow = Convert.ToInt32(_SQLDataReader["CountStampCardRowShow"].ToString());
                            _result.CountLoyaltyStamped = Convert.ToInt32(_SQLDataReader["CountLoyaltyStamped"].ToString());
                            ((StampCampaignModel)_result).StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            ((StampCampaignModel)_result).isStampRulePopUp = _SQLDataReader["isStampRulePopUp"].ToString();
                            _result.Batch = Convert.ToInt32(_SQLDataReader["Batch"].ToString());
                            _result.CurrentBatch = Convert.ToInt32(_SQLDataReader["CurrentBatch"].ToString());

                            //_result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            //_result.isStampRulePopUp = _SQLDataReader["isStampRulePopUp"].ToString();


                            //_result.CheckInDateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["DateDT"]);
                            //_result.CheckInTimeOnly = String.Format("{0:T}", _SQLDataReader["DateDT"]);
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



        public static List<LoyaltyStampModel> LoyaltyStamp_CheckExistingStampQrCode(string StampQrCode)
        {
            List<LoyaltyStampModel> _Value = new List<LoyaltyStampModel>();

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
                        _SQLCommand.CommandText = "LoyaltyStamp_CheckExistingStampQrCode";
                        _SQLCommand.Parameters.AddWithValue("@StampQrCode", StampQrCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyStampModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new LoyaltyStampModel();;
                            _result.StampQrCode = _SQLDataReader["StampQrCode"].ToString();
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

     