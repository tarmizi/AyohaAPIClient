using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using WebApiResit.Helpers;


namespace WebApiResit.Models
{
    public class DiscountCampaignModel
    {

        public int ID
        {
            get;
            set;
        }



        public string DiscountCode
        {
            get;
            set;
        }
        public string DiscountName
        {
            get;
            set;
        }



        public string DiscountImgPath
        {
            get;
            set;
        }
        public string DiscountImgName
        {
            get;
            set;
        }
        public string DiscountPercent
        {
            get;
            set;
        }

        public string DiscountTermAndCondition
        {
            get;
            set;
        }
        public string RowStatus
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
        public string EnterpriseAccNo
        {
            get;
            set;
        }

        public string DiscountType
        {
            get;
            set;
        }



        public string MembershipCardCode
        {
            get;
            set;
        }
        public string DiscountEndDate
        {
            get;
            set;
        }

        public string DiscountNote
        {
            get;
            set;
        }

        public string isRequireDiscountEndDate
        {
            get;
            set;
        }

        public string EnterpriseLogo
        {
            get;
            set;
        }
        public string EnterpriseName
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
        public string isMember
        {
            get;
            set;
        }
        
        public DiscountCampaignModel() { }





        public static List<DiscountCampaignModel> DiscountCampaing_LoadBySubscriberAccNo(string SubscriberAccNo)
        {
            List<DiscountCampaignModel> _Value = new List<DiscountCampaignModel>();

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
                        _SQLCommand.CommandText = "DiscountCampaing_LoadBySubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        DiscountCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new DiscountCampaignModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.DiscountCode = _SQLDataReader["DiscountCode"].ToString();
                            _result.DiscountName = HtmlUtility.EscapeForHtmlAttribute(_SQLDataReader["DiscountName"].ToString());
                            _result.DiscountImgPath = _SQLDataReader["DiscountImgPath"].ToString();
                            _result.DiscountImgName = _SQLDataReader["DiscountImgName"].ToString();
                            _result.DiscountPercent = _SQLDataReader["DiscountPercent"].ToString();
                            _result.DiscountTermAndCondition = HtmlUtility.EscapeForHtmlAttribute(_SQLDataReader["DiscountTermAndCondition"].ToString());
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.DiscountType = _SQLDataReader["DiscountType"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            //_result.DiscountEndDate = String.Format("{0:yyyy/MM/dd}", _SQLDataReader["DiscountEndDate"].ToString());
                           // _result.DiscountEndDate = Convert.ToDateTime(_SQLDataReader["DiscountEndDate"]).ToString("yyyy-MM-dd");
                            _result.DiscountEndDate = Convert.ToDateTime(_SQLDataReader["DiscountEndDate"]).ToString("dd/MM/yyyy");
                            _result.DiscountNote = _SQLDataReader["DiscountNote"].ToString();
                            _result.isRequireDiscountEndDate = _SQLDataReader["isRequireDiscountEndDate"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();


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



        public static List<DiscountCampaignModel> DiscountCampaignRedeemLoadByDiscountRedeemStatus(string SubscriberAccNo, string RedeemStatus)
        {
            List<DiscountCampaignModel> _Value = new List<DiscountCampaignModel>();

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
                        _SQLCommand.CommandText = "DiscountCampaignRedeemLoadByDiscountRedeemStatus";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@RedeemStatus", RedeemStatus);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        DiscountCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new DiscountCampaignModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.DiscountCode = _SQLDataReader["DiscountCode"].ToString();
                            _result.DiscountName = HtmlUtility.EscapeForHtmlAttribute(_SQLDataReader["DiscountName"].ToString());
                            _result.DiscountImgPath = _SQLDataReader["DiscountImgPath"].ToString();
                            _result.DiscountImgName = _SQLDataReader["DiscountImgName"].ToString();
                            _result.DiscountPercent = _SQLDataReader["DiscountPercent"].ToString();
                            _result.DiscountTermAndCondition = HtmlUtility.EscapeForHtmlAttribute(_SQLDataReader["DiscountTermAndCondition"].ToString());
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.DiscountType = _SQLDataReader["DiscountType"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            //_result.DiscountEndDate = String.Format("{0:yyyy/MM/dd}", _SQLDataReader["DiscountEndDate"].ToString());
                           // _result.DiscountEndDate = Convert.ToDateTime(_SQLDataReader["DiscountEndDate"]).ToString("yyyy-MM-dd");
                            _result.DiscountEndDate = Convert.ToDateTime(_SQLDataReader["DiscountEndDate"]).ToString("dd/MM/yyyy");
                            _result.DiscountNote = _SQLDataReader["DiscountNote"].ToString();
                            _result.isRequireDiscountEndDate = _SQLDataReader["isRequireDiscountEndDate"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.SearchCol = _SQLDataReader["EnterpriseName"].ToString() + "|" + _SQLDataReader["DiscountPercent"].ToString() + "|" + _SQLDataReader["DiscountName"].ToString();


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




        public static List<DiscountCampaignModel> Dashboard_Discount_SuccessCheckIn_Load_DiscountPerk(string EnterpriseAccNo, string SubscriberAccNo)
        {
            List<DiscountCampaignModel> _Value = new List<DiscountCampaignModel>();

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
                        _SQLCommand.CommandText = "Dashboard_Discount_SuccessCheckIn_Load_DiscountPerk";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);                     
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        DiscountCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new DiscountCampaignModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.DiscountCode = _SQLDataReader["DiscountCode"].ToString();
                            _result.DiscountName = HtmlUtility.EscapeForHtmlAttribute(_SQLDataReader["DiscountName"].ToString());
                            _result.DiscountImgPath = _SQLDataReader["DiscountImgPath"].ToString();
                            _result.DiscountImgName = _SQLDataReader["DiscountImgName"].ToString();
                            _result.DiscountPercent = _SQLDataReader["DiscountPercent"].ToString();
                            _result.DiscountTermAndCondition = HtmlUtility.EscapeForHtmlAttribute(_SQLDataReader["DiscountTermAndCondition"].ToString());
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.DiscountType = _SQLDataReader["DiscountType"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            //_result.DiscountEndDate = String.Format("{0:yyyy/MM/dd}", _SQLDataReader["DiscountEndDate"].ToString());
                            // _result.DiscountEndDate = Convert.ToDateTime(_SQLDataReader["DiscountEndDate"]).ToString("yyyy-MM-dd");
                            _result.DiscountEndDate = Convert.ToDateTime(_SQLDataReader["DiscountEndDate"]).ToString("dd/MM/yyyy");
                            _result.DiscountNote = _SQLDataReader["DiscountNote"].ToString();
                            _result.isRequireDiscountEndDate = _SQLDataReader["isRequireDiscountEndDate"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.SearchCol = _SQLDataReader["EnterpriseName"].ToString() + "|" + _SQLDataReader["DiscountPercent"].ToString() + "|" + _SQLDataReader["DiscountName"].ToString();
                            _result.isMember = _SQLDataReader["isMember"].ToString();


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

        


        public static List<DiscountCampaignModel> DiscountCampaing_LoadByEnterpriseAccNoMembershipCardCode(string EnterpriseAccNo, string MembershipCardCode)
        {
            List<DiscountCampaignModel> _Value = new List<DiscountCampaignModel>();

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
                        _SQLCommand.CommandText = "DiscountCampaingLoadByEnterpriseAccNoMembershipCardCode";
                        _SQLCommand.Parameters.AddWithValue("EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("MembershipCardCode", MembershipCardCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        DiscountCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new DiscountCampaignModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.DiscountCode = _SQLDataReader["DiscountCode"].ToString();
                            _result.DiscountName = _SQLDataReader["DiscountName"].ToString();
                            _result.DiscountImgPath = _SQLDataReader["DiscountImgPath"].ToString();
                            _result.DiscountImgName = _SQLDataReader["DiscountImgName"].ToString();
                            _result.DiscountPercent = _SQLDataReader["DiscountPercent"].ToString();
                            _result.DiscountTermAndCondition = _SQLDataReader["DiscountTermAndCondition"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.DiscountType = _SQLDataReader["DiscountType"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.DiscountEndDate = _SQLDataReader["DiscountEndDate"].ToString();
                            _result.DiscountNote = _SQLDataReader["DiscountNote"].ToString();
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

        public static List<DiscountCampaignModel> DiscountCampaingLoadByDiscountCode(string EnterpriseAccNo, string DiscountCode)
        {
            List<DiscountCampaignModel> _Value = new List<DiscountCampaignModel>();

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
                        _SQLCommand.CommandText = "DiscountCampaingLoadByDiscountCode";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@DiscountCode", DiscountCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        DiscountCampaignModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new DiscountCampaignModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.DiscountCode = _SQLDataReader["DiscountCode"].ToString();
                            _result.DiscountName = _SQLDataReader["DiscountName"].ToString();
                            _result.DiscountImgPath = _SQLDataReader["DiscountImgPath"].ToString();
                            _result.DiscountImgName = _SQLDataReader["DiscountImgName"].ToString();
                            _result.DiscountPercent = _SQLDataReader["DiscountPercent"].ToString();
                            _result.DiscountTermAndCondition = _SQLDataReader["DiscountTermAndCondition"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.DiscountType = _SQLDataReader["DiscountType"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            //_result.DiscountEndDate = String.Format("{0:yyyy/MM/dd}", _SQLDataReader["DiscountEndDate"].ToString());
                            //_result.DiscountEndDate = Convert.ToDateTime(_SQLDataReader["DiscountEndDate"]).ToString("yyyy-MM-dd");
                            _result.DiscountEndDate = Convert.ToDateTime(_SQLDataReader["DiscountEndDate"]).ToString("dd/MM/yyyy");
                            _result.DiscountNote = _SQLDataReader["DiscountNote"].ToString();
                            _result.isRequireDiscountEndDate = _SQLDataReader["isRequireDiscountEndDate"].ToString();
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