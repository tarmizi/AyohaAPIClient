using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
namespace WebApiResit.Models
{
    public class MembershipCardExtentModel
    {
        public int ID
        {
            get;
            set;
        }




        public string MembershipCardCode
        {
            get;
            set;
        }

        public string EnterpriseAccNo
        {
            get;
            set;
        }

        public string MembershipCardFee
        {
            get;
            set;
        }
        public string MembershipCardType
        {
            get;
            set;
        }

        public string RowStatus
        {
            get;
            set;
        }

        public string ExpiredDate
        {
            get;
            set;
        }

        public string MembershipCardBackgroundImg
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

        public string StartDate
        {
            get;
            set;
        }
        public string MembershipCardName
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

        public string isRequiredApproval
        {
            get;
            set;
        }
        public string MembershipCardBackgroundImgName_back
        {
            get;
            set;
        }

        public string MembershipCardBackgroundImg_back
        {
            get;
            set;
        }

        public string MembrshipApprovalDate
        {
            get;
            set;
        }

        public string MembershipApprovalStatus
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

        public string IsRequiredMembershipFee
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

        public string MembershipPaymentCode
        {
            get;
            set;
        }

        public string MembershipPaymentPaidProofName
        {
            get;
            set;
        }
        public string ReceivedAmount
        {
            get;
            set;
        }

        public string Remarks
        {
            get;
            set;
        }

        public string MembershipRejectedDate
        {
            get;
            set;
        }

        public string SubscriberAccNo
        {
            get;
            set;
        }

        public MembershipCardExtentModel() { }






        public static List<MembershipCardExtentModel> MembershipCard_LoadByEnterpriseAccNo_testing(string EnterpriseAccNo)
        {
            List<MembershipCardExtentModel> _Value = new List<MembershipCardExtentModel>();

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
                        _SQLCommand.CommandText = "MembershipCard_LoadByEnterpriseAccNo_testing"; 
                 
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipCardExtentModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new MembershipCardExtentModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                            _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.ExpiredDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ExpiredDate"]);
                            _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                            _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                            _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                            _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                            _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
                            _result.MembershipDate = _SQLDataReader["MembershipDate"].ToString();
                            _result.MembershipByMethod = _SQLDataReader["MembershipByMethod"].ToString();
                            _result.MembrshipApprovalDate = _SQLDataReader["MembrshipApprovalDate"].ToString();
                            _result.MembershipApprovalBy = _SQLDataReader["MembershipApprovalBy"].ToString();
                            _result.ReferalSubscriberAccNo = _SQLDataReader["ReferalSubscriberAccNo"].ToString();
                            _result.IsRequiredMembershipFee = _SQLDataReader["IsRequiredMembershipFee"].ToString();
                            _result.MembershipApprovalStatus = _SQLDataReader["MembershipApprovalStatus"].ToString();
                            _result.MembershipFeePaymentMethod = _SQLDataReader["MembershipFeePaymentMethod"].ToString();
                            _result.MembershipPaymentLink = _SQLDataReader["MembershipPaymentLink"].ToString();
                            _result.MembershipPaymentPaidProof = _SQLDataReader["MembershipPaymentPaidProof"].ToString();
                            _result.MembershipPaymentCode = _SQLDataReader["MembershipPaymentCode"].ToString();
                            _result.MembershipPaymentPaidProofName = _SQLDataReader["MembershipPaymentPaidProofName"].ToString();
                            _result.ReceivedAmount = _SQLDataReader["ReceivedAmount"].ToString();
                            _result.Remarks = _SQLDataReader["Remarks"].ToString();
                            _result.MembershipRejectedDate = _SQLDataReader["MembershipRejectedDate"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
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







        public static List<MembershipCardExtentModel> MembershipCard_LoadBySubscriberAccNoMembershipCardCodeEnterpriseAccNo(string AyohaUserAccNo, string MMC, string EnterprisesAccNo)
        {
            List<MembershipCardExtentModel> _Value = new List<MembershipCardExtentModel>();

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
                        _SQLCommand.CommandText = "MembershipCard_LoadBySubscriberAccNoMembershipCardCodeEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@AyohaUserAccNo", AyohaUserAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MMC", MMC);
                        _SQLCommand.Parameters.AddWithValue("@EnterprisesAccNo", EnterprisesAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        MembershipCardExtentModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new MembershipCardExtentModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.MembershipCardFee = _SQLDataReader["MembershipCardFee"].ToString();
                            _result.MembershipCardType = _SQLDataReader["MembershipCardType"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.ExpiredDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ExpiredDate"]);
                            _result.MembershipCardBackgroundImg = _SQLDataReader["MembershipCardBackgroundImg"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                            _result.MembershipCardName = _SQLDataReader["MembershipCardName"].ToString();
                            _result.MembershipCardFeePaymentCycle = _SQLDataReader["MembershipCardFeePaymentCycle"].ToString();
                            _result.StrExpiredDate = _SQLDataReader["StrExpiredDate"].ToString();
                            _result.isValidLifeTime = _SQLDataReader["isValidLifeTime"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.isRequiredApproval = _SQLDataReader["isRequiredApproval"].ToString();
                            _result.MembershipCardBackgroundImgName_back = _SQLDataReader["MembershipCardBackgroundImgNameback"].ToString();
                            _result.MembershipCardBackgroundImg_back = _SQLDataReader["MembershipCardBackgroundImgback"].ToString();
                            _result.MembershipDate = _SQLDataReader["MembershipDate"].ToString();
                            _result.MembershipByMethod = _SQLDataReader["MembershipByMethod"].ToString();
                            _result.MembrshipApprovalDate = _SQLDataReader["MembrshipApprovalDate"].ToString();
                            _result.MembershipApprovalBy = _SQLDataReader["MembershipApprovalBy"].ToString();
                            _result.ReferalSubscriberAccNo = _SQLDataReader["ReferalSubscriberAccNo"].ToString();
                            _result.IsRequiredMembershipFee = _SQLDataReader["IsRequiredMembershipFee"].ToString();
                            _result.MembershipApprovalStatus = _SQLDataReader["MembershipApprovalStatus"].ToString();
                            _result.MembershipFeePaymentMethod = _SQLDataReader["MembershipFeePaymentMethod"].ToString();
                            _result.MembershipPaymentLink = _SQLDataReader["MembershipPaymentLink"].ToString();
                            _result.MembershipPaymentPaidProof = _SQLDataReader["MembershipPaymentPaidProof"].ToString();
                            _result.MembershipPaymentCode = _SQLDataReader["MembershipPaymentCode"].ToString();
                            _result.MembershipPaymentPaidProofName = _SQLDataReader["MembershipPaymentPaidProofName"].ToString();
                            _result.ReceivedAmount = _SQLDataReader["ReceivedAmount"].ToString();
                            _result.Remarks = _SQLDataReader["Remarks"].ToString();
                            _result.MembershipRejectedDate = _SQLDataReader["MembershipRejectedDate"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
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