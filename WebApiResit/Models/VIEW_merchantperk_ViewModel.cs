using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
namespace WebApiResit.Models
{
    public class VIEW_merchantperk_ViewModel
    {


        public string ItemType
        {
            get;
            set;
        }
        public string PrimaryCode
        {
            get;
            set;
        }


        public string SecondaryCode
        {
            get;
            set;
        }


        public string Name
        {
            get;
            set;
        }
        public string ImagePath
        {
            get;
            set;
        }

        public string Amount
        {
            get;
            set;
        }

        public string Percentage
        {
            get;
            set;
        }


        public string Points
        {
            get;
            set;
        }




        public string Fees
        {
            get;
            set;
        }





        public string Description
        {
            get;
            set;
        }


        public string Terms
        {
            get;
            set;
        }

        public string EventType
        {
            get;
            set;
        }

        public string StartDate
        {
            get;
            set;
        }
        public string StartTime
        {
            get;
            set;
        }

        public string EndDate
        {
            get;
            set;
        }
        public string EndTime
        {
            get;
            set;
        }
        public string IsEndDateRequired
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
        public string Status
        {
            get;
            set;
        }


        public string CreatedDate
        {
            get;
            set;
        }

        public string EnterpriseLogo
        {
            get;
            set;
        }

        public string EnterpriseName
        {
            get;
            set;
        }
        public string EnterpriseTagLine
        {
            get;
            set;
        }

        public string EnterpriseCountStar
        {
            get;
            set;
        }

        public string TotalReviewer
        {
            get;
            set;
        }

       public string BusinessMode
        {
            get;
            set;
        }

         public string EnterpriseDescription
        {
            get;
            set;
        }
         public string SearchCol
        {
            get;
            set;
        }
         public string SubscriberAccNo
        {
            get;
            set;
        }

        public string TodayCheckInCount
        {
            get;
            set;
        }
        public string EnterpriseAddress
        {
            get;
            set;
        }


        public VIEW_merchantperk_ViewModel() { }




        public static List<VIEW_merchantperk_ViewModel> VIEW_merchantperk_View()
        {
            List<VIEW_merchantperk_ViewModel> _Value = new List<VIEW_merchantperk_ViewModel>();

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
                        _SQLCommand.CommandText = "VIEW_merchantperk_View";
                       // _SQLCommand.Parameters.AddWithValue("@eWalletAccNo", eWalletAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        VIEW_merchantperk_ViewModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new VIEW_merchantperk_ViewModel();
                            _result.ItemType = _SQLDataReader["ItemType"].ToString();
                            _result.PrimaryCode = _SQLDataReader["PrimaryCode"].ToString();
                            _result.SecondaryCode = _SQLDataReader["SecondaryCode"].ToString();
                            _result.Name = _SQLDataReader["Name"].ToString();
                            _result.ImagePath = _SQLDataReader["ImagePath"].ToString();
                            _result.Amount = _SQLDataReader["Amount"].ToString();
                            _result.Percentage = _SQLDataReader["Percentage"].ToString();
                            _result.Points = _SQLDataReader["Points"].ToString();
                            _result.Fees = _SQLDataReader["Fees"].ToString();
                            _result.Description = _SQLDataReader["Description"].ToString();
                            _result.Terms = _SQLDataReader["Terms"].ToString();
                            _result.EventType = _SQLDataReader["EventType"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.StartDate = _SQLDataReader["StartDate"].ToString();
                            _result.StartTime = _SQLDataReader["StartTime"].ToString();
                          //  _result.EndDate = _SQLDataReader["EndDate"].ToString();
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.EndTime = _SQLDataReader["EndTime"].ToString();
                            _result.IsEndDateRequired = _SQLDataReader["IsEndDateRequired"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.Status = _SQLDataReader["Status"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.EnterpriseCountStar = _SQLDataReader["EnterpriseCountStar"].ToString();
                            _result.TotalReviewer = _SQLDataReader["TotalReviewer"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.EnterpriseDescription = _SQLDataReader["EnterpriseDescription"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();                        
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




        public static List<VIEW_merchantperk_ViewModel> VIEW_merchantperk_View_LoadbySubscriberAccNo(string SubscriberAccNo)
        {
            List<VIEW_merchantperk_ViewModel> _Value = new List<VIEW_merchantperk_ViewModel>();

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
                        _SQLCommand.CommandText = "VIEW_merchantperk_View_LoadbySubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        VIEW_merchantperk_ViewModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new VIEW_merchantperk_ViewModel();
                            _result.ItemType = _SQLDataReader["ItemType"].ToString();
                            _result.PrimaryCode = _SQLDataReader["PrimaryCode"].ToString();
                            _result.SecondaryCode = _SQLDataReader["SecondaryCode"].ToString();
                            _result.Name = _SQLDataReader["Name"].ToString();
                            _result.ImagePath = _SQLDataReader["ImagePath"].ToString();
                            _result.Amount = _SQLDataReader["Amount"].ToString();
                            _result.Percentage = _SQLDataReader["Percentage"].ToString();
                            _result.Points = _SQLDataReader["Points"].ToString();
                            _result.Fees = _SQLDataReader["Fees"].ToString();
                            _result.Description = _SQLDataReader["Description"].ToString();
                            _result.Terms = _SQLDataReader["Terms"].ToString();
                            _result.EventType = _SQLDataReader["EventType"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.StartDate = _SQLDataReader["StartDate"].ToString();
                            _result.StartTime = _SQLDataReader["StartTime"].ToString();
                            //  _result.EndDate = _SQLDataReader["EndDate"].ToString();
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.EndTime = _SQLDataReader["EndTime"].ToString();
                            _result.IsEndDateRequired = _SQLDataReader["IsEndDateRequired"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.Status = _SQLDataReader["Status"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.EnterpriseCountStar = _SQLDataReader["EnterpriseCountStar"].ToString();
                            _result.TotalReviewer = _SQLDataReader["TotalReviewer"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.EnterpriseDescription = _SQLDataReader["EnterpriseDescription"].ToString();
                            _result.SearchCol = _SQLDataReader["EventType"].ToString()+'|'+_SQLDataReader["EnterpriseName"].ToString()+'|'+_SQLDataReader["EnterpriseName"].ToString()+'|'+_SQLDataReader["Description"].ToString();
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







        public static List<VIEW_merchantperk_ViewModel> VIEW_merchantperk_View_DashboardInitialLoad(string SubscriberAccNo)
        {
            List<VIEW_merchantperk_ViewModel> _Value = new List<VIEW_merchantperk_ViewModel>();

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
                        _SQLCommand.CommandText = "VIEW_merchantperk_View_DashboardInitialLoad";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        VIEW_merchantperk_ViewModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new VIEW_merchantperk_ViewModel();
                            _result.ItemType = _SQLDataReader["ItemType"].ToString();
                            _result.PrimaryCode = _SQLDataReader["PrimaryCode"].ToString();
                            _result.SecondaryCode = _SQLDataReader["SecondaryCode"].ToString();
                            _result.Name = _SQLDataReader["Name"].ToString();
                            _result.ImagePath = _SQLDataReader["ImagePath"].ToString();
                            _result.Amount = _SQLDataReader["Amount"].ToString();
                            _result.Percentage = _SQLDataReader["Percentage"].ToString();
                            _result.Points = _SQLDataReader["Points"].ToString();
                            _result.Fees = _SQLDataReader["Fees"].ToString();
                            _result.Description = _SQLDataReader["Description"].ToString();
                            _result.Terms = _SQLDataReader["Terms"].ToString();
                            _result.EventType = _SQLDataReader["EventType"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.StartDate = _SQLDataReader["StartDate"].ToString();
                            _result.StartTime = _SQLDataReader["StartTime"].ToString();
                            //  _result.EndDate = _SQLDataReader["EndDate"].ToString();
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.EndTime = _SQLDataReader["EndTime"].ToString();
                            _result.IsEndDateRequired = _SQLDataReader["IsEndDateRequired"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.Status = _SQLDataReader["Status"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.EnterpriseCountStar = _SQLDataReader["EnterpriseCountStar"].ToString();
                            _result.TotalReviewer = _SQLDataReader["TotalReviewer"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.EnterpriseDescription = _SQLDataReader["EnterpriseDescription"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
                            _result.TodayCheckInCount = _SQLDataReader["TodayCheckInCount"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
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





        public static List<VIEW_merchantperk_ViewModel> VIEW_merchantperk_View_DashboardLoadByEnterpriseAccNo(string SubscriberAccNo,string EnterpriseAccNo)
        {
            List<VIEW_merchantperk_ViewModel> _Value = new List<VIEW_merchantperk_ViewModel>();

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
                        _SQLCommand.CommandText = "VIEW_merchantperk_View_DashboardLoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        VIEW_merchantperk_ViewModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new VIEW_merchantperk_ViewModel();
                            _result.ItemType = _SQLDataReader["ItemType"].ToString();
                            _result.PrimaryCode = _SQLDataReader["PrimaryCode"].ToString();
                            _result.SecondaryCode = _SQLDataReader["SecondaryCode"].ToString();
                            _result.Name = _SQLDataReader["Name"].ToString();
                            _result.ImagePath = _SQLDataReader["ImagePath"].ToString();
                            _result.Amount = _SQLDataReader["Amount"].ToString();
                            _result.Percentage = _SQLDataReader["Percentage"].ToString();
                            _result.Points = _SQLDataReader["Points"].ToString();
                            _result.Fees = _SQLDataReader["Fees"].ToString();
                            _result.Description = _SQLDataReader["Description"].ToString();
                            _result.Terms = _SQLDataReader["Terms"].ToString();
                            _result.EventType = _SQLDataReader["EventType"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.StartDate = _SQLDataReader["StartDate"].ToString();
                            _result.StartTime = _SQLDataReader["StartTime"].ToString();
                            //  _result.EndDate = _SQLDataReader["EndDate"].ToString();
                            _result.EndDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["EndDate"]);
                            _result.EndTime = _SQLDataReader["EndTime"].ToString();
                            _result.IsEndDateRequired = _SQLDataReader["IsEndDateRequired"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.MembershipCardCode = _SQLDataReader["MembershipCardCode"].ToString();
                            _result.Status = _SQLDataReader["Status"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.EnterpriseLogo = _SQLDataReader["EnterpriseLogo"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.EnterpriseCountStar = _SQLDataReader["EnterpriseCountStar"].ToString();
                            _result.TotalReviewer = _SQLDataReader["TotalReviewer"].ToString();
                            _result.BusinessMode = _SQLDataReader["BusinessMode"].ToString();
                            _result.EnterpriseDescription = _SQLDataReader["EnterpriseDescription"].ToString();
                            _result.SearchCol = _SQLDataReader["SearchCol"].ToString();
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