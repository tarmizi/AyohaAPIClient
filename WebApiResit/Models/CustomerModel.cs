using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class CustomerModel:VehiclesModel
    {


        public int CustomerId
        {
            get;
            set;
        }
        public string CustomerName
        {
            get;
            set;
        }

        public int CustomerStatusId
        {
            get;
            set;
        }
        public string CustomerNumber
        {
            get;
            set;
        }
        public string IdentityNumber
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string PhoneNumber
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }

        public string UTCRegistration
        {
            get;
            set;
        }
        public int UserDetailId
        {
            get;
            set;
        }
        public string Model
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public CustomerModel() { }



        public static List<CustomerModel> Customer_getByCustomerNumberJoinVehicle(string CustomerNumber)
        {
            List<CustomerModel> _Value = new List<CustomerModel>();
        
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
                        _SQLCommand.CommandText = "Customer_getByCustomerNumberJoinVehicle";
                        _SQLCommand.Parameters.AddWithValue("@CustomerNumber", CustomerNumber);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        CustomerModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new CustomerModel();
                            _result.CustomerId = Convert.ToInt32(_SQLDataReader["CustomerId"].ToString());
                            _result.CustomerName = _SQLDataReader["CustomerName"].ToString();
                            _result.CustomerStatusId = Convert.ToInt32(_SQLDataReader["CustomerStatusId"].ToString());
                            _result.CustomerNumber = _SQLDataReader["CustomerNumber"].ToString();
                            _result.IdentityNumber = _SQLDataReader["IdentityNumber"].ToString();
                            _result.Address = _SQLDataReader["Address"].ToString();
                            _result.PhoneNumber = _SQLDataReader["PhoneNumber"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.UTCRegistration = _SQLDataReader["UTCRegistration"].ToString();
                            _result.UserDetailId = Convert.ToInt32(_SQLDataReader["UserDetailId"].ToString());
                            ((VehiclesModel)_result).VehicleId = Convert.ToInt32(_SQLDataReader["VehicleId"].ToString());
                            ((VehiclesModel)_result).PlateNumber = _SQLDataReader["PlateNumber"].ToString();
                            ((VehiclesModel)_result).VehicleModelId = Convert.ToInt32(_SQLDataReader["VehicleModelId"].ToString());
                            ((VehiclesModel)_result).CustomerId = Convert.ToInt32(_SQLDataReader["CustomerId"].ToString());
                            ((VehiclesModel)_result).VehicleImage = _SQLDataReader["VehicleImage"].ToString();
                            _result.Model = _SQLDataReader["Model"].ToString();
                            _result.Type = _SQLDataReader["Type"].ToString();

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



        public static List<CustomerModel> Customer_getByCustomerNumber(string CustomerNumber)
        {
            List<CustomerModel> _Value = new List<CustomerModel>();

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
                        _SQLCommand.CommandText = "Customer_getByCustomerNumber";
                        _SQLCommand.Parameters.AddWithValue("@CustomerNumber", CustomerNumber);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        CustomerModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new CustomerModel();
                            _result.CustomerId = Convert.ToInt32(_SQLDataReader["CustomerId"].ToString());
                            _result.CustomerName = _SQLDataReader["CustomerName"].ToString();
                            _result.CustomerStatusId = Convert.ToInt32(_SQLDataReader["CustomerStatusId"].ToString());
                            _result.CustomerNumber = _SQLDataReader["CustomerNumber"].ToString();
                            _result.IdentityNumber = _SQLDataReader["IdentityNumber"].ToString();
                            _result.Address = _SQLDataReader["Address"].ToString();
                            _result.PhoneNumber = _SQLDataReader["PhoneNumber"].ToString();
                            _result.Email = _SQLDataReader["Email"].ToString();
                            _result.UTCRegistration = _SQLDataReader["UTCRegistration"].ToString();
                            _result.UserDetailId = Convert.ToInt32(_SQLDataReader["UserDetailId"].ToString());
                      


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