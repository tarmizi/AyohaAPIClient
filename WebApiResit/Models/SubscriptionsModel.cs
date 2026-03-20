using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
namespace WebApiResit.Models
{
    public class SubscriptionsModel
    {
        public int ID
        {
            get;
            set;
        }

        public int SubscriptionCodeCount
        {
            get;
            set;
        }


        public string SubscriptionCode
        {
            get;
            set;
        }
        public string SubscriberAccNo
        {
            get;
            set;
        }
        public string MerchantAccNo
        {
            get;
            set;
        }
        public string SaleItemsCode
        {
            get;
            set;
        }
        public string SubscribedDate
        {
            get;
            set;
        }

        public string SubsrcibedEndDate
        {
            get;
            set;
        }
        public string SubscriptionStatus
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










        public string APIKey
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

        public string GeobridgeLayer
        {
            get;
            set;
        }


        public string MerchantName
        {
            get;
            set;
        }

        public string MerchantType
        {
            get;
            set;
        }

        public string CountryCode
        {
            get;
            set;
        }


        public string FeePaymentCycleType
        {
            get;
            set;
        }

        public string ItemDescribtion
        {
            get;
            set;
        }










        public string GisServerSourceType
        {
            get;
            set;
        }


        public string LayerType
        {
            get;
            set;
        }

        public string LayerThumbImg
        {
            get;
            set;
        }
        public string RowNumber
        {
            get;
            set;
        }






        public string SubscriptionCount
        {
            get;
            set;
        }
        public string TotalPrice
        {
            get;
            set;
        }

        public string ImagePath
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

         public string billExternalReferenceNo
        {
            get;
            set;
        }

        public string billCode
        {
            get;
            set;
        }


        public string EnterpriseAccNo
        {
            get;
            set;
        }

        public string MembershipCardCode
        {
            get;
            set;
        }

        public SubscriptionsModel() { }



        public static List<SubscriptionsModel> Subscriptions_loadBySubscriberAccNo_DashboardServices(string SubscriberAccNo)
        {
            List<SubscriptionsModel> _Value = new List<SubscriptionsModel>();

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
                        _SQLCommand.CommandText = "Subscriptions_loadBySubscriberAccNo_DashboardServices";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

                        if (_SQLDataReader.HasRows) // Check if there are rows in the result set
                        {
                            SubscriptionsModel _result;
                            while (_SQLDataReader.Read())
                            {
                                // Check if the result set contains the 'ErrorMessage' field
                                if (_SQLDataReader.GetName(0) == "ErrorMessage")
                                {
                                    // Handle the error message returned by the stored procedure
                                    string errorMessage = _SQLDataReader["ErrorMessage"].ToString();
                                    throw new Exception(errorMessage);  // Or handle the error message as needed
                                }
                                else
                                {
                                    // If valid data is returned, populate the model
                                    _result = new SubscriptionsModel();
                                    _result.SubscriptionCount = _SQLDataReader["SubscriptionCount"].ToString();
                                    _result.TotalPrice = _SQLDataReader["TotalPrice"].ToString();
                                    _Value.Add(_result);
                                }
                            }
                        }
                        else
                        {
                            // If no rows are returned, you can handle it as an invalid login
                            throw new Exception("Invalid SubscriptionCode.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);  // You can customize the exception handling here
                    }
                    finally
                    {
                        _DBConnection.Close();
                    }
                }
            }
            return _Value;
        }


        public static List<SubscriptionsModel> Subscriptions_loadByMerchantAccNo_Dashboard_Merchant(string MerchantAccNo)
        {
            List<SubscriptionsModel> _Value = new List<SubscriptionsModel>();

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
                        _SQLCommand.CommandText = "Subscriptions_loadByMerchantAccNo_Dashboard_Merchant";
                        _SQLCommand.Parameters.AddWithValue("@MerchantAccNo", MerchantAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

                        if (_SQLDataReader.HasRows) // Check if there are rows in the result set
                        {
                            SubscriptionsModel _result;
                            while (_SQLDataReader.Read())
                            {
                                // Check if the result set contains the 'ErrorMessage' field
                                if (_SQLDataReader.GetName(0) == "ErrorMessage")
                                {
                                    // Handle the error message returned by the stored procedure
                                    string errorMessage = _SQLDataReader["ErrorMessage"].ToString();
                                    throw new Exception(errorMessage);  // Or handle the error message as needed
                                }
                                else
                                {
                                    // If valid data is returned, populate the model
                                    _result = new SubscriptionsModel();
                                    _result.SubscriptionCount = _SQLDataReader["SubscriptionCount"].ToString();
                                    _result.TotalPrice = _SQLDataReader["TotalPrice"].ToString();
                                    _Value.Add(_result);
                                }
                            }
                        }
                        else
                        {
                            // If no rows are returned, you can handle it as an invalid login
                            throw new Exception("Invalid SubscriptionCode.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);  // You can customize the exception handling here
                    }
                    finally
                    {
                        _DBConnection.Close();
                    }
                }
            }
            return _Value;
        }





        public static List<SubscriptionsModel> Subscriptions_loadBySubscriberAccNo_SubscriptionPackage(string SubscriberAccNo)
        {
            List<SubscriptionsModel> _Value = new List<SubscriptionsModel>();

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
                        _SQLCommand.CommandText = "Subscriptions_loadBySubscriberAccNo_SubscriptionPackage";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

                        if (_SQLDataReader.HasRows) // Check if there are rows in the result set
                        {
                            SubscriptionsModel _result;
                            while (_SQLDataReader.Read())
                            {
                                // Check if the result set contains the 'ErrorMessage' field
                                if (_SQLDataReader.GetName(0) == "ErrorMessage")
                                {
                                    // Handle the error message returned by the stored procedure
                                    string errorMessage = _SQLDataReader["ErrorMessage"].ToString();
                                    throw new Exception(errorMessage);  // Or handle the error message as needed
                                }
                                else
                                {
                                    // If valid data is returned, populate the model
                                    _result = new SubscriptionsModel();
                                    _result.SubscribedPackage = _SQLDataReader["SubscribedPackage"].ToString();
                                    _result.SubscriptionCount = _SQLDataReader["PackageCount"].ToString();
                                    _Value.Add(_result);
                                }
                            }
                        }
                        else
                        {
                            // If no rows are returned, you can handle it as an invalid login
                            throw new Exception("Invalid SubscriptionCode.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);  // You can customize the exception handling here
                    }
                    finally
                    {
                        _DBConnection.Close();
                    }
                }
            }
            return _Value;
        }


        public static List<SubscriptionsModel> Subscriptions_loadByMerchantAccNo_SubscriptionPackage_Dashbord_Merchant(string MerchantAccNo)
        {
            List<SubscriptionsModel> _Value = new List<SubscriptionsModel>();

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
                        _SQLCommand.CommandText = "Subscriptions_loadByMerchantAccNo_SubscriptionPackage_Dashbord_Merchant";
                        _SQLCommand.Parameters.AddWithValue("@MerchantAccNo", MerchantAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

                        if (_SQLDataReader.HasRows) // Check if there are rows in the result set
                        {
                            SubscriptionsModel _result;
                            while (_SQLDataReader.Read())
                            {
                                // Check if the result set contains the 'ErrorMessage' field
                                if (_SQLDataReader.GetName(0) == "ErrorMessage")
                                {
                                    // Handle the error message returned by the stored procedure
                                    string errorMessage = _SQLDataReader["ErrorMessage"].ToString();
                                    throw new Exception(errorMessage);  // Or handle the error message as needed
                                }
                                else
                                {
                                    // If valid data is returned, populate the model
                                    _result = new SubscriptionsModel();
                                    _result.SubscribedPackage = _SQLDataReader["SubscribedPackage"].ToString();
                                    _result.SubscriptionCount = _SQLDataReader["PackageCount"].ToString();
                                    _Value.Add(_result);
                                }
                            }
                        }
                        else
                        {
                            // If no rows are returned, you can handle it as an invalid login
                            throw new Exception("Invalid SubscriptionCode.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);  // You can customize the exception handling here
                    }
                    finally
                    {
                        _DBConnection.Close();
                    }
                }
            }
            return _Value;
        }






        public static string Subscriptions_InsertUpdate(string SubscriptionCode, string SubscriberAccNo,
           string MerchantAccNo, string SaleItemsCode, string SubscriptionStatus,
            string ModifiedBy, string SubscribedPackage, string PackagePrice)
        {
            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            string _value = "true";

            using (SqlConnection _DBConnection = _SQLConnection)
            {
                SqlCommand _SQLCommand = new SqlCommand();
                _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
                _SQLCommand.CommandTimeout = 0;
                _SQLCommand.CommandText = "Subscriptions_InsertUpdate";  // Call your stored procedure
                _SQLCommand.Parameters.AddWithValue("@SubscriptionCode", SubscriptionCode);
                _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                _SQLCommand.Parameters.AddWithValue("@MerchantAccNo", MerchantAccNo);
                _SQLCommand.Parameters.AddWithValue("@SaleItemsCode", SaleItemsCode);
                // _SQLCommand.Parameters.AddWithValue("@SubscribedDate", SubscribedDate);
                _SQLCommand.Parameters.AddWithValue("@SubscriptionStatus", SubscriptionStatus);
                _SQLCommand.Parameters.AddWithValue("@ModifiedBy", ModifiedBy);
                _SQLCommand.Parameters.AddWithValue("@SubscribedPackage", SubscribedPackage);
                _SQLCommand.Parameters.AddWithValue("@PackagePrice", PackagePrice);
                try
                {
                    _SQLCommand.Connection = _DBConnection;
                    _DBConnection.Open();
                    _SQLCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // Check for the 'API Key does not exist' error
                    if (ex.Message.Contains("SubscriptionCode Already Exists"))
                    {
                        //_value = "false, API Key does not exist";
                        _value = "false";
                    }
                    else
                    {
                        _value = "false," + ex.ToString();
                    }
                }
                finally
                {
                    _DBConnection.Close();
                }
            }

            return _value;
        }

        public static string Subscriptions_Insert(string SubscriptionCode, string SubscriberAccNo,
         string MerchantAccNo, string SaleItemsCode, string SubscriptionStatus,
          string ModifiedBy, string SubscribedPackage, string PackagePrice)
        {
            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            string _value = "true";

            using (SqlConnection _DBConnection = _SQLConnection)
            {
                SqlCommand _SQLCommand = new SqlCommand();
                _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
                _SQLCommand.CommandTimeout = 0;
                _SQLCommand.CommandText = "Subscriptions_Insert";  // Call your stored procedure
                _SQLCommand.Parameters.AddWithValue("@SubscriptionCode", SubscriptionCode);
                _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                _SQLCommand.Parameters.AddWithValue("@MerchantAccNo", MerchantAccNo);
                _SQLCommand.Parameters.AddWithValue("@SaleItemsCode", SaleItemsCode);
                // _SQLCommand.Parameters.AddWithValue("@SubscribedDate", SubscribedDate);
                _SQLCommand.Parameters.AddWithValue("@SubscriptionStatus", SubscriptionStatus);
                _SQLCommand.Parameters.AddWithValue("@ModifiedBy", ModifiedBy);
                _SQLCommand.Parameters.AddWithValue("@SubscribedPackage", SubscribedPackage);
                _SQLCommand.Parameters.AddWithValue("@PackagePrice", PackagePrice);
                try
                {
                    _SQLCommand.Connection = _DBConnection;
                    _DBConnection.Open();
                    _SQLCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    _value = "false," + ex.ToString();

                }
                finally
                {
                    _DBConnection.Close();
                }
            }

            return _value;
        }





      
        public static string Subscriptions_UpdateSubscriptionStatus(string SubscriptionCode, string SubscriptionStatus, string billExternalReferenceNo, string billCode,
            string SubscriberAccNo, string EnterpriseAccNo, string MembershipCardCode, string PackagePrice)
        {
            SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
            string _value = "true";

            using (SqlConnection _DBConnection = _SQLConnection)
            {
                SqlCommand _SQLCommand = new SqlCommand();
                _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
                _SQLCommand.CommandTimeout = 0;
                _SQLCommand.CommandText = "Subscriptions_UpdateSubscriptionStatus";  // Call your stored procedure
                _SQLCommand.Parameters.AddWithValue("@SubscriptionCode", SubscriptionCode);
                _SQLCommand.Parameters.AddWithValue("@SubscriptionStatus", SubscriptionStatus);
                _SQLCommand.Parameters.AddWithValue("@billExternalReferenceNo", billExternalReferenceNo);
                _SQLCommand.Parameters.AddWithValue("@billCode", billCode);
                _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                _SQLCommand.Parameters.AddWithValue("@MembershipCardCode", MembershipCardCode);
                _SQLCommand.Parameters.AddWithValue("@PackagePrice", PackagePrice);
                try
                {
                    _SQLCommand.Connection = _DBConnection;
                    _DBConnection.Open();
                    _SQLCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    _value = "false," + ex.ToString();

                }
                finally
                {
                    _DBConnection.Close();
                }
            }

            return _value;
        }




        public static List<SubscriptionsModel> Subscriptions_loadByMerchantNo(string MerchantAccNo)
        {
            List<SubscriptionsModel> _Value = new List<SubscriptionsModel>();

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
                        _SQLCommand.CommandText = "Subscriptions_loadByMerchantNo";
                        _SQLCommand.Parameters.AddWithValue("@MerchantAccNo", MerchantAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

                        if (_SQLDataReader.HasRows) // Check if there are rows in the result set
                        {
                            SubscriptionsModel _result;
                            while (_SQLDataReader.Read())
                            {
                                // Check if the result set contains the 'ErrorMessage' field
                                if (_SQLDataReader.GetName(0) == "ErrorMessage")
                                {
                                    // Handle the error message returned by the stored procedure
                                    string errorMessage = _SQLDataReader["ErrorMessage"].ToString();
                                    throw new Exception(errorMessage);  // Or handle the error message as needed
                                }
                                else
                                {
                                    // If valid data is returned, populate the model
                                    _result = new SubscriptionsModel();
                                    _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                                    _result.SubscriptionCode = _SQLDataReader["SubscriptionCode"].ToString();
                                    _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                                    _result.MerchantAccNo = _SQLDataReader["MerchantAccNo"].ToString();
                                    _result.SaleItemsCode = _SQLDataReader["SaleItemsCode"].ToString();
                                    _result.SubscribedDate = _SQLDataReader["SubscribedDate"].ToString();
                                    _result.SubsrcibedEndDate = _SQLDataReader["SubsrcibedEndDate"].ToString();
                                    _result.SubscriptionStatus = _SQLDataReader["SubscriptionStatus"].ToString();
                                    _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                                    _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                                    _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                                    _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                                    _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                                    _result.SubscribedPackage = _SQLDataReader["SubscribedPackage"].ToString();
                                    _result.PackagePrice = _SQLDataReader["PackagePrice"].ToString();
                                    _Value.Add(_result);
                                }
                            }
                        }
                        else
                        {
                            // If no rows are returned, you can handle it as an invalid login
                            throw new Exception("Invalid SubscriptionCode.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);  // You can customize the exception handling here
                    }
                    finally
                    {
                        _DBConnection.Close();
                    }
                }
            }
            return _Value;
        }





        public static List<SubscriptionsModel> Subscriptions_ListOfSubscriber_loadByMerchantNo(string MerchantAccNo)
        {
            List<SubscriptionsModel> _Value = new List<SubscriptionsModel>();

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
                        _SQLCommand.CommandText = "Subscriptions_ListOfSubscriber_loadByMerchantNo";
                        _SQLCommand.Parameters.AddWithValue("@MerchantAccNo", MerchantAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

                        if (_SQLDataReader.HasRows) // Check if there are rows in the result set
                        {
                            SubscriptionsModel _result;
                            while (_SQLDataReader.Read())
                            {
                                // Check if the result set contains the 'ErrorMessage' field
                                if (_SQLDataReader.GetName(0) == "ErrorMessage")
                                {
                                    // Handle the error message returned by the stored procedure
                                    string errorMessage = _SQLDataReader["ErrorMessage"].ToString();
                                    throw new Exception(errorMessage);  // Or handle the error message as needed
                                }
                                else
                                {
                                    // If valid data is returned, populate the model
                                    _result = new SubscriptionsModel();
                                    //   _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                                    _result.SubscribedDate = _SQLDataReader["SubscribedDate"].ToString();
                                    _result.SubsrcibedEndDate = _SQLDataReader["SubsrcibedEndDate"].ToString();
                                    _result.SubscribedPackage = _SQLDataReader["SubscribedPackage"].ToString();
                                    _result.ImagePath = _SQLDataReader["ImagePath"].ToString();
                                    _result.Name = _SQLDataReader["Name"].ToString();
                                    _result.ItemName = _SQLDataReader["ItemName"].ToString();
                                    _result.PackagePrice = _SQLDataReader["PackagePrice"].ToString();
                                    _Value.Add(_result);
                                }
                            }
                        }
                        else
                        {
                            // If no rows are returned, you can handle it as an invalid login
                            throw new Exception("Invalid SubscriptionCode.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);  // You can customize the exception handling here
                    }
                    finally
                    {
                        _DBConnection.Close();
                    }
                }
            }
            return _Value;
        }


        public static List<SubscriptionsModel> Subscriptions_loadBySubscriberAccNo(string SubscriberAccNo)
        {
            List<SubscriptionsModel> _Value = new List<SubscriptionsModel>();

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
                        _SQLCommand.CommandText = "Subscriptions_loadBySubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

                        if (_SQLDataReader.HasRows) // Check if there are rows in the result set
                        {
                            SubscriptionsModel _result;
                            while (_SQLDataReader.Read())
                            {
                                // Check if the result set contains the 'ErrorMessage' field
                                if (_SQLDataReader.GetName(0) == "ErrorMessage")
                                {
                                    // Handle the error message returned by the stored procedure
                                    string errorMessage = _SQLDataReader["ErrorMessage"].ToString();
                                    throw new Exception(errorMessage);  // Or handle the error message as needed
                                }
                                else
                                {
                                    // If valid data is returned, populate the model
                                    _result = new SubscriptionsModel();
                                    _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                                    _result.SubscriptionCode = _SQLDataReader["SubscriptionCode"].ToString();
                                    _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                                    _result.MerchantAccNo = _SQLDataReader["MerchantAccNo"].ToString();
                                    _result.SaleItemsCode = _SQLDataReader["SaleItemsCode"].ToString();
                                    _result.SubscribedDate = _SQLDataReader["SubscribedDate"].ToString().Replace("12:00:00 AM", string.Empty);
                                    _result.SubsrcibedEndDate = _SQLDataReader["SubsrcibedEndDate"].ToString().Replace("12:00:00 AM", string.Empty);
                                    _result.SubscriptionStatus = _SQLDataReader["SubscriptionStatus"].ToString();
                                    _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                                    _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                                    _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                                    _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                                    _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                                    _result.SubscribedPackage = _SQLDataReader["SubscribedPackage"].ToString();
                                    _result.PackagePrice = _SQLDataReader["PackagePrice"].ToString();
                                    _result.APIKey = _SQLDataReader["APIKey"].ToString();
                                    _result.ItemName = _SQLDataReader["ItemName"].ToString();
                                    _result.ItemPrice = _SQLDataReader["ItemPrice"].ToString();
                                    _result.GeobridgeLayer = _SQLDataReader["GeobridgeLayer"].ToString();
                                    _result.MerchantName = _SQLDataReader["MerchantName"].ToString();
                                    _result.MerchantType = _SQLDataReader["MerchantType"].ToString();
                                    _result.CountryCode = _SQLDataReader["CountryCode"].ToString();
                                    _result.FeePaymentCycleType = _SQLDataReader["FeePaymentCycleType"].ToString();
                                    _result.ItemDescribtion = _SQLDataReader["ItemDescribtion"].ToString();
                                    _result.GisServerSourceType = _SQLDataReader["GisServerSourceType"].ToString();
                                    _result.LayerType = _SQLDataReader["LayerType"].ToString();
                                    _result.LayerThumbImg = _SQLDataReader["LayerThumbImg"].ToString();
                                    _result.RowNumber = _SQLDataReader["RowNumber"].ToString();
                                    _Value.Add(_result);
                                }
                            }
                        }
                        else
                        {
                            // If no rows are returned, you can handle it as an invalid login
                            throw new Exception("Invalid SubscriptionCode.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);  // You can customize the exception handling here
                    }
                    finally
                    {
                        _DBConnection.Close();
                    }
                }
            }
            return _Value;
        }




        public static List<SubscriptionsModel> Subscriptions_loadBySubscriptionCode(string SubscriptionCode)
        {
            List<SubscriptionsModel> _Value = new List<SubscriptionsModel>();

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
                        _SQLCommand.CommandText = "Subscriptions_loadBySubscriptionCode";
                        _SQLCommand.Parameters.AddWithValue("@SubscriptionCode", SubscriptionCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

                        if (_SQLDataReader.HasRows) // Check if there are rows in the result set
                        {
                            SubscriptionsModel _result;
                            while (_SQLDataReader.Read())
                            {
                                // Check if the result set contains the 'ErrorMessage' field
                                if (_SQLDataReader.GetName(0) == "ErrorMessage")
                                {
                                    // Handle the error message returned by the stored procedure
                                    string errorMessage = _SQLDataReader["ErrorMessage"].ToString();
                                    throw new Exception(errorMessage);  // Or handle the error message as needed
                                }
                                else
                                {
                                    // If valid data is returned, populate the model
                                    _result = new SubscriptionsModel();
                                    _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                                    _result.SubscriptionCode = _SQLDataReader["SubscriptionCode"].ToString();
                                    _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                                    _result.MerchantAccNo = _SQLDataReader["MerchantAccNo"].ToString();
                                    _result.SaleItemsCode = _SQLDataReader["SaleItemsCode"].ToString();
                                    _result.SubscribedDate = _SQLDataReader["SubscribedDate"].ToString();
                                    _result.SubsrcibedEndDate = _SQLDataReader["SubsrcibedEndDate"].ToString();
                                    _result.SubscriptionStatus = _SQLDataReader["SubscriptionStatus"].ToString();
                                    _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                                    _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                                    _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                                    _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                                    _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                                    _result.SubscribedPackage = _SQLDataReader["SubscribedPackage"].ToString();
                                    _result.PackagePrice = _SQLDataReader["PackagePrice"].ToString();
                                    _Value.Add(_result);
                                }
                            }
                        }
                        else
                        {
                            // If no rows are returned, you can handle it as an invalid login
                            throw new Exception("Invalid SubscriptionCode.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);  // You can customize the exception handling here
                    }
                    finally
                    {
                        _DBConnection.Close();
                    }
                }
            }
            return _Value;
        }








        public static List<SubscriptionsModel> Subscriptions_checkBySubscriptionCode(string SubscriptionCode, string PackagePrice, string SubscribedPackage)
        {
            List<SubscriptionsModel> _Value = new List<SubscriptionsModel>();

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
                        _SQLCommand.CommandText = "Subscriptions_checkBySubscriptionCode";
                        _SQLCommand.Parameters.AddWithValue("@SubscriptionCode", SubscriptionCode);
                        _SQLCommand.Parameters.AddWithValue("@PackagePrice", PackagePrice);
                        _SQLCommand.Parameters.AddWithValue("@SubscribedPackage", SubscribedPackage);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        SubscriptionsModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new SubscriptionsModel();
                            _result.SubscriptionCodeCount = Convert.ToInt32(_SQLDataReader["SubscriptionCodeCount"].ToString());
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





        public static List<SubscriptionsModel> Subscriptions_checkBySubscriberAccNo_MerchantAccNo_SaleItemsCode(string SubscriberAccNo, string MerchantAccNo, string SaleItemsCode)
        {
            List<SubscriptionsModel> _Value = new List<SubscriptionsModel>();

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
                        _SQLCommand.CommandText = "Subscriptions_checkBySubscriberAccNo_MerchantAccNo_SaleItemsCode";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MerchantAccNo", MerchantAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SaleItemsCode", SaleItemsCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        SubscriptionsModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new SubscriptionsModel();
                            _result.SubscriptionCodeCount = Convert.ToInt32(_SQLDataReader["SubscriptionCodeCount"].ToString());
                            _result.SubscribedPackage = _SQLDataReader["SubscribedPackage"].ToString();
                            _result.SubsrcibedEndDate = _SQLDataReader["SubsrcibedEndDate"].ToString();
                            _result.SubscriptionStatus = _SQLDataReader["SubscriptionStatus"].ToString();
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


        public static List<SubscriptionsModel> Subscriptions_loadBySubscriberAccNo_MerchantAccNo_SaleItemsCode(string SubscriberAccNo, string MerchantAccNo, string SaleItemsCode)
        {
            List<SubscriptionsModel> _Value = new List<SubscriptionsModel>();

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
                        _SQLCommand.CommandText = "Subscriptions_loadBySubscriberAccNo_MerchantAccNo_SaleItemsCode";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@MerchantAccNo", MerchantAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SaleItemsCode", SaleItemsCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

                        if (_SQLDataReader.HasRows) // Check if there are rows in the result set
                        {
                            SubscriptionsModel _result;
                            while (_SQLDataReader.Read())
                            {
                                // Check if the result set contains the 'ErrorMessage' field
                                if (_SQLDataReader.GetName(0) == "ErrorMessage")
                                {
                                    // Handle the error message returned by the stored procedure
                                    string errorMessage = _SQLDataReader["ErrorMessage"].ToString();
                                    throw new Exception(errorMessage);  // Or handle the error message as needed
                                }
                                else
                                {
                                    // If valid data is returned, populate the model
                                    _result = new SubscriptionsModel();
                                    _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                                    _result.SubscriptionCode = _SQLDataReader["SubscriptionCode"].ToString();
                                    _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                                    _result.MerchantAccNo = _SQLDataReader["MerchantAccNo"].ToString();
                                    _result.SaleItemsCode = _SQLDataReader["SaleItemsCode"].ToString();
                                    _result.SubscribedDate = _SQLDataReader["SubscribedDate"].ToString().Replace("12:00:00 AM", string.Empty);
                                    _result.SubsrcibedEndDate = _SQLDataReader["SubsrcibedEndDate"].ToString().Replace("12:00:00 AM", string.Empty);
                                    _result.SubscriptionStatus = _SQLDataReader["SubscriptionStatus"].ToString();
                                    _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                                    _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                                    _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                                    _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                                    _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                                    _result.SubscribedPackage = _SQLDataReader["SubscribedPackage"].ToString();
                                    _result.PackagePrice = _SQLDataReader["PackagePrice"].ToString();
                                    _result.APIKey = _SQLDataReader["APIKey"].ToString();
                                    _result.ItemName = _SQLDataReader["ItemName"].ToString();
                                    _result.ItemPrice = _SQLDataReader["ItemPrice"].ToString();
                                    _result.GeobridgeLayer = _SQLDataReader["GeobridgeLayer"].ToString();
                                    _result.MerchantName = _SQLDataReader["MerchantName"].ToString();
                                    _result.MerchantType = _SQLDataReader["MerchantType"].ToString();
                                    _result.CountryCode = _SQLDataReader["CountryCode"].ToString();
                                    _result.FeePaymentCycleType = _SQLDataReader["FeePaymentCycleType"].ToString();
                                    _result.ItemDescribtion = _SQLDataReader["ItemDescribtion"].ToString();
                                    _result.GisServerSourceType = _SQLDataReader["GisServerSourceType"].ToString();
                                    _result.LayerType = _SQLDataReader["LayerType"].ToString();
                                    _result.LayerThumbImg = _SQLDataReader["LayerThumbImg"].ToString();
                                    _result.RowNumber = _SQLDataReader["RowNumber"].ToString();
                                    _Value.Add(_result);
                                }
                            }
                        }
                        else
                        {
                            // If no rows are returned, you can handle it as an invalid login
                            throw new Exception("Invalid SubscriptionCode.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);  // You can customize the exception handling here
                    }
                    finally
                    {
                        _DBConnection.Close();
                    }
                }
            }
            return _Value;
        }






        public static List<SubscriptionsModel> Subscriptions_ListOfSubscriber_loadByMerchantNo_SaleItemsCode(string MerchantAccNo, string SaleItemsCode)
        {
            List<SubscriptionsModel> _Value = new List<SubscriptionsModel>();

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
                        _SQLCommand.CommandText = "Subscriptions_ListOfSubscriber_loadByMerchantNo_SaleItemsCode";
                        _SQLCommand.Parameters.AddWithValue("@MerchantAccNo", MerchantAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SaleItemsCode", SaleItemsCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

                        if (_SQLDataReader.HasRows) // Check if there are rows in the result set
                        {
                            SubscriptionsModel _result;
                            while (_SQLDataReader.Read())
                            {
                                // Check if the result set contains the 'ErrorMessage' field
                                if (_SQLDataReader.GetName(0) == "ErrorMessage")
                                {
                                    // Handle the error message returned by the stored procedure
                                    string errorMessage = _SQLDataReader["ErrorMessage"].ToString();
                                    throw new Exception(errorMessage);  // Or handle the error message as needed
                                }
                                else
                                {
                                    // If valid data is returned, populate the model
                                    _result = new SubscriptionsModel();
                                    //   _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                                    _result.SubscribedDate = _SQLDataReader["SubscribedDate"].ToString();
                                    _result.SubsrcibedEndDate = _SQLDataReader["SubsrcibedEndDate"].ToString();
                                    _result.SubscribedPackage = _SQLDataReader["SubscribedPackage"].ToString();
                                    _result.ImagePath = _SQLDataReader["ImagePath"].ToString();
                                    _result.Name = _SQLDataReader["Name"].ToString();
                                    _result.ItemName = _SQLDataReader["ItemName"].ToString();
                                    _result.PackagePrice = _SQLDataReader["PackagePrice"].ToString();
                                    _result.SaleItemsCode = _SQLDataReader["SaleItemsCode"].ToString();
                                    _Value.Add(_result);
                                }
                            }
                        }
                        else
                        {
                            // If no rows are returned, you can handle it as an invalid login
                            throw new Exception("Invalid SubscriptionCode.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);  // You can customize the exception handling here
                    }
                    finally
                    {
                        _DBConnection.Close();
                    }
                }
            }
            return _Value;
        }






        //public static List<SubscriptionsModel> Subscriptions_checkBySubscriptionCode(string SubscriptionCode)
        //{
        //    List<SubscriptionsModel> _Value = new List<SubscriptionsModel>();

        //    SqlConnection _SQLConnection = SQLConnectionString.BuildConnection();
        //    using (SqlConnection _DBConnection = _SQLConnection)
        //    {
        //        SqlCommand _SQLCommand = new SqlCommand();
        //        _SQLCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        _SQLCommand.CommandTimeout = 0;
        //        using (_SQLCommand)
        //        {
        //            try
        //            {
        //                _SQLCommand.Connection = _DBConnection;
        //                _SQLCommand.CommandText = "Subscriptions_checkBySubscriptionCode";
        //                _SQLCommand.Parameters.AddWithValue("@SubscriptionCode", SubscriptionCode);
        //                _DBConnection.Open();
        //                SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

                        
        //                    SubscriptionsModel _result;
        //                    while (_SQLDataReader.Read())
        //                    {
        //                        // If valid data is returned, populate the model
        //                        _result = new SubscriptionsModel();
        //                        _result.SubscriptionCodeCount = Convert.ToInt32(_SQLDataReader["SubscriptionCodeCount"].ToString());
                        




        //                        _Value.Add(_result);
        //                    }
                       
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception(ex.Message);  // You can customize the exception handling here
        //            }
        //            finally
        //            {
        //                _DBConnection.Close();
        //            }
        //        }
        //    }
        //    return _Value;
        //}
    }
}