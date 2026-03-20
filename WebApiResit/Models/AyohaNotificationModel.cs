using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaNotificationModel
    {
        public int ID
        {
            get;
            set;
        }

        public string NotificationCode
        {
            get;
            set;
        }
        public string SubscriberAccNo
        {
            get;
            set;
        }
        public string AccountName
        {
            get;
            set;
        }
        public string IsRead
        {
            get;
            set;
        }
        public string ReadDate
        {
            get;
            set;
        }
        public string PlayerID
        {
            get;
            set;
        }


        public string EnterpriseRowStatus
        {
            get;
            set;
        }
        public string SentDate
        {
            get;
            set;
        }
        public string UserRowStatus
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

        public string MobilePhoneNo
        {
            get;
            set;
        }
        public string Counts
        {
            get;
            set;
        }

        public string SendStatus
        {
            get;
            set;
        }
        public int RowNumber
        {
            get;
            set;
        }

        public string NotificationTitle
        {
            get;
            set;
        }
        public string NotificationBody
        {
            get;
            set;
        }


        public string NotifcationImage
        {
            get;
            set;
        }
        public string NotificationFooterImage
        {
            get;
            set;
        }
      
       
        public string NotificationType
        {
            get;
            set;
        }

        public string NotificationMedium
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

        public string EnterpriseAddress
        {
            get;
            set;
        }
         public string EnterprisePhoneNo
        {
            get;
            set;
        }
      
       
        public string EnterpriseWebsite
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
        public string EnterpriseTagLine
        {
            get;
            set;
        }

        public string AdvertisementCode
        {
            get;
            set;
        }
        

        public AyohaNotificationModel() { }




        public static List<AyohaNotificationModel> AyohaNotification_LoadByNotificationCode(string NotificationCode, string EnterpriseAccNo)
        {
            List<AyohaNotificationModel> _Value = new List<AyohaNotificationModel>();

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
                        _SQLCommand.CommandText = "AyohaNotification_LoadByNotificationCode";
                        _SQLCommand.Parameters.AddWithValue("@NotificationCode", NotificationCode);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaNotificationModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaNotificationModel();

                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.IsRead = _SQLDataReader["isRead"].ToString();
                            _result.ReadDate = _SQLDataReader["ReadDate"].ToString();
                            _result.RowNumber =Convert.ToInt32(_SQLDataReader["RowNumber"].ToString());

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










        public static List<AyohaNotificationModel> AyohaNotification_LoadBySubscriberAccNo(string SubscriberAccNo)
        {
            List<AyohaNotificationModel> _Value = new List<AyohaNotificationModel>();

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
                        _SQLCommand.CommandText = "AyohaNotification_LoadBySubscriberAccNo";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaNotificationModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AyohaNotificationModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.NotificationCode = _SQLDataReader["NotificationCode"].ToString();
                            _result.NotificationTitle = _SQLDataReader["NotificationTitle"].ToString();
                            _result.NotificationBody = _SQLDataReader["NotificationBody"].ToString();
                            _result.NotifcationImage = _SQLDataReader["NotifcationImage"].ToString();
                            _result.NotificationFooterImage = _SQLDataReader["NotificationFooterImage"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.NotificationType = _SQLDataReader["NotificationType"].ToString();
                            _result.NotificationMedium = _SQLDataReader["NotificationMedium"].ToString();
                            _result.SentDate = _SQLDataReader["SentDate"].ToString();
                            _result.SendStatus = _SQLDataReader["SendStatus"].ToString();
                            _result.EnterpriseName = _SQLDataReader["EnterpriseName"].ToString();
                            _result.EnterpriseLogoPath = _SQLDataReader["EnterpriseLogoPath"].ToString();
                            _result.IsRead = _SQLDataReader["IsRead"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
                            _result.EnterpriseFacebook = _SQLDataReader["EnterpriseFacebook"].ToString();
                            _result.EnterpriseTwiter = _SQLDataReader["EnterpriseTwiter"].ToString();
                            _result.EnterpriseInstagram = _SQLDataReader["EnterpriseInstagram"].ToString();
                            _result.EnterpriseCoordinate = _SQLDataReader["EnterpriseCoordinate"].ToString();
                            _result.EnterpriseTagLine = _SQLDataReader["EnterpriseTagLine"].ToString();
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();                            
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









        public static string AyohaNotification_IsReadUpdate(string SubscriberAccNo, int ID, string IsRead)
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
                        _SQLCommand.CommandText = "AyohaNotification_IsReadUpdate";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@IsRead", IsRead);
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










        public static string AyohaNotification_UserRowStatusUpdate(string SubscriberAccNo, int ID, string UserRowStatus)
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
                        _SQLCommand.CommandText = "AyohaNotification_UserRowStatusUpdate";
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", UserRowStatus);
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

    }
}