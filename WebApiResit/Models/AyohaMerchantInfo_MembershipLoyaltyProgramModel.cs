using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaMerchantInfo_MembershipLoyaltyProgramModel
    {
        

        public string MembershipSegmentCode
        {
            get;
            set;
        }
        public int Bilangan
        {
            get;
            set;
        }
        public string MembershipcardName
        {
            get;
            set;
        }
        public string MembershipcardImg
        {
            get;
            set;
        }
        public string AyohaLoyaltyProgram
        {
            get;
            set;
        }
       
        public string LoyaltyProgramCode
        {
            get;
            set;
        }


       
        public AyohaMerchantInfo_MembershipLoyaltyProgramModel() { }

        public static List<AyohaMerchantInfo_MembershipLoyaltyProgramModel> AyohaMerchantInfo_MembershipLoyaltyProgram(string MembershipCardCode)
        {
            List<AyohaMerchantInfo_MembershipLoyaltyProgramModel> _Value = new List<AyohaMerchantInfo_MembershipLoyaltyProgramModel>();

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
                        _SQLCommand.CommandText = "AyohaMerchantInfo_MembershipLoyaltyProgram";
                        _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaMerchantInfo_MembershipLoyaltyProgramModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new AyohaMerchantInfo_MembershipLoyaltyProgramModel();

                            _result.MembershipSegmentCode = _SQLDataReader["MembershipSegmentCode"].ToString();
                            _result.Bilangan = Convert.ToInt32(_SQLDataReader["Bilangan"].ToString());
                            _result.MembershipcardName = _SQLDataReader["MembershipcardName"].ToString();
                            _result.MembershipcardImg = _SQLDataReader["MembershipcardImg"].ToString();
                            _result.AyohaLoyaltyProgram = _SQLDataReader["AyohaLoyaltyProgram"].ToString();
                            _result.LoyaltyProgramCode = _SQLDataReader["LoyaltyProgramCode"].ToString();
                      
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