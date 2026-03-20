using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class ReceiptsModel
    {


        public string PlateNumber
        {
            get;
            set;
        }
        public string VehicleModel
        {
            get;
            set;
        }
        public string CustomerName
        {
            get;
            set;
        }
        public string CustomerIdentity
        {
            get;
            set;
        }
        public string Mileage
        {
            get;
            set;
        }


        public string TotalAmount
        {
            get;
            set;
        }
        public string UTCBillDate
        {
            get;
            set;
        }
        public string BillId
        {
            get;
            set;
        }
        public string Quantity
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }






        public string Price
        {
            get;
            set;
        }
        public string Amount
        {
            get;
            set;
        }
        public string ReferralPerson
        {
            get;
            set;
        }
        public string CompanyName
        {
            get;
            set;
        }






        public string PartiallyPaid
        {
            get;
            set;
        }
        public string General
        {
            get;
            set;
        }
        public string Claimable
        {
            get;
            set;
        }
        public string Warranty
        {
            get;
            set;
        }

        public string Deposit
        {
            get;
            set;
        }

        public string Confirm
        {
            get;
            set;
        }
        public string New
        {
            get;
            set;
        }
        public string Reject
        {
            get;
            set;
        }
        public ReceiptsModel() { }

        public static List<ReceiptsModel> Receipt_getByIc(string CustomerIC)
        {
            List<ReceiptsModel> _Value = new List<ReceiptsModel>();

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
                        _SQLCommand.CommandText = "Receipt_getByIc";
                        _SQLCommand.Parameters.AddWithValue("@CustomerIC", CustomerIC);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        ReceiptsModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new ReceiptsModel();
                            _result.PlateNumber = _SQLDataReader["PlateNumber"].ToString();
                            _result.VehicleModel = _SQLDataReader["VehicleModel"].ToString();
                            _result.CustomerName = _SQLDataReader["CustomerName"].ToString();
                            _result.CustomerIdentity = _SQLDataReader["CustomerIdentity"].ToString();
                            _result.Mileage = _SQLDataReader["Mileage"].ToString();
                            _result.TotalAmount = _SQLDataReader["TotalAmount"].ToString();
                            _result.UTCBillDate = _SQLDataReader["UTCBillDate"].ToString();
                            _result.BillId = _SQLDataReader["BillId"].ToString();
                            _result.Quantity = _SQLDataReader["Quantity"].ToString();
                            _result.Description = _SQLDataReader["Description"].ToString();
                            _result.Price = _SQLDataReader["Price"].ToString();
                            _result.Amount = _SQLDataReader["Amount"].ToString();
                            _result.ReferralPerson = _SQLDataReader["ReferralPerson"].ToString();
                            _result.CompanyName = _SQLDataReader["CompanyName"].ToString();

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














                public static List<ReceiptsModel> ReceiptTypeCategoryCount_getByIcNumber(string MykadID)
        {
            List<ReceiptsModel> _Value = new List<ReceiptsModel>();

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
                        _SQLCommand.CommandText = "ReceiptTypeCategoryCount_getByIcNumber";
                        _SQLCommand.Parameters.AddWithValue("@MykadID", MykadID);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        ReceiptsModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new ReceiptsModel();
                            _result.PartiallyPaid = _SQLDataReader["PartiallyPaid"].ToString();
                            _result.General = _SQLDataReader["General"].ToString();
                            _result.Claimable = _SQLDataReader["Claimable"].ToString();
                            _result.Warranty = _SQLDataReader["Warranty"].ToString();
                            _result.Deposit = _SQLDataReader["Deposit"].ToString();
                            _result.Confirm = _SQLDataReader["Confirm"].ToString();
                            _result.New = _SQLDataReader["New"].ToString();
                            _result.Reject = _SQLDataReader["Reject"].ToString();

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



























