using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;


namespace WebApiResit.Models
{
    public class AyohaRewardPointModel
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



        public string CreatedBy
        {
            get;
            set;
        }
        public string CreatedByAccNo
        {
            get;
            set;
        }



        public string CreatedDate
        {
            get;
            set;
        }


        public string RowStatus
        {
            get;
            set;
        }


        public string AyohaPoint
        {
            get;
            set;
        }

        public int AyohaPoint_Yearly
        {
            get;
            set;
        }

        public string CampaignCode
        {
            get;
            set;
        }

        public string MembershipCardCode
        {
            get;
            set;
        }

        public string GUIDRow
        {
            get;
            set;
        }


        public string AyohaPointType
        {
            get;
            set;
        }

        public string RowID
        {
            get;
            set;
        }

        public string CreatedDate_DateOnly
        {
            get;
            set;
        }

        public string CreatedDate_TimeOnly
        {
            get;
            set;
        }

        public string CreatedDate_MonthYear
        {
            get;
            set;
        }


        public string CampaignName
        {
            get;
            set;
        }

        public string EnterpriseName
        {
            get;
            set;
        }

        public string TypeCRDB
        {
            get;
            set;
        }


        public string AccountName
        {
            get;
            set;
        }

        public string Photo
        {
            get;
            set;
        }


        public string JoinDate_DateOnly
        {
            get;
            set;
        }

        public string JoinDate_TimeOnly
        {
            get;
            set;
        }

        public string JenisPoint
        {
            get;
            set;
        }

        public string ModifiedBy
        {
            get;
            set;
        }

        public string AyohaPointRedemptionItem
        {
            get;
            set;
        }

        public string ModifiedDateTime
        {
            get;
            set;
        }


        public int Month
        {
            get;
            set;
        }


        public string ItemCartCode
        {
            get;
            set;
        }

        public string MembershipCardCode_AyohaStore_Order
        {
            get;
            set;
        }


        public string PaymentNo
        {
            get;
            set;
        }









         public string EnterpriseLogo
        {
            get;
            set;
        }

        public string PointAmountEquation
        {
            get;
            set;
        }


        public string PaymentAmount
        {
            get;
            set;
        }
        


         public string PaymentNoDisplay
        {
            get;
            set;
        }

        public string MembershipCardImg
        {
            get;
            set;
        }


        public string MembershipCardName
        {
            get;
            set;
        }

        public string PaymentNote
        {
            get;
            set;
        }


        public string OrderNo
        {
            get;
            set;
        }
        public string TotalStampEarn
        {
            get;
            set;
        }


        public string EnterpriseAddress
        {
            get;
            set;
        }
        public string EnterpriseTagLine
        {
            get;
            set;
        }


        public int RowNumber
        {
            get;
            set;
        }

        public int MyRanking
        {
            get;
            set;
        }


        public AyohaRewardPointModel() { }



        public static List<AyohaRewardPointModel> AyohaRewardPoint_LoadBySubscriberAccNo(string SubscriberAccNo, string Year)
        {
            List<AyohaRewardPointModel> _Value = new List<AyohaRewardPointModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardPoint_LoadBySubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@Year", Year);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardPointModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardPointModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedByAccNo = _SQLDataReader["CreatedByAccNo"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                            _result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.GUIDRow = _SQLDataReader["GUIDRow"].ToString();
                            _result.JenisPoint = _SQLDataReader["AyohaPointType"].ToString();
                           // _result.AyohaPointType = _SQLDataReader["AyohaPointType"].ToString();
                           // _result.AyohaPointType = CampaignTypeCard(_SQLDataReader["AyohaPointType"].ToString());
                            _result.AyohaPointType = CampaignTypeCard_AyohaPointTransactionDashboard(_SQLDataReader["AyohaPointType"].ToString(), _SQLDataReader["EnterpriseAccNo"].ToString(), _SQLDataReader["CampaignCode"].ToString());
                            
                            _result.RowID = _SQLDataReader["RowID"].ToString();
                          //  _result.CampaignName = _SQLDataReader["CampaignName"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CreatedDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["CreatedDate"]), String.Format("{0:yyyy}", _SQLDataReader["CreatedDate"]));
                            _result.TypeCRDB = _SQLDataReader["TypeCRDB"].ToString();
                            _result.CampaignName = _SQLDataReader["CampaignName"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();  
                            _result.AyohaPointRedemptionItem = _SQLDataReader["AyohaPointRedemptionItem"].ToString();
                            _result.ModifiedDateTime = String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ModifiedDate"]);
                            _result.AyohaPoint_Yearly = Convert.ToInt32(_SQLDataReader["AyohaPoint_Yearly"].ToString());
                            _result.Month = Convert.ToInt32( _SQLDataReader["MonthNumber"].ToString());
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode_AyohaStore_Order = _SQLDataReader["MembershipCardCode_AyohaStore_Order"].ToString();
                            _result.PaymentNo = _SQLDataReader["PaymentNo"].ToString();



                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.PointAmountEquation = _SQLDataReader["PointAmountEquation"].ToString();
                            _result.PaymentAmount = _SQLDataReader["PaymentAmount"].ToString();
                            _result.PaymentNoDisplay = _SQLDataReader["PaymentNoDisplay"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.MembershipCardImg = _SQLDataReader["MembershipCardImg"].ToString();
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.PaymentNote = _SQLDataReader["PaymentNote"].ToString();
                            _result.TotalStampEarn = _SQLDataReader["TotalStampEarn"].ToString();

                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            
                            
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








        public static List<AyohaRewardPointModel> AyohaRewardPoint_LoadBySubscriberAccNoEnterpriseAccNoMCC(string AyohaUserAccNo, string EnterprisesAccNo, string MCC)
        {
            List<AyohaRewardPointModel> _Value = new List<AyohaRewardPointModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardPoint_LoadBySubscriberAccNoEnterpriseAccNoMCC";
                        _SQLCommand.Parameters.AddWithValue("@AyohaUserAccNo", AyohaUserAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterprisesAccNo", EnterprisesAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MCC", MCC);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardPointModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardPointModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedByAccNo = _SQLDataReader["CreatedByAccNo"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                            _result.JenisPoint = _SQLDataReader["AyohaPointType"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.GUIDRow = _SQLDataReader["GUIDRow"].ToString();
                            _result.JenisPoint = _SQLDataReader["AyohaPointType"].ToString();
                            // _result.AyohaPointType = _SQLDataReader["AyohaPointType"].ToString();
                            _result.AyohaPointType = CampaignTypeCard(_SQLDataReader["AyohaPointType"].ToString());
                            _result.RowID = _SQLDataReader["RowID"].ToString();
                            //  _result.CampaignName = _SQLDataReader["CampaignName"].ToString();                       
                           
                            _result.CreatedDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["CreatedDate"]), String.Format("{0:yyyy}", _SQLDataReader["CreatedDate"]));
                            _result.TypeCRDB = _SQLDataReader["TypeCRDB"].ToString();
                            _result.CampaignName = _SQLDataReader["CampaignName"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString() + " - " + String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ModifiedDate"]);
                            _result.Month = Convert.ToInt32(_SQLDataReader["MonthNumber"].ToString());
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode_AyohaStore_Order = _SQLDataReader["MembershipCardCode_AyohaStore_Order"].ToString();
                            _result.PaymentNo = _SQLDataReader["PaymentNo"].ToString();

                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.PointAmountEquation = _SQLDataReader["PointAmountEquation"].ToString();
                            _result.PaymentAmount = _SQLDataReader["PaymentAmount"].ToString();
                            _result.PaymentNoDisplay = _SQLDataReader["PaymentNoDisplay"].ToString();
                            _result.MembershipCardImg = _SQLDataReader["MembershipCardImg"].ToString();
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.PaymentNote = _SQLDataReader["PaymentNote"].ToString();
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











        public static List<AyohaRewardPointModel> AyohaRewardPoint_RewardRanking(string RankingLevel, string SubscriberAccNo)
        {
            List<AyohaRewardPointModel> _Value = new List<AyohaRewardPointModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardPoint_RewardRanking";
                        _SQLCommand.Parameters.AddWithValue("@RankingLevel", RankingLevel);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", RankingLevel);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardPointModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardPointModel();
                            //_result.AyohaPoints = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                            _result.JoinDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["JoinDate"]);
                            _result.JoinDate_TimeOnly = String.Format("{0:T}", _SQLDataReader["JoinDate"]);
                            _result.RowNumber =Convert.ToInt32(_SQLDataReader["RowNumber"].ToString());
                            _result.MyRanking = Convert.ToInt32(_SQLDataReader["MyRanking"].ToString());
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



        public static string CampaignTypeCard_AyohaPointTransactionDashboard(string jenis, string EnterpriseAccNo, string CampaignCode)
        {
            string result = "";
            if (EnterpriseAccNo != "50528-0133376958-NoEnterprise")
            {
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
            }
            else
            {

                if (CampaignCode == "AyohaPointRedemption")
                {
                   
                    result = "<font color=purple>Ayoha Point Redemption</font>";
                }
                if (CampaignCode == "AyohaPointRedemptionCancel")
                {

                    result = "<font color=red>Ayoha Point Redemption Cancelled</font>";
                }
                if (CampaignCode == "AyohaPointGreetingPoint")
                {

                   
                    result = "<font color=purple class=blink_me> <b>Ayoha Reward Greeting Point! </b></font>";
                }
                if (CampaignCode == "AyohaPointToken-eWalletOpeningAccount")
                {

                    result = "<font color=purple class=blink_me> <b>Ayoha eWallet Greeting Point! </b></font>";
                }
                if (CampaignCode == "AC-02")
                {

                    result = "<font color=purple class=blink_me> <b>Winner TAP And Win Contest Point </b></font>";
                }
              

            }
       


            return result;
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


        public static string EnterpriseCampaignTypeCard(string jenis,string EnterpriseName)
        {
            string result = "ha";

            if (jenis == "Point")
            {
                result = EnterpriseName;
                return result;
            }

            if (jenis == "Stamp")
            {
                result = EnterpriseName;
                return result;
            }

            if (jenis == "Cancel")
            {
                result = "<font color=red>" + EnterpriseName + "</font>";
                return result;
            }

            return result;
          
        }


    }
}