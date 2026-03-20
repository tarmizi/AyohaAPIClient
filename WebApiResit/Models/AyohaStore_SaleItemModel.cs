using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
 
    public class AyohaStore_SaleItemModel
    {
        //   public int ID
        //{
        //    get;
        //    set;
        //}

        //    public int CountItemCategory
        //{
        //    get;
        //    set;
        //}
        //    public int CountItem
        //{
        //    get;
        //    set;
        //}
        //    public int CountLike
        //{
        //    get;
        //    set;
        //}
        //    public int CountMembershipCard
        //{
        //    get;
        //    set;
        //}
        //  public string MembershipCardCode
        // {
        //     get;
        //     set;
        // }
        //  public string MembershipApprovalStatus
        // {
        //     get;
        //     set;
        // }

        // public string EnterpriseAccNo
        // {
        //     get;
        //     set;
        // }
        
        //public string ItemCode
        //{
        //    get;
        //    set;
        //}


        //public string ItemName
        //{
        //    get;
        //    set;
        //}
        //public string ItemPrice
        //{
        //    get;
        //    set;
        //}

        //public string ItemPriceDiscount
        //{
        //    get;
        //    set;
        //}
        //public string ItemCoverImg
        //{
        //    get;
        //    set;
        //}
        //public string ItemDescriptions
        //{
        //    get;
        //    set;
        //}



        //public string ItemCategoryCode
        //{
        //    get;
        //    set;
        //}
        //public string CreatedBy
        //{
        //    get;
        //    set;
        //}

        //public string CreatedDate
        //{
        //    get;
        //    set;
        //}
        //public string ModifiedBy
        //{
        //    get;
        //    set;
        //}
        //public string ModifiedDate
        //{
        //    get;
        //    set;
        //}

        //public string RowStatus
        //{
        //    get;
        //    set;
        //}

        //public string isLikeStatus
        //{
        //    get;
        //    set;
        //}


        // public string CampaignCode
        //{
        //    get;
        //    set;
        //}
        //public string CampaignType
        //{
        //    get;
        //    set;
        //}

        //public string MerchantPoint
        //{
        //    get;
        //    set;
        //}

        //public string AyohaPoint
        //{
        //    get;
        //    set;
        //}

        //public string CartTotalItemQuantity
        //{
        //    get;
        //    set;
        //}
        //public string CartSumItemSumPrice
        //{
        //    get;
        //    set;
        //}

        //public string ImgPath
        //{
        //    get;
        //    set;
        //}

        //public string AyohaUser_MembershipCardCount
        //{
        //    get;
        //    set;
        //}
        //public string SaleItemCode
        //{
        //    get;
        //    set;
        //}


        //public string ItemPriceDiscountRate
        //{
        //    get;
        //    set;
        //}



        //public string MembershipCardImage
        //{
        //    get;
        //    set;
        //}

        //public string MembershipCardName
        //{
        //    get;
        //    set;
        //}
        //public string AyohaUser_MembershipCardUsedCount
        //{
        //    get;
        //    set;
        //}




        public int ID
        {
            get;
            set;
        }

        public int CountItemCategory
        {
            get;
            set;
        }
        public int CountItem
        {
            get;
            set;
        }
        public int CountLike
        {
            get;
            set;
        }
        public int CountMembershipCard
        {
            get;
            set;
        }
        public string MembershipCardCode
        {
            get;
            set;
        }
        public string MembershipApprovalStatus
        {
            get;
            set;
        }

        public string EnterpriseAccNo
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
        public string ItemCoverImg
        {
            get;
            set;
        }
        public string ItemDescriptions
        {
            get;
            set;
        }



        public string ItemCategoryCode
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

        public string isLikeStatus
        {
            get;
            set;
        }


        public string CampaignCode
        {
            get;
            set;
        }
        public string CampaignType
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

        public string CartTotalItemQuantity
        {
            get;
            set;
        }
        public string CartSumItemSumPrice
        {
            get;
            set;
        }

        public string ImgPath
        {
            get;
            set;
        }


        public string SaleItemCode
        {
            get;
            set;
        }
        public string ItemPriceDiscountRate
        {
            get;
            set;
        }
        public string ItemCoverImgName
        {
            get;
            set;
        }
        public string ProductCategoryName
        {
            get;
            set;
        }













        public string AyohaUser_MembershipCardCount
        {
            get;
            set;
        }
        public string MembershipCardImage
        {
            get;
            set;
        }
        public string MembershipCardName
        {
            get;
            set;
        }
        public string AyohaUser_MembershipCardUsedCount
        {
            get;
            set;
        }


        public string SubscriberAccNo
        {
            get;
            set;
        }

        public int row_num
        {
            get;
            set;
        }

        public int Stock
        {
            get;
            set;
        }

        public string ShowStock
        {
            get;
            set;
        }

        public int StockAlert
        {
            get;
            set;
        }

        public string ItemCartCode
        {
            get;
            set;
        }

        public int MembershipEventCount
        {
            get;
            set;
        }
        public int MembershipContestCount
        {
            get;
            set;
        }
        public int VoucherCount
        {
            get;
            set;
        }




        public int StampPointCampaignCodeCount
        {
            get;
            set;
        }
        public string StampPointCampaignCode
        {
            get;
            set;
        }
        public string StampRuleAmount
        {
            get;
            set;
        }
        public string ReviewCode
        {
            get;
            set;
        }
        
        

        public AyohaStore_SaleItemModel() { }



        public static List<AyohaStore_SaleItemModel> AyohaStore_SaleItem_loadBy_EnterpriseAccNo_ItemCategory(string EnterpriseAccNo, string ItemCategoryCode, string SubscriberAccNo)
        {
            List<AyohaStore_SaleItemModel> _Value = new List<AyohaStore_SaleItemModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_SaleItem_loadBy_EnterpriseAccNo_ItemCategory";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ItemCategoryCode", ItemCategoryCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStore_SaleItemModel _result;
                        while (_SQLDataReader.Read())
                        {
                           // _result = new AyohaStore_SaleItemModel();
                            //_result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            //_result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            //_result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            //_result.ItemName = _SQLDataReader["ItemName"].ToString();
                            //_result.ItemPrice = _SQLDataReader["ItemPrice"].ToString();
                            //_result.ItemPriceDiscount = _SQLDataReader["ItemPriceDiscount"].ToString();
                            //_result.ItemCoverImg = _SQLDataReader["ItemCoverImg"].ToString();
                            //_result.ItemDescriptions = _SQLDataReader["ItemDescriptions"].ToString();
                            //_result.ItemCategoryCode = _SQLDataReader["ItemCategoryCode"].ToString();
                            //_result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            //_result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();                            
                            //_result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            //_result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            //_result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            //_result.SaleItemCode = _SQLDataReader["SaleItemCode"].ToString(); 
                            // _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            //_result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();                            
                            //_result.CampaignType = _SQLDataReader["CampaignType"].ToString();
                            //_result.MerchantPoint = _SQLDataReader["MerchantPoint"].ToString();
                            //_result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                            //_result.AyohaUser_MembershipCardCount = _SQLDataReader["AyohaUser_MembershipCardCount"].ToString();
                            //_result.MembershipCardImage = _SQLDataReader["MembershipCardImage"].ToString();
                            //_result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            //_result.AyohaUser_MembershipCardUsedCount = _SQLDataReader["AyohaUser_MembershipCardUsedCount"].ToString();
                            //_result.ItemPriceDiscountRate = _SQLDataReader["ItemPriceDiscountRate"].ToString();

                            _result = new AyohaStore_SaleItemModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemPrice = _SQLDataReader["ItemPrice"].ToString();
                            _result.ItemPriceDiscount = _SQLDataReader["ItemPriceDiscount"].ToString();
                            _result.ItemCoverImg = _SQLDataReader["ProductImg"].ToString();
                            _result.ItemDescriptions = _SQLDataReader["ItemDescriptions"].ToString();
                            _result.ItemCategoryCode = _SQLDataReader["ItemCategoryCode"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.SaleItemCode = _SQLDataReader["SaleItemCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();
                            _result.CampaignType = _SQLDataReader["CampaignType"].ToString();
                            _result.MerchantPoint = _SQLDataReader["MerchantPoint"].ToString();
                            _result.StampRuleAmount = _SQLDataReader["StampRuleAmount"].ToString();                            
                            _result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                            _result.AyohaUser_MembershipCardCount = _SQLDataReader["AyohaUser_MembershipCardCount"].ToString();
                            _result.MembershipCardImage = _SQLDataReader["MembershipCardImage"].ToString();
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.AyohaUser_MembershipCardUsedCount = _SQLDataReader["AyohaUser_MembershipCardUsedCount"].ToString();
                            _result.ItemPriceDiscountRate = _SQLDataReader["ItemPriceDiscountRate"].ToString();
                            _result.ProductCategoryName = _SQLDataReader["ProductCategoryName"].ToString();
                            _result.ItemCoverImgName = _SQLDataReader["ItemCoverImgName"].ToString();
                            _result.row_num = Convert.ToInt32(_SQLDataReader["row_num"].ToString());
                            _result.Stock = Convert.ToInt32(_SQLDataReader["Stock"].ToString());
                            _result.ShowStock = _SQLDataReader["ShowStock"].ToString();
                            _result.StockAlert = Convert.ToInt32(_SQLDataReader["StockAlert"].ToString());
                            
                         
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



        public static List<AyohaStore_SaleItemModel> AyohaStore_SaleItem_loadBy_ItemCode(string EnterpriseAccNo, string SubscriberAccNo, string ReviewCode)
        {
            List<AyohaStore_SaleItemModel> _Value = new List<AyohaStore_SaleItemModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_SaleItem_loadBy_ItemCode";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ReviewCode", ReviewCode);
                       
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStore_SaleItemModel _result;
                        while (_SQLDataReader.Read())
                        {
                          
                            _result = new AyohaStore_SaleItemModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemPrice = _SQLDataReader["ItemPrice"].ToString();
                            _result.ItemPriceDiscount = _SQLDataReader["ItemPriceDiscount"].ToString();
                            _result.ItemCoverImg = _SQLDataReader["ProductImg"].ToString();
                            _result.ItemDescriptions = _SQLDataReader["ItemDescriptions"].ToString();
                            _result.ItemCategoryCode = _SQLDataReader["ItemCategoryCode"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.SaleItemCode = _SQLDataReader["SaleItemCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();
                            _result.CampaignType = _SQLDataReader["CampaignType"].ToString();
                            _result.MerchantPoint = _SQLDataReader["MerchantPoint"].ToString();
                            _result.StampRuleAmount = _SQLDataReader["StampRuleAmount"].ToString();
                            _result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                            _result.AyohaUser_MembershipCardCount = _SQLDataReader["AyohaUser_MembershipCardCount"].ToString();
                            _result.MembershipCardImage = _SQLDataReader["MembershipCardImage"].ToString();
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.AyohaUser_MembershipCardUsedCount = _SQLDataReader["AyohaUser_MembershipCardUsedCount"].ToString();
                            _result.ItemPriceDiscountRate = _SQLDataReader["ItemPriceDiscountRate"].ToString();
                            _result.ProductCategoryName = _SQLDataReader["ProductCategoryName"].ToString();
                            _result.ItemCoverImgName = _SQLDataReader["ItemCoverImgName"].ToString();
                            _result.row_num = Convert.ToInt32(_SQLDataReader["row_num"].ToString());
                            _result.Stock = Convert.ToInt32(_SQLDataReader["Stock"].ToString());
                            _result.ShowStock = _SQLDataReader["ShowStock"].ToString();
                            _result.StockAlert = Convert.ToInt32(_SQLDataReader["StockAlert"].ToString());


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


        public static List<AyohaStore_SaleItemModel> AyohaStore_SaleItem_loadBy_EnterpriseAccNo_HotItem(string EnterpriseAccNo, string ItemCategoryCode, string SubscriberAccNo)
        {
            List<AyohaStore_SaleItemModel> _Value = new List<AyohaStore_SaleItemModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_SaleItem_loadBy_EnterpriseAccNo_HotItem";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ItemCategoryCode", ItemCategoryCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStore_SaleItemModel _result;
                        while (_SQLDataReader.Read())
                        {
                            

                            _result = new AyohaStore_SaleItemModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.ItemCode = _SQLDataReader["ItemCode"].ToString();
                            _result.ItemName = _SQLDataReader["ItemName"].ToString();
                            _result.ItemPrice = _SQLDataReader["ItemPrice"].ToString();
                            _result.ItemPriceDiscount = _SQLDataReader["ItemPriceDiscount"].ToString();
                            _result.ItemCoverImg = _SQLDataReader["ProductImg"].ToString();
                            _result.ItemDescriptions = _SQLDataReader["ItemDescriptions"].ToString();
                            _result.ItemCategoryCode = _SQLDataReader["ItemCategoryCode"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.SaleItemCode = _SQLDataReader["SaleItemCode"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.CampaignCode = _SQLDataReader["CampaignCode"].ToString();
                            _result.CampaignType = _SQLDataReader["CampaignType"].ToString();
                            _result.MerchantPoint = _SQLDataReader["MerchantPoint"].ToString();
                            _result.AyohaPoint = _SQLDataReader["AyohaPoint"].ToString();
                            _result.AyohaUser_MembershipCardCount = _SQLDataReader["AyohaUser_MembershipCardCount"].ToString();
                            _result.MembershipCardImage = _SQLDataReader["MembershipCardImage"].ToString();
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.AyohaUser_MembershipCardUsedCount = _SQLDataReader["AyohaUser_MembershipCardUsedCount"].ToString();
                            _result.ItemPriceDiscountRate = _SQLDataReader["ItemPriceDiscountRate"].ToString();
                            _result.ProductCategoryName = _SQLDataReader["ProductCategoryName"].ToString();
                            _result.ItemCoverImgName = _SQLDataReader["ItemCoverImgName"].ToString();
                            _result.row_num = Convert.ToInt32(_SQLDataReader["row_num"].ToString());
                            _result.Stock = Convert.ToInt32(_SQLDataReader["Stock"].ToString());
                            _result.ShowStock = _SQLDataReader["ShowStock"].ToString();
                            _result.StockAlert = Convert.ToInt32(_SQLDataReader["StockAlert"].ToString());


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


        public static List<AyohaStore_SaleItemModel> AyohaStore_SaleItem_loadItemCategory(string EnterpriseAccNo, string MembershipCardCode)
        {
            List<AyohaStore_SaleItemModel> _Value = new List<AyohaStore_SaleItemModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_SaleItem_loadItemCategory";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStore_SaleItemModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStore_SaleItemModel();
                            _result.CountItemCategory = Convert.ToInt32(_SQLDataReader["CountItemCategory"].ToString());
                            _result.ItemCategoryCode = _SQLDataReader["ItemCategoryCode"].ToString();
                            _result.ProductCategoryName = _SQLDataReader["ProductCategoryName"].ToString();
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





        public static List<AyohaStore_SaleItemModel> AyohaStore_SaleItem_ImgExtendloadBy_ItemCode(string ItemCode)
        {
            List<AyohaStore_SaleItemModel> _Value = new List<AyohaStore_SaleItemModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_SaleItem_ImgExtendloadBy_ItemCode";
                        _SQLCommand.Parameters.AddWithValue("@ItemCode", ItemCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStore_SaleItemModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStore_SaleItemModel();
                            _result.ImgPath = _SQLDataReader["ImgPath"].ToString();
                            _result.row_num = Convert.ToInt32(_SQLDataReader["row_num"].ToString());                            
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



        public static List<AyohaStore_SaleItemModel> AyohaStore_SaleItem_AyohaStoreFrontPage(string SubscriberAccNo, string EnterpriseAccNo,string MembershipCardCode)
        {
            List<AyohaStore_SaleItemModel> _Value = new List<AyohaStore_SaleItemModel>();

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
                        _SQLCommand.CommandText = "AyohaStore_SaleItem_AyohaStoreFrontPage";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaStore_SaleItemModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaStore_SaleItemModel();
                            _result.CountItemCategory = Convert.ToInt32(_SQLDataReader["CountItemCategory"].ToString());
                            _result.CountItem = Convert.ToInt32(_SQLDataReader["CountItem"].ToString());
                            _result.CountLike = Convert.ToInt32(_SQLDataReader["CountLike"].ToString());
                            _result.CountMembershipCard = Convert.ToInt32(_SQLDataReader["CountMembershipCard"].ToString());
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.MembershipApprovalStatus = _SQLDataReader["MembershipApprovalStatus"].ToString();
                            _result.isLikeStatus = _SQLDataReader["isLikeStatus"].ToString();
                            _result.CartTotalItemQuantity = _SQLDataReader["CartTotalItemQuantity"].ToString();
                            _result.CartSumItemSumPrice =_SQLDataReader["CartSumItemSumPrice"].ToString();
                            _result.ItemCartCode = _SQLDataReader["ItemCartCode"].ToString();
                            _result.MembershipEventCount = Convert.ToInt32(_SQLDataReader["MembershipEventCount"].ToString());
                            _result.MembershipContestCount = Convert.ToInt32(_SQLDataReader["MembershipContestCount"].ToString());
                            _result.VoucherCount = Convert.ToInt32(_SQLDataReader["VoucherCount"].ToString());
                            _result.StampPointCampaignCodeCount = Convert.ToInt32(_SQLDataReader["StampPointCampaignCodeCount"].ToString());
                            _result.StampPointCampaignCode = _SQLDataReader["StampPointCampaignCode"].ToString();
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