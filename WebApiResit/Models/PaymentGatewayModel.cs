using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApiResit.Models
{
    public class PaymentGatewayModel
    {

        public string namBill
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public string hpNo
        {
            get;
            set;
        }
        public string billName
        {
            get;
            set;
        }
         public string billDesc
        {
            get;
            set;
        }

         public string billEmail
         {
             get;
             set;
         }








         public string refno
        {
            get;
            set;
        }
        public string status
        {
            get;
            set;
        }
        public string reason
        {
            get;
            set;
        }
         public string billcode
        {
            get;
            set;
        }

         public string order_id
         {
             get;
             set;
         }




          public string amount
        {
            get;
            set;
        }

         public string transaction_time
         {
             get;
             set;
         }



         public string billCode
         {
             get;
             set;
         }

         public string billpaymentStatus
         {
             get;
             set;
         }
              
         public PaymentGatewayModel() { }


         public static string CreateBill_MakePayment(string namBill, string name, string hpNo, string billName, string billDesc, string billEmail, string billExternalID, int billAmount)
         {

             ServicePointManager.Expect100Continue = true;
             ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                    | SecurityProtocolType.Tls11
                    | SecurityProtocolType.Tls12
                    | SecurityProtocolType.Ssl3;


             var client = new WebClient();
             client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
             string data = "userSecretKey=api7h8k8-grtq-blvf-seuj-fi9fouwzsd2c"
                 + "&categoryCode=rnnmzmyc"
                 + "&billName=Ayoha Reward Membership Fees"
                 // + "&billDescription=MapBridge Package Payment Fee"
                 + "&billDescription=" + billDesc
                 + "&billPriceSetting=0&billPayorInfo=1&billAmount=" + billAmount
                 + "&billReturnUrl=https://setkita.com/AyohaClient/AyohaMembershipPayment.html"
                 + "&billCallbackUrl=https://setkita.com/CRMOBILEAPI/PaymentGateway/PaymentGatewayCreateBillCallBack"
                 + "&billExternalReferenceNo=" + billExternalID
                 + "&billTo=" + name
                 + "&billEmail=" + billEmail
                 + "&billPhone=" + hpNo
                 + "&billSplitPayment=0"
                 + "&billSplitPaymentArgs="
                 + "&billPaymentChannel=0&billContentEmail=Thank you for purchasing our product&billChargeToCustomer=1&billExpiryDate=&billExpiryDays=";
             var response = client.UploadString("https://dev.toyyibpay.com/index.php/api/createBill", data);

             return response.Trim();






         }






         public static string CreateBill_MakePayment_AyohaOnlineStore(string namBill, string name, string hpNo, string billName, string billDesc, string billEmail, string billExternalID, int billAmount)
         {

             ServicePointManager.Expect100Continue = true;
             ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                    | SecurityProtocolType.Tls11
                    | SecurityProtocolType.Tls12
                    | SecurityProtocolType.Ssl3;


             var client = new WebClient();
             client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
             string data = "userSecretKey=api7h8k8-grtq-blvf-seuj-fi9fouwzsd2c"
                 + "&categoryCode=4qfiw71z"
                 + "&billName=Ayoha Online Store"
                 // + "&billDescription=MapBridge Package Payment Fee"
                 + "&billDescription=" + billDesc
                 + "&billPriceSetting=0&billPayorInfo=1&billAmount=" + billAmount
                 + "&billReturnUrl=https://setkita.com/AyohaClient/AyohaOnlineStorePayment.html"
                 + "&billCallbackUrl=https://setkita.com/CRMOBILEAPI/PaymentGateway/PaymentGatewayCreateBillCallBack"
                 + "&billExternalReferenceNo=" + billExternalID
                 + "&billTo=" + name
                 + "&billEmail=" + billEmail
                 + "&billPhone=" + hpNo
                 + "&billSplitPayment=0"
                 + "&billSplitPaymentArgs="
                 + "&billPaymentChannel=0&billContentEmail=Thank you for purchasing our product&billChargeToCustomer=1&billExpiryDate=&billExpiryDays=";
             var response = client.UploadString("https://dev.toyyibpay.com/index.php/api/createBill", data);

             return response.Trim();






         }





         public static string CreateBillCategory(string namBill, string name, string hpNo, string billName, string billDesc)
         {
             ServicePointManager.Expect100Continue = true;
             ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                    | SecurityProtocolType.Tls11
                    | SecurityProtocolType.Tls12
                    | SecurityProtocolType.Ssl3;


             var client = new WebClient();
             client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
             string data = "userSecretKey=api7h8k8-grtq-blvf-seuj-fi9fouwzsd2c"
                 + "&catname=Ayoha Membership Fess"
                 + "&catdescription=Ayoha Reward Membership Fees";
             var response = client.UploadString("https://dev.toyyibpay.com/index.php/api/createBill", data);
             return response.Trim();

         }


         public static string GetBillTransaction(string billCodes, string billpaymentStatuss)
         {
             ServicePointManager.Expect100Continue = true;
             ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                    | SecurityProtocolType.Tls11
                    | SecurityProtocolType.Tls12
                    | SecurityProtocolType.Ssl3;


             var client = new WebClient();
             client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
             string data = "billCode=" + billCodes
                 + "&billpaymentStatus=1";
             var response = client.UploadString("https://dev.toyyibpay.com/index.php/api/getBillTransactions", data);
             return response.Trim();

         }



         public static string PaymentGatewayCreateBill_CallBack(string refno, string status, string reason, string billcode, string order_id, string amount, string transaction_time)
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
                         _SQLCommand.CommandText = "PaymentGateWay_Insert";
                         _SQLCommand.Parameters.AddWithValue("@refno", refno);
                         _SQLCommand.Parameters.AddWithValue("@status", status);
                         _SQLCommand.Parameters.AddWithValue("@reason", reason);
                         _SQLCommand.Parameters.AddWithValue("@billcode", billcode);
                         _SQLCommand.Parameters.AddWithValue("@order_id", order_id);
                         _SQLCommand.Parameters.AddWithValue("@amount", amount);
                         _SQLCommand.Parameters.AddWithValue("@transaction_time", transaction_time);
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




         public static string CreateBill_eWalletTopUp(string namBill, string name, string hpNo, string billName, string billDesc, string billEmail, string billExternalID)
         {
             
             ServicePointManager.Expect100Continue = true;
             ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                    | SecurityProtocolType.Tls11
                    | SecurityProtocolType.Tls12
                    | SecurityProtocolType.Ssl3;


             var client = new WebClient();
             client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
             string data = "userSecretKey=api7h8k8-grtq-blvf-seuj-fi9fouwzsd2c"
                 + "&categoryCode=vfh8jih2"
                 + "&billName=Ayoha eWallet Topup"
                 + "&billDescription=Ayoha eWallet Topup"
                 + "&billPriceSetting=0&billPayorInfo=1&billAmount=0"
                 + "&billReturnUrl=https://setkita.com/AyohaNative/AyohaeWalletTopUpUrl.html"
                 + "&billCallbackUrl=https://setkita.com/CRMOBILEAPI/PaymentGateway/PaymentGatewayCreateBillCallBack"
                 + "&billExternalReferenceNo=" + billExternalID
                 + "&billTo=" + name
                 + "&billEmail=" + billEmail
                 + "&billPhone=" + hpNo
                 + "&billSplitPayment=0"
                 + "&billSplitPaymentArgs="
                 + "&billPaymentChannel=0&billContentEmail=Thank you for purchasing our product&billChargeToCustomer=1&billExpiryDate=&billExpiryDays=";
             var response = client.UploadString("https://dev.toyyibpay.com/index.php/api/createBill", data);

             return response.Trim();



             //ServicePointManager.Expect100Continue = true;
             //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
             //       | SecurityProtocolType.Tls11
             //       | SecurityProtocolType.Tls12
             //       | SecurityProtocolType.Ssl3;


             //var client = new WebClient();
             //client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
             //string data = "userSecretKey=api7h8k8-grtq-blvf-seuj-fi9fouwzsd2c"
             //    + "&catname=Ayoha Membership Fess"
             //    + "&catdescription=Ayoha Reward Membership Fees";
             //var response = client.UploadString("https://dev.toyyibpay.com/index.php/api/createCategory", data);
             //return response.Trim();




         }
    }
}

