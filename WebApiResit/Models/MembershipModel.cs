using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class MembershipModel
    {
        public int ID
        {
            get;
            set;
        }

        public string MembershipNo
        {
            get;
            set;
        }
        public string StampCampaignCode
        {
            get;
            set;
        }
        public string StampCampaignName
        {
            get;
            set;
        }
        public string StartDate
        {
            get;
            set;
        }

        public string EndDate
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
        public string Stamps
        {
            get;
            set;
        }


        public string LastStampedDate
        {
            get;
            set;
        }
        public string NextRedeem
        {
            get;
            set;
        }

        public string EnterpriseBusinessType
        {
            get;
            set;
        }
        public string CurrentBatch
        {
            get;
            set;
        }

        public string BackgroundImgOne
        {
            get;
            set;
        }
        public string BackgroundImgTwo
        {
            get;
            set;
        }


         public string EnterpriseAccNo
        {
            get;
            set;
        }

        public string StampRuleRemarks
        {
            get;
            set;
        }
        public string IsStampRulePopUp
        {
            get;
            set;
        }


         public MembershipModel() { }



         public static List<MembershipModel> Membership_LoadBySubscriberAccNo(string SubscriberAccNo)
         {
             List<MembershipModel> _Value = new List<MembershipModel>();

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
                         _SQLCommand.CommandText = "Membership_LoadBySubscriberAccNo";
                         _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                         _DBConnection.Open();
                         SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                         MembershipModel _result;
                         while (_SQLDataReader.Read())
                         {
                             _result = new MembershipModel();
                             _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                             _result.MembershipNo = _SQLDataReader["MembershipNo"].ToString();
                             _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                             _result.StampCampaignName = _SQLDataReader["StampCampaignName"].ToString();
                             _result.StartDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["StartDate"]);
                             _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                             _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                             _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                             _result.Stamps = _SQLDataReader["Stamps"].ToString();
                             _result.LastStampedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["LastStampedDate"]);
                             _result.NextRedeem = _SQLDataReader["NextRedeem"].ToString();
                             _result.EnterpriseBusinessType = _SQLDataReader["EnterpriseBusinessType"].ToString();
                             _result.CurrentBatch = _SQLDataReader["CurrentBatch"].ToString();
                             _result.BackgroundImgOne = _SQLDataReader["BackgroundImgOne"].ToString();
                             _result.BackgroundImgTwo = _SQLDataReader["BackgroundImgTwo"].ToString();
                             _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                             _result.StampRuleRemarks = _SQLDataReader["StampRuleRemarks"].ToString();
                             _result.IsStampRulePopUp = _SQLDataReader["IsStampRulePopUp"].ToString();
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