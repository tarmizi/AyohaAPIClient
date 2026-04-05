using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class MerchantLoyaltyCampaignModel
    {
        public int ID
        {
            get;
            set;
        }



        public string PointCampaignCode
        {
            get;
            set;
        }
        public string ImgPath
        {
            get;
            set;
        }


        public string ItemName
        {
            get;
            set;
        }


        public string ItemPoint
        {
            get;
            set;
        }


        public string ItemPrizePriceCost
        {
            get;
            set;
        }
        public string Remarks
        {
            get;
            set;
        }


        public string StrEndDate
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
        public string EnterpriseTagLine
        {
            get;
            set;
        }
        public string EndDate
        {
            get;
            set;
        }
        public string StartDate
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string PointCampaignName
        {
            get;
            set;
        }
        /// <summary>
        /// ///////////////////////////////////////Discount
        /// </summary>
        /// 


        
              public string DiscountCode
        {
            get;
            set;
        }
          public string DiscountImgPath
        {
            get;
            set;
        }
          public string DiscountName
        {
            get;
            set;
        }
          public string DiscountPercent
        {
            get;
            set;
        }
          public string DiscountTermAndCondition
        {
            get;
            set;
        }
          public string DiscountEndDate
        {
            get;
            set;
        }
          public string CreatedDate
        {
            get;
            set;
        }
        public string DiscountNote
        {
            get;
            set;
        }
          public string isRequireDiscountEndDate
        {
            get;
            set;
        }
        
        ////////////////////////////////////////////////




        /// <summary>
        /// //// Contest
        /// </summary>


          public string ContestCode
          {
              get;
              set;
          }
          public string AdvertisementImgPath
          {
              get;
              set;
          }
          public string ContestName
          {
              get;
              set;
          }
          public string ContestFees
          {
              get;
              set;
          }
          public string ContestDescription
          {
              get;
              set;
          }
          public string ContestType
          {
              get;
              set;
          }
          public string ContestQuestion
          {
              get;
              set;
          }
          public string isRequiredReceipt
          {
              get;
              set;
          }
       




        //////////////////////////////////////////////////



          /// <summary>
          /// //// Event
          /// </summary>


          public string EventCode
          {
              get;
              set;
          }
          public string EventCoverPhoto
          {
              get;
              set;
          }
          public string EventName
          {
              get;
              set;
          }
          public string EventType
          {
              get;
              set;
          }
          public string EventDescription
          {
              get;
              set;
          }
          public string EventStartDate
          {
              get;
              set;
          }
          public string EventEndDate
          {
              get;
              set;
          }
        


          public string EventLocationName
          {
              get;
              set;
          }
          public string EventStatus
          {
              get;
              set;
          }


          //////////////////////////////////////////////////



        public string MembershipCardCode
        {
            get;
            set;
        }
        public string CountStar
        {
            get;
            set;
        }
        public string CountReviewer
        {
            get;
            set;
        }
        public string MembershipCardFeePaymentCycle
        {
            get;
            set;
        }
        public string SearchCol
        {
            get;
            set;
        }

        public string SubscriberAccNo
        {
            get;
            set;
        }
        public string isCampaignExpired
        {
            get;
            set;
        }



        public string BusinessMode
        {
            get;
            set;
        }
        public string EnterpriseDescription
        {
            get;
            set;
        }
        public string CampaignName
        {
            get;
            set;
        }

        public string isMember
        {
            get;
            set;
        }




        public string TodayCheckInCount
        {
            get;
            set;
        }


        public string EnterpriseAddress
        {
            get;
            set;
        }

        public MerchantLoyaltyCampaignModel() { }


        public static List<MerchantLoyaltyCampaignModel> MerchantLoyaltyCampaign_LoadPoint(string SubscriberAccNo)
        {
            List<MerchantLoyaltyCampaignModel> _Value = new List<MerchantLoyaltyCampaignModel>();

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
                        _SQLCommand.CommandText = "MerchantLoyaltyCampaign_LoadPoint";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MerchantLoyaltyCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new MerchantLoyaltyCampaignModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.PointCampaignCode = _SQLDataReader["PointCampaignCode"].ToString();
                            _result.ImgPath = _SQLDataReader["ImgPath"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemPoint = _SQLDataReader["ItemPoint"].ToString();
                            _result.ItemPrizePriceCost = _SQLDataReader["ItemPrizePriceCost"].ToString();
                            _result.Remarks = _SQLDataReader["Remarks"].ToString();
                            _result.StrEndDate = _SQLDataReader["StrEndDate"].ToString();
                            _result.isCampaignExpired = _SQLDataReader["isCampaignExpired"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.PointCampaignName = _SQLDataReader["PointCampaignName"].ToString();                         
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.CountReviewer = _SQLDataReader["CountReviewer"].ToString();
                            _result.SearchCol = _SQLDataReader["EnterpriseName"].ToString() + '|' + _SQLDataReader["PointCampaignName"].ToString() + '|' + _SQLDataReader["ItemName"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.EnterpriseDescription = _SQLDataReader["EnterpriseDescription"].ToString();
                            _result.TodayCheckInCount = _SQLDataReader["TodayCheckInCount"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();

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


        public static List<MerchantLoyaltyCampaignModel> Dashboard_PointCard_SuccessCheckIn_LoadPointCardPerk(string EnterpriseAccNo,string SubscriberAccNo)
        {
            List<MerchantLoyaltyCampaignModel> _Value = new List<MerchantLoyaltyCampaignModel>();

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
                        _SQLCommand.CommandText = "Dashboard_PointCard_SuccessCheckIn_LoadPointCardPerk";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MerchantLoyaltyCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new MerchantLoyaltyCampaignModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.PointCampaignCode = _SQLDataReader["PointCampaignCode"].ToString();
                            _result.ImgPath = _SQLDataReader["ImgPath"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemPoint = _SQLDataReader["ItemPoint"].ToString();
                            _result.ItemPrizePriceCost = _SQLDataReader["ItemPrizePriceCost"].ToString();
                            _result.Remarks = _SQLDataReader["Remarks"].ToString();
                            _result.StrEndDate = _SQLDataReader["StrEndDate"].ToString();
                            _result.isCampaignExpired = _SQLDataReader["isCampaignExpired"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.PointCampaignName = _SQLDataReader["PointCampaignName"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.CountReviewer = _SQLDataReader["CountReviewer"].ToString();
                            _result.SearchCol = _SQLDataReader["EnterpriseName"].ToString() + '|' + _SQLDataReader["PointCampaignName"].ToString() + '|' + _SQLDataReader["ItemName"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.EnterpriseDescription = _SQLDataReader["EnterpriseDescription"].ToString();
                            _result.isMember = _SQLDataReader["isMember"].ToString();                         
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





        public static List<MerchantLoyaltyCampaignModel> MerchantLoyaltyCampaign_LoadDiscount(string SubscriberAccNo)
        {
            List<MerchantLoyaltyCampaignModel> _Value = new List<MerchantLoyaltyCampaignModel>();

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
                        _SQLCommand.CommandText = "MerchantLoyaltyCampaign_LoadDiscount";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MerchantLoyaltyCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new MerchantLoyaltyCampaignModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.DiscountCode = _SQLDataReader["DiscountCode"].ToString();
                            _result.DiscountImgPath = _SQLDataReader["DiscountImgPath"].ToString();
                            _result.DiscountName = _SQLDataReader["DiscountName"].ToString();
                            _result.DiscountPercent = _SQLDataReader["DiscountPercent"].ToString();
                            _result.DiscountTermAndCondition = _SQLDataReader["DiscountTermAndCondition"].ToString();
                            _result.DiscountEndDate = _SQLDataReader["DiscountEndDate"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.DiscountNote = _SQLDataReader["DiscountNote"].ToString();
                            _result.isRequireDiscountEndDate = _SQLDataReader["isRequireDiscountEndDate"].ToString(); 
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.CountReviewer = _SQLDataReader["CountReviewer"].ToString();
                            _result.SearchCol = _SQLDataReader["EnterpriseName"].ToString() + '|' + _SQLDataReader["DiscountName"].ToString() + '|' + _SQLDataReader["DiscountNote"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.EnterpriseDescription = _SQLDataReader["EnterpriseDescription"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();

                            _result.TodayCheckInCount = _SQLDataReader["TodayCheckInCount"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();

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



        public static List<MerchantLoyaltyCampaignModel> MerchantLoyaltyCampaign_LoadContest(string SubscriberAccNo)
        {
            List<MerchantLoyaltyCampaignModel> _Value = new List<MerchantLoyaltyCampaignModel>();

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
                        _SQLCommand.CommandText = "MerchantLoyaltyCampaign_LoadContest";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MerchantLoyaltyCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new MerchantLoyaltyCampaignModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ContestCode = _SQLDataReader["ContestCode"].ToString();
                            _result.AdvertisementImgPath = _SQLDataReader["AdvertisementImgPath"].ToString();
                            _result.ContestName = _SQLDataReader["ContestName"].ToString();
                            _result.ContestFees = _SQLDataReader["ContestFees"].ToString();
                            _result.ContestDescription = _SQLDataReader["ContestDescription"].ToString();
                            _result.CampaignName = _SQLDataReader["CampaignName"].ToString();                            
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.ContestType = _SQLDataReader["ContestType"].ToString();
                            _result.ContestQuestion = _SQLDataReader["ContestQuestion"].ToString();
                            _result.isRequiredReceipt = _SQLDataReader["isRequiredReceipt"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.CountReviewer = _SQLDataReader["CountReviewer"].ToString();
                            _result.SearchCol = _SQLDataReader["EnterpriseName"].ToString() + '|' + _SQLDataReader["ContestName"].ToString() + '|' + _SQLDataReader["ContestQuestion"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.EnterpriseDescription = _SQLDataReader["EnterpriseDescription"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                            _result.TodayCheckInCount = _SQLDataReader["TodayCheckInCount"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();

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






        public static List<MerchantLoyaltyCampaignModel> MerchantLoyaltyCampaign_LoadEvent(string SubscriberAccNo)
        {
            List<MerchantLoyaltyCampaignModel> _Value = new List<MerchantLoyaltyCampaignModel>();

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
                        _SQLCommand.CommandText = "MerchantLoyaltyCampaign_LoadEvent";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MerchantLoyaltyCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new MerchantLoyaltyCampaignModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EventCode = _SQLDataReader["EventCode"].ToString();
                            _result.EventCoverPhoto = _SQLDataReader["EventCoverPhoto"].ToString();
                            _result.EventName = _SQLDataReader["EventName"].ToString();
                            _result.EventType = _SQLDataReader["EventType"].ToString();
                            _result.EventDescription = _SQLDataReader["EventDescription"].ToString();
                            _result.EventStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EventStartDate"]);
                            _result.EventEndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EventEndDate"]);
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.EventLocationName = _SQLDataReader["EventLocationName"].ToString();
                            _result.EventStatus = _SQLDataReader["EventStatus"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CountStar = _SQLDataReader["CountStar"].ToString();
                            _result.CountReviewer = _SQLDataReader["CountReviewer"].ToString();
                            _result.SearchCol = _SQLDataReader["EnterpriseName"].ToString() + '|' + _SQLDataReader["EventName"].ToString() + '|' + _SQLDataReader["EventDescription"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.EnterpriseDescription = _SQLDataReader["EnterpriseDescription"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                            _result.TodayCheckInCount = _SQLDataReader["TodayCheckInCount"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();

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