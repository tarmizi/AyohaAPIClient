using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class FlatBillModel
    {

        public int ID
        {
            get;
            set;
        }
        public string FlatBillDesc
        {
            get;
            set;
        }
        public string FlatBillDate
        {
            get;
            set;
        }
        public string FlatBillPlatNo
        {
            get;
            set;
        }
        public string FlatBillWorkshop
        {
            get;
            set;
        }


        public string FlatBillWorkshopID
        {
            get;
            set;
        }
        public string FlatBillIssuedBy
        {
            get;
            set;
        }
        public string FlatBillID
        {
            get;
            set;
        }
        public string FlatBillTotalAmount
        {
            get;
            set;
        }
        public string FlatBillNumberIC
        {
            get;
            set;
        }
        public string FlatBillVehicleModel
        {
            get;
            set;
        }

        public string FlatBillImgLogo
        {
            get;
            set;
        }





          public string FlatBillStatus
        {
            get;
            set;
        }
        public string FlatBillUpdateDate
        {
            get;
            set;
        }

        public string FlatBillUpdateBy
        {
            get;
            set;
        }

            public string CloudreceiptAccNo
        {
            get;
            set;
        }
        public string FlatBillFinalAmount
        {
            get;
            set;
        }

        public string FlatBillTax
        {
            get;
            set;
        }





          public string FlatBillBalance
        {
            get;
            set;
        }

            public string FlatBillDeposit
        {
            get;
            set;
        }
        public string FlatBillMilage
        {
            get;
            set;
        }

        public string FlatBillGSTNo
        {
            get;
            set;
        }


              public string FlatBillTaxInvoice
        {
            get;
            set;
        }
        public string FlatBillBillNo
        {
            get;
            set;
        }

        public string FlatBillCustomerName
        {
            get;
            set;
        }

        public string FlatBillWorkShopAddress
        {
            get;
            set;
        }
        public string FlatBillWorkshopPhoneNo
        {
            get;
            set;
        }

        public string FlatBillCompanyNumber
        {
            get;
            set;
        }

        public string FlatBillPaymentType
        {
            get;
            set;
        }
        public string FlatBillPushNotificationSendStatus
        {
            get;
            set;
        }
        public string FlatBillUniqueID
        {
            get;
            set;
        }
        public string FlatBillAccountNo
        {
            get;
            set;
        }
        public string FlatBillShotDesc
        {
            get;
            set;
        }


        public string FlatBillInvoiceNo
        {
            get;
            set;
        }
        public string FlatBillReceiptNo
        {
            get;
            set;
        }
        public string FlatBillFaxNo
        {
            get;
            set;
        }
        public string FlatBillPremiseEmail
        {
            get;
            set;
        }
        public string FlatBillPremiseWebsite
        {
            get;
            set;
        }
        public string TotalAmount
        {
            get;
            set;
        }
        public string TotalTax
        {
            get;
            set;
        }

        public string FlatbillConvertedStatus
        {
            get;
            set;
        }
        public string FlatBillOutStandingBalance
        {
            get;
            set;
        }

        public string FlatBillCurrentPaid
        {
            get;
            set;
        }

        public string ReceiptTemplateCode
        {
            get;
            set;
        }
        public string FlatBillCategory
        {
            get;
            set;
        }
        public FlatBillModel() { }


        public static List<FlatBillModel> FlatBill_getByCustomerIc(string CustomerIC)
        {
            List<FlatBillModel> _Value = new List<FlatBillModel>();

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
                        _SQLCommand.CommandText = "FlatBill_getByCustomerIc";
                        _SQLCommand.Parameters.AddWithValue("@CustomerIC", CustomerIC);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        FlatBillModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new FlatBillModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.FlatBillDesc = _SQLDataReader["FlatBillDesc"].ToString();
                            _result.FlatBillDate = _SQLDataReader["FlatBillDate"].ToString();
                            _result.FlatBillPlatNo = _SQLDataReader["FlatBillPlatNo"].ToString();
                            _result.FlatBillWorkshop = _SQLDataReader["FlatBillWorkshop"].ToString();
                            _result.FlatBillWorkshopID = _SQLDataReader["FlatBillWorkshopID"].ToString();
                            _result.FlatBillIssuedBy = _SQLDataReader["FlatBillIssuedBy"].ToString();
                            _result.FlatBillID = _SQLDataReader["FlatBillID"].ToString();
                            _result.FlatBillTotalAmount = _SQLDataReader["FlatBillTotalAmount"].ToString();
                            _result.FlatBillNumberIC = _SQLDataReader["FlatBillNumberIC"].ToString();
                            _result.FlatBillVehicleModel = _SQLDataReader["FlatBillVehicleModel"].ToString();
                            _result.FlatBillImgLogo = _SQLDataReader["FlatBillImgLogo64"].ToString();
                         
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

        public static List<FlatBillModel> FlatBill_getFlatBill(string CustomerIC,string Status,int Month,int Year,string CloudreceiptAccNo,string PremiseNo)
        {
            List<FlatBillModel> _Value = new List<FlatBillModel>();

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
                        _SQLCommand.CommandText = "FlatBill_getFlatBill";
                        _SQLCommand.Parameters.AddWithValue("@CustomerIC", CustomerIC);
                        _SQLCommand.Parameters.AddWithValue("@Status", Status);
                        _SQLCommand.Parameters.AddWithValue("@Month", Month);
                        _SQLCommand.Parameters.AddWithValue("@Year", Year);
                        _SQLCommand.Parameters.AddWithValue("@CloudreceiptAccNo", CloudreceiptAccNo);
                        _SQLCommand.Parameters.AddWithValue("@PremiseNo", PremiseNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        FlatBillModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new FlatBillModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());                       
                            _result.FlatBillDate = _SQLDataReader["FlatBillDate"].ToString();
                            _result.FlatBillUpdateDate = _SQLDataReader["FlatBillUpdateDate"].ToString();       
                            _result.FlatBillWorkshop = _SQLDataReader["FlatBillWorkshop"].ToString();                     
                            _result.FlatBillIssuedBy = _SQLDataReader["FlatBillIssuedBy"].ToString();
                            _result.FlatBillID = _SQLDataReader["FlatBillID"].ToString();
                            _result.FlatBillTotalAmount = _SQLDataReader["FlatBillTotalAmount"].ToString();
                            _result.FlatBillTax = _SQLDataReader["FlatBillTax"].ToString();
                            _result.FlatBillImgLogo = _SQLDataReader["FlatBillImgLogo64"].ToString();
                            _result.FlatBillCompanyNumber = _SQLDataReader["FlatBillCompanyNumber"].ToString();
                            _result.FlatBillFinalAmount = _SQLDataReader["FlatBillFinalAmount"].ToString();
                            _result.FlatBillCurrentPaid = _SQLDataReader["FlatBillCurrentPaid"].ToString();
                            _result.CloudreceiptAccNo = _SQLDataReader["CloudreceiptAccNo"].ToString();
                            _result.ReceiptTemplateCode = _SQLDataReader["ReceiptTemplateCode"].ToString();
                            _result.FlatBillShotDesc = _SQLDataReader["FlatBillShotDesc"].ToString();
                            _result.FlatBillCategory = _SQLDataReader["FlatBillCategory"].ToString(); 
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



        public static List<FlatBillModel> FlatBill_SearchCloudReceipts(string query)
        {
            List<FlatBillModel> _Value = new List<FlatBillModel>();

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
                        _SQLCommand.CommandText = "FlatBill_SearchCloudReceipts";
                        _SQLCommand.Parameters.AddWithValue("@query", query);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        FlatBillModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new FlatBillModel();

                            _result.TotalAmount = _SQLDataReader["TotalAmount"].ToString();
                            _result.TotalTax = _SQLDataReader["TotalTax"].ToString();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.CloudreceiptAccNo = _SQLDataReader["CloudreceiptAccNo"].ToString();
                            _result.FlatBillDate = _SQLDataReader["FlatBillDate"].ToString();
                            _result.FlatBillWorkshop = _SQLDataReader["FlatBillWorkshop"].ToString();
                            _result.FlatBillStatus = ConvertStatus(_SQLDataReader["FlatBillStatus"].ToString(), query, _SQLDataReader["FlatBillCategory"].ToString());
                            _result.FlatBillPaymentType = _SQLDataReader["FlatBillPaymentType"].ToString();
                            _result.FlatBillShotDesc = _SQLDataReader["FlatBillShotDesc"].ToString();
                            _result.FlatBillID = _SQLDataReader["FlatBillID"].ToString();
                            _result.FlatBillAccountNo = _SQLDataReader["FlatBillAccountNo"].ToString();
                            _result.FlatBillTax = _SQLDataReader["FlatBillTax"].ToString();
                            _result.FlatBillTotalAmount = _SQLDataReader["FlatBillTotalAmount"].ToString();
                            _result.FlatBillFinalAmount = _SQLDataReader["FlatBillFinalAmount"].ToString();
                            _result.FlatBillCurrentPaid = _SQLDataReader["FlatBillCurrentPaid"].ToString();
                            _result.ReceiptTemplateCode = _SQLDataReader["ReceiptTemplateCode"].ToString();
                            _result.FlatBillCategory = _SQLDataReader["FlatBillCategory"].ToString();  
                          //  _result.FlatBillImgLogo = _SQLDataReader["FlatBillImgLogo64"].ToString();                            
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

        public static List<FlatBillModel> FlatBill_getFlatBillDetails(int FlatBillID)
        {
            List<FlatBillModel> _Value = new List<FlatBillModel>();

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
                        _SQLCommand.CommandText = "FlatBill_getFlatBillDetails";
                        _SQLCommand.Parameters.AddWithValue("@FlatBillID", FlatBillID);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        FlatBillModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new FlatBillModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.FlatBillDesc =remove1stChar(_SQLDataReader["FlatBillDesc"].ToString());
                            _result.FlatBillDate = _SQLDataReader["FlatBillDate"].ToString();
                            _result.FlatBillPlatNo = _SQLDataReader["FlatBillPlatNo"].ToString();
                            _result.FlatBillWorkshop = _SQLDataReader["FlatBillWorkshop"].ToString();
                            _result.FlatBillWorkshopID = _SQLDataReader["FlatBillWorkshopID"].ToString();
                            _result.FlatBillIssuedBy = _SQLDataReader["FlatBillIssuedBy"].ToString();
                            _result.FlatBillID = _SQLDataReader["FlatBillID"].ToString();
                            _result.FlatBillTotalAmount = _SQLDataReader["FlatBillTotalAmount"].ToString();
                            _result.FlatBillNumberIC = _SQLDataReader["FlatBillNumberIC"].ToString();
                            _result.FlatBillVehicleModel = _SQLDataReader["FlatBillVehicleModel"].ToString();
                            _result.FlatBillImgLogo = _SQLDataReader["FlatBillImgLogo64"].ToString();


                            _result.FlatBillStatus = _SQLDataReader["FlatBillStatus"].ToString();
                            _result.FlatBillUpdateDate = _SQLDataReader["FlatBillUpdateDate"].ToString();
                            _result.FlatBillUpdateBy = _SQLDataReader["FlatBillUpdateBy"].ToString();
                            _result.CloudreceiptAccNo = _SQLDataReader["CloudreceiptAccNo"].ToString();




                            _result.FlatBillFinalAmount = _SQLDataReader["FlatBillFinalAmount"].ToString();
                            _result.FlatBillTax = _SQLDataReader["FlatBillTax"].ToString();
                            _result.FlatBillBalance = _SQLDataReader["FlatBillBalance"].ToString();
                            _result.FlatBillDeposit = _SQLDataReader["FlatBillDeposit"].ToString();

                            _result.FlatBillMilage = _SQLDataReader["FlatBillMilage"].ToString();
                            _result.FlatBillGSTNo = _SQLDataReader["FlatBillGSTNo"].ToString();
                            _result.FlatBillTaxInvoice = _SQLDataReader["FlatBillTaxInvoice"].ToString();
                            _result.FlatBillBillNo = _SQLDataReader["FlatBillBillNo"].ToString();
                            _result.FlatBillCustomerName = _SQLDataReader["FlatBillCustomerName"].ToString();

                            _result.FlatBillWorkShopAddress = _SQLDataReader["FlatBillWorkShopAddress"].ToString();
                            _result.FlatBillWorkshopPhoneNo = _SQLDataReader["FlatBillWorkshopPhoneNo"].ToString();
                            _result.FlatBillCompanyNumber = _SQLDataReader["FlatBillCompanyNumber"].ToString();
                            _result.FlatBillShotDesc = _SQLDataReader["FlatBillShotDesc"].ToString();

                            _result.FlatBillInvoiceNo = _SQLDataReader["FlatBillInvoiceNo"].ToString();
                            _result.FlatBillReceiptNo = _SQLDataReader["FlatBillReceiptNo"].ToString();
                            _result.FlatBillFaxNo = _SQLDataReader["FlatBillFaxNo"].ToString();
                            _result.FlatBillPremiseEmail = _SQLDataReader["FlatBillPremiseEmail"].ToString();
                            _result.FlatBillPremiseWebsite = _SQLDataReader["FlatBillPremiseWebsite"].ToString();
                            
                            _result.FlatBillAccountNo = _SQLDataReader["FlatBillAccountNo"].ToString();

                            _result.FlatBillPaymentType = _SQLDataReader["FlatBillPaymentType"].ToString();
                            _result.FlatBillOutStandingBalance = _SQLDataReader["FlatBillOutStandingBalance"].ToString();
                            _result.FlatBillCurrentPaid = _SQLDataReader["FlatBillCurrentPaid"].ToString();
                            _result.FlatBillCategory = _SQLDataReader["FlatBillCategory"].ToString();  
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








        public static bool FlatBill_UpdateFlatBillStatus(int FlatBillID, string FlatBillUpdateBy, string FlatBillStatus)
        {
        
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
                        _SQLCommand.CommandText = "FlatBill_UpdateFlatBillStatus";
                        _SQLCommand.Parameters.AddWithValue("@FlatBillID", FlatBillID);
                        _SQLCommand.Parameters.AddWithValue("@FlatBillUpdateBy", FlatBillUpdateBy);
                        _SQLCommand.Parameters.AddWithValue("@FlatBillStatus", FlatBillStatus);
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




        public static bool FlatBill_UpdateFlatBillCategory(int FlatBillID, string FlatBillUpdateBy, string FlatBillCategory,int ID)
        {

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
                        _SQLCommand.CommandText = "FlatBill_UpdateFlatBillCategory";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@FlatBillID", FlatBillID);
                        _SQLCommand.Parameters.AddWithValue("@FlatBillUpdateBy", FlatBillUpdateBy);
                        _SQLCommand.Parameters.AddWithValue("@FlatBillCategory", FlatBillCategory);
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






        public static string remove1stChar (string str)
        {


         
           
            if (str.StartsWith(","))
            {
                str = str.Substring(1);
                
            }


            return str;
            
            
           


        }



        public static string ConvertStatus(string status,string creteria,string category)
        {
            string convertedstatus = "<div class=blink_me style='background-color: #f44336; color: white; padding: 5px 5px;text-align: center; text-decoration: none;font-size: 12px;margin: 0px 0px -20px 250px;cursor: pointer;width:100px;' >" + category + "</div>";
            bool containsFlatBillStatus = Regex.IsMatch(creteria, @"\bFlatBillStatus\b");
            bool containsFlatBillCategory = Regex.IsMatch(creteria, @"\bFlatBillCategory\b");
            if (containsFlatBillStatus == true)
            {
                if (status == "1")
                {
                    //convertedstatus = "Confirm";
                    convertedstatus = "<div style='background-color: #26ade4; color: white; padding: 5px 5px;text-align: center; text-decoration: none;font-size: 12px;margin: 0px 0px -20px 250px;cursor: pointer;width:100px;'>Confirm</div>";
                }
                else if (status == "2")
                {
                    //convertedstatus = "New";
                    convertedstatus = "<div class=blink_me style='background-color: #f44336; color: white; padding: 5px 5px;text-align: center; text-decoration: none;font-size: 12px;margin: 0px 0px -20px 250px;cursor: pointer;width:100px;' >New</div>";
                }
                else if (status == "3")
                {
                    //  convertedstatus = "Void";
                    convertedstatus = "<div style='background-color: #D25959; color: white; padding: 5px 5px;text-align: center; text-decoration: none;font-size: 12px;margin: 0px 0px -20px 250px;cursor: pointer;width:100px;' >Void</div>";
                }
                else
                {
                    convertedstatus = "Unknown";
                }
               
            }

            if (containsFlatBillCategory == true)
            {

                convertedstatus = "<div class=blink_me style='background-color: #f44336; color: white; padding: 5px 5px;text-align: center; text-decoration: none;font-size: 12px;margin: 0px 0px -20px 250px;cursor: pointer;width:100px;' >" + category + "</div>";
              

            }


            return convertedstatus;





            
        }
    }
}