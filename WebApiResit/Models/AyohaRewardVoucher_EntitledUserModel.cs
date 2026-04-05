using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaRewardVoucher_EntitledUserModel : AyohaRewardVoucherModel
    {
        public int ID
        {
            get;
            set;
        }



        public string VoucherCode
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
        public string EntitledVoucherStartDate
        {
            get;
            set;
        }
        public string EntitledVoucherEndDate
        {
            get;
            set;
        }
        public string EntitledVoucherNote
        {
            get;
            set;
        }



        public string EntitledVoucherStatus
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }

        public string CreatedDate
        {
            get;
            set;
        }
        public string CreatedBy
        {
            get;
            set;
        }
        public string DayLeft
        {
            get;
            set;
        }

        public string MembershipCardCode
        {
            get;
            set;
        }

        public int Count
        {
            get;
            set;
        }






        public string PaymentNo
        {
            get;
            set;
        }
        public string OrderNo
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

        public string ItemCartCode
        {
            get;
            set;
        }

        public int TotalQuantity
        {
            get;
            set;
        }
        public int TotalStampEarn
        {
            get;
            set;
        }
        public string PaymentAtEnterpriseAccNo
        {
            get;
            set;
        }


        public string Voucher_EnterpriseName
        {
            get;
            set;
        }

        public string Voucher_EnterpriseLogo
        {
            get;
            set;
        }

        public string EnterpriseTagLine
        {
            get;
            set;
        }
        public string SearchCol
        {
            get;
            set;
        }










        public string EnterpriseCountStar
        {
            get;
            set;
        }

        public string TotalReviewer
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

        public string MembershipCardFeePaymentCycle
        {
            get;
            set;
        }
        public string RedeemStatus
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

        public AyohaRewardVoucher_EntitledUserModel() { }


        public static List<AyohaRewardVoucher_EntitledUserModel> AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_VoucherType(string SubscriberAccNo, string VoucherType)
        {
            List<AyohaRewardVoucher_EntitledUserModel> _Value = new List<AyohaRewardVoucher_EntitledUserModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_VoucherType";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@VoucherType", VoucherType);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardVoucher_EntitledUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardVoucher_EntitledUserModel();
                            _result.EntitledVoucherStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherStartDate"]) + " " + String.Format("{0:T}", _SQLDataReader["EntitledVoucherStartDate"]);
                            _result.EntitledVoucherEndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]);
                            _result.EntitledVoucherStatus = _SQLDataReader["EntitledVoucherStatus"].ToString();
                            _result.EntitledVoucherNote = _SQLDataReader["EntitledVoucherNote"].ToString();
                            _result.VoucherCode = _SQLDataReader["VoucherCode"].ToString();
                            _result.DayLeft = _SQLDataReader["DayLeft"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherName = _SQLDataReader["VoucherName"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherImgPath = _SQLDataReader["VoucherImgPath"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherAmount = _SQLDataReader["VoucherAmount"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherTermAndCondition = _SQLDataReader["VoucherTermAndCondition"].ToString();
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






        public static List<AyohaRewardVoucher_EntitledUserModel> AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_VoucherType_VoucherHistory(string SubscriberAccNo, string VoucherType)
        {
            List<AyohaRewardVoucher_EntitledUserModel> _Value = new List<AyohaRewardVoucher_EntitledUserModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_VoucherType_VoucherHistory";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@VoucherType", VoucherType);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardVoucher_EntitledUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardVoucher_EntitledUserModel();
                            _result.EntitledVoucherStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherStartDate"]) + " " + String.Format("{0:T}", _SQLDataReader["EntitledVoucherStartDate"]);
                            _result.EntitledVoucherEndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]);
                            _result.EntitledVoucherStatus = _SQLDataReader["EntitledVoucherStatus"].ToString();
                            _result.EntitledVoucherNote = _SQLDataReader["EntitledVoucherNote"].ToString();
                            _result.VoucherCode = _SQLDataReader["VoucherCode"].ToString();
                            _result.DayLeft = _SQLDataReader["DayLeft"].ToString();
                            _result.PaymentNo = _SQLDataReader["PaymentNo"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.Voucher_EnterpriseName = _SQLDataReader["Voucher_EnterpriseName"].ToString();
                            _result.Voucher_EnterpriseLogo = _SQLDataReader["Voucher_EnterpriseLogo"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.TotalQuantity =Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            _result.TotalStampEarn = Convert.ToInt32(_SQLDataReader["TotalStampEarn"].ToString());
                            _result.PaymentAtEnterpriseAccNo =_SQLDataReader["PaymentAtEnterpriseAccNo"].ToString();                            
                            ((AyohaRewardVoucherModel)_result).VoucherName = _SQLDataReader["VoucherName"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherImgPath = _SQLDataReader["VoucherImgPath"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherAmount = _SQLDataReader["VoucherAmount"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherTermAndCondition = _SQLDataReader["VoucherTermAndCondition"].ToString();
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


        public static List<AyohaRewardVoucher_EntitledUserModel> AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MerchantReward_VoucherHistory(string SubscriberAccNo)
        {
            List<AyohaRewardVoucher_EntitledUserModel> _Value = new List<AyohaRewardVoucher_EntitledUserModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MerchantReward_VoucherHistory";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardVoucher_EntitledUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardVoucher_EntitledUserModel();
                            _result.EntitledVoucherStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherStartDate"]) + " " + String.Format("{0:T}", _SQLDataReader["EntitledVoucherStartDate"]);
                            _result.EntitledVoucherEndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]);
                            _result.EntitledVoucherStatus = _SQLDataReader["EntitledVoucherStatus"].ToString();
                            _result.EntitledVoucherNote = _SQLDataReader["EntitledVoucherNote"].ToString();
                            _result.VoucherCode = _SQLDataReader["VoucherCode"].ToString();
                            _result.DayLeft = _SQLDataReader["DayLeft"].ToString();
                            _result.PaymentNo = _SQLDataReader["PaymentNo"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.Voucher_EnterpriseName = _SQLDataReader["Voucher_EnterpriseName"].ToString();
                            _result.Voucher_EnterpriseLogo = _SQLDataReader["Voucher_EnterpriseLogo"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            _result.PaymentAtEnterpriseAccNo = _SQLDataReader["PaymentAtEnterpriseAccNo"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherName = _SQLDataReader["VoucherName"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherImgPath = _SQLDataReader["VoucherImgPath"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherAmount = _SQLDataReader["VoucherAmount"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherTermAndCondition = _SQLDataReader["VoucherTermAndCondition"].ToString();
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

        public static List<AyohaRewardVoucher_EntitledUserModel> AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_AyohaStore_VoucherHistory(string SubscriberAccNo,string EnterpriseAccNo)
        {
            List<AyohaRewardVoucher_EntitledUserModel> _Value = new List<AyohaRewardVoucher_EntitledUserModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_AyohaStore_VoucherHistory";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardVoucher_EntitledUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardVoucher_EntitledUserModel();
                            _result.EntitledVoucherStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherStartDate"]) + " " + String.Format("{0:T}", _SQLDataReader["EntitledVoucherStartDate"]);
                            _result.EntitledVoucherEndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]);
                            _result.EntitledVoucherStatus = _SQLDataReader["EntitledVoucherStatus"].ToString();
                            _result.EntitledVoucherNote = _SQLDataReader["EntitledVoucherNote"].ToString();
                            _result.VoucherCode = _SQLDataReader["VoucherCode"].ToString();
                            _result.DayLeft = _SQLDataReader["DayLeft"].ToString();
                            _result.PaymentNo = _SQLDataReader["PaymentNo"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.Voucher_EnterpriseName = _SQLDataReader["Voucher_EnterpriseName"].ToString();
                            _result.Voucher_EnterpriseLogo = _SQLDataReader["Voucher_EnterpriseLogo"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            _result.PaymentAtEnterpriseAccNo = _SQLDataReader["PaymentAtEnterpriseAccNo"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherName = _SQLDataReader["VoucherName"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherImgPath = _SQLDataReader["VoucherImgPath"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherAmount = _SQLDataReader["VoucherAmount"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherTermAndCondition = _SQLDataReader["VoucherTermAndCondition"].ToString();
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

        public static List<AyohaRewardVoucher_EntitledUserModel> AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MembershipCard(string SubscriberAccNo, string EnterpriseAccNo)
        {
            List<AyohaRewardVoucher_EntitledUserModel> _Value = new List<AyohaRewardVoucher_EntitledUserModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MembershipCard";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardVoucher_EntitledUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardVoucher_EntitledUserModel();
                            _result.EntitledVoucherStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherStartDate"]) + " " + String.Format("{0:T}", _SQLDataReader["EntitledVoucherStartDate"]);
                            _result.EntitledVoucherEndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]);
                            _result.EntitledVoucherStatus = _SQLDataReader["EntitledVoucherStatus"].ToString();
                            _result.EntitledVoucherNote = _SQLDataReader["EntitledVoucherNote"].ToString();
                            _result.VoucherCode = _SQLDataReader["VoucherCode"].ToString();
                            _result.DayLeft = _SQLDataReader["DayLeft"].ToString();
                            _result.PaymentNo = _SQLDataReader["PaymentNo"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.Voucher_EnterpriseName = _SQLDataReader["Voucher_EnterpriseName"].ToString();
                            _result.Voucher_EnterpriseLogo = _SQLDataReader["Voucher_EnterpriseLogo"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            _result.PaymentAtEnterpriseAccNo = _SQLDataReader["PaymentAtEnterpriseAccNo"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherName = _SQLDataReader["VoucherName"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherImgPath = _SQLDataReader["VoucherImgPath"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherAmount = _SQLDataReader["VoucherAmount"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherTermAndCondition = _SQLDataReader["VoucherTermAndCondition"].ToString();
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



        public static List<AyohaRewardVoucher_EntitledUserModel> AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MerchantLoyaltyCampaign(string SubscriberAccNo, string EnterpriseAccNo)
        {
            List<AyohaRewardVoucher_EntitledUserModel> _Value = new List<AyohaRewardVoucher_EntitledUserModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MerchantLoyaltyCampaign";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardVoucher_EntitledUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardVoucher_EntitledUserModel();
                            _result.EntitledVoucherStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherStartDate"]) + " " + String.Format("{0:T}", _SQLDataReader["EntitledVoucherStartDate"]);
                            _result.EntitledVoucherEndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]);
                            _result.EntitledVoucherStatus = _SQLDataReader["EntitledVoucherStatus"].ToString();
                            _result.EntitledVoucherNote = _SQLDataReader["EntitledVoucherNote"].ToString();
                            _result.VoucherCode = _SQLDataReader["VoucherCode"].ToString();
                            _result.DayLeft = _SQLDataReader["DayLeft"].ToString();
                            _result.PaymentNo = _SQLDataReader["PaymentNo"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.Voucher_EnterpriseName = _SQLDataReader["Voucher_EnterpriseName"].ToString();
                            _result.Voucher_EnterpriseLogo = _SQLDataReader["Voucher_EnterpriseLogo"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.SearchCol = _SQLDataReader["EnterpriseName"].ToString() + '|' + _SQLDataReader["VoucherName"].ToString();
                            _result.PaymentAtEnterpriseAccNo = _SQLDataReader["PaymentAtEnterpriseAccNo"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherName = _SQLDataReader["VoucherName"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherImgPath = _SQLDataReader["VoucherImgPath"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherAmount = _SQLDataReader["VoucherAmount"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherTermAndCondition = _SQLDataReader["VoucherTermAndCondition"].ToString();
                            _result.EnterpriseCountStar = _SQLDataReader["EnterpriseCountStar"].ToString();
                            _result.TotalReviewer = _SQLDataReader["TotalReviewer"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.EnterpriseDescription = _SQLDataReader["EnterpriseDescription"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                            _result.SearchCol = _SQLDataReader["EnterpriseName"].ToString() + '|' + _SQLDataReader["VoucherName"].ToString();

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




        public static List<AyohaRewardVoucher_EntitledUserModel> AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MerchantReward(string SubscriberAccNo, string VoucherType)
        {
            List<AyohaRewardVoucher_EntitledUserModel> _Value = new List<AyohaRewardVoucher_EntitledUserModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_MerchantReward";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@VoucherType", VoucherType);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardVoucher_EntitledUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardVoucher_EntitledUserModel();
                            _result.EntitledVoucherStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherStartDate"]) + " " + String.Format("{0:T}", _SQLDataReader["EntitledVoucherStartDate"]);
                            _result.EntitledVoucherEndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]);
                            _result.EntitledVoucherStatus = _SQLDataReader["EntitledVoucherStatus"].ToString();
                            _result.EntitledVoucherNote = _SQLDataReader["EntitledVoucherNote"].ToString();
                            _result.VoucherCode = _SQLDataReader["VoucherCode"].ToString();
                            _result.DayLeft = _SQLDataReader["DayLeft"].ToString();
                            //_result.EnterpriseLogo = _SQLDataReader["EnterpiseLogo"].ToString();
                            //_result.EnterpriseName = _SQLDataReader["EnterpiseName"].ToString();
                            //_result.PaymentNo = _SQLDataReader["PaymentNo"].ToString();
                            //_result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            //_result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            //_result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            //_result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            //_result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            //_result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            //_result.PaymentAtEnterpriseAccNo = _SQLDataReader["PaymentAtEnterpriseAccNo"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherName = _SQLDataReader["VoucherName"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherImgPath = _SQLDataReader["VoucherImgPath"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherAmount = _SQLDataReader["VoucherAmount"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherTermAndCondition = _SQLDataReader["VoucherTermAndCondition"].ToString();
                       
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








        public static List<AyohaRewardVoucher_EntitledUserModel> VoucherCampaignRedeemLoadByVoucherRedeemStatus(string SubscriberAccNo, string RedeemStatus)
        {
            List<AyohaRewardVoucher_EntitledUserModel> _Value = new List<AyohaRewardVoucher_EntitledUserModel>();

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
                        _SQLCommand.CommandText = "VoucherCampaignRedeemLoadByVoucherRedeemStatus";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@RedeemStatus", RedeemStatus);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardVoucher_EntitledUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardVoucher_EntitledUserModel();
                            _result.EntitledVoucherStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherStartDate"]) + " " + String.Format("{0:T}", _SQLDataReader["EntitledVoucherStartDate"]);
                            _result.EntitledVoucherEndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]);
                            _result.EntitledVoucherStatus = _SQLDataReader["EntitledVoucherStatus"].ToString();
                            _result.EntitledVoucherNote = _SQLDataReader["EntitledVoucherNote"].ToString();
                            _result.VoucherCode = _SQLDataReader["VoucherCode"].ToString();
                            _result.DayLeft = _SQLDataReader["DayLeft"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.SearchCol = _SQLDataReader["VoucherName"].ToString() + "|" + _SQLDataReader["EnterpriseName"].ToString() + "|" + _SQLDataReader["VoucherAmount"].ToString() + "|" + String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]); 
                            //_result.PaymentNo = _SQLDataReader["PaymentNo"].ToString();
                            //_result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            //_result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            //_result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            //_result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            //_result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            //_result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            //_result.PaymentAtEnterpriseAccNo = _SQLDataReader["PaymentAtEnterpriseAccNo"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherName = _SQLDataReader["VoucherName"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherImgPath = _SQLDataReader["VoucherImgPath"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherAmount = _SQLDataReader["VoucherAmount"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherTermAndCondition = _SQLDataReader["VoucherTermAndCondition"].ToString();

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






        public static List<AyohaRewardVoucher_EntitledUserModel> Dashboard_VoucherCard_SuccessCheckIn_LoadVoucherPerk(string EnterpriseAccNo, string SubscriberAccNo)
        {
            List<AyohaRewardVoucher_EntitledUserModel> _Value = new List<AyohaRewardVoucher_EntitledUserModel>();

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
                        _SQLCommand.CommandText = "Dashboard_VoucherCard_SuccessCheckIn_LoadVoucherPerk";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);                      
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardVoucher_EntitledUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardVoucher_EntitledUserModel();
                            _result.EntitledVoucherStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherStartDate"]) + " " + String.Format("{0:T}", _SQLDataReader["EntitledVoucherStartDate"]);
                            _result.EntitledVoucherEndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]);
                            _result.EntitledVoucherStatus = _SQLDataReader["EntitledVoucherStatus"].ToString();
                            _result.EntitledVoucherNote = _SQLDataReader["EntitledVoucherNote"].ToString();
                            _result.VoucherCode = _SQLDataReader["VoucherCode"].ToString();
                            _result.DayLeft = _SQLDataReader["DayLeft"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.SearchCol = _SQLDataReader["VoucherName"].ToString() + "|" + _SQLDataReader["EnterpriseName"].ToString() + "|" + _SQLDataReader["VoucherAmount"].ToString() + "|" + String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]);
                            //_result.PaymentNo = _SQLDataReader["PaymentNo"].ToString();
                            //_result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            //_result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            //_result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            //_result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            //_result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            //_result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            //_result.PaymentAtEnterpriseAccNo = _SQLDataReader["PaymentAtEnterpriseAccNo"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherName = _SQLDataReader["VoucherName"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherImgPath = _SQLDataReader["VoucherImgPath"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherAmount = _SQLDataReader["VoucherAmount"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherTermAndCondition = _SQLDataReader["VoucherTermAndCondition"].ToString();
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



        public static List<AyohaRewardVoucher_EntitledUserModel> AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_PaymentNo_EntitledVoucherStatus(string SubscriberAccNo, string PaymentNo, string EntitledVoucherStatus, string EnterpriseAccNo)
        {
            List<AyohaRewardVoucher_EntitledUserModel> _Value = new List<AyohaRewardVoucher_EntitledUserModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_PaymentNo_EntitledVoucherStatus";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@PaymentNo", PaymentNo);
                        _SQLCommand.Parameters.AddWithValue("@EntitledVoucherStatus", EntitledVoucherStatus);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardVoucher_EntitledUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardVoucher_EntitledUserModel();
                            _result.EntitledVoucherStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherStartDate"]) + " " + String.Format("{0:T}", _SQLDataReader["EntitledVoucherStartDate"]);
                            _result.EntitledVoucherEndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]);
                            _result.EntitledVoucherStatus = _SQLDataReader["EntitledVoucherStatus"].ToString();
                            _result.EntitledVoucherNote = _SQLDataReader["EntitledVoucherNote"].ToString();
                            _result.VoucherCode = _SQLDataReader["VoucherCode"].ToString();
                            _result.DayLeft = _SQLDataReader["DayLeft"].ToString();
                            _result.PaymentNo = _SQLDataReader["PaymentNo"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            _result.PaymentAtEnterpriseAccNo = _SQLDataReader["PaymentAtEnterpriseAccNo"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherName = _SQLDataReader["VoucherName"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherImgPath = _SQLDataReader["VoucherImgPath"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherAmount = _SQLDataReader["VoucherAmount"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherTermAndCondition = _SQLDataReader["VoucherTermAndCondition"].ToString();
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







        public static List<AyohaRewardVoucher_EntitledUserModel> AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_EnterpriseAccNo_MembershipCardCode(string SubscriberAccNo, string EnterpriseAccNo,string MembershipCardCode)
        {
            List<AyohaRewardVoucher_EntitledUserModel> _Value = new List<AyohaRewardVoucher_EntitledUserModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_LoadBySubscriberAccNo_EnterpriseAccNo_MembershipCardCode";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardVoucher_EntitledUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardVoucher_EntitledUserModel();
                            _result.EntitledVoucherStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherStartDate"]) + " " + String.Format("{0:T}", _SQLDataReader["EntitledVoucherStartDate"]);
                            _result.EntitledVoucherEndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]);
                            _result.EntitledVoucherStatus = _SQLDataReader["EntitledVoucherStatus"].ToString();
                            _result.EntitledVoucherNote = _SQLDataReader["EntitledVoucherNote"].ToString();
                            _result.VoucherCode = _SQLDataReader["VoucherCode"].ToString();
                            _result.DayLeft = _SQLDataReader["DayLeft"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherName = _SQLDataReader["VoucherName"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherImgPath = _SQLDataReader["VoucherImgPath"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherAmount = _SQLDataReader["VoucherAmount"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherTermAndCondition = _SQLDataReader["VoucherTermAndCondition"].ToString();
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








        public static List<AyohaRewardVoucher_EntitledUserModel> AyohaRewardVoucher_EntitledUser_EntitledVoucherStatusTemp_LoadBySubscriberAccNo_EnterpriseAccNo_MembershipCardCode(string SubscriberAccNo, string EnterpriseAccNo, string MembershipCardCode)
        {
            List<AyohaRewardVoucher_EntitledUserModel> _Value = new List<AyohaRewardVoucher_EntitledUserModel>();

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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_EntitledVoucherStatusTemp_LoadBySubscriberAccNo_EnterpriseAccNo_MembershipCardCode";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaRewardVoucher_EntitledUserModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaRewardVoucher_EntitledUserModel();
                            _result.EntitledVoucherStartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherStartDate"]) + " " + String.Format("{0:T}", _SQLDataReader["EntitledVoucherStartDate"]);
                            _result.EntitledVoucherEndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EntitledVoucherEndDate"]);
                            _result.EntitledVoucherStatus = _SQLDataReader["EntitledVoucherStatus"].ToString();
                            _result.EntitledVoucherNote = _SQLDataReader["EntitledVoucherNote"].ToString();
                            _result.VoucherCode = _SQLDataReader["VoucherCode"].ToString();
                            _result.DayLeft = _SQLDataReader["DayLeft"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherName = _SQLDataReader["VoucherName"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherImgPath = _SQLDataReader["VoucherImgPath"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherAmount = _SQLDataReader["VoucherAmount"].ToString();
                            ((AyohaRewardVoucherModel)_result).VoucherTermAndCondition = _SQLDataReader["VoucherTermAndCondition"].ToString();
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


        public static string AyohaRewardVoucher_EntitledUser_AyohaStoreCart_UpdateVoucherStatus(string VoucherCode, string SubscriberAccNo, int Count)
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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_AyohaStoreCart_UpdateVoucherStatus";
                        _SQLCommand.Parameters.AddWithValue("@VoucherCode", VoucherCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@Count", Count);
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



        public static string AyohaRewardVoucher_EntitledUser_EntitledVoucherStatusTemp_AyohaStoreCart_UpdateVoucherStatus_SingleTap(string VoucherCode, string SubscriberAccNo, string EntitledVoucherStatus)
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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_EntitledVoucherStatusTemp_AyohaStoreCart_UpdateVoucherStatus_SingleTap";
                        _SQLCommand.Parameters.AddWithValue("@VoucherCode", VoucherCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EntitledVoucherStatus", EntitledVoucherStatus);
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


        public static string AyohaRewardVoucher_EntitledUser_UpdateEntitledVoucherStatus(string SubscriberAccNo, string VoucherCode, string EntitledVoucherStatus, int Count)
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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_UpdateEntitledVoucherStatus";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@VoucherCode", VoucherCode);                      
                        _SQLCommand.Parameters.AddWithValue("@EntitledVoucherStatus", EntitledVoucherStatus);
                        _SQLCommand.Parameters.AddWithValue("@Count", Count);
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



        public static string AyohaRewardVoucher_EntitledUser_AyohaStoreCart_UpdateVoucherStatus_SingleTap(string VoucherCode, string SubscriberAccNo, string EntitledVoucherStatus)
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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_AyohaStoreCart_UpdateVoucherStatus_SingleTap";
                        _SQLCommand.Parameters.AddWithValue("@VoucherCode", VoucherCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EntitledVoucherStatus", EntitledVoucherStatus);
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






        public static string AyohaRewardVoucher_EntitledUser_EntitledVoucherStatusTemp_UpdateEntitledVoucherStatus(string SubscriberAccNo, string VoucherCode, string EntitledVoucherStatus, int Count)
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
                        _SQLCommand.CommandText = "AyohaRewardVoucher_EntitledUser_EntitledVoucherStatusTemp_UpdateEntitledVoucherStatus";
                           _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@VoucherCode", VoucherCode);
                        _SQLCommand.Parameters.AddWithValue("@EntitledVoucherStatus", EntitledVoucherStatus);                     
                        _SQLCommand.Parameters.AddWithValue("@Count", Count);
                        
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


    }
}