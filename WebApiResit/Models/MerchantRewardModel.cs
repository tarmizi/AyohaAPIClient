using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class MerchantRewardModel
    {
        public string SubscriberAccNo
        {
            get;
            set;
        }


        public int ContestEligible
        {
            get;
            set;
        }
        public int ContestJoined
        {
            get;
            set;
        }

        public int ContestApproved
        {
            get;
            set;
        }


        public int ContestExpired
        {
            get;
            set;
        }

        public int EventEligible
        {
            get;
            set;
        }
        public int EventJoined
        {
            get;
            set;
        }


        public int Event_IwillAttend
        {
            get;
            set;
        }
        public int Event_Interested
        {
            get;
            set;
        }
        public int EventExpired
        {
            get;
            set;
        }





        public int PointPerksEligible
        {
            get;
            set;
        }

        public int PointPerksRedeemSubmitted
        {
            get;
            set;
        }
        public int PointPerksRedeemApproved
        {
            get;
            set;
        }

        public int PointPerksExpired
        {
            get;
            set;
        }

        public int StampedPerksEligible
        {
            get;
            set;
        }

        public int StampedPerksRedeemSubmitted
        {
            get;
            set;
        }












        public int StampedPerksRedeemApproved
        {
            get;
            set;
        }

        public int StampedPerksRedeemRejected
        {
            get;
            set;
        }

        public int StampedPerksRedeemExpired
        {
            get;
            set;
        }

        public int VoucherPerksEligible
        {
            get;
            set;
        }



        public int VoucherPerksRedeem
        {
            get;
            set;
        }

        public int VoucherPerksRedeemApproved
        {
            get;
            set;
        }



        public int VoucherExpired
        {
            get;
            set;
        }






        public int DiscountEligible
        {
            get;
            set;
        }

        public int DiscountExpired
        {
            get;
            set;
        }



        public int DiscountRedeem
        {
            get;
            set;
        }
        public MerchantRewardModel() { }


        public static List<MerchantRewardModel> MerchantReward_Perks_DashboardData(string SubscriberAccNo)
        {
            List<MerchantRewardModel> _Value = new List<MerchantRewardModel>();

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
                        _SQLCommand.CommandText = "MerchantReward_Perks_DashboardData";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MerchantRewardModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new MerchantRewardModel();
                            _result.ContestEligible = Convert.ToInt32(_SQLDataReader["ContestEligible"].ToString());
                            _result.ContestJoined = Convert.ToInt32(_SQLDataReader["ContestJoined"].ToString());
                            _result.ContestApproved = Convert.ToInt32(_SQLDataReader["ContestApproved"].ToString());                            
                            _result.ContestExpired = Convert.ToInt32(_SQLDataReader["ContestExpired"].ToString());

                            _result.EventEligible = Convert.ToInt32(_SQLDataReader["EventEligible"].ToString());
                            _result.EventJoined = Convert.ToInt32(_SQLDataReader["EventJoined"].ToString());
                            _result.EventExpired = Convert.ToInt32(_SQLDataReader["EventExpired"].ToString());

                            _result.Event_IwillAttend = Convert.ToInt32(_SQLDataReader["Event_IwillAttend"].ToString());
                            _result.Event_Interested = Convert.ToInt32(_SQLDataReader["Event_Interested"].ToString());


                            _result.PointPerksEligible = Convert.ToInt32(_SQLDataReader["PointPerksEligible"].ToString());
                            _result.PointPerksRedeemSubmitted = Convert.ToInt32(_SQLDataReader["PointPerksRedeemSubmitted"].ToString());
                            _result.PointPerksRedeemApproved = Convert.ToInt32(_SQLDataReader["PointPerksRedeemApproved"].ToString());
                            _result.PointPerksExpired = Convert.ToInt32(_SQLDataReader["PointPerksExpired"].ToString());




                            _result.StampedPerksEligible = Convert.ToInt32(_SQLDataReader["StampedPerksEligible"].ToString());
                            _result.StampedPerksRedeemSubmitted = Convert.ToInt32(_SQLDataReader["StampedPerksRedeemSubmitted"].ToString());
                            _result.StampedPerksRedeemApproved = Convert.ToInt32(_SQLDataReader["StampedPerksRedeemApproved"].ToString());
                            _result.StampedPerksRedeemRejected = Convert.ToInt32(_SQLDataReader["StampedPerksRedeemRejected"].ToString());
                            _result.StampedPerksRedeemExpired = Convert.ToInt32(_SQLDataReader["StampedPerksRedeemExpired"].ToString());


                            _result.VoucherPerksEligible = Convert.ToInt32(_SQLDataReader["VoucherPerksEligible"].ToString());
                            _result.VoucherPerksRedeem = Convert.ToInt32(_SQLDataReader["VoucherPerksRedeem"].ToString());
                            _result.VoucherPerksRedeemApproved = Convert.ToInt32(_SQLDataReader["VoucherPerksRedeemApproved"].ToString());
                            _result.VoucherExpired = Convert.ToInt32(_SQLDataReader["VoucherExpired"].ToString());



                            _result.DiscountEligible = Convert.ToInt32(_SQLDataReader["DiscountEligible"].ToString());
                            _result.DiscountExpired = Convert.ToInt32(_SQLDataReader["DiscountExpired"].ToString());
                            _result.DiscountRedeem = Convert.ToInt32(_SQLDataReader["DiscountRedeem"].ToString());

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

      


        public static List<MerchantRewardModel> MerchantReward_Perks_RedeemJoinedApproved(string SubscriberAccNo)
        {
            List<MerchantRewardModel> _Value = new List<MerchantRewardModel>();

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
                        _SQLCommand.CommandText = "MerchantReward_Perks_RedeemJoinedApproved";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MerchantRewardModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new MerchantRewardModel();
                            _result.ContestJoined = Convert.ToInt32(_SQLDataReader["ContestJoined"].ToString());
                            _result.EventJoined = Convert.ToInt32(_SQLDataReader["EventJoined"].ToString());
                            _result.PointPerksRedeemSubmitted = Convert.ToInt32(_SQLDataReader["PointPerksRedeemSubmitted"].ToString());
                            _result.PointPerksRedeemApproved = Convert.ToInt32(_SQLDataReader["PointPerksRedeemApproved"].ToString());
                            _result.StampedPerksRedeemSubmitted = Convert.ToInt32(_SQLDataReader["StampedPerksRedeemSubmitted"].ToString());
                            _result.StampedPerksRedeemApproved = Convert.ToInt32(_SQLDataReader["StampedPerksRedeemApproved"].ToString());
                            _result.StampedPerksRedeemRejected = Convert.ToInt32(_SQLDataReader["StampedPerksRedeemRejected"].ToString());
                            _result.StampedPerksRedeemExpired = Convert.ToInt32(_SQLDataReader["StampedPerksRedeemExpired"].ToString());
                            _result.VoucherPerksRedeem = Convert.ToInt32(_SQLDataReader["VoucherPerksRedeem"].ToString());
                           // _result.DiscountRedeem = Convert.ToInt32(_SQLDataReader["DiscountRedeem"].ToString());
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