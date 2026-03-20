using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaeWalletTransactionTransferEwalletModel
    {

        public string OrderNo
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


        public string GrandTotal
        {
            get;
            set;
        }
        public string PaymentAmount
        {
            get;
            set;
        }

        public string PaymentMethod
        {
            get;
            set;
        }
        public string PaymentMethodCode
        {
            get;
            set;
        }
     
        public string CreatedBy
        {
            get;
            set;
        }


        public string MembershipCardCode
        {
            get;
           set;
        }

      



        public string PaymentStatus
        {
            get;
            set;
        }
       


        public string NoteToSeller
        {
            get;
            set;
        }

       











        /// <summary>
        /// /////////////
        /// </summary>
        public string eWalletAccNo_Credit
        {
            get;
            set;
        }
        public string TransactionType_Credit
        {
            get;
            set;
        }
        public string TransactionAmount_Credit
        {
            get;
            set;
        }
        public string TransactionReferenceNo_Credit
        {
            get;
            set;
        }
        public string TransactionStatus_Credit
        {
            get;
            set;
        }
        public string TransactionNote_Credit
        {
            get;
            set;
        }
        public string CreditDebitType_Credit
        {
            get;
            set;
        }
        public string CustomerAccNo_Credit
        {
            get;
            set;
        }






        public string eWalletAccNo_Debit
        {
            get;
            set;
        }
        public string TransactionType_Debit
        {
            get;
            set;
        }
        public string TransactionAmount_Debit
        {
            get;
            set;
        }
        public string TransactionReferenceNo_Debit
        {
            get;
            set;
        }
        public string TransactionStatus_Debit
        {
            get;
            set;
        }
        public string TransactionNote_Debit
        {
            get;
            set;
        }
        public string CreditDebitType_Debit
        {
            get;
            set;
        }
        public string CustomerAccNo_Debit
        {
            get;
            set;
        }


        public string Email_Credit
        {
            get;
            set;
        }
        public string Email_Debit
        {
            get;
            set;
        }


        public string MerchantPoint
        {
            get;
            set;
        }
        public string AyohaPoint
        {
            get;
            set;
        }



        public int Points
        {
            get;
            set;
        }

        public string PlayerID_Credit
        {
            get;
            set;

        }

        public string AyohaeWalletTransactionTransactionType
        {
            get;
            set;

        }
        
        public AyohaeWalletTransactionTransferEwalletModel() { }


        public static string AyohaeWalletTransaction_Insert_TransferEwallet(string eWalletAccNo_Credit, string TransactionType_Credit, string TransactionAmount_Credit, string TransactionReferenceNo_Credit, string TransactionStatus_Credit, string TransactionNote_Credit,
          string CreditDebitType_Credit, string CustomerAccNo_Credit,string Email_Credit, string eWalletAccNo_Debit, string TransactionType_Debit, string TransactionAmount_Debit, string TransactionReferenceNo_Debit, string TransactionStatus_Debit,
          string TransactionNote_Debit, string CreditDebitType_Debit, string CustomerAccNo_Debit, string Email_Debit, string PlayerID_Credit, string AyohaeWalletTransactionTransactionType)
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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_Insert_TransferEwallet";
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo_Credit", eWalletAccNo_Credit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionType_Credit", TransactionType_Credit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionAmount_Credit", TransactionAmount_Credit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionReferenceNo_Credit", TransactionReferenceNo_Credit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionStatus_Credit", TransactionStatus_Credit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionNote_Credit", TransactionNote_Credit);
                        _SQLCommand.Parameters.AddWithValue("@CreditDebitType_Credit", CreditDebitType_Credit);
                        _SQLCommand.Parameters.AddWithValue("@CustomerAccNo_Credit", CustomerAccNo_Credit);
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo_Debit", eWalletAccNo_Debit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionType_Debit", TransactionType_Debit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionAmount_Debit", TransactionAmount_Debit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionReferenceNo_Debit", TransactionReferenceNo_Debit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionStatus_Debit", TransactionStatus_Debit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionNote_Debit", TransactionNote_Debit);
                        _SQLCommand.Parameters.AddWithValue("@CreditDebitType_Debit", CreditDebitType_Debit);
                        _SQLCommand.Parameters.AddWithValue("@CustomerAccNo_Debit", CustomerAccNo_Debit);
                        _SQLCommand.Parameters.AddWithValue("@AyohaeWalletTransactionTransactionType", AyohaeWalletTransactionTransactionType);
                        
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

                        _value = Emails.mail_SendMailTransferEwallet(Email_Credit, TransactionAmount_Credit);
                        if (PlayerID_Credit.Length > 5)
                        {
                            OneSignalModel.onesignalAPI_AyohaNotification_SendPointNotification_AyohaeWalletTransfer(PlayerID_Credit, TransactionAmount_Credit);
                        }
                      

                    }

                }

            }





            return _value;



        }






        public static string AyohaeWalletTransaction_Payment_Insert(string OrderNo, string SubscriberAccNo, string EnterpriseAccNo, string GrandTotal, string PaymentAmount, string PaymentMethod,
           string PaymentMethodCode, string CreatedBy, string MembershipCardCode, string PaymentStatus, string NoteToSeller,string MerchantPoint,string AyohaPoint,
            string eWalletAccNo_Credit, string TransactionType_Credit, string TransactionAmount_Credit, string TransactionReferenceNo_Credit, string TransactionStatus_Credit, string TransactionNote_Credit,
         string CreditDebitType_Credit, string CustomerAccNo_Credit, string Email_Credit, string eWalletAccNo_Debit, string TransactionType_Debit, string TransactionAmount_Debit, string TransactionReferenceNo_Debit, string TransactionStatus_Debit,
         string TransactionNote_Debit, string CreditDebitType_Debit, string CustomerAccNo_Debit, string Email_Debit, int Points)
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
                        _SQLCommand.CommandText = "AyohaeWalletTransaction_Payment_Insert";

                        _SQLCommand.Parameters.AddWithValue("@OrderNo", OrderNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@GrandTotal", GrandTotal);
                        _SQLCommand.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                        _SQLCommand.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        _SQLCommand.Parameters.AddWithValue("@PaymentMethodCode", PaymentMethodCode);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                        _SQLCommand.Parameters.AddWithValue("@NoteToSeller", NoteToSeller);

                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo_Credit", eWalletAccNo_Credit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionType_Credit", TransactionType_Credit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionAmount_Credit", TransactionAmount_Credit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionReferenceNo_Credit", TransactionReferenceNo_Credit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionStatus_Credit", TransactionStatus_Credit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionNote_Credit", TransactionNote_Credit);
                        _SQLCommand.Parameters.AddWithValue("@CreditDebitType_Credit", CreditDebitType_Credit);
                        _SQLCommand.Parameters.AddWithValue("@CustomerAccNo_Credit", CustomerAccNo_Credit);
                        _SQLCommand.Parameters.AddWithValue("@eWalletAccNo_Debit", eWalletAccNo_Debit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionType_Debit", TransactionType_Debit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionAmount_Debit", TransactionAmount_Debit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionReferenceNo_Debit", TransactionReferenceNo_Debit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionStatus_Debit", TransactionStatus_Debit);
                        _SQLCommand.Parameters.AddWithValue("@TransactionNote_Debit", TransactionNote_Debit);
                        _SQLCommand.Parameters.AddWithValue("@CreditDebitType_Debit", CreditDebitType_Debit);
                        _SQLCommand.Parameters.AddWithValue("@CustomerAccNo_Debit", CustomerAccNo_Debit);
                        _SQLCommand.Parameters.AddWithValue("@Points", Points);
                        
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

                       // _value = Emails.mail_SendMailTransferEwallet(Email_Credit, TransactionAmount_Credit);

                    }

                }

            }





            return _value;



        }

        


        public static string AyohaStore_Payment_Insert(string OrderNo, string SubscriberAccNo, string EnterpriseAccNo, string GrandTotal, string PaymentAmount, string PaymentMethod,
        string PaymentMethodCode, string CreatedBy, string MembershipCardCode, string PaymentStatus, string NoteToSeller, string MerchantPoint, string AyohaPoint)
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
                        _SQLCommand.CommandText = "AyohaStore_Payment_Insert";
                        _SQLCommand.Parameters.AddWithValue("@OrderNo", OrderNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@GrandTotal", GrandTotal);
                        _SQLCommand.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                        _SQLCommand.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        _SQLCommand.Parameters.AddWithValue("@PaymentMethodCode", PaymentMethodCode);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                        _SQLCommand.Parameters.AddWithValue("@NoteToSeller", NoteToSeller);
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

                       // AyohaStore_Payment_PushNotificationInfo(SubscriberAccNo, EnterpriseAccNo, MerchantPoint, AyohaPoint);

                    }

                }

            }





            return _value;



        }


    }
}