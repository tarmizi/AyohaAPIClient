using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaMerchantReviewModel
    {
         public int ID
        {
            get;
            set;
        }

         public string ReviewCode
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
         public int StarReview
        {
            get;
            set;
        }
         public string ReviewText
        {
            get;
            set;
        }
         public string RowStatusMerchant
        {
            get;
            set;
        }


         public string RowStatusAyoha
         {
             get;
             set;
         }
         public string ReviewDate
         {
             get;
             set;
         }


        public string AccountName
         {
             get;
             set;
         }


        public string Photo
        {
            get;
            set;
        }



        public int FiveStar
        {
            get;
            set;
        }
        public int FourStar
        {
            get;
            set;
        }
        public int ThreeStar
        {
            get;
            set;
        }
        public int TwoStar
        {
            get;
            set;
        }
        public int OneStar
        {
            get;
            set;
        }


        public int TotalStar
        {
            get;
            set;
        }
        public int TotalVoter
        {
            get;
            set;
        }





        public int VoteFiveStar
        {
            get;
            set;
        }
        public int VoteFourStar
        {
            get;
            set;
        }
        public int VoteThreeStar
        {
            get;
            set;
        }
        public int VoteTwoStar
        {
            get;
            set;
        }
        public int VoteOneStar
        {
            get;
            set;
        }

        public string ItemCodeReview
        {
            get;
            set;
        }

        public AyohaMerchantReviewModel() { }



        public static string AyohaMerchantReview_InsertUpdate(int ID, string ReviewCode, string SubscriberAccNo, string EnterpriseAccNo, int StarReview, string ReviewText
     , string RowStatusMerchant, string RowStatusAyoha, string ItemCodeReview)
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
                        _SQLCommand.CommandText = "AyohaMerchantReview_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@ReviewCode", ReviewCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@StarReview", StarReview);
                        _SQLCommand.Parameters.AddWithValue("@ReviewText", ReviewText);
                        _SQLCommand.Parameters.AddWithValue("@RowStatusMerchant", RowStatusMerchant);
                        _SQLCommand.Parameters.AddWithValue("@RowStatusAyoha", RowStatusAyoha);
                        _SQLCommand.Parameters.AddWithValue("@ItemCodeReview", ItemCodeReview);                        
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










        public static List<AyohaMerchantReviewModel>AyohaMerchantReview_LoadByEnterpriseAccNoAndItemCodeReview(string EnterpriseAccNo, string ItemCodeReview)
        {
            List<AyohaMerchantReviewModel> _Value = new List<AyohaMerchantReviewModel>();

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
                        _SQLCommand.CommandText = "AyohaMerchantReview_LoadByEnterpriseAccNoAndItemCodeReview";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ItemCodeReview", ItemCodeReview);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaMerchantReviewModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaMerchantReviewModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ReviewCode = _SQLDataReader["ReviewCode"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StarReview = Convert.ToInt32(_SQLDataReader["StarReview"].ToString());
                            //_result.ReviewText = _SQLDataReader["ReviewText"].ToString();
                            _result.ReviewText = _SQLDataReader["ReviewText"].ToString() + "<br><br>" + AyohaMerchantReview_ReplyTopTwo_LoadByReviewCode(_SQLDataReader["ReviewCode"].ToString());
                            _result.RowStatusMerchant = _SQLDataReader["RowStatusMerchant"].ToString();
                            _result.RowStatusAyoha = _SQLDataReader["RowStatusAyoha"].ToString();
                            _result.ReviewDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ReviewDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ReviewDate"]);
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.ItemCodeReview = _SQLDataReader["ItemCodeReview"].ToString();
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



        public static List<AyohaMerchantReviewModel> AyohaMerchantReview_LoadByEnterpriseAccNo(string EnterpriseAccNo,string ItemCodeReview)
        {
            List<AyohaMerchantReviewModel> _Value = new List<AyohaMerchantReviewModel>();

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
                        _SQLCommand.CommandText = "AyohaMerchantReview_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ItemCodeReview", ItemCodeReview);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaMerchantReviewModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaMerchantReviewModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ReviewCode = _SQLDataReader["ReviewCode"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StarReview = Convert.ToInt32(_SQLDataReader["StarReview"].ToString());
                           // _result.ReviewText = _SQLDataReader["ReviewText"].ToString();
                            _result.ReviewText = _SQLDataReader["ReviewText"].ToString() + "<br><br>" + AyohaMerchantReview_ReplyTopTwo_LoadByReviewCode(_SQLDataReader["ReviewCode"].ToString());
                            _result.RowStatusMerchant = _SQLDataReader["RowStatusMerchant"].ToString();
                            _result.RowStatusAyoha = _SQLDataReader["RowStatusAyoha"].ToString();
                            _result.ReviewDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ReviewDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ReviewDate"]);
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.ItemCodeReview = _SQLDataReader["ItemCodeReview"].ToString();
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






        public static List<AyohaMerchantReviewModel> AyohaMerchantReview_LoadByEnterpriseAccNoAndItemCodeReview_MembershipCardSale(string EnterpriseAccNo, string ItemCodeReview)
        {
            List<AyohaMerchantReviewModel> _Value = new List<AyohaMerchantReviewModel>();

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
                        _SQLCommand.CommandText = "AyohaMerchantReview_LoadByEnterpriseAccNoAndItemCodeReview_MembershipCardSale";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ItemCodeReview", ItemCodeReview);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaMerchantReviewModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaMerchantReviewModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ReviewCode = _SQLDataReader["ReviewCode"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StarReview = Convert.ToInt32(_SQLDataReader["StarReview"].ToString());
                            // _result.ReviewText = _SQLDataReader["ReviewText"].ToString();
                            _result.ReviewText = _SQLDataReader["ReviewText"].ToString() + "<br><br>" + AyohaMerchantReview_ReplyTopTwo_LoadByReviewCode(_SQLDataReader["ReviewCode"].ToString());
                            _result.RowStatusMerchant = _SQLDataReader["RowStatusMerchant"].ToString();
                            _result.RowStatusAyoha = _SQLDataReader["RowStatusAyoha"].ToString();
                            _result.ReviewDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ReviewDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ReviewDate"]);
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.Photo = _SQLDataReader["Photo"].ToString();
                            _result.ItemCodeReview = _SQLDataReader["ItemCodeReview"].ToString();
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













        public static string AyohaMerchantReview_ReplyTopTwo_LoadByReviewCode(string ReviewCode)
        {
            //List<AyohaMerchantReviewModel> _Value = new List<AyohaMerchantReviewModel>();
            string _Value = "";
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
                        _SQLCommand.CommandText = "AyohaMerchantReview_ReplyTopTwo_LoadByReviewCode";
                        _SQLCommand.Parameters.AddWithValue("@ReviewCode", ReviewCode);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        //AyohaMerchantReviewModel _result;
                        while (_SQLDataReader.Read())
                        {
                            //_result = new AyohaMerchantReviewModel();
                            //_result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            //_result.ReviewCode = _SQLDataReader["ReviewCode"].ToString();
                            //_result.ReplyCode = _SQLDataReader["ReplyCode"].ToString();
                            //_result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            //_result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            //_result.StarReview = Convert.ToInt32(_SQLDataReader["StarReview"].ToString());
                          //  _Value += "<b>(Reply From Owner) -</b> <font-size:12px;><u><b>" + _SQLDataReader["AccountName"].ToString() + "</b></u></font><br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + _SQLDataReader["ReviewText"].ToString() + " - " + String.Format("{0:d/M/yyyy}", _SQLDataReader["ReviewDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ReviewDate"]) + "<br><div style=width:100%;text-align:right;margin:0px 0px 0px 0px;height:26px;background-color:transparent;float:left;><button OnClick=AyohaMerchantReview_OwnerEditReplyShow_Edit('" + _SQLDataReader["ReplyCode"].ToString() + "') class='buttonsHtmlBgTransparent'><img src='resources/icons/editReview.png' style='width:23px; height:23px;' margin:10px 0px 0px 0px;/></button></div>";

                            _Value += "<b>(Reply From Owner) -</b> <font-size:12px;><u><b>" + _SQLDataReader["AccountName"].ToString() + "</b></u></font><br>" + _SQLDataReader["ReviewText"].ToString() + " - " + String.Format("{0:d/M/yyyy}", _SQLDataReader["ReviewDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ReviewDate"]) + "";
                           
                            
                            //_result.RowStatusMerchant = _SQLDataReader["RowStatusMerchant"].ToString();
                            //_result.RowStatusAyoha = _SQLDataReader["RowStatusAyoha"].ToString();
                            //_result.ReviewDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ReviewDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ReviewDate"]);
                            //_result.AccountName = _SQLDataReader["AccountName"].ToString();
                            //_result.Photo = _SQLDataReader["Photo"].ToString();
                            //_Value.Add(_result);
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






        public static List<AyohaMerchantReviewModel> AyohaMerchantReview_CalculateRating(string EnterpriseAccNo)
        {
            List<AyohaMerchantReviewModel> _Value = new List<AyohaMerchantReviewModel>();

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
                        _SQLCommand.CommandText = "AyohaMerchantReview_CalculateRating";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaMerchantReviewModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaMerchantReviewModel();
                            _result.FiveStar = Convert.ToInt32(_SQLDataReader["FiveStar"].ToString());
                            _result.FourStar = Convert.ToInt32(_SQLDataReader["FourStar"].ToString());
                            _result.ThreeStar = Convert.ToInt32(_SQLDataReader["ThreeStar"].ToString());
                            _result.TwoStar = Convert.ToInt32(_SQLDataReader["TwoStar"].ToString());
                            _result.OneStar = Convert.ToInt32(_SQLDataReader["OneStar"].ToString());
                            _result.TotalStar = Convert.ToInt32(_SQLDataReader["TotalStar"].ToString());
                            _result.TotalVoter = Convert.ToInt32(_SQLDataReader["TotalVoter"].ToString());
                            _result.VoteFiveStar = Convert.ToInt32(_SQLDataReader["VoteFiveStar"].ToString());
                            _result.VoteFourStar = Convert.ToInt32(_SQLDataReader["VoteFourStar"].ToString());
                            _result.VoteThreeStar = Convert.ToInt32(_SQLDataReader["VoteThreeStar"].ToString());
                            _result.VoteTwoStar = Convert.ToInt32(_SQLDataReader["VoteTwoStar"].ToString());
                            _result.VoteOneStar = Convert.ToInt32(_SQLDataReader["VoteOneStar"].ToString());
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





        public static List<AyohaMerchantReviewModel> AyohaMerchantReview_CalculateRating_SaleItemDetail(string EnterpriseAccNo, string ItemCodeReview)
        {
            List<AyohaMerchantReviewModel> _Value = new List<AyohaMerchantReviewModel>();

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
                        _SQLCommand.CommandText = "AyohaMerchantReview_CalculateRating_SaleItemDetail";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ItemCodeReview", ItemCodeReview);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaMerchantReviewModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaMerchantReviewModel();
                            _result.FiveStar = Convert.ToInt32(_SQLDataReader["FiveStar"].ToString());
                            _result.FourStar = Convert.ToInt32(_SQLDataReader["FourStar"].ToString());
                            _result.ThreeStar = Convert.ToInt32(_SQLDataReader["ThreeStar"].ToString());
                            _result.TwoStar = Convert.ToInt32(_SQLDataReader["TwoStar"].ToString());
                            _result.OneStar = Convert.ToInt32(_SQLDataReader["OneStar"].ToString());
                            _result.TotalStar = Convert.ToInt32(_SQLDataReader["TotalStar"].ToString());
                            _result.TotalVoter = Convert.ToInt32(_SQLDataReader["TotalVoter"].ToString());
                            _result.VoteFiveStar = Convert.ToInt32(_SQLDataReader["VoteFiveStar"].ToString());
                            _result.VoteFourStar = Convert.ToInt32(_SQLDataReader["VoteFourStar"].ToString());
                            _result.VoteThreeStar = Convert.ToInt32(_SQLDataReader["VoteThreeStar"].ToString());
                            _result.VoteTwoStar = Convert.ToInt32(_SQLDataReader["VoteTwoStar"].ToString());
                            _result.VoteOneStar = Convert.ToInt32(_SQLDataReader["VoteOneStar"].ToString());
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