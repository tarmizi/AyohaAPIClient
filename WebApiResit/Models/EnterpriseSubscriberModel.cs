using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class EnterpriseSubscriberModel : EnterpriseModel
    {


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


      

        public string SubscribedDate
        {
            get;
            set;
        }


     

        
        public EnterpriseSubscriberModel() { }




        public static bool EnterpriseSubscriber_Insert(string SubcriberAccNo, string EnterpriseAccNo, int SubscribedCloudReceipt, int SubscribedNewsAndPromotion, string User)
        {
            List<GPSuserModel> _Value = new List<GPSuserModel>();
            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            bool _value = true;
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
                        _SQLCommand.CommandText = "EnterpriseSubscriber_Insert";
                        _SQLCommand.Parameters.AddWithValue("@SubcriberAccNo", SubcriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscribedCloudReceipt", SubscribedCloudReceipt);
                        _SQLCommand.Parameters.AddWithValue("@SubscribedNewsAndPromotion", SubscribedNewsAndPromotion);
                        _SQLCommand.Parameters.AddWithValue("@User", User);
                        _DBConnection.Open();
                        _SQLCommand.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        _value = false;
                    }

                    finally
                    {

                        _DBConnection.Close();

                    }

                }

            }



            return _value;
        }





        public static List<EnterpriseSubscriberModel> EnterpriseSubscriber_getBySubcriberAccNo(string SubcriberAccNo)
        {
            List<EnterpriseSubscriberModel> _Value = new List<EnterpriseSubscriberModel>();

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
                        _SQLCommand.CommandText = "EnterpriseSubscriber_getBySubcriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubcriberAccNo", SubcriberAccNo);               
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterpriseSubscriberModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterpriseSubscriberModel();
                            _result.SubscribedCloudReceipt =ConvertStatus(_SQLDataReader["SubscribedCloudReceipt"].ToString());
                            _result.SubscribedNewsAndPromotion = ConvertStatus(_SQLDataReader["SubscribedNewsAndPromotion"].ToString());
                            _result.SubscribedDate = _SQLDataReader["SubscribedDate"].ToString();
                            ((EnterpriseModel)_result).ID= Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            ((EnterpriseModel)_result).EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            ((EnterpriseModel)_result).EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            ((EnterpriseModel)_result).EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            ((EnterpriseModel)_result).EnterpriseRegistrationNo = _SQLDataReader["EnterpriseRegistrationNo"].ToString();
                            ((EnterpriseModel)_result).EnterpriseGSTNo = _SQLDataReader["EnterpriseGSTNo"].ToString();
                            ((EnterpriseModel)_result).EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            ((EnterpriseModel)_result).EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            ((EnterpriseModel)_result).EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            ((EnterpriseModel)_result).EnterpriseFaxNo = _SQLDataReader["EnterpriseFaxNo"].ToString();
                            ((EnterpriseModel)_result).EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            ((EnterpriseModel)_result).EnterpriseLogo64 = _SQLDataReader["EnterpriseLogo64"].ToString();
                            ((EnterpriseModel)_result).EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            ((EnterpriseModel)_result).RowStatus = _SQLDataReader["RowStatus"].ToString();
                            ((EnterpriseModel)_result).CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            ((EnterpriseModel)_result).CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            ((EnterpriseModel)_result).ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            ((EnterpriseModel)_result).ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            ((EnterpriseModel)_result).Status = _SQLDataReader["Status"].ToString();
                            ((EnterpriseModel)_result).EnterpriseTaxNo = _SQLDataReader["EnterpriseTaxNo"].ToString();
                            ((EnterpriseModel)_result).isTaxApplied = _SQLDataReader["isTaxApplied"].ToString();
                            ((EnterpriseModel)_result).TaxRate = _SQLDataReader["TaxRate"].ToString();
                            ((EnterpriseModel)_result).EnterpriseDescriptions = _SQLDataReader["EnterpriseDescriptions"].ToString();
                            ((EnterpriseModel)_result).LoyaltyCardType = _SQLDataReader["LoyaltyCardType"].ToString();
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

        public static List<EnterpriseSubscriberModel> EnterpriseSubscriber_getBySubcriberAccNo_SearchReceipt(string SubcriberAccNo)
        {
            List<EnterpriseSubscriberModel> _Value = new List<EnterpriseSubscriberModel>();

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
                        _SQLCommand.CommandText = "EnterpriseSubscriber_getBySubcriberAccNo_SearchReceipt";
                        _SQLCommand.Parameters.AddWithValue("@SubcriberAccNo", SubcriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        EnterpriseSubscriberModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new EnterpriseSubscriberModel();
                         
                            ((EnterpriseModel)_result).ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            ((EnterpriseModel)_result).EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            ((EnterpriseModel)_result).EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            ((EnterpriseModel)_result).EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.SubscribedCloudReceipt = ConvertStatus(_SQLDataReader["SubscribedCloudReceipt"].ToString());
                            _result.SubscribedNewsAndPromotion = ConvertStatus(_SQLDataReader["SubscribedNewsAndPromotion"].ToString());
                            _result.SubscribedDate = _SQLDataReader["SubscribedDate"].ToString();

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



       
    





    private static string ConvertStatus(string val)
        {

            string Status = "NO";
            if (val == "1")
            {
                Status = "YES";
            }
           
            return Status;

        }
    }
}