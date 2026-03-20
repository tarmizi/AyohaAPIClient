using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class NotificationsModel
    {

        public int ID
        {
            get;
            set;
        }
        public string Notification
        {
            get;
            set;
        }
        public string NotificationDate
        {
            get;
            set;
        }
        public string SentFrom
        {
            get;
            set;
        }
        public string Logo64
        {
            get;
            set;
        }
        public string PaymentType
        {
            get;
            set;
        }
        public string AccountNo
        {
            get;
            set;
        }

        public string FlatBillAccountNo
        {
            get;
            set;
        }

        public string TotalPaid
        {
            get;
            set;
        }

        public string NotificationType
        {
            get;
            set;
        }
        public string NotificationTitle
        {
            get;
            set;
        }

        public string FlatbilliD
        {
            get;
            set;
        }

        public string NotificationReadDate
        {
            get;
            set;
        }

        public string NotificationCode
        {
            get;
            set;
        }

        public string ReceiptTemplateCode
        {
            get;
            set;
        }
        
        public string AdvertisementImage
        {

            get;
            set;
        }

        public string EnterpriseAddress
        {

            get;
            set;
        }
         public string EnterpriseEmail
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
          public string SearchCol
          {

              get;
              set;
          }                   
                                
        public NotificationsModel() { }




        public static List<NotificationsModel> Notifications_LoadNotifications(string CR_MykadNo, string CR_AccountNo)
        {
            List<NotificationsModel> _Value = new List<NotificationsModel>();
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
                        _SQLCommand.CommandText = "Notifications_LoadNotifications";
                        _SQLCommand.Parameters.AddWithValue("@CR_MykadNo", CR_MykadNo);
                        _SQLCommand.Parameters.AddWithValue("@CR_AccountNo", CR_AccountNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        NotificationsModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new NotificationsModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            //_result.Notification = _SQLDataReader["Notification"].ToString();
                            _result.NotificationDate = _SQLDataReader["NotificationDate"].ToString();
                            _result.SentFrom = _SQLDataReader["SentFrom"].ToString();
                            _result.Logo64 = _SQLDataReader["Logo64"].ToString();
                            //_result.PaymentType = _SQLDataReader["PaymentType"].ToString();
                            //_result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            //_result.FlatBillAccountNo = _SQLDataReader["FlatBillAccountNo"].ToString();
                            //_result.TotalPaid = _SQLDataReader["TotalPaid"].ToString();
                            _result.NotificationType = _SQLDataReader["NotificationType"].ToString();
                            _result.NotificationTitle = _SQLDataReader["NotificationTitle"].ToString();
                            _result.FlatbilliD = _SQLDataReader["FlatbilliD"].ToString();
                                _result.NotificationCode = _SQLDataReader["NotificationCode"].ToString();
                                _result.ReceiptTemplateCode = _SQLDataReader["ReceiptTemplateCode"].ToString();
                            
                                

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




        public static List<NotificationsModel> Notifications_CountNotificationsTypeNN(string CR_MykadNo, string CR_AccountNo)
        {
            List<NotificationsModel> _Value = new List<NotificationsModel>();
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
                        _SQLCommand.CommandText = "Notifications_CountNotificationsTypeNN";
                        _SQLCommand.Parameters.AddWithValue("@CR_MykadNo", CR_MykadNo);
                        _SQLCommand.Parameters.AddWithValue("@CR_AccountNo", CR_AccountNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        NotificationsModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new NotificationsModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                           


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


        public static List<NotificationsModel> Notifications_CountNotificationsTypeR(string CR_MykadNo, string CR_AccountNo)
        {
            List<NotificationsModel> _Value = new List<NotificationsModel>();
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
                        _SQLCommand.CommandText = "Notifications_CountNotificationsTypeR";
                        _SQLCommand.Parameters.AddWithValue("@CR_MykadNo", CR_MykadNo);
                        _SQLCommand.Parameters.AddWithValue("@CR_AccountNo", CR_AccountNo);


                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        NotificationsModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new NotificationsModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());



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
        public static List<NotificationsModel> Notifications_LoadNotifications_TypeN(string CR_MykadNo,int ID)
        {
            List<NotificationsModel> _Value = new List<NotificationsModel>();
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
                        _SQLCommand.CommandText = "Notifications_LoadNotifications_TypeN";
                        _SQLCommand.Parameters.AddWithValue("@CR_MykadNo", CR_MykadNo);
                        _SQLCommand.Parameters.AddWithValue("@CR_ID", ID);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        NotificationsModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new NotificationsModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.Notification = _SQLDataReader["Notification"].ToString();
                            _result.NotificationDate = _SQLDataReader["NotificationDate"].ToString();
                            _result.NotificationReadDate = _SQLDataReader["NotificationReadDate"].ToString();
                            
                            _result.SentFrom = _SQLDataReader["SentFrom"].ToString();
                            _result.Logo64 = _SQLDataReader["Logo64"].ToString();
                            //_result.PaymentType = _SQLDataReader["PaymentType"].ToString();
                            //_result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            //_result.FlatBillAccountNo = _SQLDataReader["FlatBillAccountNo"].ToString();
                            //_result.TotalPaid = _SQLDataReader["TotalPaid"].ToString();
                      
                            _result.NotificationTitle = _SQLDataReader["NotificationTitle"].ToString();
                            _result.AdvertisementImage = _SQLDataReader["AdvertisementImage"].ToString();
                            _result.NotificationCode = _SQLDataReader["NotificationCode"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();
                            _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
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








        public static List<NotificationsModel> Notifications_LoadNotifications_TypeN_All(string CR_MykadNo,string Year,string Month)
        {
            List<NotificationsModel> _Value = new List<NotificationsModel>();
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
                        _SQLCommand.CommandText = "Notifications_LoadNotifications_TypeN_All";
                        _SQLCommand.Parameters.AddWithValue("@CR_MykadNo", CR_MykadNo);
                        _SQLCommand.Parameters.AddWithValue("@Year", Year);
                        _SQLCommand.Parameters.AddWithValue("@Month", Month);     
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        NotificationsModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new NotificationsModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.Notification = _SQLDataReader["Notification"].ToString();
                            _result.NotificationDate = _SQLDataReader["NotificationDate"].ToString();
                            _result.NotificationReadDate = _SQLDataReader["NotificationReadDate"].ToString();

                            _result.SentFrom = _SQLDataReader["SentFrom"].ToString();
                            _result.Logo64 = _SQLDataReader["Logo64"].ToString();
                            //_result.PaymentType = _SQLDataReader["PaymentType"].ToString();
                            //_result.AccountNo = _SQLDataReader["AccountNo"].ToString();
                            //_result.FlatBillAccountNo = _SQLDataReader["FlatBillAccountNo"].ToString();
                            //_result.TotalPaid = _SQLDataReader["TotalPaid"].ToString();

                            _result.NotificationTitle = _SQLDataReader["NotificationTitle"].ToString();
                            _result.AdvertisementImage = _SQLDataReader["AdvertisementImage"].ToString();
                            _result.NotificationCode = _SQLDataReader["NotificationCode"].ToString();
                            _result.EnterpriseAddress = _SQLDataReader["EnterpriseAddress"].ToString();

                               _result.EnterpriseEmail = _SQLDataReader["EnterpriseEmail"].ToString();
                            _result.EnterprisePhoneNo = _SQLDataReader["EnterprisePhoneNo"].ToString();
                            _result.EnterpriseWebsite = _SQLDataReader["EnterpriseWebsite"].ToString();
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

        public static bool Notifications_UpdateReadNotifications(int ID, string CR_AccountNo)
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
                        _SQLCommand.CommandText = "Notifications_UpdateReadNotifications";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@CR_AccountNo", CR_AccountNo);
                     
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


    }
}