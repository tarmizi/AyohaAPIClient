using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
namespace WebApiResit.Models
{
    public class AyohaStore_CartModel
    {
        public int ID
        {
            get;
            set;
        }

        public string ItemCode
        {
            get;
            set;
        }
        public int ItemQuantity
        {
            get;
            set;
        }
        public string ItemSumPrice
        {
            get;
            set;
        }
        public string ItemCartStatus
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

        public string ItemPriceDiscountRate
        {
            get;
            set;
        }

        




        public string LoyaltyRewardType
        {
            get;
            set;
        }


        public string MerchantSumPoint
        {
            get;
            set;
        }
        public string AyohaSumPoint
        {
            get;
            set;
        }


        public int MerchantSumStamp
        {
            get;
            set;
        }

        public string ItemCoverImg
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

        public string TotalItemQuantity
        {
            get;
            set;
        }


        public string TotalSumPrice
        {
            get;
            set;
        }

        public string TotalMerchantPoint
        {
            get;
            set;
        }

        public string TotalAyohaPoint
        {
            get;
            set;
        }

        public string TotalMerchantSumStamp
        {
            get;
            set;
        }

        public int RowNumber
        {
            get;
            set;
        }

        public string ItemDescriptions
        {
            get;
            set;
        }
        public string MembershipCardCode
        {
            get;
            set;
        }

        public string ItemCartCode
        {
            get;
            set;
        }
        public string ItemCartCodes
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

        public string StampRuleAmount
        {
            get;
            set;
        }
        public string NewItemCartCode
        {
            get;
            set;
        }
        
        public AyohaStore_CartModel() { }


        public static string AyohaStore_Cart_InsertUpdate(int ID, string ItemCode, int ItemQuantity, string ItemSumPrice, string ItemCartStatus, string CreatedBy, string EnterpriseAccNo, string SubscriberAccNo, string LoyaltyRewardType, string MerchantSumPoint
            , string AyohaSumPoint, int MerchantSumStamp, string MerchantPoint, string AyohaPoint, string MembershipCardCode, string ItemCartCode)
        {

          //  string  ItemCartCodes = "";
            AyohaStore_CartModel c = new AyohaStore_CartModel();
            if (ItemCartCode == "NewItemCartCode")
            {
                c.ItemCartCodes = GenerateCartCode() + '-' + SubscriberAccNo + '-' + EnterpriseAccNo + '-' + MembershipCardCode;
            }
            else
            {
                c.ItemCartCodes = ItemCartCode;
            }


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
                        _SQLCommand.CommandText = "AyohaStore_Cart_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@ItemCode", ItemCode);
                        _SQLCommand.Parameters.AddWithValue("@ItemQuantity", ItemQuantity);
                        _SQLCommand.Parameters.AddWithValue("@ItemSumPrice", ItemSumPrice);
                        _SQLCommand.Parameters.AddWithValue("@ItemCartStatus", ItemCartStatus);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@LoyaltyRewardType", LoyaltyRewardType);
                        _SQLCommand.Parameters.AddWithValue("@MerchantSumPoint", MerchantSumPoint);
                        _SQLCommand.Parameters.AddWithValue("@AyohaSumPoint", AyohaSumPoint);
                        _SQLCommand.Parameters.AddWithValue("@MerchantSumStamp", MerchantSumStamp);
                        _SQLCommand.Parameters.AddWithValue("@MerchantPoint", MerchantPoint);
                        _SQLCommand.Parameters.AddWithValue("@AyohaPoint", AyohaPoint);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@ItemCartCode", c.ItemCartCodes);                        
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


        public static string AyohaStore_Cart_Delete(int ID, string EnterpriseAccNo, string SubscriberAccNo, string MembershipCardCode)
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
                        _SQLCommand.CommandText = "AyohaStore_Cart_Delete";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
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



        public static string AyohaStore_Cart_UnSold(string EnterpriseAccNo, string SubscriberAccNo,string ItemCartCode)
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
                        _SQLCommand.CommandText = "AyohaStore_Cart_UnSold";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ItemCartCode", ItemCartCode);
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

        public static string AyohaStore_Cart_Re_Order(string EnterpriseAccNo, string SubscriberAccNo, string ItemCartCode, string NewItemCartCode)
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
                        _SQLCommand.CommandText = "AyohaStore_Cart_Re_Order";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ItemCartCode", ItemCartCode);
                        _SQLCommand.Parameters.AddWithValue("@NewItemCartCode", NewItemCartCode);
                        
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















        public static string AyohaStore_Cart_UpdateStatus_OrderSent(string EnterpriseAccNo, string SubscriberAccNo, string MembershipCardCode)
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
                        _SQLCommand.CommandText = "AyohaStore_Cart_UpdateStatus_OrderSent";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
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
        public static List<AyohaStore_CartModel> AyohaStore_Cart_LoadCartAyohaStore(string ItemCartStatus, string EnterpriseAccNo, string SubscriberAccNo, string MembershipCardCode)
        {
            List<AyohaStore_CartModel> _Value = new List<AyohaStore_CartModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_Cart_LoadCartAyohaStore";
                        _SQLCommand.Parameters.AddWithValue("@ItemCartStatus", ItemCartStatus);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStore_CartModel _result;
                        while (_SQLDataReader.Read())
                        {

                         




                            //_result = new AyohaStore_CartModel();
                            //_result.RowNumber = Convert.ToInt32(_SQLDataReader["RowNumber"].ToString());
                            //_result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            //_result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            //_result.ItemQuantity = Convert.ToInt32(_SQLDataReader["ItemQuantity"].ToString());
                            //_result.ItemSumPrice = _SQLDataReader["ItemSumPrice"].ToString();
                            //_result.ItemCartStatus = _SQLDataReader["ItemCartStatus"].ToString();
                            //_result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            //_result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            //_result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            //_result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            //_result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            //_result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            //_result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            // _result.LoyaltyRewardType = _SQLDataReader["LoyaltyRewardType"].ToString();
                            //_result.MerchantSumPoint = _SQLDataReader["MerchantSumPoint"].ToString();
                            //_result.AyohaSumPoint = _SQLDataReader["AyohaSumPoint"].ToString();
                            //_result.MerchantSumStamp =Convert.ToInt32( _SQLDataReader["MerchantSumStamp"].ToString());
                            //_result.ItemCoverImg = _SQLDataReader["ItemCoverImg"].ToString();
                            //_result.MerchantPoint = _SQLDataReader["MerchantPoint"].ToString();
                            //_result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                            //_result.ItemName = _SQLDataReader["ItemName"].ToString();
                            //_result.ItemPrice = _SQLDataReader["ItemPrice"].ToString();
                            //_result.ItemPriceDiscount = _SQLDataReader["ItemPriceDiscount"].ToString();
                            //_result.ItemPriceDiscountRate = _SQLDataReader["ItemPriceDiscountRate"].ToString();                            
                            //_result.TotalItemQuantity = _SQLDataReader["TotalItemQuantity"].ToString();
                            //_result.TotalSumPrice = _SQLDataReader["TotalSumPrice"].ToString();
                            //_result.TotalMerchantPoint = _SQLDataReader["TotalMerchantPoint"].ToString();
                            //_result.TotalAyohaPoint = _SQLDataReader["TotalAyohaPoint"].ToString();
                            //_result.TotalMerchantSumStamp = _SQLDataReader["TotalMerchantSumStamp"].ToString();
                            //_result.StampRuleAmount = _SQLDataReader["StampRuleAmount"].ToString();
                            //_result.ItemDescriptions = _SQLDataReader["ItemDescriptions"].ToString();
                            //_result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            //_result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();










                            _result = new AyohaStore_CartModel();
                            _result.RowNumber = Convert.ToInt32(_SQLDataReader["RowNumber"].ToString());
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.ItemQuantity = Convert.ToInt32(_SQLDataReader["ItemQuantity"].ToString());
                            _result.ItemSumPrice = _SQLDataReader["ItemSumPrice"].ToString();
                            _result.ItemCartStatus = _SQLDataReader["ItemCartStatus"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.LoyaltyRewardType = _SQLDataReader["LoyaltyRewardType"].ToString();
                            _result.MerchantSumPoint = _SQLDataReader["MerchantSumPoint"].ToString();
                            _result.AyohaSumPoint = _SQLDataReader["AyohaSumPoint"].ToString();
                            _result.MerchantSumStamp = Convert.ToInt32(_SQLDataReader["MerchantSumStamp"].ToString());
                            _result.MerchantPoint = _SQLDataReader["MerchantPoint"].ToString();
                            _result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.ItemCoverImg = _SQLDataReader["ItemCoverImg"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemPrice = _SQLDataReader["ItemPrice"].ToString();
                            _result.ItemPriceDiscount = _SQLDataReader["ItemPriceDiscount"].ToString();
                            _result.ItemPriceDiscountRate = _SQLDataReader["ItemPriceDiscountRate"].ToString();
                            _result.ItemDescriptions = _SQLDataReader["ItemDescriptions"].ToString();
                            _result.TotalItemQuantity = _SQLDataReader["TotalItemQuantity"].ToString();
                            _result.TotalSumPrice = _SQLDataReader["TotalSumPrice"].ToString();
                            _result.TotalMerchantPoint = _SQLDataReader["TotalMerchantPoint"].ToString();
                            _result.TotalAyohaPoint = _SQLDataReader["TotalAyohaPoint"].ToString();
                            _result.TotalMerchantSumStamp = _SQLDataReader["TotalMerchantSumStamp"].ToString();
                            _result.StampRuleAmount = _SQLDataReader["StampRuleAmount"].ToString();
                      
                       
                   
                            
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


        public static List<AyohaStore_CartModel> AyohaStore_Cart_LoadCartAyohaStore_ReOrder(string ItemCartStatus, string EnterpriseAccNo, string SubscriberAccNo, string MembershipCardCode, string ItemCartCode)
        {
            List<AyohaStore_CartModel> _Value = new List<AyohaStore_CartModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_Cart_LoadCartAyohaStore_ReOrder";
                        _SQLCommand.Parameters.AddWithValue("@ItemCartStatus", ItemCartStatus);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@ItemCartCode", ItemCartCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStore_CartModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStore_CartModel();
                            _result.RowNumber = Convert.ToInt32(_SQLDataReader["RowNumber"].ToString());
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.ItemQuantity = Convert.ToInt32(_SQLDataReader["ItemQuantity"].ToString());
                            _result.ItemSumPrice = _SQLDataReader["ItemSumPrice"].ToString();
                            _result.ItemCartStatus = _SQLDataReader["ItemCartStatus"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.LoyaltyRewardType = _SQLDataReader["LoyaltyRewardType"].ToString();
                            _result.MerchantSumPoint = _SQLDataReader["MerchantSumPoint"].ToString();
                            _result.AyohaSumPoint = _SQLDataReader["AyohaSumPoint"].ToString();
                            _result.MerchantSumStamp = Convert.ToInt32(_SQLDataReader["MerchantSumStamp"].ToString());
                            _result.ItemCoverImg = _SQLDataReader["ItemCoverImg"].ToString();
                            _result.MerchantPoint = _SQLDataReader["MerchantPoint"].ToString();
                            _result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemPrice = _SQLDataReader["ItemPrice"].ToString();
                            _result.ItemPriceDiscount = _SQLDataReader["ItemPriceDiscount"].ToString();
                            _result.ItemPriceDiscountRate = _SQLDataReader["ItemPriceDiscountRate"].ToString();
                            _result.TotalItemQuantity = _SQLDataReader["TotalItemQuantity"].ToString();
                            _result.TotalSumPrice = _SQLDataReader["TotalSumPrice"].ToString();
                            _result.TotalMerchantPoint = _SQLDataReader["TotalMerchantPoint"].ToString();
                            _result.TotalAyohaPoint = _SQLDataReader["TotalAyohaPoint"].ToString();
                            _result.TotalMerchantSumStamp = _SQLDataReader["TotalMerchantSumStamp"].ToString();
                            _result.StampRuleAmount = _SQLDataReader["StampRuleAmount"].ToString();
                            _result.ItemDescriptions = _SQLDataReader["ItemDescriptions"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();

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



        public static List<AyohaStore_CartModel> AyohaStore_Cart_OrderCart(string ItemCartStatus, string SubscriberAccNo)
        {
            List<AyohaStore_CartModel> _Value = new List<AyohaStore_CartModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_Cart_OrderCart";
                        _SQLCommand.Parameters.AddWithValue("@ItemCartStatus", ItemCartStatus);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStore_CartModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStore_CartModel();
                            _result.RowNumber = Convert.ToInt32(_SQLDataReader["RowNumber"].ToString());
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.ItemQuantity = Convert.ToInt32(_SQLDataReader["ItemQuantity"].ToString());
                            _result.ItemSumPrice = _SQLDataReader["ItemSumPrice"].ToString();
                            _result.ItemCartStatus = _SQLDataReader["ItemCartStatus"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.LoyaltyRewardType = _SQLDataReader["LoyaltyRewardType"].ToString();
                            _result.MerchantSumPoint = _SQLDataReader["MerchantSumPoint"].ToString();
                            _result.AyohaSumPoint = _SQLDataReader["AyohaSumPoint"].ToString();
                            _result.MerchantSumStamp = Convert.ToInt32(_SQLDataReader["MerchantSumStamp"].ToString());
                            _result.ItemCoverImg = _SQLDataReader["ItemCoverImg"].ToString();
                            _result.MerchantPoint = _SQLDataReader["MerchantPoint"].ToString();
                            _result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemPrice = _SQLDataReader["ItemPrice"].ToString();
                            _result.ItemPriceDiscount = _SQLDataReader["ItemPriceDiscount"].ToString();
                            _result.ItemPriceDiscountRate = _SQLDataReader["ItemPriceDiscountRate"].ToString();
                            _result.TotalItemQuantity = _SQLDataReader["TotalItemQuantity"].ToString();
                            _result.TotalSumPrice = _SQLDataReader["TotalSumPrice"].ToString();
                            _result.TotalMerchantPoint = _SQLDataReader["TotalMerchantPoint"].ToString();
                            _result.TotalAyohaPoint = _SQLDataReader["TotalAyohaPoint"].ToString();
                            _result.TotalMerchantSumStamp = _SQLDataReader["TotalMerchantSumStamp"].ToString();
                            _result.ItemDescriptions = _SQLDataReader["ItemDescriptions"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
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

        public static List<AyohaStore_CartModel> AyohaStore_Cart_LoadItemCartStatus(string EnterpriseAccNo, string SubscriberAccNo)
        {
            List<AyohaStore_CartModel> _Value = new List<AyohaStore_CartModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_Cart_LoadItemCartStatus";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStore_CartModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStore_CartModel();
                            _result.ItemCartStatus = _SQLDataReader["ItemCartStatus"].ToString();
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



        public static List<AyohaStore_CartModel> AyohaStore_Cart_CartTotalItemQuantity(string EnterpriseAccNo, string SubscriberAccNo)
        {
            List<AyohaStore_CartModel> _Value = new List<AyohaStore_CartModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_Cart_CartTotalItemQuantity";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStore_CartModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStore_CartModel();
                            _result.TotalItemQuantity = _SQLDataReader["TotalItemQuantity"].ToString();
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



        public static string GenerateCartCode()
        {
            string val = "";

            Random rnd = new Random();
            int month = rnd.Next(1, 13);  // creates a number between 1 and 12
            int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
            int card = rnd.Next(55555);

            val = month.ToString() + dice.ToString() + card.ToString();

            return val;
        }


    }
}