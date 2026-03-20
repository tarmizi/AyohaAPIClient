using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaeWalletTransactionModel
    {
        public int ID
        {
            get;
            set;
        }

        public int MonthNumber
        {
            get;
            set;
        }

        public string eWalletAccNo
        {
            get;
            set;
        }
        public string TransactionType
        {
            get;
            set;
        }
        public string TransactionAmount
        {
            get;
            set;
        }
        public string TransactionReferenceNo
        {
            get;
            set;
        }
        public string TransactionStatus
        {
            get;
            set;
        }
        public string TransactionNote
        {
            get;
            set;
        }
        public string CreditDebitType
        {
            get;
            set;
        }
        public string CustomerAccNo
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
        public string AccountName
        {
            get;
            set;
        }
        public string AccountProfileImg
        {
            get;
            set;
        }
        public string ItemCartCode
        {
            get;
            set;
        }
        public string MembershipCardCode
        {
            get;
            set;
        }
        public string CreatedDate_DateOnly
        {
            get;
            set;
        }

        public string OrderNo
        {
            get;
            set;
        }

        public string CreatedDate_MonthYear
        {
            get;
            set;
        }

        public string ThisMonthSpent
        {
            get;
            set;
        }

        public string ThisMonthIncome
        {
            get;
            set;
        }






        public string PhoneNo
        {
            get;
            set;
        }

        public string UserProfileImg
        {
            get;
            set;
        }

        public string FullAccountName
        {
            get;
            set;
        }

        public string TransferredToPlayerID
        {
            get;
            set;
        }



        public string CashOutCharge
        {
            get;
            set;
        }

        public string CashOutPercentageCharge
        {
            get;
            set;
        }

        public string TotalCashOutAmount
        {
            get;
            set;
        }



        public string TotalStampEarn
        {
            get;
            set;

        }




        public string MemberDiscountPercent
        {
            get;
            set;
        }



        public string MemberDiscountAmount
        {
            get;
            set;

        }

        public string billExternalNo
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

        public string FilterType
        {
            get;
            set;

        }


        public string Year
        {
            get;
            set;

        }

        public string AyohaPoint
        {
            get;
            set;

        }





        public string PaymentMethod
        {
            get;
            set;

        }


        public string PaymentChannel
        {
            get;
            set;

        }





        public string SubscriberAccNo
        {
            get;
            set;

        }

        
        public string RedeemStatus
        {
            get;
            set;

        }


        public string SearchCol
        {
            get;
            set;

        }
        public AyohaeWalletTransactionModel() { }

        public static List<AyohaeWalletTransactionModel> AyohaeWalletTransaction_Enterprises_LoadBy_eWalletAccNo_TransactionReferenceNo(string eWalletAccNo, string TransactionReferenceNo)
        {
            List<AyohaeWalletTransactionModel> _Value = new List<AyohaeWalletTransactionModel>();

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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_Enterprises_LoadBy_eWalletAccNo_TransactionReferenceNo";
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _SQLCommand.Parameters.AddWithValue("@TransactionReferenceNo", TransactionReferenceNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletTransactionModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaeWalletTransactionModel();
                            _result.TransactionAmount = _SQLDataReader["TransactionAmount"].ToString();
                            _result.TransactionType = _SQLDataReader["TransactionType"].ToString();
                            _result.TransactionStatus = _SQLDataReader["TransactionStatus"].ToString();
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

        public static List<AyohaeWalletTransactionModel> AyohaeWalletTransaction_Enterprises_LoadBy_eWalletAccNo_billExternalNo(string eWalletAccNo, string billExternalNo)
        {
            List<AyohaeWalletTransactionModel> _Value = new List<AyohaeWalletTransactionModel>();

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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_Enterprises_LoadBy_eWalletAccNo_billExternalNo";
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _SQLCommand.Parameters.AddWithValue("@billExternalNo", billExternalNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletTransactionModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaeWalletTransactionModel();
                            _result.TransactionAmount = _SQLDataReader["TransactionAmount"].ToString();
                            _result.TransactionType = _SQLDataReader["TransactionType"].ToString();
                            _result.TransactionStatus = _SQLDataReader["TransactionStatus"].ToString();
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
        public static List<AyohaeWalletTransactionModel> AyohaeWalletTransaction_LoadBy_eWalletAccNo_LatestTransactions(string eWalletAccNo)
        {
            List<AyohaeWalletTransactionModel> _Value = new List<AyohaeWalletTransactionModel>();

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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_LoadBy_eWalletAccNo_LatestTransactions";
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletTransactionModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaeWalletTransactionModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.eWalletAccNo = _SQLDataReader["eWalletAccNo"].ToString();
                            _result.TransactionType = _SQLDataReader["TransactionType"].ToString();
                            _result.TransactionAmount = _SQLDataReader["TransactionAmount"].ToString();
                            _result.TransactionReferenceNo = _SQLDataReader["TransactionReferenceNo"].ToString();
                            _result.TransactionStatus = _SQLDataReader["TransactionStatus"].ToString();
                            _result.TransactionNote = _SQLDataReader["TransactionNote"].ToString();
                            _result.CreditDebitType = _SQLDataReader["CreditDebitType"].ToString();
                            _result.CustomerAccNo = _SQLDataReader["CustomerAccNo"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.AccountProfileImg = _SQLDataReader["AccountProfileImg"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.ThisMonthSpent = _SQLDataReader["ThisMonthSpent"].ToString();
                            _result.ThisMonthIncome = _SQLDataReader["ThisMonthIncome"].ToString();
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.UserProfileImg = _SQLDataReader["UserProfileImg"].ToString();
                            _result.FullAccountName = _SQLDataReader["FullAccountName"].ToString();
                            _result.TotalStampEarn = _SQLDataReader["TotalStampEarn"].ToString();
                            _result.MemberDiscountPercent = _SQLDataReader["MemberDiscountPercent"].ToString();
                            _result.MemberDiscountAmount = _SQLDataReader["MemberDiscountAmount"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
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






        public static List<AyohaeWalletTransactionModel> AyohaeWalletTransaction_LoadBy_eWalletAccNo_LatestTransferTransactions(string eWalletAccNo)
        {
            List<AyohaeWalletTransactionModel> _Value = new List<AyohaeWalletTransactionModel>();

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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_LoadBy_eWalletAccNo_LatestTransferTransactions";
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletTransactionModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaeWalletTransactionModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.eWalletAccNo = _SQLDataReader["eWalletAccNo"].ToString();
                            _result.TransactionType = _SQLDataReader["TransactionType"].ToString();
                            _result.TransactionAmount = _SQLDataReader["TransactionAmount"].ToString();
                            _result.TransactionReferenceNo = _SQLDataReader["TransactionReferenceNo"].ToString();
                            _result.TransactionStatus = _SQLDataReader["TransactionStatus"].ToString();
                            _result.TransactionNote = _SQLDataReader["TransactionNote"].ToString();
                            _result.CreditDebitType = _SQLDataReader["CreditDebitType"].ToString();
                            _result.CustomerAccNo = _SQLDataReader["CustomerAccNo"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.AccountProfileImg = _SQLDataReader["AccountProfileImg"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.ThisMonthSpent = _SQLDataReader["ThisMonthSpent"].ToString();
                            _result.ThisMonthIncome = _SQLDataReader["ThisMonthIncome"].ToString();
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.UserProfileImg = _SQLDataReader["UserProfileImg"].ToString();
                            _result.FullAccountName = _SQLDataReader["FullAccountName"].ToString();
                          


           

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



        public static List<AyohaeWalletTransactionModel> AyohaeWalletTransaction_LoadBy_eWalletAccNo_RecentlyTransferTo(string eWalletAccNo)
        {
            List<AyohaeWalletTransactionModel> _Value = new List<AyohaeWalletTransactionModel>();
            string check = "NA";
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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_LoadBy_eWalletAccNo_RecentlyTransferTo";
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletTransactionModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaeWalletTransactionModel();

                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.eWalletAccNo = _SQLDataReader["eWalletAccNo"].ToString();
                            _result.TransactionType = _SQLDataReader["TransactionType"].ToString();
                            _result.TransactionAmount = _SQLDataReader["TransactionAmount"].ToString();
                            _result.TransactionReferenceNo = _SQLDataReader["TransactionReferenceNo"].ToString();
                            _result.TransactionStatus = _SQLDataReader["TransactionStatus"].ToString();
                            _result.TransactionNote = _SQLDataReader["TransactionNote"].ToString();
                            _result.CreditDebitType = _SQLDataReader["CreditDebitType"].ToString();
                            _result.CustomerAccNo = _SQLDataReader["CustomerAccNo"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.AccountProfileImg = _SQLDataReader["AccountProfileImg"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.ThisMonthSpent = _SQLDataReader["ThisMonthSpent"].ToString();
                            _result.ThisMonthIncome = _SQLDataReader["ThisMonthIncome"].ToString();
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.UserProfileImg = _SQLDataReader["UserProfileImg"].ToString();
                            _result.FullAccountName = _SQLDataReader["FullAccountName"].ToString();
                            _result.TransferredToPlayerID = _SQLDataReader["TransferredToPlayerID"].ToString();
                            

                            if (check != _result.CustomerAccNo)
                            {
                                _Value.Add(_result);
                                check = _result.CustomerAccNo;
                            }

                           
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



        public static List<AyohaeWalletTransactionModel> AyohaeWalletTransaction_LoadBy_eWalletAccNo_FilterType(string FilterType, string eWalletAccNo, string Year, string TransactionType)
        {
            List<AyohaeWalletTransactionModel> _Value = new List<AyohaeWalletTransactionModel>();

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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_LoadBy_eWalletAccNo_FilterType";
                        _SQLCommand.Parameters.AddWithValue("@FilterType", FilterType);
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _SQLCommand.Parameters.AddWithValue("@Year", Year);
                        _SQLCommand.Parameters.AddWithValue("@TransactionType", TransactionType);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletTransactionModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaeWalletTransactionModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.eWalletAccNo = _SQLDataReader["eWalletAccNo"].ToString();
                            _result.TransactionType = _SQLDataReader["TransactionType"].ToString();
                            _result.TransactionAmount = _SQLDataReader["TransactionAmount"].ToString();
                            _result.TransactionReferenceNo = _SQLDataReader["TransactionReferenceNo"].ToString();
                            _result.TransactionStatus = _SQLDataReader["TransactionStatus"].ToString();
                            _result.TransactionNote = _SQLDataReader["TransactionNote"].ToString();
                            _result.CreditDebitType = _SQLDataReader["CreditDebitType"].ToString();
                            _result.CustomerAccNo = _SQLDataReader["CustomerAccNo"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.AccountProfileImg = _SQLDataReader["AccountProfileImg"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.MonthNumber = Convert.ToInt32(_SQLDataReader["MonthNumber"].ToString());
                            _result.CreatedDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["CreatedDate"]), String.Format("{0:yyyy}", _SQLDataReader["CreatedDate"]));
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.UserProfileImg = _SQLDataReader["UserProfileImg"].ToString();
                            _result.FullAccountName = _SQLDataReader["FullAccountName"].ToString();
                            _result.TotalStampEarn = _SQLDataReader["TotalStampEarn"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.PaymentMethod = _SQLDataReader["PaymentMethod"].ToString();
                            _result.PaymentChannel = _SQLDataReader["PaymentChannel"].ToString();
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


        public static List<AyohaeWalletTransactionModel> AyohaeWalletTransaction_LoadBy_eWalletAccNo_FilterType_AllTransaction(string FilterType, string eWalletAccNo, string Year, string TransactionType)
        {
            List<AyohaeWalletTransactionModel> _Value = new List<AyohaeWalletTransactionModel>();

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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_LoadBy_eWalletAccNo_FilterType_AllTransaction";
                        _SQLCommand.Parameters.AddWithValue("@FilterType", FilterType);
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _SQLCommand.Parameters.AddWithValue("@Year", Year);
                        _SQLCommand.Parameters.AddWithValue("@TransactionType", TransactionType);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletTransactionModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaeWalletTransactionModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.eWalletAccNo = _SQLDataReader["eWalletAccNo"].ToString();
                            _result.TransactionType = _SQLDataReader["TransactionType"].ToString();
                            _result.TransactionAmount = _SQLDataReader["TransactionAmount"].ToString();
                            _result.TransactionReferenceNo = _SQLDataReader["TransactionReferenceNo"].ToString();
                            _result.TransactionStatus = _SQLDataReader["TransactionStatus"].ToString();
                            _result.TransactionNote = _SQLDataReader["TransactionNote"].ToString();
                            _result.CreditDebitType = _SQLDataReader["CreditDebitType"].ToString();
                            _result.CustomerAccNo = _SQLDataReader["CustomerAccNo"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.AccountProfileImg = _SQLDataReader["AccountProfileImg"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.MonthNumber = Convert.ToInt32(_SQLDataReader["MonthNumber"].ToString());
                            _result.CreatedDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["CreatedDate"]), String.Format("{0:yyyy}", _SQLDataReader["CreatedDate"]));
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.UserProfileImg = _SQLDataReader["UserProfileImg"].ToString();
                            _result.FullAccountName = _SQLDataReader["FullAccountName"].ToString();
                            _result.TotalStampEarn = _SQLDataReader["TotalStampEarn"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.PaymentMethod = _SQLDataReader["PaymentMethod"].ToString();
                            _result.PaymentChannel = _SQLDataReader["PaymentChannel"].ToString();
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








        public static List<AyohaeWalletTransactionModel> DiscountCampaignRedeemLoadByDiscountRedeemStatus_OnlineOffline(string SubscriberAccNo, string RedeemStatus)
        {
            List<AyohaeWalletTransactionModel> _Value = new List<AyohaeWalletTransactionModel>();

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
                        _SQLCommand.CommandText = "DiscountCampaignRedeemLoadByDiscountRedeemStatus_OnlineOffline";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@RedeemStatus", RedeemStatus);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletTransactionModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaeWalletTransactionModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.eWalletAccNo = _SQLDataReader["eWalletAccNo"].ToString();
                            _result.TransactionType = _SQLDataReader["TransactionType"].ToString();
                            _result.TransactionAmount = _SQLDataReader["TransactionAmount"].ToString();
                            _result.TransactionReferenceNo = _SQLDataReader["TransactionReferenceNo"].ToString();
                            _result.TransactionStatus = _SQLDataReader["TransactionStatus"].ToString();
                            _result.TransactionNote = _SQLDataReader["TransactionNote"].ToString();
                            _result.CreditDebitType = _SQLDataReader["CreditDebitType"].ToString();
                            _result.CustomerAccNo = _SQLDataReader["CustomerAccNo"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.AccountProfileImg = _SQLDataReader["AccountProfileImg"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.MonthNumber = Convert.ToInt32(_SQLDataReader["MonthNumber"].ToString());
                            _result.CreatedDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["CreatedDate"]), String.Format("{0:yyyy}", _SQLDataReader["CreatedDate"]));
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.UserProfileImg = _SQLDataReader["UserProfileImg"].ToString();
                            _result.FullAccountName = _SQLDataReader["FullAccountName"].ToString();
                            _result.TotalStampEarn = _SQLDataReader["TotalStampEarn"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.PaymentMethod = _SQLDataReader["PaymentMethod"].ToString();
                            _result.PaymentChannel = _SQLDataReader["PaymentChannel"].ToString();
                            _result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                          //  _result.SearchCol = _SQLDataReader["AyohaPoint"].ToString() + "|" + _SQLDataReader["TransactionAmount"].ToString() + "|" + _SQLDataReader["FullAccountName"].ToString();

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



        public static List<AyohaeWalletTransactionModel> AyohaeWalletTransaction_LoadBy_eWalletAccNo_DebitCredit(string eWalletAccNo, string CreditDebitType)
        {
            List<AyohaeWalletTransactionModel> _Value = new List<AyohaeWalletTransactionModel>();

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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_LoadBy_eWalletAccNo_DebitCredit";
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreditDebitType", CreditDebitType);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletTransactionModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaeWalletTransactionModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.eWalletAccNo = _SQLDataReader["eWalletAccNo"].ToString();
                            _result.TransactionType = _SQLDataReader["TransactionType"].ToString();
                            _result.TransactionAmount = _SQLDataReader["TransactionAmount"].ToString();
                            _result.TransactionReferenceNo = _SQLDataReader["TransactionReferenceNo"].ToString();
                            _result.TransactionStatus = _SQLDataReader["TransactionStatus"].ToString();
                            _result.TransactionNote = _SQLDataReader["TransactionNote"].ToString();
                            _result.CreditDebitType = _SQLDataReader["CreditDebitType"].ToString();
                            _result.CustomerAccNo = _SQLDataReader["CustomerAccNo"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedDate_DateOnly = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.AccountProfileImg = _SQLDataReader["AccountProfileImg"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.MonthNumber = Convert.ToInt32(_SQLDataReader["MonthNumber"].ToString());
                            _result.CreatedDate_MonthYear = AyohaPointHistoryModel.ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["CreatedDate"]), String.Format("{0:yyyy}", _SQLDataReader["CreatedDate"]));
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.UserProfileImg = _SQLDataReader["UserProfileImg"].ToString();
                            _result.FullAccountName = _SQLDataReader["FullAccountName"].ToString();
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










        public static List<AyohaeWalletTransactionModel> AyohaeWalletTransaction_LoadBy_eWalletAccNo_TransactionReferenceNo(string eWalletAccNo, string TransactionReferenceNo)
        {
            List<AyohaeWalletTransactionModel> _Value = new List<AyohaeWalletTransactionModel>();

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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_LoadBy_eWalletAccNo_TransactionReferenceNo";
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _SQLCommand.Parameters.AddWithValue("@TransactionReferenceNo", TransactionReferenceNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletTransactionModel _result;
                        while (_SQLDataReader.Read())                       {

                            _result = new AyohaeWalletTransactionModel();                        
                            _result.TransactionAmount = _SQLDataReader["TransactionAmount"].ToString();
                            _result.TransactionType = _SQLDataReader["TransactionType"].ToString();
                            _result.TransactionStatus = _SQLDataReader["TransactionStatus"].ToString();
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



        public static string AyohaeWalletTransaction_InsertRequestCashOut(string eWalletAccNo, string TransactionType, string TransactionAmount, string TransactionReferenceNo, string TransactionStatus, string TransactionNote,
        string CreditDebitType, string CustomerAccNo, string CashOutCharge, string CashOutPercentageCharge, string TotalCashOutAmount)
        {

            string _value = "true";

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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_InsertRequestCashOut";
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _SQLCommand.Parameters.AddWithValue("@TransactionType", TransactionType);
                        _SQLCommand.Parameters.AddWithValue("@TransactionAmount", TransactionAmount);
                        _SQLCommand.Parameters.AddWithValue("@TransactionReferenceNo", TransactionReferenceNo);
                        _SQLCommand.Parameters.AddWithValue("@TransactionStatus", TransactionStatus);
                        _SQLCommand.Parameters.AddWithValue("@TransactionNote", TransactionNote);
                        _SQLCommand.Parameters.AddWithValue("@CreditDebitType", CreditDebitType);
                        _SQLCommand.Parameters.AddWithValue("@CustomerAccNo", CustomerAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CashOutCharge", CashOutCharge);
                        _SQLCommand.Parameters.AddWithValue("@CashOutPercentageCharge", CashOutPercentageCharge);
                        _SQLCommand.Parameters.AddWithValue("@TotalCashOutAmount", TotalCashOutAmount);
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

                        _value = Emails.mail_SendMailTransferEwallet("Tarmizi.Rahim@Ayoha-Reward.com", TransactionAmount);
                        //if (PlayerID_Credit.Length > 5)
                        //{
                        //    OneSignalModel.onesignalAPI_AyohaNotification_SendPointNotification_AyohaeWalletTransfer(PlayerID_Credit, TransactionAmount_Credit);
                        //}


                    }

                }

            }





            return _value;



        }


    }
}