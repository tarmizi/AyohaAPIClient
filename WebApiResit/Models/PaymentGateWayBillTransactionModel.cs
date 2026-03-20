using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApiResit.Models
{
    public class PaymentGateWayBillTransactionModel
    {
        public string billName
        {
            get;
            set;
        }
        public string billDescription
        {
            get;
            set;
        }
        public string billTo
        {
            get;
            set;
        }
        public string billEmail
        {
            get;
            set;
        }
        public string billPhone
        {
            get;
            set;
        }

        public string billStatus
         {
             get;
             set;
         }








        public string billpaymentStatus
        {
            get;
            set;
        }
        public string billpaymentChannel
        {
            get;
            set;
        }
        public string billpaymentAmount
        {
            get;
            set;
        }
        public string billpaymentInvoiceNo
        {
            get;
            set;
        }

        public string billSplitPayment
         {
             get;
             set;
         }




        public string billSplitPaymentArgs
        {
            get;
            set;
        }

        public string billpaymentSettlement
         {
             get;
             set;
         }



        public string billpaymentSettlementDate
         {
             get;
             set;
         }

        public string SettlementReferenceNo
         {
             get;
             set;
         }





        public string billPaymentDate
        {
            get;
            set;
        }

        public string billExternalReferenceNo
        {
            get;
            set;
        }
        public string billCode
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

        public string SaleItemsCode
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
      
     
         public PaymentGateWayBillTransactionModel() { }




         public static string PaymentGateWayBillTransaction_Insert(string billName, string billDescription, string billTo, string billEmail, string billPhone, string billStatus, string billpaymentStatus,
             string billpaymentChannel, string billpaymentAmount, string billpaymentInvoiceNo, string billSplitPayment, string billSplitPaymentArgs, string billpaymentSettlement,
                 string billpaymentSettlementDate, string SettlementReferenceNo, string billPaymentDate, string billExternalReferenceNo, string billCode)
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
                         _SQLCommand.CommandText = "PaymentGateWayBillTransaction_Insert";
                         _SQLCommand.Parameters.AddWithValue("@billName", billName);
                         _SQLCommand.Parameters.AddWithValue("@billDescription", billDescription);
                         _SQLCommand.Parameters.AddWithValue("@billTo", billTo);
                         _SQLCommand.Parameters.AddWithValue("@billEmail", billEmail);
                         _SQLCommand.Parameters.AddWithValue("@billPhone", billPhone);
                         _SQLCommand.Parameters.AddWithValue("@billStatus", billStatus);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentStatus", billpaymentStatus);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentChannel", billpaymentChannel);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentAmount", billpaymentAmount);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentInvoiceNo", billpaymentInvoiceNo);
                         _SQLCommand.Parameters.AddWithValue("@billSplitPayment", billSplitPayment);
                         _SQLCommand.Parameters.AddWithValue("@billSplitPaymentArgs", billSplitPaymentArgs);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentSettlement", billpaymentSettlement);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentSettlementDate", billpaymentSettlementDate);
                         _SQLCommand.Parameters.AddWithValue("@SettlementReferenceNo", SettlementReferenceNo);
                         _SQLCommand.Parameters.AddWithValue("@billPaymentDate", billPaymentDate);
                         _SQLCommand.Parameters.AddWithValue("@billExternalReferenceNo", billExternalReferenceNo);
                         _SQLCommand.Parameters.AddWithValue("@billCode", billCode);
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



         public static string PaymentGateWayBillTransaction_InsertMembershipPayment(string billName, string billDescription, string billTo, string billEmail, string billPhone, string billStatus, string billpaymentStatus,
     string billpaymentChannel, string billpaymentAmount, string billpaymentInvoiceNo, string billSplitPayment, string billSplitPaymentArgs, string billpaymentSettlement,
         string billpaymentSettlementDate, string SettlementReferenceNo, string billPaymentDate, string billExternalReferenceNo, string billCode, string SaleItemsCode)
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
                         _SQLCommand.CommandText = "PaymentGateWayBillTransaction_InsertMembershipCardPayment";
                         _SQLCommand.Parameters.AddWithValue("@billName", billName);
                         _SQLCommand.Parameters.AddWithValue("@billDescription", billDescription);
                         _SQLCommand.Parameters.AddWithValue("@billTo", billTo);
                         _SQLCommand.Parameters.AddWithValue("@billEmail", billEmail);
                         _SQLCommand.Parameters.AddWithValue("@billPhone", billPhone);
                         _SQLCommand.Parameters.AddWithValue("@billStatus", billStatus);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentStatus", billpaymentStatus);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentChannel", billpaymentChannel);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentAmount", billpaymentAmount);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentInvoiceNo", billpaymentInvoiceNo);
                         _SQLCommand.Parameters.AddWithValue("@billSplitPayment", billSplitPayment);
                         _SQLCommand.Parameters.AddWithValue("@billSplitPaymentArgs", billSplitPaymentArgs);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentSettlement", billpaymentSettlement);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentSettlementDate", billpaymentSettlementDate);
                         _SQLCommand.Parameters.AddWithValue("@SettlementReferenceNo", SettlementReferenceNo);
                         _SQLCommand.Parameters.AddWithValue("@billPaymentDate", billPaymentDate);
                         _SQLCommand.Parameters.AddWithValue("@billExternalReferenceNo", billExternalReferenceNo);
                         _SQLCommand.Parameters.AddWithValue("@billCode", billCode);
                         _SQLCommand.Parameters.AddWithValue("@SaleItemsCode", SaleItemsCode);
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

         public static string PaymentGateWayBillTransaction_InsertMembershipPaymentAyohaStoreOnline(string billName, string billDescription, string billTo, string billEmail, string billPhone, string billStatus, string billpaymentStatus,
      string billpaymentChannel, string billpaymentAmount, string billpaymentInvoiceNo, string billSplitPayment, string billSplitPaymentArgs, string billpaymentSettlement,
          string billpaymentSettlementDate, string SettlementReferenceNo, string billPaymentDate, string billExternalReferenceNo, string billCode, string SaleItemsCode)
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
                         _SQLCommand.CommandText = "PaymentGateWayBillTransaction_InsertAyohaOnlineStorePayment";
                         _SQLCommand.Parameters.AddWithValue("@billName", billName);
                         _SQLCommand.Parameters.AddWithValue("@billDescription", billDescription);
                         _SQLCommand.Parameters.AddWithValue("@billTo", billTo);
                         _SQLCommand.Parameters.AddWithValue("@billEmail", billEmail);
                         _SQLCommand.Parameters.AddWithValue("@billPhone", billPhone);
                         _SQLCommand.Parameters.AddWithValue("@billStatus", billStatus);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentStatus", billpaymentStatus);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentChannel", billpaymentChannel);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentAmount", billpaymentAmount);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentInvoiceNo", billpaymentInvoiceNo);
                         _SQLCommand.Parameters.AddWithValue("@billSplitPayment", billSplitPayment);
                         _SQLCommand.Parameters.AddWithValue("@billSplitPaymentArgs", billSplitPaymentArgs);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentSettlement", billpaymentSettlement);
                         _SQLCommand.Parameters.AddWithValue("@billpaymentSettlementDate", billpaymentSettlementDate);
                         _SQLCommand.Parameters.AddWithValue("@SettlementReferenceNo", SettlementReferenceNo);
                         _SQLCommand.Parameters.AddWithValue("@billPaymentDate", billPaymentDate);
                         _SQLCommand.Parameters.AddWithValue("@billExternalReferenceNo", billExternalReferenceNo);
                         _SQLCommand.Parameters.AddWithValue("@billCode", billCode);
                         _SQLCommand.Parameters.AddWithValue("@SaleItemsCode", SaleItemsCode);
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

         public static string PaymentGateWayBill_Master_Insert(string billCode, string billName, string SubscriberAccNo, string EnterpriseAccNo, string billExternalReferenceNo)
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
                         _SQLCommand.CommandText = "PaymentGateWayBill_Master_Insert";
                         _SQLCommand.Parameters.AddWithValue("@billCode", billCode);
                         _SQLCommand.Parameters.AddWithValue("@billName", billName);
                         _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                         _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);                       
                         _SQLCommand.Parameters.AddWithValue("@billExternalReferenceNo", billExternalReferenceNo);
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

        


         public static string PaymentGateWayBill_Master_InsertMembershipCardPayment(string billCode, string billName, string SubscriberAccNo, string EnterpriseAccNo,
             string billExternalReferenceNo, string SaleItemsCode, string PaymentMethod, string PaymentChannel)
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
                         _SQLCommand.CommandText = "PaymentGateWayBill_Master_InsertMembershipCardPayment";
                         _SQLCommand.Parameters.AddWithValue("@billCode", billCode);
                         _SQLCommand.Parameters.AddWithValue("@billName", billName);
                         _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                         _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                         _SQLCommand.Parameters.AddWithValue("@billExternalReferenceNo", billExternalReferenceNo);
                         _SQLCommand.Parameters.AddWithValue("@SaleItemsCode", SaleItemsCode);
                           _SQLCommand.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                           _SQLCommand.Parameters.AddWithValue("@PaymentChannel", PaymentChannel);

                         
                             
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




         public static string PaymentGateWayBill_Master_InsertAyohaOnlineStorePayment(string billCode, string billName, string SubscriberAccNo, string EnterpriseAccNo,
             string billExternalReferenceNo, string SaleItemsCode, string PaymentMethod, string PaymentChannel)
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
                         _SQLCommand.CommandText = "PaymentGateWayBill_Master_InsertAyohaOnlineStorePayment";
                         _SQLCommand.Parameters.AddWithValue("@billCode", billCode);
                         _SQLCommand.Parameters.AddWithValue("@billName", billName);
                         _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                         _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                         _SQLCommand.Parameters.AddWithValue("@billExternalReferenceNo", billExternalReferenceNo);
                         _SQLCommand.Parameters.AddWithValue("@SaleItemsCode", SaleItemsCode);
                           _SQLCommand.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                           _SQLCommand.Parameters.AddWithValue("@PaymentChannel", PaymentChannel);

                         
                             
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






         public static List<PaymentGateWayBillTransactionModel> PaymentGateWayBillTransaction_loadBybillCodeAndbillExternalReferenceNo_AyohaStoreOnline(string billCode, string billExternalReferenceNo)
         {
             List<PaymentGateWayBillTransactionModel> _Value = new List<PaymentGateWayBillTransactionModel>();

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
                         _SQLCommand.CommandText = "PaymentGateWayBillTransaction_loadBybillCodeAndbillExternalReferenceNo_AyohaStoreOnline";
                         _SQLCommand.Parameters.AddWithValue("@billCode", billCode);
                         _SQLCommand.Parameters.AddWithValue("@billExternalReferenceNo", billExternalReferenceNo);
                         _DBConnection.Open();
                         SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                         PaymentGateWayBillTransactionModel _result;
                         while (_SQLDataReader.Read())
                         {

                             _result = new PaymentGateWayBillTransactionModel();
                             _result.billpaymentStatus = _SQLDataReader["billpaymentStatus"].ToString();
                             _result.billpaymentInvoiceNo = _SQLDataReader["billpaymentInvoiceNo"].ToString();
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