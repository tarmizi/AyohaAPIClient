using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class LoyaltyPointModel
    {

        public int ID
        {
            get;
            set;
        }

        public string IDS
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


        public string PointCode
        {
            get;
            set;
        }


        public string PointQrCode
        {
            get;
            set;
        }
        public string PointedBy
        {
            get;
            set;
        }

        public string PointedByDate
        {
            get;
            set;
        }

        public string PointedByPhoneModel
        {
            get;
            set;
        }

        public string PointedByUserAccNo
        {
            get;
            set;
        }
        public string PointedByPhoneSerialNo
        {
            get;
            set;
        }


        public string PointedByPhoneManufacturer
        {
            get;
            set;
        }


        public string PointedByPhonePlatform
        {
            get;
            set;
        }
        public string PointedByOneSignalID
        {
            get;
            set;
        }

        public string PointedByPhoneRawInfo
        {
            get;
            set;
        }

        public string RowStatus
        {
            get;
            set;
        }

        public string CountsPoint
        {
            get;
            set;
        }


        public string PointCampaignCode
        {
            get;
            set;
        }
        public string Batch
        {
            get;
            set;
        }




        public string PointClaimStatus
        {
            get;
            set;
        }

        public string Amount
        {
            get;
            set;
        }



        public string ReceiptBillID
        {
            get;
            set;
        }

        public string PointEquation
        {
            get;
            set;
        }

        public int SumPoint
        {
            get;
            set;
        }

        public string PointCampaignName
        {
            get;
            set;
        }

        public string PointedByDate_DateOnly
        {
            get;
            set;
        }

        public string PointedByDate_TimeOnly
        {
            get;
            set;
        }

        public string PointedByDate_MonthYear
        {
            get;
            set;
        }


        public string RowID
        {
            get;
            set;
        }

        public string TypeCRDB
        {
            get;
            set;
        }


        public string PointType
        {
            get;
            set;
        }




          public string EnterpriseName
        {
            get;
            set;
        }

        public string EnterpriseLogo
        {
            get;
            set;
        }


        public string EndDate
        {
            get;
            set;
        }





        public string CustomerAccountName
        {
            get;
            set;
        }

        public string CustomerEmail
        {
            get;
            set;
        }


        public string CustomerPhoneNo
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



        public string JenisPoint
        {
            get;
            set;
        }
        public string PlayerID
        {
            get;
            set;
        }
        public int Month
        {
            get;
            set;
        }

        public LoyaltyPointModel() { }


        public static string LoyaltyPoint_Insert(string SubscriberAccNo, string EnterpriseAccNo,string PointCode, string PointQrCode, string PointedBy, string PointedByPhoneModel, string PointedByUserAccNo,string PointedByPhoneSerialNo, string PointedByPhoneManufacturer,
 string PointedByPhonePlatform, string PointedByOneSignalID, string PointedByPhoneRawInfo, string CountsPoint, string PointCampaignCode,string Amount, string ReceiptBillID, string PointEquation,string TypeCRDB,string PointType
            ,string EnterpriseName,string PlayerID)
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
                        _SQLCommand.CommandText = "LoyaltyPoint_Insert";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@PointCode", PointCode);
                        _SQLCommand.Parameters.AddWithValue("@PointQrCode", PointQrCode);
                        _SQLCommand.Parameters.AddWithValue("@PointedBy", PointedBy);
                        _SQLCommand.Parameters.AddWithValue("@PointedByPhoneModel", PointedByPhoneModel);
                        _SQLCommand.Parameters.AddWithValue("@PointedByUserAccNo", PointedByUserAccNo);
                        _SQLCommand.Parameters.AddWithValue("@PointedByPhoneSerialNo", PointedByPhoneSerialNo);
                        _SQLCommand.Parameters.AddWithValue("@PointedByPhoneManufacturer", PointedByPhoneManufacturer);
                        _SQLCommand.Parameters.AddWithValue("@PointedByPhonePlatform", PointedByPhonePlatform);
                        _SQLCommand.Parameters.AddWithValue("@PointedByOneSignalID", PointedByOneSignalID);
                        _SQLCommand.Parameters.AddWithValue("@PointedByPhoneRawInfo", PointedByPhoneRawInfo);
                        _SQLCommand.Parameters.AddWithValue("@CountsPoint", CountsPoint);
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignCode", PointCampaignCode);
                      //  _SQLCommand.Parameters.AddWithValue("@Batch", Batch);
                        _SQLCommand.Parameters.AddWithValue("@Amount", Amount);
                        _SQLCommand.Parameters.AddWithValue("@ReceiptBillID", ReceiptBillID);
                        _SQLCommand.Parameters.AddWithValue("@PointEquation", PointEquation);
                        _SQLCommand.Parameters.AddWithValue("@TypeCRDB", TypeCRDB);
                        _SQLCommand.Parameters.AddWithValue("@PointType", PointType);
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
                        OneSignalModel.onesignalAPI_AyohaNotification_SendPointNotification_Point(PlayerID, EnterpriseName, CountsPoint);

                    }

                }

            }



            return _value;
        }




        public static void LoyaltyPoint_Insert_AyohaUserCreatedAccountPoint(string SubscriberAccNo,string PlayerID,string AccountName)
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
                        _SQLCommand.CommandText = "LoyaltyPoint_Insert";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo","50528-0133376958-NoEnterprise");
                        _SQLCommand.Parameters.AddWithValue("@PointCode", SubscriberAccNo + "-50528-0133376958-NoEnterprise");
                        _SQLCommand.Parameters.AddWithValue("@PointQrCode", "AyohaUserCreatedAccount");
                        _SQLCommand.Parameters.AddWithValue("@PointedBy", "AyohaAdmin");
                        _SQLCommand.Parameters.AddWithValue("@PointedByPhoneModel", "NotRequired");
                        _SQLCommand.Parameters.AddWithValue("@PointedByUserAccNo", "AyohaAdmin");
                        _SQLCommand.Parameters.AddWithValue("@PointedByPhoneSerialNo", "NotRequired");
                        _SQLCommand.Parameters.AddWithValue("@PointedByPhoneManufacturer", "NotRequired");
                        _SQLCommand.Parameters.AddWithValue("@PointedByPhonePlatform", "NotRequired");
                        _SQLCommand.Parameters.AddWithValue("@PointedByOneSignalID", "NotRequired");
                        _SQLCommand.Parameters.AddWithValue("@PointedByPhoneRawInfo", "NotRequired");
                        _SQLCommand.Parameters.AddWithValue("@CountsPoint", 100);
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignCode", "AyohaPointGreetingPoint");
                        //  _SQLCommand.Parameters.AddWithValue("@Batch", Batch);
                        _SQLCommand.Parameters.AddWithValue("@Amount", 100);
                        _SQLCommand.Parameters.AddWithValue("@ReceiptBillID", "NotRequired");
                        _SQLCommand.Parameters.AddWithValue("@PointEquation", 1.00);
                        _SQLCommand.Parameters.AddWithValue("@TypeCRDB", "Credit");
                        _SQLCommand.Parameters.AddWithValue("@PointType", "Earn");
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
                        OneSignalModel.onesignalAPI_AyohaNotification_UserProfileCreated(AccountName, PlayerID);

                    }

                }

            }



         //   return _value;
        }



        public static string LoyaltyPoint_InsertLooping(string SubscriberAccNo, string EnterpriseAccNo, string PointCode, string PointQrCode, string PointedBy, string PointedByPhoneModel, string PointedByUserAccNo, string PointedByPhoneSerialNo, string PointedByPhoneManufacturer,
 string PointedByPhonePlatform, string PointedByOneSignalID, string PointedByPhoneRawInfo, string CountsPoint, string PointCampaignCode, string Amount, string ReceiptBillID, string PointEquation, string TypeCRDB, string PointType
            , string EnterpriseName, string PlayerID)
        {


            string AyohaUserAccountNo = SubscriberAccNo;
            string[] ArrAyohaUserAccountNo = AyohaUserAccountNo.Split(',');

            string AmountSpend = Amount;
            string[] ArrAmountSpend = AmountSpend.Split(',');


            string PointEarn = CountsPoint;
            string[] ArrPointEarn = PointEarn.Split(',');


            string PlayerIDs = PlayerID;
            string[] ArrPlayerIDs = PlayerIDs.Split(',');

            string _value = "true";
            int ii = 0;
            foreach (string SAN in ArrAyohaUserAccountNo)
            {

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
                            _SQLCommand.CommandText = "LoyaltyPoint_Insert";
                            _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", ArrAyohaUserAccountNo[ii]);
                            _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                            _SQLCommand.Parameters.AddWithValue("@PointCode", PointCode);
                            _SQLCommand.Parameters.AddWithValue("@PointQrCode", PointQrCode);
                            _SQLCommand.Parameters.AddWithValue("@PointedBy", PointedBy);
                            _SQLCommand.Parameters.AddWithValue("@PointedByPhoneModel", PointedByPhoneModel);
                            _SQLCommand.Parameters.AddWithValue("@PointedByUserAccNo", PointedByUserAccNo);
                            _SQLCommand.Parameters.AddWithValue("@PointedByPhoneSerialNo", PointedByPhoneSerialNo);
                            _SQLCommand.Parameters.AddWithValue("@PointedByPhoneManufacturer", PointedByPhoneManufacturer);
                            _SQLCommand.Parameters.AddWithValue("@PointedByPhonePlatform", PointedByPhonePlatform);
                            _SQLCommand.Parameters.AddWithValue("@PointedByOneSignalID", "NotRequired");
                            _SQLCommand.Parameters.AddWithValue("@PointedByPhoneRawInfo", PointedByPhoneRawInfo);
                            _SQLCommand.Parameters.AddWithValue("@CountsPoint",Convert.ToInt32(ArrPointEarn[ii]));
                            _SQLCommand.Parameters.AddWithValue("@PointCampaignCode", PointCampaignCode);
                            //  _SQLCommand.Parameters.AddWithValue("@Batch", Batch);
                            _SQLCommand.Parameters.AddWithValue("@Amount", ArrAmountSpend[ii]);
                            _SQLCommand.Parameters.AddWithValue("@ReceiptBillID", ReceiptBillID);
                            _SQLCommand.Parameters.AddWithValue("@PointEquation", PointEquation);
                            _SQLCommand.Parameters.AddWithValue("@TypeCRDB", TypeCRDB);
                            _SQLCommand.Parameters.AddWithValue("@PointType", PointType);
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
                            string PlyID=ArrPlayerIDs[ii];
                            if (PlyID.Length>0)
                            {
                                if (ii < 3)
                                {
                                    OneSignalModel.onesignalAPI_AyohaNotification_SendPointNotification_Point(PlyID, EnterpriseName, ArrPointEarn[ii]);
                                }
                               
                            }
                           // OneSignalModel.onesignalAPI_AyohaNotification_SendPointNotification(PlayerID,EnterpriseName)

                        }

                    }

                }

                ii++;



            }

         



            return _value;
        }





        public static string LoyaltyPoint_CreatePoint_CancelLooping(string IDS, string ModifiedBy)
        {


            string AyohaUserID = IDS;
            string[] ArrAyohaUserID = AyohaUserID.Split(',');


            string _value = "true";
          //  int ii = 0;
            foreach (string IDi in ArrAyohaUserID)
            {

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
                            _SQLCommand.CommandText = "LoyaltyPoint_CreatePoint_Cancel";
                            _SQLCommand.Parameters.AddWithValue("@ID",Convert.ToInt32(IDi));
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

               // ii++;



            }





            return _value;
        }






        public static List<LoyaltyPointModel> LoyaltyPoint_LoadByPointCampaignCode(string PointCampaignCode, string SubscriberAccNo)
        {
            List<LoyaltyPointModel> _Value = new List<LoyaltyPointModel>();

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
                        _SQLCommand.CommandText = "LoyaltyPoint_LoadByPointCampaignCode";
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignCode", PointCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyPointModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new LoyaltyPointModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.PointCode = _SQLDataReader["PointCode"].ToString();
                            _result.PointQrCode = _SQLDataReader["PointQrCode"].ToString();
                            _result.PointedBy = _SQLDataReader["PointedBy"].ToString();
                            _result.PointedByDate = _SQLDataReader["PointedByDate"].ToString();
                            _result.PointedByPhoneModel = _SQLDataReader["PointedByPhoneModel"].ToString();
                            _result.PointedByUserAccNo = _SQLDataReader["PointedByUserAccNo"].ToString();
                            _result.PointedByPhoneSerialNo = _SQLDataReader["PointedByPhoneSerialNo"].ToString();
                            _result.PointedByPhoneManufacturer = _SQLDataReader["PointedByPhoneManufacturer"].ToString();
                            _result.PointedByPhonePlatform = _SQLDataReader["PointedByPhonePlatform"].ToString();
                            _result.PointedByOneSignalID = _SQLDataReader["PointedByOneSignalID"].ToString();
                            _result.PointedByPhoneRawInfo = _SQLDataReader["PointedByPhoneRawInfo"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CountsPoint = _SQLDataReader["CountsPoint"].ToString();
                            _result.PointCampaignCode = _SQLDataReader["PointCampaignCode"].ToString();
                            _result.Batch = _SQLDataReader["Batch"].ToString();
                            _result.PointClaimStatus = _SQLDataReader["PointClaimStatus"].ToString();
                            _result.Amount = _SQLDataReader["Amount"].ToString();
                            _result.ReceiptBillID = _SQLDataReader["ReceiptBillID"].ToString();
                            _result.PointEquation = _SQLDataReader["PointEquation"].ToString();
                            _result.SumPoint = Convert.ToInt32(_SQLDataReader["SumPoint"].ToString());
                            _result.PointCampaignName = _SQLDataReader["PointCampaignName"].ToString();
                            _result.PointedByDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["PointedByDate"]);
                            _result.PointedByDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["PointedByDate"]);
                            _result.PointedByDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["PointedByDate"]), String.Format("{0:yyyy}", _SQLDataReader["PointedByDate"]));
                            _result.RowID = _SQLDataReader["RowID"].ToString();
                            _result.JenisPoint = _SQLDataReader["PointType"].ToString();
                            _result.TypeCRDB = _SQLDataReader["TypeCRDB"].ToString();
                          //  _result.PointType = _SQLDataReader["PointType"].ToString();
                            _result.PointType = CampaignTypeCard(_SQLDataReader["PointType"].ToString());
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString() + " - " + String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ModifiedDate"]);
                            
                            
                            

                          
   
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







        public static List<LoyaltyPointModel> LoyaltyPoint_LoadByEnterpriseAccNo(string EnterpriseAccNo,string Month,string Year)
        {
            List<LoyaltyPointModel> _Value = new List<LoyaltyPointModel>();

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
                        _SQLCommand.CommandText = "LoyaltyPoint_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@Month", Month);
                        _SQLCommand.Parameters.AddWithValue("@Year", Year);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyPointModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new LoyaltyPointModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.Amount = _SQLDataReader["Amount"].ToString();
                            _result.CountsPoint = _SQLDataReader["CountsPoint"].ToString();
                            _result.PointEquation = _SQLDataReader["PointEquation"].ToString();
                            _result.ReceiptBillID = _SQLDataReader["ReceiptBillID"].ToString();
                            _result.RowID = _SQLDataReader["RowID"].ToString();
                            _result.TypeCRDB = _SQLDataReader["TypeCRDB"].ToString();
                            _result.PointType = _SQLDataReader["PointType"].ToString();
                            _result.PointedBy = _SQLDataReader["PointedBy"].ToString();
                            _result.PointedByDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["PointedByDate"]);
                            _result.PointedByDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["PointedByDate"]);
                            _result.PointedByDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["PointedByDate"]), String.Format("{0:yyyy}", _SQLDataReader["PointedByDate"]));
                            _result.PointQrCode = _SQLDataReader["PointQrCode"].ToString();
                            _result.PointedByUserAccNo = _SQLDataReader["PointedByUserAccNo"].ToString();

                                   _result.CustomerAccountName = _SQLDataReader["CustomerAccountName"].ToString();
                            _result.CustomerPhoneNo = _SQLDataReader["CustomerPhoneNo"].ToString();
                                     _result.CustomerEmail = _SQLDataReader["CustomerEmail"].ToString();
                                


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















        public static List<LoyaltyPointModel> LoyaltyPoint_LoadByPointCampaignCode_User(string PointCampaignCode, string SubscriberAccNo)
        {
            List<LoyaltyPointModel> _Value = new List<LoyaltyPointModel>();

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
                        _SQLCommand.CommandText = "LoyaltyPoint_LoadByPointCampaignCode_User";
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignCode", PointCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyPointModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new LoyaltyPointModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.PointCode = _SQLDataReader["PointCode"].ToString();
                            _result.PointQrCode = _SQLDataReader["PointQrCode"].ToString();
                            _result.PointedBy = _SQLDataReader["PointedBy"].ToString();
                            _result.PointedByDate = _SQLDataReader["PointedByDate"].ToString();
                            _result.PointedByPhoneModel = _SQLDataReader["PointedByPhoneModel"].ToString();
                            _result.PointedByUserAccNo = _SQLDataReader["PointedByUserAccNo"].ToString();
                            _result.PointedByPhoneSerialNo = _SQLDataReader["PointedByPhoneSerialNo"].ToString();
                            _result.PointedByPhoneManufacturer = _SQLDataReader["PointedByPhoneManufacturer"].ToString();
                            _result.PointedByPhonePlatform = _SQLDataReader["PointedByPhonePlatform"].ToString();
                            _result.PointedByOneSignalID = _SQLDataReader["PointedByOneSignalID"].ToString();
                            _result.PointedByPhoneRawInfo = _SQLDataReader["PointedByPhoneRawInfo"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CountsPoint = _SQLDataReader["CountsPoint"].ToString();
                            _result.PointCampaignCode = _SQLDataReader["PointCampaignCode"].ToString();
                            _result.Batch = _SQLDataReader["Batch"].ToString();
                            _result.PointClaimStatus = _SQLDataReader["PointClaimStatus"].ToString();
                            _result.Amount = _SQLDataReader["Amount"].ToString();
                            _result.ReceiptBillID = _SQLDataReader["ReceiptBillID"].ToString();
                            _result.PointEquation = _SQLDataReader["PointEquation"].ToString();
                            _result.SumPoint = Convert.ToInt32(_SQLDataReader["SumPoint"].ToString());
                            _result.PointCampaignName = _SQLDataReader["PointCampaignName"].ToString();
                            _result.PointedByDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["PointedByDate"]);
                            _result.PointedByDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["PointedByDate"]);
                            _result.PointedByDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["PointedByDate"]), String.Format("{0:yyyy}", _SQLDataReader["PointedByDate"]));
                            _result.RowID = _SQLDataReader["RowID"].ToString();
                            _result.TypeCRDB = _SQLDataReader["TypeCRDB"].ToString();
                            _result.JenisPoint = _SQLDataReader["PointType"].ToString();
                            _result.PointType = CampaignTypeCard(_SQLDataReader["PointType"].ToString());
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString() + " " + String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ModifiedDate"]);
                            _result.Month = Convert.ToInt32(_SQLDataReader["MonthNumber"].ToString()) + Convert.ToInt32(_SQLDataReader["ID"].ToString());






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














        public static List<LoyaltyPointModel>LoyaltyPoint_DashboardAyohaUser_LatestPoint( string SubscriberAccNo,string PointCampaignCode)
        {
            List<LoyaltyPointModel> _Value = new List<LoyaltyPointModel>();

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
                        _SQLCommand.CommandText = "LoyaltyPoint_DashboardAyohaUser_LatestPoint";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@PointCampaignCode", PointCampaignCode);
                    
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyPointModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new LoyaltyPointModel();
                          
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.PointCampaignName = _SQLDataReader["PointCampaignName"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
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









        public static string CampaignTypeCard(string jenis)
        {
            string result = "";

            if (jenis == "Point")
            {
                result = "(Point Loyalty Card)";
            }

            if (jenis == "Stamp")
            {
                result = "(Stamp Loyalty Card)";
            }

            if (jenis == "Cancel")
            {
                result = "<font color=red>(Point Cancelled by Merchant)</font>";
            }


            return result;
        }






    }








}