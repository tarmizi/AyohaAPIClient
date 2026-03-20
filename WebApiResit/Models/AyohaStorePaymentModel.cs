using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
namespace WebApiResit.Models
{
    public class AyohaStorePaymentModel
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
        public string PaymentNo
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


        //public string MembershipCardCode
        //{
        //    get;
        //    set;
        //}
        public string RowStatus
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

        //public string NoteToSeller
        //{
        //    get;
        //    set;
        //}


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



























        public string DeliveryName
        {
            get;
            set;
        }
        public string DeliveryCharge
        {
            get;
            set;
        }
        public string MembershipDiscount
        {
            get;
            set;
        }
        public string VoucherDiscount
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

        public string MembershipCardCode
        {
            get;
            set;
        }


        public string DisplayOrderNo
        {
            get;
            set;
        }

        public string TotalQuantity
        {
            get;
            set;
        }
























        public string SubTotal
        {
            get;
            set;
        }
        public string ItemSumPrice
        {
            get;
            set;
        }
        public string ItemName
        {
            get;
            set;
        }
        public string ItemQuantity
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
        public string ItemPriceDiscountRate
        {
            get;
            set;
        }

        public string EnterpriseName
        {
            get;
            set;
        }
        public string EnterpriseLogoPath
        {
            get;
            set;
        }
        public string EnterpriseAddress
        {
            get;
            set;
        }
        public string EnterpriseRegistrationNo
        {
            get;
            set;
        }


        public string EnterpriseTagLine
        {
            get;
            set;
        }
        public string EnterprisePhoneNo
        {
            get;
            set;
        }



        public string EnterpriseEmail
        {
            get;
            set;
        }
        public string EnterpriseWebsite
        {
            get;
            set;
        }

        public string PayerName
        {
            get;
            set;
        }


        public int Row_num
        {
            get;
            set;
        }

        public string MembershipCardName
        {
            get;
            set;
        }

        public string MembershipCardBackgroundImg
        {
            get;
            set;
        }

        public string VoucherCode
        {
            get;
            set;
        }

        public int VoucherCount
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
        public AyohaStorePaymentModel() { }



         


        public static string AyohaStore_Payment_Insert(string OrderNo, string SubscriberAccNo, string EnterpriseAccNo, string GrandTotal, string PaymentAmount, string PaymentMethod,
           string PaymentMethodCode, string CreatedBy, string MembershipCardCode, string PaymentStatus, string NoteToSeller, string MerchantPoint, string AyohaPoint, string VoucherCode, int VoucherCount, string VoucherDiscount,
            string MemberDiscountPercent, string MemberDiscountAmount)
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
                        _SQLCommand.Parameters.AddWithValue("@VoucherCode", VoucherCode);
                        _SQLCommand.Parameters.AddWithValue("@VoucherCount", VoucherCount);
                        _SQLCommand.Parameters.AddWithValue("@VoucherDiscount", VoucherDiscount);

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

                        AyohaStore_Payment_PushNotificationInfo(SubscriberAccNo, EnterpriseAccNo, MerchantPoint, AyohaPoint);


        //                AyohaNotificationMasterEnterprisesModel.AyohaNotificationMaster_Enterprises_Insert(OrderNo, SubscriberAccNo, EnterpriseAccNo, GrandTotal, PaymentAmount, PaymentMethod,
        //PaymentMethodCode, CreatedBy, MembershipCardCode, PaymentStatus, NoteToSeller,"Payment-Received");
                       

                    }

                }

            }





            return _value;



        }





        public static void AyohaStore_Payment_PushNotificationInfo(string SubscriberAccNo, string EnterpriseAccNo, string MerchantPointEarn, string AyohaPointEarn)
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








        public static List<AyohaStorePaymentModel> AyohaStore_Payment_GenerateReceipt(string OrderNo, string ItemCartCode, string PaymentNo, string SubscriberAccNo, string MembershipCardCode)
        {
            List<AyohaStorePaymentModel> _Value = new List<AyohaStorePaymentModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_Payment_GenerateReceipt";
                        _SQLCommand.Parameters.AddWithValue("@OrderNo", OrderNo);
                        _SQLCommand.Parameters.AddWithValue("@ItemCartCode", ItemCartCode);
                        _SQLCommand.Parameters.AddWithValue("@PaymentNo", PaymentNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStorePaymentModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStorePaymentModel();
                            _result.PaymentNo = _SQLDataReader["PaymentNo"].ToString();
                            _result.PaymentNoDisplay = _SQLDataReader["PaymentNoDisplay"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.OrderNo = _SQLDataReader["OrderNo"].ToString();
                            _result.GrandTotal = _SQLDataReader["GrandTotal"].ToString();
                            _result.PaymentAmount = _SQLDataReader["PaymentAmount"].ToString();
                            _result.PaymentMethod = _SQLDataReader["PaymentMethod"].ToString();
                            _result.PaymentStatus = _SQLDataReader["PaymentStatus"].ToString();
                            _result.DeliveryName = _SQLDataReader["DeliveryName"].ToString();
                            _result.DeliveryCharge = _SQLDataReader["DeliveryCharge"].ToString();                         
                            _result.MembershipDiscount = _SQLDataReader["MembershipDiscount"].ToString();
                            _result.VoucherDiscount = _SQLDataReader["VoucherDiscount"].ToString();                         
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
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.DisplayOrderNo = _SQLDataReader["DisplayOrderNo"].ToString();
                            _result.TotalQuantity =_SQLDataReader["TotalQuantity"].ToString();
                            _result.SubTotal = _SQLDataReader["SubTotal"].ToString();
                            _result.ItemSumPrice = _SQLDataReader["ItemSumPrice"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemQuantity = _SQLDataReader["ItemQuantity"].ToString();                            
                            _result.ItemPrice = _SQLDataReader["ItemPrice"].ToString();
                            _result.ItemPriceDiscount = _SQLDataReader["ItemPriceDiscount"].ToString();
                            _result.ItemPriceDiscountRate = _SQLDataReader["ItemPriceDiscountRate"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.PayerName = _SQLDataReader["PayerName"].ToString();
                            _result.Row_num = Convert.ToInt32(_SQLDataReader["Row_num"].ToString());
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                            
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