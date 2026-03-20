using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
namespace WebApiResit.Models
{
    public class DashboardAyohaUserModel
    {
         public string ThisWeekCountsStamp
        {
            get;
            set;
        }

        public string ThisWeekCountsPoint
        {
            get;
            set;
        }
        public string TotalCountStamp
        {
            get;
            set;
        }

        public string TotalCountPoint
        {
            get;
            set;
        }
        public string TotalMembershipCard
        {
            get;
            set;
        }

        public string AyohaPoint
        {
            get;
            set;
        }

        public string TotalCampaign
        {
            get;
            set;
        }









        public string LatestStamp
        {
            get;
            set;
        }
        public string LatestStampDate
        {
            get;
            set;
        }

        public string LatestPoint
        {
            get;
            set;
        }

        public string LatestPointDate
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


        
        public string EnterpriseNameStampCard
        {
            get;
            set;
        }

        public string EnterpriseNamePointCard
        {
            get;
            set;
        }



        public string LatestStampCampaignCode
        {
            get;
            set;
        }

        public string LatestPointCampaignCode
        {
            get;
            set;
        }

        public string PNUnread
        {
            get;
            set;
        }
        
        public string ThisWeekCountsStampRedeem
        {
            get;
            set;
        }


        public string ThisWeekCountsPointRedeem
        {
            get;
            set;
        }
        
        public string SubscriberAccNo
        {
            get;
            set;
        }

        public string TotalItemQuantityCart
        {
            get;
            set;
        }



        public string AyohaTaAndWin_TapBalance
        {
            get;
            set;
        }

        public string AyohaMember_Rank
        {
            get;
            set;
        }










        public string BadgeCount_Stamp
        {
            get;
            set;
        }

        public string BadgeCount_Point
        {
            get;
            set;
        }
        public string BadgeCount_Discount
        {
            get;
            set;
        }

        public string BadgeCount_Contest
        {
            get;
            set;
        }
        public string BadgeCount_Event
        {
            get;
            set;
        }

        public string BadgeCount_Voucher
        {
            get;
            set;
        }

        public DashboardAyohaUserModel() { }




        public static List<DashboardAyohaUserModel> DashboardAyohaUser_Main(string SubscriberAccNo)
        {
            List<DashboardAyohaUserModel> _Value = new List<DashboardAyohaUserModel>();

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
                        _SQLCommand.CommandText = "DashboardAyohaUser_Main";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        DashboardAyohaUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new DashboardAyohaUserModel();

                            _result.ThisWeekCountsStamp = _SQLDataReader["ThisWeekCountsStamp"].ToString();
                            _result.ThisWeekCountsPoint = _SQLDataReader["ThisWeekCountsPoint"].ToString();
                            _result.TotalCountStamp = _SQLDataReader["TotalCountStamp"].ToString();
                            _result.TotalCountPoint = _SQLDataReader["TotalCountPoint"].ToString();
                            _result.TotalMembershipCard = _SQLDataReader["TotalMembershipCard"].ToString();
                            _result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                            _result.TotalCampaign = _SQLDataReader["TotalCampaign"].ToString();
                            _result.LatestStamp = _SQLDataReader["LatestStamp"].ToString();
                          //  _result.LatestStampDate = _SQLDataReader["LatestStampDate"].ToString();
                            _result.LatestStampDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["LatestStampDate"]) + " " + String.Format("{0:T}", _SQLDataReader["LatestStampDate"]);
                            _result.LatestPoint = _SQLDataReader["LatestPoint"].ToString();
                           // _result.LatestPointDate = _SQLDataReader["LatestPointDate"].ToString();
                            _result.LatestPointDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["LatestPointDate"]) + " " + String.Format("{0:T}", _SQLDataReader["LatestPointDate"]);
                            _result.TypeCRDB = _SQLDataReader["TypeCRDB"].ToString();
                            _result.PointType = _SQLDataReader["PointType"].ToString();
                              _result.EnterpriseNameStampCard = _SQLDataReader["EnterpriseNameStampCard"].ToString();
                              _result.EnterpriseNamePointCard = _SQLDataReader["EnterpriseNamePointCard"].ToString();                            
                             _result.LatestPointCampaignCode = _SQLDataReader["LatestPointCampaignCode"].ToString();
                             _result.LatestStampCampaignCode = _SQLDataReader["LatestStampCampaignCode"].ToString();
                             _result.PNUnread = _SQLDataReader["PNUnread"].ToString();
                             _result.ThisWeekCountsStampRedeem = _SQLDataReader["ThisWeekCountsStampRedeem"].ToString();
                             _result.ThisWeekCountsPointRedeem = _SQLDataReader["ThisWeekCountsPointRedeem"].ToString();
                             _result.TotalItemQuantityCart = _SQLDataReader["TotalItemQuantityCart"].ToString();
                             _result.AyohaTaAndWin_TapBalance = _SQLDataReader["AyohaTaAndWin_TapBalance"].ToString();
                             _result.AyohaMember_Rank = _SQLDataReader["AyohaMember_Rank"].ToString();
                             _result.BadgeCount_Stamp = _SQLDataReader["BadgeCount_Stamp"].ToString();
                             _result.BadgeCount_Point = _SQLDataReader["BadgeCount_Point"].ToString();
                             _result.BadgeCount_Discount = _SQLDataReader["BadgeCount_Discount"].ToString();
                             _result.BadgeCount_Contest = _SQLDataReader["BadgeCount_Contest"].ToString();
                             _result.BadgeCount_Event = _SQLDataReader["BadgeCount_Event"].ToString();
                             _result.BadgeCount_Voucher = _SQLDataReader["BadgeCount_Voucher"].ToString();
                            
                                
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






        public static List<DashboardAyohaUserModel> DashboardAyohaUser_Main_getAyohaPoint(string SubscriberAccNo)
        {
            List<DashboardAyohaUserModel> _Value = new List<DashboardAyohaUserModel>();

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
                        _SQLCommand.CommandText = "DashboardAyohaUser_Main_getAyohaPoint";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        DashboardAyohaUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new DashboardAyohaUserModel();

                       
                            _result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();



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