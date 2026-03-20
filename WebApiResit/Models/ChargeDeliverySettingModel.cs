using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class ChargeDeliverySettingModel
    {
        public int ID
        {
            get;
            set;
        }
        public string ChargeSettingCode
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string DeliveryName
        {
            get;
            set;
        }

        public string ChargeTypeCode
        {
            get;
            set;
        }
        public string FreeDeliveryConditionCode
        {
            get;
            set;
        }
        public string Over_Or_Equal
        {
            get;
            set;
        }
        public string IsEnableDeliveryChargeSetting
        {
            get;
            set;
        }
        public string CreatedBy
        {
            get;
            set;
        }
        public string CreatedDate
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
        public string RowStatus
        {
            get;
            set;
        }

        public string DeliveryRate_Charge
        {
            get;
            set;

        }
        public string Locations
        {
            get;
            set;

        }

        public string ChargeTypes
        {
            get;
            set;

        }



        public string FreeCondition
        {
            get;
            set;

        }



        public ChargeDeliverySettingModel() { }


        public static string ChargeDeliverySetting_InsertUpdate(int ID, string ChargeSettingCode, string EnterpriseAccNo,
string DeliveryName, string ChargeTypeCode, string FreeDeliveryConditionCode, string Over_Or_Equal, string IsEnableDeliveryChargeSetting, string CreatedBy, string Locations)
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
                        _SQLCommand.CommandText = "ChargeDeliverySetting_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@ChargeSettingCode", ChargeSettingCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@DeliveryName ", DeliveryName);
                        _SQLCommand.Parameters.AddWithValue("@ChargeTypeCode", ChargeTypeCode);
                        _SQLCommand.Parameters.AddWithValue("@FreeDeliveryConditionCode", FreeDeliveryConditionCode);
                        _SQLCommand.Parameters.AddWithValue("@Over_Or_Equal", Over_Or_Equal);
                        _SQLCommand.Parameters.AddWithValue("@IsEnableDeliveryChargeSetting", IsEnableDeliveryChargeSetting);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@Locations", Locations);
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





        public static string ChargeDeliverySetting_Delete(string ChargeSettingCode, string CreatedBy, string EnterpriseAccNo)
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
                        _SQLCommand.CommandText = "ChargeDeliverySetting_Delete";
                        _SQLCommand.Parameters.AddWithValue("@ChargeSettingCode", ChargeSettingCode);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
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







        public static List<ChargeDeliverySettingModel> ChargeDeliverySetting_LoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<ChargeDeliverySettingModel> _Value = new List<ChargeDeliverySettingModel>();

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
                        _SQLCommand.CommandText = "ChargeDeliverySetting_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        ChargeDeliverySettingModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new ChargeDeliverySettingModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.ChargeSettingCode = _SQLDataReader["ChargeSettingCode"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.DeliveryName = _SQLDataReader["DeliveryName"].ToString();
                            _result.ChargeTypeCode = _SQLDataReader["ChargeTypeCode"].ToString();
                            _result.FreeDeliveryConditionCode = _SQLDataReader["FreeDeliveryConditionCode"].ToString();
                            _result.Over_Or_Equal = _SQLDataReader["Over_Or_Equal"].ToString();
                            _result.IsEnableDeliveryChargeSetting = _SQLDataReader["IsEnableDeliveryChargeSetting"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.DeliveryRate_Charge = _SQLDataReader["DeliveryRate_Charge"].ToString();
                            _result.Locations = _SQLDataReader["Locations"].ToString();
                            _result.ChargeTypes = _SQLDataReader["ChargeTypes"].ToString();
                            _result.FreeCondition = _SQLDataReader["FreeCondition"].ToString();
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