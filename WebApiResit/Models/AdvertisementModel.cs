using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AdvertisementModel
    {


        public int ID
        {
            get;
            set;
        }

        public string AdvertisementCode
        {
            get;
            set;
        }
        public string AdvertisementTitle
        {
            get;
            set;
        }
        public string AdvertisementDesc
        {
            get;
            set;
        }
        public string AdvertisementImg
        {
            get;
            set;
        }
        public string AdvertisementImgName
        {
            get;
            set;
        }
        public string AdvertisementStartDate
        {
            get;
            set;
        }
        public string AdvertisementEndDate
        {
            get;
            set;
        }

        public string AdvertisementType
        {
            get;
            set;
        }
        public string AdvertisementStatus
        {
            get;
            set;
        }
        public string AdvertisementNote
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string EnterpriseHQAccNo
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
        public string ModifiedRemarks
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }
        public int AdvertisementPeriod
        {
            get;
            set;
        }
        public decimal AdvertisementFees
        {
            get;
            set;
        }

        public string AdvertisementMedia
        {
            get;
            set;
        }

        public string AdvertisementStartDateOnly
        {
            get;
            set;
        }

        public string AdvertisementEndDateOnly
        {
            get;
            set;
        }
        public string Submitted
        {
            get;
            set;
        }

        public string Approved
        {
            get;
            set;
        }

        public string Rejected
        {
            get;
            set;
        }

        public string Published
        {
            get;
            set;
        }



        public string AdvertismentMediaUrl
        {
            get;
            set;
        }

        public string AdvertismentMediaNote
        {
            get;
            set;
        }
        public string MediaType
        {
            get;
            set;
        }
        public string MediaFileName
        {
            get;
            set;
        }
            public string EnterpriseName
        {
            get;
            set;
        }

        public string EnterpriseLogoPath
        {
            get;
            set;
        }

        public string EnterpriseEmail
        {
            get;
            set;
        }



        public string EnterpriseFacebook
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
        public string EnterpriseTwiter
        {
            get;
            set;
        }
        


          public string EnterpriseWebsite
        {
            get;
            set;
        }
        public string PICContactNo
        {
            get;
            set;
        }
        public string RowNum
        {
            get;
            set;
        }


        public string SocialMediaLink
        {
            get;
            set;
        }

        public string DiscountText
        {
            get;
            set;
        }


        public string NormalPrice
        {
            get;
            set;
        }

        public string MemberPrice
        {
            get;
            set;
        }





        public string AverageRating
        {
            get;
            set;
        }

        public string TotalReviews
        {
            get;
            set;
        }
        public string EnterpriseAddress
        {
            get;
            set;
        }



        public string TodayCheckInCount
        {
            get;
            set;
        }
        
        public AdvertisementModel() { }

             


        public static string Advertisement_InsertUpdate(int ID, string AdvertisementCode, string AdvertisementTitle, string AdvertisementDesc, string AdvertisementStartDate, string AdvertisementEndDate, string AdvertisementType, string AdvertisementStatus,
            string AdvertisementNote, string EnterpriseAccNo, string EnterpriseHQAccNo, string CreatedBy, string ModifiedRemarks, string RowStatus, int AdvertisementPeriod, decimal AdvertisementFees, string AdvertisementMedia)
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
                        _SQLCommand.CommandText = "Advertisement_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementTitle", AdvertisementTitle);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementDesc", AdvertisementDesc);
                        //_SQLCommand.Parameters.AddWithValue("@AdvertisementImg", AdvertisementImg);
                        //_SQLCommand.Parameters.AddWithValue("@AdvertisementImgName", AdvertisementImgName);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementStartDate",  String.Format("{0:yyyy-MM-dd}",AdvertisementStartDate));
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementEndDate", String.Format("{0:yyyy-MM-dd}",AdvertisementEndDate));
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementType", AdvertisementType);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementStatus", AdvertisementStatus);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementNote", AdvertisementNote);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);

                       // _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        //_SQLCommand.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                        //_SQLCommand.Parameters.AddWithValue("@ModifiedBy", ModifiedBy);
                        //_SQLCommand.Parameters.AddWithValue("@ModifiedDate", ModifiedDate);
                        _SQLCommand.Parameters.AddWithValue("@ModifiedRemarks", ModifiedRemarks);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementPeriod", AdvertisementPeriod);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementFees", AdvertisementFees);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementMedia", AdvertisementMedia);

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


        public static List<AdvertisementModel> Advertisement_loadByEnterpriseHQAccNo(string EnterpriseHQAccNo)
        {
            List<AdvertisementModel> _Value = new List<AdvertisementModel>();

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
                        _SQLCommand.CommandText = "Advertisement_loadByEnterpriseHQAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            _result.AdvertisementDesc = _SQLDataReader["AdvertisementDesc"].ToString();
                            //_result.AdvertisementImg = _SQLDataReader["AdvertisementImg"].ToString();
                            //_result.AdvertisementImgName = _SQLDataReader["AdvertisementImgName"].ToString();
                            _result.AdvertisementStartDate = _SQLDataReader["AdvertisementStartDate"].ToString();
                            _result.AdvertisementEndDate = _SQLDataReader["AdvertisementEndDate"].ToString();
                            _result.AdvertisementStartDateOnly = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["AdvertisementStartDate"]);
                            _result.AdvertisementEndDateOnly = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["AdvertisementEndDate"]);
                            _result.AdvertisementType = _SQLDataReader["AdvertisementType"].ToString();
                            _result.AdvertisementStatus = _SQLDataReader["AdvertisementStatus"].ToString();
                            _result.AdvertisementNote = _SQLDataReader["AdvertisementNote"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedRemarks = _SQLDataReader["ModifiedRemarks"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.AdvertisementPeriod = Convert.ToInt32(_SQLDataReader["AdvertisementPeriod"].ToString());
                            _result.AdvertisementFees = Convert.ToDecimal(_SQLDataReader["AdvertisementFees"].ToString());
                            _result.AdvertisementMedia = _SQLDataReader["AdvertisementMedia"].ToString();
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



        public static List<AdvertisementModel> Advertisement_DashboardCountByEnterpriseHQAccNo(string EnterpriseHQAccNo)
        {
            List<AdvertisementModel> _Value = new List<AdvertisementModel>();

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
                        _SQLCommand.CommandText = "Advertisement_DashboardCountByEnterpriseHQAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementModel();
                            _result.Submitted = _SQLDataReader["Submitted"].ToString();
                            _result.Approved = _SQLDataReader["Approved"].ToString();
                            _result.Rejected = _SQLDataReader["Rejected"].ToString();
                            _result.Published = _SQLDataReader["Published"].ToString();
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


        public static List<AdvertisementModel> Advertisement_loadByApprovedAdvertisementStartDateEndDate(string ApprovedAdvertisementStartDate, string ApprovedAdvertisementEndDate)
        {
            List<AdvertisementModel> _Value = new List<AdvertisementModel>();

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
                        _SQLCommand.CommandText = "Advertisement_loadByApprovedAdvertisementStartDateEndDate";
                        _SQLCommand.Parameters.AddWithValue("@ApprovedAdvertisementStartDate", ApprovedAdvertisementStartDate);
                        _SQLCommand.Parameters.AddWithValue("@ApprovedAdvertisementEndDate", ApprovedAdvertisementEndDate);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            _result.AdvertisementDesc = _SQLDataReader["AdvertisementDesc"].ToString();
                            //_result.AdvertisementImg = _SQLDataReader["AdvertisementImg"].ToString();
                            //_result.AdvertisementImgName = _SQLDataReader["AdvertisementImgName"].ToString();
                            _result.AdvertisementStartDate = _SQLDataReader["AdvertisementStartDate"].ToString();
                            _result.AdvertisementEndDate = _SQLDataReader["AdvertisementEndDate"].ToString();
                            _result.AdvertisementStartDateOnly = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["AdvertisementStartDate"]);
                            _result.AdvertisementEndDateOnly = String.Format("{0:yyyy-MM-dd}", _SQLDataReader["AdvertisementEndDate"]);
                            _result.AdvertisementType = _SQLDataReader["AdvertisementType"].ToString();
                            _result.AdvertisementStatus = _SQLDataReader["AdvertisementStatus"].ToString();
                            _result.AdvertisementNote = _SQLDataReader["AdvertisementNote"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedRemarks = _SQLDataReader["ModifiedRemarks"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.AdvertisementPeriod = Convert.ToInt32(_SQLDataReader["AdvertisementPeriod"].ToString());
                            _result.AdvertisementFees = Convert.ToDecimal(_SQLDataReader["AdvertisementFees"].ToString());
                            _result.AdvertisementMedia = _SQLDataReader["AdvertisementMedia"].ToString();
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







        public static string Advertisement_Delete(int ID, string AdvertisementCode, string CreatedBy, string EnterpriseHQAccNo, string EnterpriseAccNo, string ModifiedRemarks)
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
                        _SQLCommand.CommandText = "Advertisement_Delete";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ModifiedRemarks", ModifiedRemarks);

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









        public static List<AdvertisementModel> Advertisement_loadMedia(string AdvertisementCode, string EnterpriseHQAccNo)
        {
            List<AdvertisementModel> _Value = new List<AdvertisementModel>();

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
                        _SQLCommand.CommandText = "Advertisement_loadMedia";
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AdvertismentMediaUrl = _SQLDataReader["AdvertismentMediaUrl"].ToString();
                            _result.AdvertismentMediaNote = _SQLDataReader["AdvertismentMediaNote"].ToString();
                            _result.MediaType = _SQLDataReader["MediaType"].ToString();
                            
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




        public static List<AdvertisementModel> Advertisement_loadMedia_Preview(string AdvertisementCode, string EnterpriseHQAccNo)
        {
            List<AdvertisementModel> _Value = new List<AdvertisementModel>();

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
                        _SQLCommand.CommandText = "Advertisement_loadMedia_Preview";
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementModel();
                            _result.AdvertismentMediaUrl = _SQLDataReader["AdvertismentMediaUrl"].ToString();
                            _result.AdvertismentMediaNote = _SQLDataReader["AdvertismentMediaNote"].ToString();
                            _result.MediaType = _SQLDataReader["MediaType"].ToString();
                            _result.MediaFileName = _SQLDataReader["MediaFileName"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            
                            

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






        public static List<AdvertisementModel> Advertisement_loadMedia_AyohaUserDashboard(string AdvertisementCode)
        {
            List<AdvertisementModel> _Value = new List<AdvertisementModel>();

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
                        _SQLCommand.CommandText = "Advertisement_loadMedia_AyohaUserDashboard";
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementModel();
                            _result.AdvertismentMediaUrl = _SQLDataReader["AdvertismentMediaUrl"].ToString();
                            _result.AdvertismentMediaNote = _SQLDataReader["AdvertismentMediaNote"].ToString();
                            _result.MediaType = _SQLDataReader["MediaType"].ToString();
                            _result.MediaFileName = _SQLDataReader["MediaFileName"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.SocialMediaLink = _SQLDataReader["SocialMediaLink"].ToString();


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









        public static List<AdvertisementModel> Advertisement_loadMedia_AdvertisementVIA()
        {
            List<AdvertisementModel> _Value = new List<AdvertisementModel>();

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
                        _SQLCommand.CommandText = "Advertisement_loadMedia_AdvertisementVIA";

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementModel();
                            _result.AdvertismentMediaUrl = _SQLDataReader["AdvertismentMediaUrl"].ToString();
                            _result.AdvertismentMediaNote = _SQLDataReader["AdvertismentMediaNote"].ToString();
                            _result.MediaType = _SQLDataReader["MediaType"].ToString();
                            _result.MediaFileName = _SQLDataReader["MediaFileName"].ToString();
                                    _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                               _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                                         _result.AdvertisementEndDate = _SQLDataReader["AdvertisementEndDate"].ToString();
                               _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                               _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                               _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                               _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                                         _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                                               _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                                               _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                               _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                                         _result.PICContactNo = _SQLDataReader["PICContactNo"].ToString();
                                         _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                                         _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();                                           
                                                
                                                    


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




        public static List<AdvertisementModel> Advertisement_load_HotSeat()
        {
            List<AdvertisementModel> _Value = new List<AdvertisementModel>();

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
                        _SQLCommand.CommandText = "Advertisement_load_HotSeat";

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementModel();
                            _result.AdvertismentMediaUrl = _SQLDataReader["AdvertismentMediaUrl"].ToString();
                            _result.AdvertismentMediaNote = _SQLDataReader["AdvertismentMediaNote"].ToString();
                            _result.MediaType = _SQLDataReader["MediaType"].ToString();
                            _result.MediaFileName = _SQLDataReader["MediaFileName"].ToString();
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.RowNum = _SQLDataReader["RowNum"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            





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


        public static List<AdvertisementModel> Advertisement_load_Premium_Advertisment(string SubscriberAccNo)
        {
            List<AdvertisementModel> _Value = new List<AdvertisementModel>();

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
                        _SQLCommand.CommandText = "Advertisement_load_Premium_Advertisment";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementModel();
                            _result.AdvertismentMediaUrl = _SQLDataReader["AdvertismentMediaUrl"].ToString();
                            _result.AdvertismentMediaNote = _SQLDataReader["AdvertismentMediaNote"].ToString();
                            _result.MediaType = _SQLDataReader["MediaType"].ToString();
                            _result.MediaFileName = _SQLDataReader["MediaFileName"].ToString();
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.RowNum = _SQLDataReader["RowNum"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.DiscountText = _SQLDataReader["DiscountText"].ToString();
                            _result.NormalPrice = _SQLDataReader["NormalPrice"].ToString();
                            _result.MemberPrice = _SQLDataReader["MemberPrice"].ToString();

                            _result.AverageRating = _SQLDataReader["AverageRating"].ToString();
                            _result.TotalReviews = _SQLDataReader["TotalReviews"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.TodayCheckInCount = _SQLDataReader["TodayCheckInCount"].ToString();
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



        public static List<AdvertisementModel> Advertisement_load_Floating()
        {
            List<AdvertisementModel> _Value = new List<AdvertisementModel>();

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
                        _SQLCommand.CommandText = "Advertisement_load_Floating";

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementModel();
                            _result.AdvertismentMediaUrl = _SQLDataReader["AdvertismentMediaUrl"].ToString();
                            _result.AdvertismentMediaNote = _SQLDataReader["AdvertismentMediaNote"].ToString();
                            _result.MediaType = _SQLDataReader["MediaType"].ToString();
                            _result.MediaFileName = _SQLDataReader["MediaFileName"].ToString();
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.RowNum = _SQLDataReader["RowNum"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();






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




        public static List<AdvertisementModel> Advertisement_load_Standard()
        {
            List<AdvertisementModel> _Value = new List<AdvertisementModel>();

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
                        _SQLCommand.CommandText = "Advertisement_load_Standard";

                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementModel();
                            _result.AdvertismentMediaUrl = _SQLDataReader["AdvertismentMediaUrl"].ToString();
                            _result.AdvertismentMediaNote = _SQLDataReader["AdvertismentMediaNote"].ToString();
                            _result.MediaType = _SQLDataReader["MediaType"].ToString();
                            _result.MediaFileName = _SQLDataReader["MediaFileName"].ToString();
                            _result.AdvertisementTitle = _SQLDataReader["AdvertisementTitle"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.RowNum = _SQLDataReader["RowNum"].ToString();






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