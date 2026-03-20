using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class StampCampaignModel
    {


        public int ID
        {
            get;
            set;
        }



        public string StampCampaignCode
        {
            get;
            set;
        }
        public string StampCampaignName
        {
            get;
            set;
        }
        
        
        public string StampCardType
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




        public string StrEndDate
        {
            get;
            set;
        }

        public string RowStatus
        {
            get;
            set;
        }


        public string EnterpriseAccNo
        {
            get;
            set;
        }




        public string CreatedByAccNo
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

        public string StartDateOnly
        {
            get;
            set;
        }
        public string EndDateOnly
        {
            get;
            set;
        }

        public string StampCardBackground
        {
            get;
            set;
        }



        public string isAnimated
        {
            get;
            set;
        }


        public int AnimatedInterval
        {
            get;
            set;
        }




        public string StampRuleRemarks
        {
            get;
            set;
        }



        public string isStampRulePopUp
        {
            get;
            set;
        }
        public string LoyaltyCustomerType
        {
            get;
            set;
        }

        public string StampCampaignPremiumQRCode
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

        public string BackgroundImgOne
        {
            get;
            set;
        }

        public string BackgroundImgTwo
        {
            get;
            set;
        }



        public string NextRedeem
        {
            get;
            set;
        }

        public string NextRedeemContent
        {
            get;
            set;
        }





        public string isRequiredFee
        {
            get;
            set;
        }



        public string StampCampaignFees
        {
            get;
            set;
        }

        public string FeesCycle
        {
            get;
            set;
        }










        public string EnterpriseAddress
        {
            get;
            set;
        }



        public string SearchCol
        {
            get;
            set;
        }

        public string BusinessMode
        {
            get;
            set;
        }





        public string EnterpriseType
        {
            get;
            set;
        }



        public string BusinessTypeIconPath
        {
            get;
            set;
        }

        public string BusinessTypeGroup
        {
            get;
            set;
        }

        public string CountStampStr
        {
            get;
            set;
        }
        public int CountMembers
        {
            get;
            set;
        }

        public StampCampaignModel() { }

        public static List<StampCampaignModel> StampCampaign_LoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<StampCampaignModel> _Value = new List<StampCampaignModel>();

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
                        _SQLCommand.CommandText = "StampCampaign_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        StampCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new StampCampaignModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.StampCardType = _SQLDataReader["StampCardType"].ToString();
                            _result.StartDate = _SQLDataReader["StartDate"].ToString();
                            _result.EndDate = _SQLDataReader["EndDate"].ToString();
                            _result.StartDateOnly = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["StartDate"]);
                            _result.EndDateOnly = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["EndDate"]);
                            _result.StrEndDate = _SQLDataReader["StrEndDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.CreatedByAccNo = _SQLDataReader["CreatedByAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                          
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.StampCardBackground = _SQLDataReader["StampCardBackground"].ToString();
                            _result.AnimatedInterval = Convert.ToInt32(_SQLDataReader["AnimatedInterval"].ToString());
                            _result.isAnimated = _SQLDataReader["isAnimated"].ToString();
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.isStampRulePopUp = _SQLDataReader["isStampRulePopUp"].ToString();
                            _result.LoyaltyCustomerType = _SQLDataReader["LoyaltyCustomerType"].ToString();
                            _result.StampCampaignPremiumQRCode = _SQLDataReader["StampCampaignPremiumQRCode"].ToString();



                            _result.isRequiredFee = _SQLDataReader["isRequiredFee"].ToString();
                            _result.StampCampaignFees = _SQLDataReader["StampCampaignFees"].ToString();
                            _result.FeesCycle = _SQLDataReader["FeesCycle"].ToString();
                            _result.CountMembers = Convert.ToInt32(_SQLDataReader["CountMembers"].ToString());
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












        public static List<StampCampaignModel> StampCampaign_DashboardAyohaUser_LatestStamp(string SubscriberAccNo, string StampCampaignCode)
        {
            List<StampCampaignModel> _Value = new List<StampCampaignModel>();

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
                        _SQLCommand.CommandText = "StampCampaign_DashboardAyohaUser_LatestStamp";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        StampCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new StampCampaignModel();
                       
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();                                             
                            _result.StartDateOnly = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["StartDate"]);
                            _result.EndDateOnly = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["EndDate"]);
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.isStampRulePopUp = _SQLDataReader["isStampRulePopUp"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.CountStampStr = _SQLDataReader["CountStampStr"].ToString();

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







        public static List<StampCampaignModel>StampCampaign_LoadByStampCampaignCode(string StampCampaignCode)
        {
            List<StampCampaignModel> _Value = new List<StampCampaignModel>();

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
                        _SQLCommand.CommandText = "StampCampaign_LoadByStampCampaignCode";
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        StampCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new StampCampaignModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.StampCardType = _SQLDataReader["StampCardType"].ToString();
                            _result.StartDate = _SQLDataReader["StartDate"].ToString();
                            _result.EndDate = _SQLDataReader["EndDate"].ToString();
                            _result.StartDateOnly = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["StartDate"]);
                            _result.EndDateOnly = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["EndDate"]);
                            _result.StrEndDate = _SQLDataReader["StrEndDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.CreatedByAccNo = _SQLDataReader["CreatedByAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.StampCardBackground = _SQLDataReader["StampCardBackground"].ToString();
                            _result.AnimatedInterval = Convert.ToInt32(_SQLDataReader["AnimatedInterval"].ToString());
                            _result.isAnimated = _SQLDataReader["isAnimated"].ToString();
                            _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                            _result.isStampRulePopUp = _SQLDataReader["isStampRulePopUp"].ToString();
                            _result.LoyaltyCustomerType = _SQLDataReader["LoyaltyCustomerType"].ToString();
                            _result.StampCampaignPremiumQRCode = _SQLDataReader["StampCampaignPremiumQRCode"].ToString();
                            _result.isRequiredFee = _SQLDataReader["isRequiredFee"].ToString();
                            _result.StampCampaignFees = _SQLDataReader["StampCampaignFees"].ToString();
                            _result.FeesCycle = _SQLDataReader["FeesCycle"].ToString();
                            

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







        public static bool StampCampaign_Update(string StampCampaignCode, string StampCampaignName, string StartDate, string EndDate, string EnterpriseAccNo, string CreatedByAccNo, string CreatedBy
            , string isAnimated, int AnimatedInterval, string RowStatus, string StampRuleRemarks, string isStampRulePopUp, string LoyaltyCustomerType, string strEndDate)
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
                        _SQLCommand.CommandText = "StampCampaign_Update";
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignName", StampCampaignName);
                        _SQLCommand.Parameters.AddWithValue("@StartDate", StartDate);
                        _SQLCommand.Parameters.AddWithValue("@EndDate", EndDate);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedByAccNo", CreatedByAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@isAnimated", isAnimated);
                        _SQLCommand.Parameters.AddWithValue("@AnimatedInterval", AnimatedInterval);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@StampRuleRemarks", StampRuleRemarks);
                        _SQLCommand.Parameters.AddWithValue("@isStampRulePopUp", isStampRulePopUp);
                        _SQLCommand.Parameters.AddWithValue("@LoyaltyCustomerType", LoyaltyCustomerType);
                        _SQLCommand.Parameters.AddWithValue("@strEndDate", strEndDate);

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









        public static bool StampCampaign_UpdateStampContent(string StampContentNo, string StampCampaignCode, string StampContent)
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
                        _SQLCommand.CommandText = "StampCampaign_UpdateStampContent";
                        _SQLCommand.Parameters.AddWithValue("@StampContentNo", StampContentNo);
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@StampContent", StampContent);
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








        public static string StampCampaign_Insert(string StampCampaignName, string StampCardType, string StartDate, string EndDate, string EnterpriseAccNo, string CreatedByAccNo, string CreatedBy, string StampCardBackground)
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
                        _SQLCommand.CommandText = "StampCampaign_Insert";
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignName", StampCampaignName);
                        _SQLCommand.Parameters.AddWithValue("@StampCardType", StampCardType);
                        //_SQLCommand.Parameters.AddWithValue("@StartDate", String.Format("{0:yyyy-MM-dd}", StartDate));
                        //_SQLCommand.Parameters.AddWithValue("@EndDate", String.Format("{0:yyyy-MM-dd}", EndDate));
                        _SQLCommand.Parameters.AddWithValue("@StartDate", StartDate);
                        _SQLCommand.Parameters.AddWithValue("@EndDate", EndDate);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedByAccNo", CreatedByAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@StampCardBackground", StampCardBackground);
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = "false:Error-->"+ex.ToString();
                    }

                    finally
                    {

                        _DBConnection.Close();

                    }

                }

            }



            return _value;
        }






        public static List<StampCampaignModel>StampCampaign_LoadByGetLoyaltyCard(string EnterpriseAccNo)
        {
            List<StampCampaignModel> _Value = new List<StampCampaignModel>();

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
                        _SQLCommand.CommandText = "StampCampaign_LoadByGetLoyaltyCard";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        StampCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new StampCampaignModel();
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                            _result.StartDateOnly = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["StartDate"]);
                            _result.EndDateOnly = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["EndDate"]);
                            _result.StampCardType = _SQLDataReader["StampCardType"].ToString();
                            _result.isRequiredFee = _SQLDataReader["isRequiredFee"].ToString();
                            _result.StampCampaignFees = _SQLDataReader["StampCampaignFees"].ToString();
                            _result.FeesCycle = _SQLDataReader["FeesCycle"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.BackgroundImgOne = _SQLDataReader["BackgroundImgOne"].ToString();
                            _result.BackgroundImgTwo = _SQLDataReader["BackgroundImgTwo"].ToString();
                            _result.NextRedeem = _SQLDataReader["NextRedeem"].ToString();
                            _result.NextRedeemContent = _SQLDataReader["NextRedeemContent"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();



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