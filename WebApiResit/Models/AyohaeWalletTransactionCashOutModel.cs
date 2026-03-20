using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaeWalletTransactionCashOutModel
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
        public string TransactionType
        {
            get;
            set;
        }
        public string RequestCashOutAmount
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
        public string CashOutStatus
        {
            get;
            set;
        }
        public string CashOutNote
        {
            get;
            set;
        }
        public string CreditDebitType
        {
            get;
            set;
        }
        public string TransactionReferenceNo
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
        public string RowStatus
        {
            get;
            set;
        }
        public string BankName
        {
            get;
            set;
        }
        public string BankAccountNo
        {
            get;
            set;
        }
        public string BankAccountName
        {
            get;
            set;
        }
        public string BankAccountType
        {
            get;
            set;
        }
        public AyohaeWalletTransactionCashOutModel() { }




        public static List<AyohaeWalletTransactionCashOutModel> AyohaeWalletTransaction_CashOut_LoadByTransactionReferenceNo(string TransactionReferenceNo)
        {
            List<AyohaeWalletTransactionCashOutModel> _Value = new List<AyohaeWalletTransactionCashOutModel>();

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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_CashOut_LoadByTransactionReferenceNo";
                        _SQLCommand.Parameters.AddWithValue("@TransactionReferenceNo", TransactionReferenceNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletTransactionCashOutModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaeWalletTransactionCashOutModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.TransactionType = _SQLDataReader["TransactionType"].ToString();
                            _result.RequestCashOutAmount = _SQLDataReader["RequestCashOutAmount"].ToString();
                            _result.CashOutCharge = _SQLDataReader["CashOutCharge"].ToString();
                            _result.CashOutPercentageCharge = _SQLDataReader["CashOutPercentageCharge"].ToString();
                            _result.TotalCashOutAmount = _SQLDataReader["TotalCashOutAmount"].ToString();
                            _result.CashOutStatus = _SQLDataReader["CashOutStatus"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.ModifiedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]);
                            _result.CashOutNote = _SQLDataReader["CashOutNote"].ToString();
                            _result.CreditDebitType = _SQLDataReader["CreditDebitType"].ToString();
                            _result.TransactionReferenceNo = _SQLDataReader["TransactionReferenceNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.BankName = _SQLDataReader["BankName"].ToString();
                            _result.BankAccountNo = _SQLDataReader["BankAccountNo"].ToString();
                            _result.BankAccountName = _SQLDataReader["BankAccountName"].ToString();
                            _result.BankAccountType = _SQLDataReader["BankAccountType"].ToString();

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





        public static List<AyohaeWalletTransactionCashOutModel> AyohaeWalletTransaction_CashOut_LoadByID(int ID)
        {
            List<AyohaeWalletTransactionCashOutModel> _Value = new List<AyohaeWalletTransactionCashOutModel>();

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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_CashOut_LoadByID";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaeWalletTransactionCashOutModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaeWalletTransactionCashOutModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.TransactionType = _SQLDataReader["TransactionType"].ToString();
                            _result.RequestCashOutAmount = _SQLDataReader["RequestCashOutAmount"].ToString();
                            _result.CashOutCharge = _SQLDataReader["CashOutCharge"].ToString();
                            _result.CashOutPercentageCharge = _SQLDataReader["CashOutPercentageCharge"].ToString();
                            _result.TotalCashOutAmount = _SQLDataReader["TotalCashOutAmount"].ToString();
                            _result.CashOutStatus = _SQLDataReader["CashOutStatus"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.ModifiedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]);
                            _result.CashOutNote = _SQLDataReader["CashOutNote"].ToString();
                            _result.CreditDebitType = _SQLDataReader["CreditDebitType"].ToString();
                            _result.TransactionReferenceNo = _SQLDataReader["TransactionReferenceNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.BankName = _SQLDataReader["BankName"].ToString();
                            _result.BankAccountNo = _SQLDataReader["BankAccountNo"].ToString();
                            _result.BankAccountName = _SQLDataReader["BankAccountName"].ToString();
                            _result.BankAccountType = _SQLDataReader["BankAccountType"].ToString();

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