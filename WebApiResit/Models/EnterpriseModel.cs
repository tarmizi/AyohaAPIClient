using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class EnterpriseModel 
    {

        public int ID
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string EnterpriseName
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





        public string EnterpriseGSTNo
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
        public string EnterprisePhoneNo
        {
            get;
            set;
        }







        public string EnterpriseFaxNo
        {
            get;
            set;
        }
        public string EnterpriseLogo
        {
            get;
            set;
        }
        public string EnterpriseLogo64
        {
            get;
            set;
        }
        public string EnterpriseLogoPath
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
        public string Status
        {
            get;
            set;
        }
        public string EnterpriseTaxNo
        {
            get;
            set;
        }
        public string isTaxApplied
        {
            get;
            set;
        }

        public string TaxRate
        {
            get;
            set;
        }

        public string EnterpriseDescriptions
        {
            get;
            set;
        }
        public string SubscribedCloudReceipt
        {
            get;
            set;
        }
        public string SubscribedNewsAndPromotion
        {
            get;
            set;
        }

        public string LoyaltyCardType
        {
            get;
            set;
        }

        public string EnterpriseFacebook
        {
            get;
            set;
        }
        public string EnterpriseTwiter
        {
            get;
            set;
        }
        public string EnterpriseInstagram
        {
            get;
            set;
        }

        public string EnterpriseCoordinate
        {
            get;
            set;
        }



        public EnterpriseModel() { }


        public static List<EnterpriseModel> Enterprise_getAll()
        {
            List<EnterpriseModel> _Value = new List<EnterpriseModel>();

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
                        _SQLCommand.CommandText = "Enterprise_getAll";
                    
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterpriseModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterpriseModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseGSTNo = _SQLDataReader["EnterpriseGSTNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseFaxNo = _SQLDataReader["EnterpriseFaxNo"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseLogo64 = _SQLDataReader["EnterpriseLogo64"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.Status = _SQLDataReader["Status"].ToString();
                            _result.EnterpriseTaxNo = _SQLDataReader["EnterpriseTaxNo"].ToString();
                            _result.isTaxApplied = _SQLDataReader["isTaxApplied"].ToString();
                            _result.TaxRate = _SQLDataReader["TaxRate"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            
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





        public static List<EnterpriseModel> Enterprise_getDetails(int ID, string EnterpriseAccNo, string SubcriberAccNo)
        {
            List<EnterpriseModel> _Value = new List<EnterpriseModel>();

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
                        _SQLCommand.CommandText = "Enterprise_getDetails";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubcriberAccNo", SubcriberAccNo);

                        
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterpriseModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterpriseModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            _result.EnterpriseGSTNo = _SQLDataReader["EnterpriseGSTNo"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseFaxNo = _SQLDataReader["EnterpriseFaxNo"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseLogo64 = _SQLDataReader["EnterpriseLogo64"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.Status = _SQLDataReader["Status"].ToString();
                            _result.EnterpriseTaxNo = _SQLDataReader["EnterpriseTaxNo"].ToString();
                            _result.isTaxApplied = _SQLDataReader["isTaxApplied"].ToString();
                            _result.TaxRate = _SQLDataReader["TaxRate"].ToString();
                            _result.EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                           _result.SubscribedCloudReceipt =_SQLDataReader["SubscribedCloudReceipt"].ToString();
                            _result.SubscribedNewsAndPromotion = _SQLDataReader["SubscribedNewsAndPromotion"].ToString();
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