using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaStoreOrderModel
    {
        public int ID
        {
            get;
            set;
        }

        public string OrderNo
        {
            get;
            set;
        }
        public string ItemCartCode
        {
            get;
            set;
        }
        public string DeliveryChargeCode
        {
            get;
            set;
        }
        public string DeliveryCharge
        {
            get;
            set;
        }


        public string MembershipDiscountCampaignCode
        {
            get;
            set;
        }
        public string MembershipDiscount
        {
            get;
            set;
        }
        public string VoucherCampaignCode
        {
            get;
            set;
        }
        public string VoucherDiscount
        {
            get;
            set;
        }
        public string GrandTotal
        {
            get;
            set;
        }
        public string DeliveryAddress_StreetName
        {
            get;
            set;
        }


        public string DeliveryAddress_Town
        {
            get;
            set;
        }
        public string DeliveryAddress_Postcode
        {
            get;
            set;
        }
        public string DeliveryAddress_StateCode
        {
            get;
            set;
        }
        public string DeliveryAddress_CountryCode
        {
            get;
            set;
        }
        public string ReferenceName
        {
            get;
            set;
        }
        public string ReferencePhoneNo
        {
            get;
            set;
        }


        public string NoteToSeller
        {
            get;
            set;
        }
        public string MerchantPointEarn
        {
            get;
            set;
        }

        public string AyohaPointEarn
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string SubscriberAccNo
        {
            get;
            set;
        }
        public string MembershipCardCode
        {
            get;
            set;
        }
        public string OrderStatus
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

        public string DeliveryName
        {
            get;
            set;
        }
        public int TotalQuantity
        {
            get;
            set;
        }
        public string DisplayOrderNo
        {
            get;
            set;

        }
        public string OrderLogOrderStatus
        {
            get;
            set;

        }
        public string OrderLogCreatedDate
        {
            get;
            set;

        }

        public int Row_num
        {
            get;
            set;
        }

        public int ItemQuantity 
        {
            get;
            set;
        }



        public string ItemCode
        {
            get;
            set;

        }
        public string ItemName
        {
            get;
            set;

        }
        public string ItemPrice
        {
            get;
            set;

        }
        public string ItemPriceDiscount
        {
            get;
            set;

        }
        public string MembershipCardBackgroundImg
        {
            get;
            set;

        }
        public string MembershipCardName
        {
            get;
            set;

        }
        public string ItemCoverImg
        {
            get;
            set;

        }
        public string SubTotal
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
       
        public string PaymentStatus
        {
            get;
            set;

        }
        public string PaymentNoDisplay
        {
            get;
            set;

        }
        public string PaymentNo
        {
            get;
            set;

        }
        public string PaymentDate
        {
            get;
            set;

        }

        public string LoyaltyRewardType
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



        public int VoucherCount
        {
            get;
            set;

        }

        public string VoucherCode
        {
            get;
            set;

        }


        public string TotalVoucherDiscount
        {
            get;
            set;

        }


        public string ItemDescriptions
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

        public string billExternalReferenceNo
        {
            get;
            set;

        }
        public string EnterpriseAddress
        {
            get;
            set;

        }
        public AyohaStoreOrderModel() { }



        public static string AyohaStore_Order_Insert(string ItemCartCode, string DeliveryChargeCode, string DeliveryCharge, string MembershipDiscountCampaignCode, string MembershipDiscount, string VoucherCampaignCode,
            string VoucherDiscount, string GrandTotal, string DeliveryAddress_StreetName, string DeliveryAddress_Town, string DeliveryAddress_Postcode, string DeliveryAddress_StateCode, string DeliveryAddress_CountryCode,
            string ReferenceName, string ReferencePhoneNo, string NoteToSeller, string MerchantPointEarn, string AyohaPointEarn, string EnterpriseAccNo, string SubscriberAccNo, string MembershipCardCode, string DeliveryName,
            int TotalQuantity, string SubTotal, int VoucherCount, string VoucherCode, string TotalStampEarn)
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
                            _SQLCommand.CommandText = "AyohaStore_Order_Insert";
                            _SQLCommand.Parameters.AddWithValue("@ItemCartCode", ItemCartCode);
                            _SQLCommand.Parameters.AddWithValue("@DeliveryChargeCode", DeliveryChargeCode);
                            _SQLCommand.Parameters.AddWithValue("@DeliveryCharge", DeliveryCharge);
                            _SQLCommand.Parameters.AddWithValue("@MembershipDiscountCampaignCode", MembershipDiscountCampaignCode);
                            _SQLCommand.Parameters.AddWithValue("@MembershipDiscount", MembershipDiscount);
                            _SQLCommand.Parameters.AddWithValue("@VoucherCampaignCode", VoucherCampaignCode);
                            _SQLCommand.Parameters.AddWithValue("@VoucherDiscount", VoucherDiscount);
                            _SQLCommand.Parameters.AddWithValue("@GrandTotal", GrandTotal);
                            _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_StreetName", DeliveryAddress_StreetName);
                            _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_Town", DeliveryAddress_Town);
                            _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_Postcode", DeliveryAddress_Postcode);
                            _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_StateCode", DeliveryAddress_StateCode);
                            _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_CountryCode", DeliveryAddress_CountryCode);
                            _SQLCommand.Parameters.AddWithValue("@ReferenceName", ReferenceName);
                            _SQLCommand.Parameters.AddWithValue("@ReferencePhoneNo", ReferencePhoneNo);
                            _SQLCommand.Parameters.AddWithValue("@NoteToSeller", NoteToSeller);
                            _SQLCommand.Parameters.AddWithValue("@MerchantPointEarn", MerchantPointEarn);
                            _SQLCommand.Parameters.AddWithValue("@AyohaPointEarn", AyohaPointEarn);
                            _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                            _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                            _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                            _SQLCommand.Parameters.AddWithValue("@OrderStatus", "OrderUnPaid");
                            _SQLCommand.Parameters.AddWithValue("@DeliveryName", DeliveryName);
                            _SQLCommand.Parameters.AddWithValue("@TotalQuantity", TotalQuantity);
                            _SQLCommand.Parameters.AddWithValue("@SubTotal", SubTotal);
                            _SQLCommand.Parameters.AddWithValue("@VoucherCount", VoucherCount);
                            _SQLCommand.Parameters.AddWithValue("@VoucherCode", VoucherCode);
                            _SQLCommand.Parameters.AddWithValue("@TotalStampEarn", TotalStampEarn);
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





        public static string AyohaStore_Order_AyohaStore_Payment_Order_And_ConfirmPay_Insert(string ItemCartCode, string DeliveryChargeCode, string DeliveryCharge, string MembershipDiscountCampaignCode, string MembershipDiscount, string VoucherCampaignCode,
    string VoucherDiscount, string GrandTotal, string DeliveryAddress_StreetName, string DeliveryAddress_Town, string DeliveryAddress_Postcode, string DeliveryAddress_StateCode, string DeliveryAddress_CountryCode,
    string ReferenceName, string ReferencePhoneNo, string NoteToSeller, string MerchantPointEarn, string AyohaPointEarn, string EnterpriseAccNo, string SubscriberAccNo, string MembershipCardCode, string DeliveryName,
    int TotalQuantity, string SubTotal, string PaymentAmount, string PaymentMethod, string PaymentMethodCode, string CreatedBy, string PaymentStatus, int VoucherCount, string VoucherCode, string TotalStampEarn, string MemberDiscountPercent,
            string MemberDiscountAmount)
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
                        _SQLCommand.CommandText = "AyohaStore_Order_AyohaStore_Payment_Order_And_ConfirmPay_Insert";
                        _SQLCommand.Parameters.AddWithValue("@ItemCartCode", ItemCartCode);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryChargeCode", DeliveryChargeCode);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryCharge", DeliveryCharge);
                        _SQLCommand.Parameters.AddWithValue("@MembershipDiscountCampaignCode", MembershipDiscountCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@MembershipDiscount", MembershipDiscount);
                        _SQLCommand.Parameters.AddWithValue("@VoucherCampaignCode", VoucherCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@VoucherDiscount", VoucherDiscount);
                        _SQLCommand.Parameters.AddWithValue("@GrandTotal", GrandTotal);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_StreetName", DeliveryAddress_StreetName);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_Town", DeliveryAddress_Town);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_Postcode", DeliveryAddress_Postcode);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_StateCode", DeliveryAddress_StateCode);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_CountryCode", DeliveryAddress_CountryCode);
                        _SQLCommand.Parameters.AddWithValue("@ReferenceName", ReferenceName);
                        _SQLCommand.Parameters.AddWithValue("@ReferencePhoneNo", ReferencePhoneNo);
                        _SQLCommand.Parameters.AddWithValue("@NoteToSeller", NoteToSeller);
                        _SQLCommand.Parameters.AddWithValue("@MerchantPointEarn", MerchantPointEarn);
                        _SQLCommand.Parameters.AddWithValue("@AyohaPointEarn", AyohaPointEarn);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@OrderStatus", "OrderPaid");
                        _SQLCommand.Parameters.AddWithValue("@DeliveryName", DeliveryName);
                        _SQLCommand.Parameters.AddWithValue("@TotalQuantity", TotalQuantity);
                        _SQLCommand.Parameters.AddWithValue("@SubTotal", SubTotal);
                        _SQLCommand.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                        _SQLCommand.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        _SQLCommand.Parameters.AddWithValue("@PaymentMethodCode", PaymentMethodCode);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                        _SQLCommand.Parameters.AddWithValue("@VoucherCount", VoucherCount);
                        _SQLCommand.Parameters.AddWithValue("@VoucherCode", VoucherCode);
                        _SQLCommand.Parameters.AddWithValue("@TotalStampEarn", TotalStampEarn);
                        _SQLCommand.Parameters.AddWithValue("@MemberDiscountPercent", MemberDiscountPercent);
                        _SQLCommand.Parameters.AddWithValue("@MemberDiscountAmount", MemberDiscountAmount);

                        
                        

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
                        AyohaStore_Order_PushNotificationInfo(SubscriberAccNo,EnterpriseAccNo,MerchantPointEarn,AyohaPointEarn);


                    }

                }

            }





            return _value;



        }



        public static string AyohaStore_Order_AyohaStore_Payment_Order_And_ConfirmPay_InsertAyohaStoreOnline(string ItemCartCode, string DeliveryChargeCode, string DeliveryCharge, string MembershipDiscountCampaignCode, string MembershipDiscount, string VoucherCampaignCode,
 string VoucherDiscount, string GrandTotal, string DeliveryAddress_StreetName, string DeliveryAddress_Town, string DeliveryAddress_Postcode, string DeliveryAddress_StateCode, string DeliveryAddress_CountryCode,
 string ReferenceName, string ReferencePhoneNo, string NoteToSeller, string MerchantPointEarn, string AyohaPointEarn, string EnterpriseAccNo, string SubscriberAccNo, string MembershipCardCode, string DeliveryName,
 int TotalQuantity, string SubTotal, string PaymentAmount, string PaymentMethod, string PaymentMethodCode, string CreatedBy, string PaymentStatus, int VoucherCount, string VoucherCode, string TotalStampEarn, string MemberDiscountPercent,
         string MemberDiscountAmount, string billExternalReferenceNo)
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
                        _SQLCommand.CommandText = "AyohaStore_Order_AyohaStore_Payment_Order_And_ConfirmPay_InsertAyohaStoreOnline";
                        _SQLCommand.Parameters.AddWithValue("@ItemCartCode", ItemCartCode);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryChargeCode", DeliveryChargeCode);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryCharge", DeliveryCharge);
                        _SQLCommand.Parameters.AddWithValue("@MembershipDiscountCampaignCode", MembershipDiscountCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@MembershipDiscount", MembershipDiscount);
                        _SQLCommand.Parameters.AddWithValue("@VoucherCampaignCode", VoucherCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@VoucherDiscount", VoucherDiscount);
                        _SQLCommand.Parameters.AddWithValue("@GrandTotal", GrandTotal);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_StreetName", DeliveryAddress_StreetName);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_Town", DeliveryAddress_Town);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_Postcode", DeliveryAddress_Postcode);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_StateCode", DeliveryAddress_StateCode);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryAddress_CountryCode", DeliveryAddress_CountryCode);
                        _SQLCommand.Parameters.AddWithValue("@ReferenceName", ReferenceName);
                        _SQLCommand.Parameters.AddWithValue("@ReferencePhoneNo", ReferencePhoneNo);
                        _SQLCommand.Parameters.AddWithValue("@NoteToSeller", NoteToSeller);
                        _SQLCommand.Parameters.AddWithValue("@MerchantPointEarn", MerchantPointEarn);
                        _SQLCommand.Parameters.AddWithValue("@AyohaPointEarn", AyohaPointEarn);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@OrderStatus", "OrderPaid");
                        _SQLCommand.Parameters.AddWithValue("@DeliveryName", DeliveryName);
                        _SQLCommand.Parameters.AddWithValue("@TotalQuantity", TotalQuantity);
                        _SQLCommand.Parameters.AddWithValue("@SubTotal", SubTotal);
                        _SQLCommand.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                        _SQLCommand.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        _SQLCommand.Parameters.AddWithValue("@PaymentMethodCode", PaymentMethodCode);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                        _SQLCommand.Parameters.AddWithValue("@VoucherCount", VoucherCount);
                        _SQLCommand.Parameters.AddWithValue("@VoucherCode", VoucherCode);
                        _SQLCommand.Parameters.AddWithValue("@TotalStampEarn", TotalStampEarn);
                        _SQLCommand.Parameters.AddWithValue("@MemberDiscountPercent", MemberDiscountPercent);
                        _SQLCommand.Parameters.AddWithValue("@MemberDiscountAmount", MemberDiscountAmount);
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
                        AyohaStore_Order_PushNotificationInfo(SubscriberAccNo, EnterpriseAccNo, MerchantPointEarn, AyohaPointEarn);


                    }

                }

            }





            return _value;



        }

        public static void AyohaStore_Order_PushNotificationInfo(string SubscriberAccNo,string EnterpriseAccNo,string MerchantPointEarn,string AyohaPointEarn)
        {
            string PlayerID = "";
            string EnterpriseName = "";
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
                        _SQLCommand.CommandText = "AyohaStore_Payment_PushNotificationInfo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        while (_SQLDataReader.Read())
                        {

                            PlayerID = _SQLDataReader["PlayerID"].ToString();
                            EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                    finally
                    {

                        _DBConnection.Close();
                        OneSignalModel.onesignalAPI_AyohaNotification_SendPointNotification_AyohaStoreMakePayment(PlayerID, EnterpriseName, MerchantPointEarn, AyohaPointEarn);
                    }

                }

            }

        }





        public static string AyohaStore_Order_UpdateOrderStatus(string OrderNo, string SubscriberAccNo, string OrderStatus, string OrderLogOrderStatusNote,string EnterpriseAccNo)
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
                        _SQLCommand.CommandText = "AyohaStore_Order_UpdateOrderStatus";
                        _SQLCommand.Parameters.AddWithValue("@OrderNo", OrderNo);
                        _SQLCommand.Parameters.AddWithValue("@ModifiedBy", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@OrderStatus", OrderStatus);
                        _SQLCommand.Parameters.AddWithValue("@OrderLogOrderStatusNote", OrderLogOrderStatusNote);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
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



        public static string AyohaStore_Order_UpdateRowStatus(string OrderNo, string SubscriberAccNo, string RowStatus)
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
                        _SQLCommand.CommandText = "AyohaStore_Order_UpdateRowStatus";
                        _SQLCommand.Parameters.AddWithValue("@OrderNo", OrderNo);
                        _SQLCommand.Parameters.AddWithValue("@ModifiedBy", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
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




        public static List<AyohaStoreOrderModel> AyohaStore_Order_LoadByEnterpriseAccNoAndOrderStatus(string EnterpriseAccNo, string OrderStatus)
        {
            List<AyohaStoreOrderModel> _Value = new List<AyohaStoreOrderModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_Order_LoadByEnterpriseAccNoAndOrderStatus";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@OrderStatus", OrderStatus);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStoreOrderModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStoreOrderModel();
                         
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.DeliveryChargeCode = _SQLDataReader["DeliveryChargeCode"].ToString();
                            _result.DeliveryCharge = _SQLDataReader["DeliveryCharge"].ToString();
                            _result.MembershipDiscountCampaignCode = _SQLDataReader["MembershipDiscountCampaignCode"].ToString();
                            _result.MembershipDiscount = _SQLDataReader["MembershipDiscount"].ToString();
                            _result.VoucherCampaignCode = _SQLDataReader["VoucherCampaignCode"].ToString();
                            _result.VoucherDiscount =_SQLDataReader["VoucherDiscount"].ToString();
                            _result.GrandTotal = _SQLDataReader["GrandTotal"].ToString();
                            _result.DeliveryAddress_StreetName = _SQLDataReader["DeliveryAddress_StreetName"].ToString();
                            _result.DeliveryAddress_Town = _SQLDataReader["DeliveryAddress_Town"].ToString();
                            _result.DeliveryAddress_Postcode = _SQLDataReader["DeliveryAddress_Postcode"].ToString();
                            _result.DeliveryAddress_StateCode = _SQLDataReader["DeliveryAddress_StateCode"].ToString();
                            _result.DeliveryAddress_CountryCode = _SQLDataReader["DeliveryAddress_CountryCode"].ToString();
                            _result.ReferenceName = _SQLDataReader["ReferenceName"].ToString();
                            _result.ReferencePhoneNo = _SQLDataReader["ReferencePhoneNo"].ToString();
                            _result.NoteToSeller = _SQLDataReader["NoteToSeller"].ToString();
                            _result.MerchantPointEarn = _SQLDataReader["MerchantPointEarn"].ToString();
                            _result.AyohaPointEarn = _SQLDataReader["AyohaPointEarn"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.OrderStatus = _SQLDataReader["OrderStatus"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ModifiedDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.DisplayOrderNo = _SQLDataReader["DisplayOrderNo"].ToString();                            
                            _result.DeliveryName = _SQLDataReader["DeliveryName"].ToString();
                            _result.TotalQuantity =Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            _result.SubTotal = _SQLDataReader["SubTotal"].ToString();

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





        public static List<AyohaStoreOrderModel> AyohaStore_Order_LoadBySubscriberAccNoAndOrderStatus(string SubscriberAccNo, string OrderStatus,string EnterpriseAccNo)
        {
            List<AyohaStoreOrderModel> _Value = new List<AyohaStoreOrderModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_Order_LoadBySubscriberAccNoAndOrderStatus";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@OrderStatus", OrderStatus);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStoreOrderModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStoreOrderModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.DeliveryChargeCode = _SQLDataReader["DeliveryChargeCode"].ToString();
                            _result.DeliveryCharge = _SQLDataReader["DeliveryCharge"].ToString();
                            _result.MembershipDiscountCampaignCode = _SQLDataReader["MembershipDiscountCampaignCode"].ToString();
                            _result.MembershipDiscount = _SQLDataReader["MembershipDiscount"].ToString();
                            _result.VoucherCampaignCode = _SQLDataReader["VoucherCampaignCode"].ToString();
                            _result.VoucherDiscount = _SQLDataReader["VoucherDiscount"].ToString();
                            _result.GrandTotal = _SQLDataReader["GrandTotal"].ToString();
                            _result.DeliveryAddress_StreetName = _SQLDataReader["DeliveryAddress_StreetName"].ToString();
                            _result.DeliveryAddress_Town = _SQLDataReader["DeliveryAddress_Town"].ToString();
                            _result.DeliveryAddress_Postcode = _SQLDataReader["DeliveryAddress_Postcode"].ToString();
                            _result.DeliveryAddress_StateCode = _SQLDataReader["DeliveryAddress_StateCode"].ToString();
                            _result.DeliveryAddress_CountryCode = _SQLDataReader["DeliveryAddress_CountryCode"].ToString();
                            _result.ReferenceName = _SQLDataReader["ReferenceName"].ToString();
                            _result.ReferencePhoneNo = _SQLDataReader["ReferencePhoneNo"].ToString();
                            _result.NoteToSeller = _SQLDataReader["NoteToSeller"].ToString();
                            _result.MerchantPointEarn = _SQLDataReader["MerchantPointEarn"].ToString();
                            _result.AyohaPointEarn = _SQLDataReader["AyohaPointEarn"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ModifiedDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.DisplayOrderNo = _SQLDataReader["DisplayOrderNo"].ToString();   
                            _result.DeliveryName = _SQLDataReader["DeliveryName"].ToString();
                            _result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            _result.OrderStatus = _SQLDataReader["OrderStatus"].ToString();
                            _result.TotalStampEarn = _SQLDataReader["TotalStampEarn"].ToString();
                            _result.Row_num = Convert.ToInt32(_SQLDataReader["Row_num"].ToString());
                            _result.OrderLogOrderStatus = AyohaStore_OrderLogStatus_LoadByOrderNo_Logging(_SQLDataReader["OrderNo"].ToString());
                            _result.OrderLogCreatedDate = AyohaStore_OrderLogCreatedDate_LoadByOrderNo_Logging(_SQLDataReader["OrderNo"].ToString());
                            _result.SubTotal = _SQLDataReader["SubTotal"].ToString();
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


        public static List<AyohaStoreOrderModel> AyohaStore_Order_LoadBySubscriberAccNoAndOrderStatus_DashboardOrderHistory(string SubscriberAccNo, string OrderStatus)
        {
            List<AyohaStoreOrderModel> _Value = new List<AyohaStoreOrderModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_Order_LoadBySubscriberAccNoAndOrderStatus_DashboardOrderHistory";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@OrderStatus", OrderStatus);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStoreOrderModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStoreOrderModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.DeliveryChargeCode = _SQLDataReader["DeliveryChargeCode"].ToString();
                            _result.DeliveryCharge = _SQLDataReader["DeliveryCharge"].ToString();
                            _result.MembershipDiscountCampaignCode = _SQLDataReader["MembershipDiscountCampaignCode"].ToString();
                            _result.MembershipDiscount = _SQLDataReader["MembershipDiscount"].ToString();
                            _result.VoucherCampaignCode = _SQLDataReader["VoucherCampaignCode"].ToString();
                            _result.VoucherDiscount = _SQLDataReader["VoucherDiscount"].ToString();
                            _result.GrandTotal = _SQLDataReader["GrandTotal"].ToString();
                            _result.DeliveryAddress_StreetName = _SQLDataReader["DeliveryAddress_StreetName"].ToString();
                            _result.DeliveryAddress_Town = _SQLDataReader["DeliveryAddress_Town"].ToString();
                            _result.DeliveryAddress_Postcode = _SQLDataReader["DeliveryAddress_Postcode"].ToString();
                            _result.DeliveryAddress_StateCode = _SQLDataReader["DeliveryAddress_StateCode"].ToString();
                            _result.DeliveryAddress_CountryCode = _SQLDataReader["DeliveryAddress_CountryCode"].ToString();
                            _result.ReferenceName = _SQLDataReader["ReferenceName"].ToString();
                            _result.ReferencePhoneNo = _SQLDataReader["ReferencePhoneNo"].ToString();
                            _result.NoteToSeller = _SQLDataReader["NoteToSeller"].ToString();
                            _result.MerchantPointEarn = _SQLDataReader["MerchantPointEarn"].ToString();
                            _result.AyohaPointEarn = _SQLDataReader["AyohaPointEarn"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ModifiedDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.DisplayOrderNo = _SQLDataReader["DisplayOrderNo"].ToString();
                            _result.DeliveryName = _SQLDataReader["DeliveryName"].ToString();
                            _result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            _result.OrderStatus = _SQLDataReader["OrderStatus"].ToString();
                            _result.TotalStampEarn = _SQLDataReader["TotalStampEarn"].ToString();
                            _result.Row_num = Convert.ToInt32(_SQLDataReader["Row_num"].ToString());
                            _result.OrderLogOrderStatus = AyohaStore_OrderLogStatus_LoadByOrderNo_Logging(_SQLDataReader["OrderNo"].ToString());
                            _result.OrderLogCreatedDate = AyohaStore_OrderLogCreatedDate_LoadByOrderNo_Logging(_SQLDataReader["OrderNo"].ToString());
                            _result.SubTotal = _SQLDataReader["SubTotal"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
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





        public static List<AyohaStoreOrderModel> AyohaStore_Order_LoadByItemCartCodeAndMembershipCardCode(string ItemCartCode, string MembershipCardCode, string OrderNo)
        {
            List<AyohaStoreOrderModel> _Value = new List<AyohaStoreOrderModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_Order_LoadByItemCartCodeAndMembershipCardCode";
                        _SQLCommand.Parameters.AddWithValue("@ItemCartCode", ItemCartCode);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@OrderNo", OrderNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStoreOrderModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStoreOrderModel();

                            _result.Row_num = Convert.ToInt32(_SQLDataReader["Row_num"].ToString());
                            _result.DisplayOrderNo = _SQLDataReader["DisplayOrderNo"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.OrderStatus = _SQLDataReader["OrderStatus"].ToString();

                            _result.DeliveryCharge = _SQLDataReader["DeliveryCharge"].ToString();
                            _result.DeliveryChargeCode = _SQLDataReader["DeliveryChargeCode"].ToString();
                            
                            _result.DeliveryName = _SQLDataReader["DeliveryName"].ToString();

                            _result.MembershipDiscount = _SQLDataReader["MembershipDiscount"].ToString();
                            _result.VoucherDiscount = _SQLDataReader["VoucherDiscount"].ToString();

                            _result.GrandTotal = _SQLDataReader["GrandTotal"].ToString();

                           
                            _result.DeliveryAddress_StreetName = _SQLDataReader["DeliveryAddress_StreetName"].ToString();
                            _result.DeliveryAddress_Town = _SQLDataReader["DeliveryAddress_Town"].ToString();
                            _result.DeliveryAddress_Postcode = _SQLDataReader["DeliveryAddress_Postcode"].ToString();
                            _result.DeliveryAddress_StateCode = _SQLDataReader["DeliveryAddress_StateCode"].ToString();
                            _result.DeliveryAddress_CountryCode = _SQLDataReader["DeliveryAddress_CountryCode"].ToString();
                            _result.ReferenceName = _SQLDataReader["ReferenceName"].ToString();
                            _result.ReferencePhoneNo = _SQLDataReader["ReferencePhoneNo"].ToString();
                            _result.NoteToSeller = _SQLDataReader["NoteToSeller"].ToString();
                            _result.MerchantPointEarn = _SQLDataReader["MerchantPointEarn"].ToString();
                            _result.AyohaPointEarn = _SQLDataReader["AyohaPointEarn"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            _result.ItemQuantity = Convert.ToInt32(_SQLDataReader["ItemQuantity"].ToString());
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemPrice = _SQLDataReader["ItemPrice"].ToString();
                            _result.ItemPriceDiscount = _SQLDataReader["ItemPriceDiscount"].ToString();
                            _result.ItemDescriptions = _SQLDataReader["ItemDescriptions"].ToString();
                            _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.ItemCoverImg = _SQLDataReader["ItemCoverImg"].ToString();
                            _result.SubTotal = _SQLDataReader["SubTotal"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            


                            _result.PaymentAmount = _SQLDataReader["PaymentAmount"].ToString();
                            _result.PaymentMethod = _SQLDataReader["PaymentMethod"].ToString();
                            _result.PaymentMethodCode = _SQLDataReader["PaymentMethodCode"].ToString();
                            _result.PaymentNoDisplay = _SQLDataReader["PaymentNoDisplay"].ToString();
                            _result.PaymentNo = _SQLDataReader["PaymentNo"].ToString();
                            _result.PaymentStatus = _SQLDataReader["PaymentStatus"].ToString();
                            _result.PaymentDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["PaymentDate"]) + " " + String.Format("{0:T}", _SQLDataReader["PaymentDate"]);
                            _result.LoyaltyRewardType = _SQLDataReader["LoyaltyRewardType"].ToString();
                            _result.TotalVoucherDiscount = _SQLDataReader["TotalVoucherDiscount"].ToString();

                            _result.MemberDiscountPercent = _SQLDataReader["MemberDiscountPercent"].ToString();
                            _result.MemberDiscountAmount = _SQLDataReader["MemberDiscountAmount"].ToString();
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





        public static string AyohaStore_OrderLogStatus_LoadByOrderNo_Logging(string OrderNo)
        {
            string OrderLogOrderStatus = "";
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
                        _SQLCommand.CommandText = "AyohaStore_OrderLogStatus_LoadByOrderNo_Logging";
                        _SQLCommand.Parameters.AddWithValue("@OrderNo", OrderNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        while (_SQLDataReader.Read())
                        {
                           
                            OrderLogOrderStatus += _SQLDataReader["OrderLogOrderStatus"].ToString() + ",";
                            
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
            return OrderLogOrderStatus;
        }

        public static string AyohaStore_OrderLogCreatedDate_LoadByOrderNo_Logging(string OrderNo)
        {
            string OrderLogCreatedDate = "";
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
                        _SQLCommand.CommandText = "AyohaStore_OrderLogCreatedDate_LoadByOrderNo_Logging";
                        _SQLCommand.Parameters.AddWithValue("@OrderNo", OrderNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        while (_SQLDataReader.Read())
                        {

                            OrderLogCreatedDate += String.Format("{0:d/M/yyyy}", _SQLDataReader["OrderLogCreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["OrderLogCreatedDate"]) + ",";

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
            return OrderLogCreatedDate;
        }





        public static List<AyohaStoreOrderModel> AyohaStore_Order_PendingOrder_MainDashbord(string SubscriberAccNo)
        {
            List<AyohaStoreOrderModel> _Value = new List<AyohaStoreOrderModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_Order_PendingOrder_MainDashbord";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStoreOrderModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStoreOrderModel();                       
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.GrandTotal = _SQLDataReader["GrandTotal"].ToString();
                            _result.AyohaPointEarn = _SQLDataReader["AyohaPointEarn"].ToString();
                          //  _result.ModifiedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ModifiedDate"]);
                            _result.TotalStampEarn = _SQLDataReader["TotalStampEarn"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.OrderStatus = _SQLDataReader["OrderStatus"].ToString();                            
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemQuantity = Convert.ToInt32(_SQLDataReader["ItemQuantity"].ToString());
                            _result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.AyohaPointEarn = _SQLDataReader["AyohaPointEarn"].ToString();
                            _result.Row_num = Convert.ToInt32(_SQLDataReader["rn"].ToString());
                            
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






        public static List<AyohaStoreOrderModel> AyohaStore_Order_PendingOrder_MainDashbord_Count(string SubscriberAccNo)
        {
            List<AyohaStoreOrderModel> _Value = new List<AyohaStoreOrderModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_Order_PendingOrder_MainDashbord_Count";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStoreOrderModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStoreOrderModel();
                            _result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalPendingOrders"].ToString());                           
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






        public static List<AyohaStoreOrderModel> AyohaStore_Order_LoadByOrderNo_SubscriberAccNo(string OrderNo, string SubscriberAccNo)
        {
            List<AyohaStoreOrderModel> _Value = new List<AyohaStoreOrderModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_Order_LoadByOrderNo_SubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@OrderNo", OrderNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStoreOrderModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaStoreOrderModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.DeliveryChargeCode = _SQLDataReader["DeliveryChargeCode"].ToString();
                            _result.DeliveryCharge = _SQLDataReader["DeliveryCharge"].ToString();
                            _result.MembershipDiscountCampaignCode = _SQLDataReader["MembershipDiscountCampaignCode"].ToString();
                            _result.MembershipDiscount = _SQLDataReader["MembershipDiscount"].ToString();
                            _result.VoucherCampaignCode = _SQLDataReader["VoucherCampaignCode"].ToString();
                            _result.VoucherDiscount = _SQLDataReader["VoucherDiscount"].ToString();
                            _result.GrandTotal = _SQLDataReader["GrandTotal"].ToString();
                            _result.DeliveryAddress_StreetName = _SQLDataReader["DeliveryAddress_StreetName"].ToString();
                            _result.DeliveryAddress_Town = _SQLDataReader["DeliveryAddress_Town"].ToString();
                            _result.DeliveryAddress_Postcode = _SQLDataReader["DeliveryAddress_Postcode"].ToString();
                            _result.DeliveryAddress_StateCode = _SQLDataReader["DeliveryAddress_StateCode"].ToString();
                            _result.DeliveryAddress_CountryCode = _SQLDataReader["DeliveryAddress_CountryCode"].ToString();
                            _result.ReferenceName = _SQLDataReader["ReferenceName"].ToString();
                            _result.ReferencePhoneNo = _SQLDataReader["ReferencePhoneNo"].ToString();
                            _result.NoteToSeller = _SQLDataReader["NoteToSeller"].ToString();
                            _result.MerchantPointEarn = _SQLDataReader["MerchantPointEarn"].ToString();
                            _result.AyohaPointEarn = _SQLDataReader["AyohaPointEarn"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ModifiedDate"]);
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.DisplayOrderNo = _SQLDataReader["DisplayOrderNo"].ToString();
                            _result.DeliveryName = _SQLDataReader["DeliveryName"].ToString();
                            _result.TotalQuantity = Convert.ToInt32(_SQLDataReader["TotalQuantity"].ToString());
                            _result.OrderStatus = _SQLDataReader["OrderStatus"].ToString();
                            _result.TotalStampEarn = _SQLDataReader["TotalStampEarn"].ToString();
                            _result.Row_num = Convert.ToInt32(_SQLDataReader["Row_num"].ToString());
                            _result.OrderLogOrderStatus = AyohaStore_OrderLogStatus_LoadByOrderNo_Logging(_SQLDataReader["OrderNo"].ToString());
                            _result.OrderLogCreatedDate = AyohaStore_OrderLogCreatedDate_LoadByOrderNo_Logging(_SQLDataReader["OrderNo"].ToString());
                            _result.SubTotal = _SQLDataReader["SubTotal"].ToString();




                            //_result.ClientName = _SQLDataReader["ClientName"].ToString();
                            //_result.ClientEmail = _SQLDataReader["ClientEmail"].ToString();
                            //_result.ClientPhoneNo = _SQLDataReader["ClientPhoneNo"].ToString();
                            //_result.ClientPhoto = _SQLDataReader["ClientPhoto"].ToString();
                            //_result.OrderPaidUnpaidStatus = _SQLDataReader["OrderPaidUnpaidStatus"].ToString();
                            //_result.CreatedDate_MonthYear = ModifiedMonthYear(String.Format("{0:M/yyyy}", _SQLDataReader["CreatedDate"]), String.Format("{0:yyyy}", _SQLDataReader["CreatedDate"]));
                            //_result.SearchCol = _SQLDataReader["ClientName"].ToString() + "|" + _SQLDataReader["DisplayOrderNo"].ToString() + "|" + _SQLDataReader["DeliveryName"].ToString();

                          
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




