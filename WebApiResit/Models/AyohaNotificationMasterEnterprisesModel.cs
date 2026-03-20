using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaNotificationMasterEnterprisesModel
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
        public string SubscriberAccNo
        {
            get;
            set;
        }
        public string CreatedDate
        {
            get;
            set;
        }


        //public string MembershipCardCode
        //{
        //    get;
        //    set;
        //}
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

        //public string NoteToSeller
        //{
        //    get;
        //    set;
        //}


        public string RowStatus
        {
            get;
            set;
        }

        public string IsRead
        {
            get;
            set;
        }


        public AyohaNotificationMasterEnterprisesModel() { }


        public static string AyohaNotificationMaster_Enterprises_Insert(string OrderNo, string SubscriberAccNo, string EnterpriseAccNo, string GrandTotal, string PaymentAmount, string PaymentMethod,
        string PaymentMethodCode, string CreatedBy, string MembershipCardCode, string PaymentStatus, string NoteToSeller, string NotificationType)
        {

            string _value = "true";

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
                        _SQLCommand.CommandText = "AyohaNotificationMaster_Enterprises_Insert";
                        _SQLCommand.Parameters.AddWithValue("@NotificationCode", OrderNo);
                        _SQLCommand.Parameters.AddWithValue("@NotificationType", NotificationType);
                        _SQLCommand.Parameters.AddWithValue("@NotificationTitle", NotificationType + " . Order No:" + OrderNo);
                        _SQLCommand.Parameters.AddWithValue("@NotificationBody", NotificationType + "<br>Order No:" + OrderNo + "<br>Payment Received:" + GrandTotal+"<br>Payment Method:"+PaymentMethod);
                        _SQLCommand.Parameters.AddWithValue("@NotifcationImage", "https://setkita.com/AyohaImgCard/PushNotificationImgFooter/55462-01226543120-NoEnterprise/Ucapan-Hari-Raya-2.png");
                        _SQLCommand.Parameters.AddWithValue("@NotificationFooterImage", "https://setkita.com/AyohaImgCard/PushNotificationImgFooter/55462-01226543120-NoEnterprise/Ucapan-Hari-Raya-2.png");
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
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

                       // AyohaStore_Payment_PushNotificationInfo(SubscriberAccNo, EnterpriseAccNo, MerchantPoint, AyohaPoint);

                    }

                }

            }





            return _value;



        }




        public static List<AyohaNotificationMasterEnterprisesModel> AyohaNotificationMaster_Enterprises_LoadByEnterpriseAccNo(string EnterpriseAccNo)
        {
            List<AyohaNotificationMasterEnterprisesModel> _Value = new List<AyohaNotificationMasterEnterprisesModel>();

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
                        _SQLCommand.CommandText = "AyohaNotificationMaster_Enterprises_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaNotificationMasterEnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaNotificationMasterEnterprisesModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.NotificationCode = _SQLDataReader["NotificationCode"].ToString();
                            _result.NotificationType = _SQLDataReader["NotificationType"].ToString();
                            _result.NotificationTitle = _SQLDataReader["NotificationTitle"].ToString();
                            _result.NotificationBody = _SQLDataReader["NotificationBody"].ToString();
                            _result.NotifcationImage = _SQLDataReader["NotifcationImage"].ToString();
                            _result.NotificationFooterImage = _SQLDataReader["NotificationFooterImage"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ModifiedDate"]);
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString(); _result.RowStatus = _SQLDataReader["ModifiedBy"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.IsRead = _SQLDataReader["IsRead"].ToString();

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

        public static List<AyohaNotificationMasterEnterprisesModel> AyohaNotificationMaster_Enterprises_LoadByID(string EnterpriseAccNo,int ID)
        {
            List<AyohaNotificationMasterEnterprisesModel> _Value = new List<AyohaNotificationMasterEnterprisesModel>();

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
                        _SQLCommand.CommandText = "AyohaNotificationMaster_Enterprises_LoadByID";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaNotificationMasterEnterprisesModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaNotificationMasterEnterprisesModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.NotificationCode = _SQLDataReader["NotificationCode"].ToString();
                            _result.NotificationType = _SQLDataReader["NotificationType"].ToString();
                            _result.NotificationTitle = _SQLDataReader["NotificationTitle"].ToString();
                            _result.NotificationBody = _SQLDataReader["NotificationBody"].ToString();
                            _result.NotifcationImage = _SQLDataReader["NotifcationImage"].ToString();
                            _result.NotificationFooterImage = _SQLDataReader["NotificationFooterImage"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.SubscriberAccNo = _SQLDataReader["SubscriberAccNo"].ToString();
                            _result.CreatedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["CreatedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["CreatedDate"]);
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = String.Format("{0:d/M/yyyy}", _SQLDataReader["ModifiedDate"]) + " " + String.Format("{0:T}", _SQLDataReader["ModifiedDate"]);
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString(); _result.RowStatus = _SQLDataReader["ModifiedBy"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.IsRead = _SQLDataReader["IsRead"].ToString();

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



        public static string AyohaNotificationMaster_Enterprises_Delete(string EnterpriseAccNo, int ID)
        {

            string _value = "true";

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
                        _SQLCommand.CommandText = "AyohaNotificationMaster_Enterprises_Delete";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
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

                        // AyohaStore_Payment_PushNotificationInfo(SubscriberAccNo, EnterpriseAccNo, MerchantPoint, AyohaPoint);

                    }

                }

            }





            return _value;



        }

        public static string AyohaNotificationMaster_Enterprises_UpdateIsRead(string EnterpriseAccNo, int ID)
        {

            string _value = "true";

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
                        _SQLCommand.CommandText = "AyohaNotificationMaster_Enterprises_UpdateIsRead";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
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

                        // AyohaStore_Payment_PushNotificationInfo(SubscriberAccNo, EnterpriseAccNo, MerchantPoint, AyohaPoint);

                    }

                }

            }





            return _value;



        }
    }
}