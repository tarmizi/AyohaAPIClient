using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class MembershipsModel  
    {



        public int RowNumber
        {
            get;
            set;
        }
     
 
        public int ID
        {
            get;
            set;
        }

        public string CampaignEnterpriseAccNo
        {
            get;
            set;
        }
        public string CampaignRewardType
        {
            get;
            set;
        }

        public string SubscriberAccNo
        {
            get;
            set;
        }
        public string MembershipDate
        {
            get;
            set;
        }
        public string MembershipByMethod
        {
            get;
            set;
        }
        public string MembrshipApprovalDate
        {
            get;
            set;
        }
        public string MembershipApprovalBy
        {
            get;
            set;
        }
        
        public string ReferalSubscriberAccNo
        {
            get;
            set;
        }
        public string MembershipFee
        {
            get;
            set;
        }
         public string MembershipLevel
        {
            get;
            set;
        }
        public string IsRequiredMembershipFee
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }
        public string MembershipNo
        {
            get;
            set;
        }
        public string MembershipApprovalStatus
        {
            get;
            set;
        }
        public string MembershipFeePaymentMethod
        {
            get;
            set;
        }
        public string MembershipPaymentLink
        {
            get;
            set;
        }
        public string MembershipPaymentPaidProof
        {
            get;
            set;
        }
        public string MembershipCardCode
        {
            get;
            set;
        }
        public string MembershipPaymentCode
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
        public string ModifiedDate
        {
            get;
            set;
        }
        public string ModifiedBy
        {
            get;
            set;
        }
        public string MembershipCardFeePaymentCycle
        {
            get;
            set;
        }
        public string StrExpiredDate
        {
            get;
            set;
        }
        public string isValidLifeTime
        {
            get;
            set;
        }

        public string CampaignEnterpriseHQAccNo
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
        public string EnterprisesName
        {
            get;
            set;
        }
        
        public string EnterprisesLogo
        {
            get;
            set;
        }
        public string EnterpriseAddress
        {
            get;
            set;
        }
        public string EnterpriseType
        {
            get;
            set;
        }

        public string BusinessTypeIconPath
        {
            get;
            set;
        }
        public string BusinessTypeGroup
        {
            get;
            set;
        }
        public string AccountName
        {
            get;
            set;
        }
        public string ValidUntilDateMonthYearOnly
        {
            get;
            set;
        }
        public string isRequiredApproval
        {
            get;
            set;
        }

        public string PointCampaignEndDate
        {
            get;
            set;
        }

        public string CampaignName
        {
            get;
            set;
        }

        public string EnterpriseHQAccNo
        {
            get;
            set;
        }


        public string MembershipCardPoint
        {
            get;
            set;
        }




        public string PhoneNo
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }


        public string PlayerID
        {
            get;
            set;
        }

        public string SearchCol
        {
            get;
            set;
        }


        public string isRequiredStartEndDate
        {
            get;
            set;
        }

        public string isCampaignExpired
        {
            get;
            set;
        }

        public string AyohaRewardPoint
        {
            get;
            set;
        }
        public string MerchantPoint
        {
            get;
            set;
        }



    

        public string HigherPoint
        {
            get;
            set;
        }


        public string PICContactNo
        {
            get;
            set;
        }

        public string EnterpriseLogoPath
        {
            get;
            set;
        }




        public string EnterpriseEmail
        {
            get;
            set;
        }


        public int LoyaltCampaignCount
        {
            get;
            set;
        }
        public string EnterpriseTagLine
        {
            get;
            set;
        }

        public string SubscriptionCode
        {
            get;
            set;
        }

        public string SubscribedPackage
        {
            get;
            set;
        }

        public string PackagePrice
        {
            get;
            set;
        }







        public string PaidMembershipCount
        {
            get;
            set;
        }

        public string FreeMembershipCount
        {
            get;
            set;
        }

        public string PendingApprovalCount
        {
            get;
            set;
        }

        public string ActiveCardCount
        {
            get;
            set;
        }

        public string ExpiredCardCount
        {
            get;
            set;
        }








        public MembershipsModel() { }



        public static List<MembershipsModel> Memberships_LoadByCampaignCode(string CampaignCode)
        {
            List<MembershipsModel> _Value = new List<MembershipsModel>();

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
                        _SQLCommand.CommandText = "Memberships_LoadByCampaignCode";
                        _SQLCommand.Parameters.AddWithValue("@CampaignCode", CampaignCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipsModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new MembershipsModel();
                            _result.RowNumber = Convert.ToInt32(_SQLDataReader["RowNumber"].ToString());                            
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.PhoneNo = _SQLDataReader["PhoneNo"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.PlayerID = _SQLDataReader["PlayerID"].ToString();
                            _result.SearchCol = _SQLDataReader["AccountName"].ToString()+"|" +_SQLDataReader["PhoneNo"].ToString()+"|"+_SQLDataReader["Email"].ToString();
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








        public static string Memberships_Insert(string CampaignEnterpriseAccNo, string SubscriberAccNo,
    string MembershipByMethod, string ReferalSubscriberAccNo, string MembershipCardCode, string CreatedBy)
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
                        _SQLCommand.CommandText = "Memberships_Insert";
                       // _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@CampaignEnterpriseAccNo", CampaignEnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipByMethod", MembershipByMethod);
                        _SQLCommand.Parameters.AddWithValue("@ReferalSubscriberAccNo", ReferalSubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        //_SQLCommand.Parameters.AddWithValue("@CampaignRewardType ", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipApprovalBy ", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipFeePaymentMethod", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipPaymentLink", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipPaymentPaidProof", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipPaymentCode", "NA");
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


        public static string Memberships_Insert_PayAtCounter(string CampaignEnterpriseAccNo, string SubscriberAccNo,
  string MembershipByMethod, string ReferalSubscriberAccNo, string MembershipCardCode, string CreatedBy, string SubscriptionCode, string SubscribedPackage, string PackagePrice)
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
                        _SQLCommand.CommandText = "Memberships_Insert_PayAtCounter";
                        // _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@CampaignEnterpriseAccNo", CampaignEnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipByMethod", MembershipByMethod);
                        _SQLCommand.Parameters.AddWithValue("@ReferalSubscriberAccNo", ReferalSubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@SubscriptionCode", SubscriptionCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscribedPackage", SubscribedPackage);
                        _SQLCommand.Parameters.AddWithValue("@PackagePrice", PackagePrice);
                        //_SQLCommand.Parameters.AddWithValue("@CampaignRewardType ", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipApprovalBy ", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipFeePaymentMethod", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipPaymentLink", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipPaymentPaidProof", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipPaymentCode", "NA");
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

        public static string Memberships_Insert_MembershipCardFOCFee(string CampaignEnterpriseAccNo, string SubscriberAccNo,
string MembershipByMethod, string ReferalSubscriberAccNo, string MembershipCardCode, string CreatedBy, string SubscriptionCode, string SubscribedPackage, string PackagePrice)
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
                        _SQLCommand.CommandText = "Memberships_Insert_MembershipCardFOCFee";
                        // _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@CampaignEnterpriseAccNo", CampaignEnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipByMethod", MembershipByMethod);
                        _SQLCommand.Parameters.AddWithValue("@ReferalSubscriberAccNo", ReferalSubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@SubscriptionCode", SubscriptionCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscribedPackage", SubscribedPackage);
                        _SQLCommand.Parameters.AddWithValue("@PackagePrice", PackagePrice);
                        //_SQLCommand.Parameters.AddWithValue("@CampaignRewardType ", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipApprovalBy ", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipFeePaymentMethod", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipPaymentLink", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipPaymentPaidProof", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipPaymentCode", "NA");
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
        public static string Memberships_Delete(int ID,string SubscriberAccNo,string MembershipCardCode, string CreatedBy)
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
                        _SQLCommand.CommandText = "Memberships_Delete";
                        // _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);                     
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        //_SQLCommand.Parameters.AddWithValue("@CampaignRewardType ", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipApprovalBy ", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipFeePaymentMethod", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipPaymentLink", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipPaymentPaidProof", "NA");
                        //_SQLCommand.Parameters.AddWithValue("@MembershipPaymentCode", "NA");
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


        public static List<MembershipsModel>Memberships_LoadBySubscriberAccNo(string SubscriberAccNo)
        {
            List<MembershipsModel> _Value = new List<MembershipsModel>();

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
                        _SQLCommand.CommandText = "Memberships_LoadBySubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipsModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new MembershipsModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.CampaignEnterpriseAccNo = _SQLDataReader["CampaignEnterpriseAccNo"].ToString();
                            _result.CampaignRewardType = _SQLDataReader["CampaignRewardType"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.MembershipDate = _SQLDataReader["MembershipDate"].ToString();
                            _result.MembershipByMethod = _SQLDataReader["MembershipByMethod"].ToString();
                           // _result.MembrshipApprovalDate = _SQLDataReader["MembrshipApprovalDate"].ToString();
                            _result.MembrshipApprovalDate = String.Format("{0:MM/yyyy}", _SQLDataReader["MembrshipApprovalDate"]);
                            _result.ReferalSubscriberAccNo = _SQLDataReader["ReferalSubscriberAccNo"].ToString();
                            _result.MembershipFee = _SQLDataReader["MembershipFee"].ToString();
                            _result.MembershipLevel = _SQLDataReader["MembershipLevel"].ToString();
                            _result.IsRequiredMembershipFee = _SQLDataReader["IsRequiredMembershipFee"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.MembershipNo = _SQLDataReader["MembershipNo"].ToString();
                            _result.MembershipApprovalStatus = _SQLDataReader["MembershipApprovalStatus"].ToString();
                            _result.MembershipFeePaymentMethod = _SQLDataReader["MembershipFeePaymentMethod"].ToString();
                            _result.MembershipPaymentLink = _SQLDataReader["MembershipPaymentLink"].ToString();
                            _result.MembershipPaymentPaidProof = _SQLDataReader["MembershipPaymentPaidProof"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.MembershipPaymentCode = _SQLDataReader["MembershipPaymentCode"].ToString();
                          //  _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedDate = String.Format("{0:MM/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                            _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                            _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                            _result.CampaignEnterpriseHQAccNo = _SQLDataReader["CampaignEnterpriseHQAccNo"].ToString();
                            _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.EnterprisesName = _SQLDataReader["EnterprisesName"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                           // _result.ValidUntilDate = _SQLDataReader["ValidUntilDate"].ToString();
                            _result.ValidUntilDateMonthYearOnly = _SQLDataReader["ValidUntilDate"].ToString();
                           // _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDates(Convert.ToDateTime(_SQLDataReader["ValidUntilDate"]), _SQLDataReader["StrExpiredDate"].ToString(), _SQLDataReader["isValidLifeTime"].ToString());
                            _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                            _result.AyohaRewardPoint = _SQLDataReader["AyohaRewardPoint"].ToString();
                            _result.MembershipCardPoint = _SQLDataReader["MembershipCardPoint"].ToString();
                            _result.MerchantPoint = _SQLDataReader["MerchantPoint"].ToString();
                            _result.LoyaltCampaignCount = Convert.ToInt32(_SQLDataReader["LoyaltCampaignCount"].ToString());
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.SearchCol = _SQLDataReader["EnterprisesName"].ToString() + "|" + _SQLDataReader["MembershipCardName"].ToString() + "|" + _SQLDataReader["CampaignRewardType"].ToString() + "|" + _SQLDataReader["EnterpriseAddress"].ToString();
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





        public static List<MembershipsModel> Memberships_LoadBySubscriberAccNoAndEnterpriseAccNo(string SubscriberAccNo, string EnterpriseAccNo)
        {
            List<MembershipsModel> _Value = new List<MembershipsModel>();

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
                        _SQLCommand.CommandText = "Memberships_LoadBySubscriberAccNoAndEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipsModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new MembershipsModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.CampaignEnterpriseAccNo = _SQLDataReader["CampaignEnterpriseAccNo"].ToString();
                            _result.CampaignRewardType = _SQLDataReader["CampaignRewardType"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.MembershipDate = _SQLDataReader["MembershipDate"].ToString();
                            _result.MembershipByMethod = _SQLDataReader["MembershipByMethod"].ToString();
                            // _result.MembrshipApprovalDate = _SQLDataReader["MembrshipApprovalDate"].ToString();
                            _result.MembrshipApprovalDate = String.Format("{0:MM/yyyy}", _SQLDataReader["MembrshipApprovalDate"]);
                            _result.ReferalSubscriberAccNo = _SQLDataReader["ReferalSubscriberAccNo"].ToString();
                            _result.MembershipFee = _SQLDataReader["MembershipFee"].ToString();
                            _result.MembershipLevel = _SQLDataReader["MembershipLevel"].ToString();
                            _result.IsRequiredMembershipFee = _SQLDataReader["IsRequiredMembershipFee"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.MembershipNo = _SQLDataReader["MembershipNo"].ToString();
                            _result.MembershipApprovalStatus = _SQLDataReader["MembershipApprovalStatus"].ToString();
                            _result.MembershipFeePaymentMethod = _SQLDataReader["MembershipFeePaymentMethod"].ToString();
                            _result.MembershipPaymentLink = _SQLDataReader["MembershipPaymentLink"].ToString();
                            _result.MembershipPaymentPaidProof = _SQLDataReader["MembershipPaymentPaidProof"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.MembershipPaymentCode = _SQLDataReader["MembershipPaymentCode"].ToString();
                            //  _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedDate = String.Format("{0:MM/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                            _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                            _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                            _result.CampaignEnterpriseHQAccNo = _SQLDataReader["CampaignEnterpriseHQAccNo"].ToString();
                            _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.EnterprisesName = _SQLDataReader["EnterprisesName"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            // _result.ValidUntilDate = _SQLDataReader["ValidUntilDate"].ToString();
                            _result.ValidUntilDateMonthYearOnly = ModifiedExpiredDates(Convert.ToDateTime(_SQLDataReader["ValidUntilDate"]), _SQLDataReader["StrExpiredDate"].ToString(), _SQLDataReader["isValidLifeTime"].ToString());
                            _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                            _result.AyohaRewardPoint = _SQLDataReader["AyohaRewardPoint"].ToString();                            
                            _result.MembershipCardPoint = _SQLDataReader["MembershipCardPoint"].ToString();
                            _result.MerchantPoint = _SQLDataReader["MerchantPoint"].ToString();
                            _result.LoyaltCampaignCount = Convert.ToInt32(_SQLDataReader["LoyaltCampaignCount"].ToString());
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



        public static List<MembershipsModel> Memberships_LoadBySubscriberAccNoAndEnterpriseAccNoAndMembershipCardCode(string SubscriberAccNo, string EnterpriseAccNo, string MembershipCardCode)
        {
            List<MembershipsModel> _Value = new List<MembershipsModel>();

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
                        _SQLCommand.CommandText = "Memberships_LoadBySubscriberAccNoAndEnterpriseAccNoAndMembershipCardCode";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipsModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new MembershipsModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.CampaignEnterpriseAccNo = _SQLDataReader["CampaignEnterpriseAccNo"].ToString();
                            _result.CampaignRewardType = _SQLDataReader["CampaignRewardType"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.MembershipDate = _SQLDataReader["MembershipDate"].ToString();
                            _result.MembershipByMethod = _SQLDataReader["MembershipByMethod"].ToString();
                            // _result.MembrshipApprovalDate = _SQLDataReader["MembrshipApprovalDate"].ToString();
                            _result.MembrshipApprovalDate = String.Format("{0:MM/yyyy}", _SQLDataReader["MembrshipApprovalDate"]);
                            _result.ReferalSubscriberAccNo = _SQLDataReader["ReferalSubscriberAccNo"].ToString();
                            _result.MembershipFee = _SQLDataReader["MembershipFee"].ToString();
                            _result.MembershipLevel = _SQLDataReader["MembershipLevel"].ToString();
                            _result.IsRequiredMembershipFee = _SQLDataReader["IsRequiredMembershipFee"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.MembershipNo = _SQLDataReader["MembershipNo"].ToString();
                            _result.MembershipApprovalStatus = _SQLDataReader["MembershipApprovalStatus"].ToString();
                            _result.MembershipFeePaymentMethod = _SQLDataReader["MembershipFeePaymentMethod"].ToString();
                            _result.MembershipPaymentLink = _SQLDataReader["MembershipPaymentLink"].ToString();
                            _result.MembershipPaymentPaidProof = _SQLDataReader["MembershipPaymentPaidProof"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.MembershipPaymentCode = _SQLDataReader["MembershipPaymentCode"].ToString();
                            //  _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedDate = String.Format("{0:MM/yyyy}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                            _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                            _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                            _result.CampaignEnterpriseHQAccNo = _SQLDataReader["CampaignEnterpriseHQAccNo"].ToString();
                            _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.EnterprisesName = _SQLDataReader["EnterprisesName"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterprisesLogo"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseType = _SQLDataReader["EnterpriseType"].ToString();
                            _result.BusinessTypeIconPath = _SQLDataReader["BusinessTypeIconPath"].ToString();
                            _result.BusinessTypeGroup = _SQLDataReader["BusinessTypeGroup"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            // _result.ValidUntilDate = _SQLDataReader["ValidUntilDate"].ToString();
                            _result.ValidUntilDateMonthYearOnly = _SQLDataReader["ValidUntilDate"].ToString();
                            //_result.ValidUntilDateMonthYearOnly = ModifiedExpiredDates(Convert.ToDateTime(_SQLDataReader["ValidUntilDate"]), _SQLDataReader["StrExpiredDate"].ToString(), _SQLDataReader["isValidLifeTime"].ToString());
                            _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                            _result.AyohaRewardPoint = _SQLDataReader["AyohaRewardPoint"].ToString();
                            _result.MembershipCardPoint = _SQLDataReader["MembershipCardPoint"].ToString();
                            _result.MerchantPoint = _SQLDataReader["MerchantPoint"].ToString();
                            _result.LoyaltCampaignCount = Convert.ToInt32(_SQLDataReader["LoyaltCampaignCount"].ToString());
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


        public static List<MembershipsModel> Memberships_CheckIsMember(string CampaignCode, string SubscriberAccNo, string EnterpriseAccNo)
        {
            List<MembershipsModel> _Value = new List<MembershipsModel>();

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
                        _SQLCommand.CommandText = "Memberships_CheckIsMember";
                        _SQLCommand.Parameters.AddWithValue("@CampaignCode", CampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipsModel _result;
                        while (_SQLDataReader.Read())
                        {
                            //EnterpriseLogo
                            //    EnterpriseName
                            //    PointCampaignEndDate
                            _result = new MembershipsModel();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.MembershipApprovalStatus = _SQLDataReader["MembershipApprovalStatus"].ToString();
                            _result.EnterprisesLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterprisesName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.CampaignName = _SQLDataReader["CampaignName"].ToString();                            
                          //  _result.PointCampaignEndDate = _SQLDataReader["PointCampaignEndDate"].ToString();
                            _result.PointCampaignEndDate = String.Format("{0:dd/MM/yyyy}", _SQLDataReader["PointCampaignEndDate"]);
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.isRequiredStartEndDate = _SQLDataReader["isRequiredStartEndDate"].ToString();
                            _result.isCampaignExpired = _SQLDataReader["isCampaignExpired"].ToString(); 
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





        public static List<MembershipsModel> Memberships_CheckIsMember_ScanAndPay(string SubscriberAccNo, string CampaignEnterpriseAccNo)
        {
            List<MembershipsModel> _Value = new List<MembershipsModel>();

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
                        _SQLCommand.CommandText = "Memberships_CheckIsMember_ScanAndPay";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", CampaignEnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipsModel _result;
                        while (_SQLDataReader.Read())
                        {
                            //EnterpriseLogo
                            //    EnterpriseName
                            //    PointCampaignEndDate
                            _result = new MembershipsModel();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.MembershipApprovalStatus = _SQLDataReader["MembershipApprovalStatus"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.HigherPoint = _SQLDataReader["HigherPoint"].ToString();
                            _result.EnterprisesName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
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








        public static List<MembershipsModel> Memberships_MyMembershipCardStatus(string SubscriberAccNo)
        {
            List<MembershipsModel> _Value = new List<MembershipsModel>();

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
                        _SQLCommand.CommandText = "Memberships_MyMembershipCardStatus";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipsModel _result;
                        while (_SQLDataReader.Read())
                        {
                            //EnterpriseLogo
                            //    EnterpriseName
                            //    PointCampaignEndDate
                            _result = new MembershipsModel();
                            _result.PaidMembershipCount = _SQLDataReader["PaidMembershipCount"].ToString();
                            _result.FreeMembershipCount = _SQLDataReader["FreeMembershipCount"].ToString();
                            _result.PendingApprovalCount = _SQLDataReader["PendingApprovalCount"].ToString();
                            _result.ActiveCardCount = _SQLDataReader["ActiveCardCount"].ToString();
                            _result.ExpiredCardCount = _SQLDataReader["ExpiredCardCount"].ToString();
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

        public static string ModifiedExpiredDates(DateTime ValidUntilDate, string StrExpiredDated, string isValidLifeTimes)
        {

            string _value = "";


            if (isValidLifeTimes == "YES")
            {
                _value = StrExpiredDated;
            }
            if (isValidLifeTimes == "NO")
            {
                _value = String.Format("{0:MM/yyyy}", ValidUntilDate);
            }






            return _value;



        }










     



    }
}