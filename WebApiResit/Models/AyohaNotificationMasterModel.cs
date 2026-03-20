using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;


namespace WebApiResit.Models
{
    public class AyohaNotificationMasterModel
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

        public string NotificationType
        {
            get;
            set;
        }
        public string NotificationStatus
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
        public string RowStatus
        {
            get;
            set;
        }
        public int SendToAudiencesCount
        {
            get;
            set;
        }




        public string NotifcationImageName
        {
            get;
            set;
        }
        public string NotificationFooterImageName
        {
            get;
            set;
        }
       

        public string AudienceType
        {
            get;
            set;
        }


        public string PlayerID
        {
            get;
            set;
        }

        public string NotificationMedium
        {
            get;
            set;
        }

        public string AccountName
        {
            get;
            set;
        }

        public string SubscriberAccNo
        {
            get;
            set;
        }

        public string Source
        {
            get;
            set;
        }

        public string TypeCRDB
        {
            get;
            set;
        }



        public int TotalUsed
        {
            get;
            set;
        }

        public int Quota
        {
            get;
            set;
        }

        public int Balance
        {
            get;
            set;
        }

        public string EnterpriseName
        {
            get;
            set;
        }
        //string ModifiedNotificationFooterImage;

      
        public AyohaNotificationMasterModel() { }

        public static string AyohaNotificationMaster_Insert(int ID, string NotificationCode, string NotificationTitle,
        string NotificationBody, string NotifcationImageName, string NotificationFooterImageName, string EnterpriseAccNo, string EnterpriseHQAccNo, string NotificationType, string NotificationStatus, string CreatedBy, int SendToAudiencesCount,string AudienceType,
            string NotifcationImage, string NotificationFooterImage, string PlayerID, string NotificationMedium, string SubscriberAccNo, string Source, string TypeCRDB, string EnterpriseName)
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
                        _SQLCommand.CommandText = "AyohaNotificationMaster_Insert";
                       // _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@NotificationCode", NotificationCode);
                        _SQLCommand.Parameters.AddWithValue("@NotificationTitle", NotificationTitle);
                        _SQLCommand.Parameters.AddWithValue("@NotificationBody", NotificationBody);
                        //_SQLCommand.Parameters.AddWithValue("@NotifcationImage", "http://42.1.63.57/AyohaImgCard/PushNotificationImage/" + EnterpriseAccNo + "/" + NotifcationImageName);
                        _SQLCommand.Parameters.AddWithValue("@NotifcationImage", ModifiedNotificationImage_Check(Source, EnterpriseAccNo, NotifcationImageName, NotifcationImage));
                        //_SQLCommand.Parameters.AddWithValue("@NotificationFooterImage", "http://42.1.63.57/AyohaImgCard/PushNotificationImgFooter/" + EnterpriseAccNo + "/" + NotificationFooterImageName);
                        _SQLCommand.Parameters.AddWithValue("@NotificationFooterImage", ModifiedNotificationFooterImage_Check(Source, EnterpriseAccNo, NotificationFooterImageName, NotificationFooterImage));
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _SQLCommand.Parameters.AddWithValue("@NotificationType", NotificationType);
                        _SQLCommand.Parameters.AddWithValue("@NotificationStatus", NotificationStatus);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@SendToAudiencesCount", SendToAudiencesCount);
                        _SQLCommand.Parameters.AddWithValue("@AudienceType", AudienceType);
                        _SQLCommand.Parameters.AddWithValue("@NotificationMedium", NotificationMedium);
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@TypeCRDB", TypeCRDB);                       
                        
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

                        if (NotificationType == "Image" && Source == "New")
                        {
                            if (NotifcationImage != "ExistingImage")
                            {
                                AyohaNotificationMaster_NotificationImage(NotifcationImage, EnterpriseAccNo, NotifcationImageName);
                            }
                        }
                        if (NotificationType == "Text" && Source == "New")
                        {
                            if (NotificationFooterImage != "ExistingImage")
                            {
                                AyohaNotificationMaster_NotificationImgFooter(NotificationFooterImage, EnterpriseAccNo, NotificationFooterImageName);
                            }
                        }

                        OneSignalModel.onesignalAPI_AyohaNotification_Notification(EnterpriseName,NotificationTitle, PlayerID);
                    }

                }

            }



            return _value;
        }





        public static void AyohaNotificationMaster_Insert_AyohaUserCreatedAccount(string NotificationTitle,
        string PlayerID,string SubscriberAccNo,string AccountName)
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
                        _SQLCommand.CommandText = "AyohaNotificationMaster_Insert";
                        // _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@NotificationCode", NotificationCodeGenerateRandom()+"-50528-0133376958-NoEnterprise-PN");
                        _SQLCommand.Parameters.AddWithValue("@NotificationTitle", NotificationTitle);
                        _SQLCommand.Parameters.AddWithValue("@NotificationBody", "NotRequired");
                        //_SQLCommand.Parameters.AddWithValue("@NotifcationImage", "http://42.1.63.57/AyohaImgCard/PushNotificationImage/" + EnterpriseAccNo + "/" + NotifcationImageName);
                        _SQLCommand.Parameters.AddWithValue("@NotifcationImage", "https://setkita.com/AyohaImgCard/PushNotificationImage/50528-0133376958-NoEnterprise/greetingAyohaNewAccount.png");
                        //_SQLCommand.Parameters.AddWithValue("@NotificationFooterImage", "http://42.1.63.57/AyohaImgCard/PushNotificationImgFooter/" + EnterpriseAccNo + "/" + NotificationFooterImageName);
                        _SQLCommand.Parameters.AddWithValue("@NotificationFooterImage", "NA");
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", "50528-0133376958-NoEnterprise");
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", "50528-0133376958-NoEnterprise");
                        _SQLCommand.Parameters.AddWithValue("@NotificationType", "Image");
                        _SQLCommand.Parameters.AddWithValue("@NotificationStatus", "Sent");
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", "AyohaAdmin");
                        _SQLCommand.Parameters.AddWithValue("@SendToAudiencesCount", 1);
                        _SQLCommand.Parameters.AddWithValue("@AudienceType", "Specific_Members");
                        _SQLCommand.Parameters.AddWithValue("@NotificationMedium", "PN");
                        _SQLCommand.Parameters.AddWithValue("@SubscriberAccNo", SubscriberAccNo);
                        _SQLCommand.Parameters.AddWithValue("@TypeCRDB", "Debit");

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

                        LoyaltyPointModel.LoyaltyPoint_Insert_AyohaUserCreatedAccountPoint(SubscriberAccNo, PlayerID, AccountName);

                        //OneSignalModel.onesignalAPI_AyohaNotification_UserProfileCreated(AccountName,PlayerID);
                    }

                }

            }



            //return _value;
        }





        public static List<AyohaNotificationMasterModel> AyohaNotificationMaster_LoadByEnterpriseAccNo(string EnterpriseAccNo, string NotificationMedium, string NotificationYear, string NotificationMonth, string LoadNotificationType)
        {
            List<AyohaNotificationMasterModel> _Value = new List<AyohaNotificationMasterModel>();

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
                        _SQLCommand.CommandText = "AyohaNotificationMaster_LoadByEnterpriseAccNo";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@NotificationMedium", NotificationMedium);
                        _SQLCommand.Parameters.AddWithValue("@NotificationYear", NotificationYear);
                        _SQLCommand.Parameters.AddWithValue("@NotificationMonth", NotificationMonth);
                        _SQLCommand.Parameters.AddWithValue("@LoadNotificationType", LoadNotificationType);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaNotificationMasterModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaNotificationMasterModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.NotificationCode = _SQLDataReader["NotificationCode"].ToString();
                            _result.NotificationTitle = _SQLDataReader["NotificationTitle"].ToString();
                            _result.NotificationBody = _SQLDataReader["NotificationBody"].ToString();
                            _result.NotifcationImage = _SQLDataReader["NotifcationImage"].ToString();
                            _result.NotificationFooterImage = _SQLDataReader["NotificationFooterImage"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.NotificationType = _SQLDataReader["NotificationType"].ToString();
                            _result.NotificationStatus = _SQLDataReader["NotificationStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.SendToAudiencesCount =Convert.ToInt32(_SQLDataReader["SendToAudiencesCount"].ToString());
                            _result.AudienceType = _SQLDataReader["AudienceType"].ToString();
                            _result.NotificationMedium = _SQLDataReader["NotificationMedium"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.TypeCRDB = _SQLDataReader["TypeCRDB"].ToString();
                            
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



        public static List<AyohaNotificationMasterModel> AyohaNotificationMaster_RecentlyUsed(string EnterpriseAccNo, string NotificationMedium)
        {
            List<AyohaNotificationMasterModel> _Value = new List<AyohaNotificationMasterModel>();

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
                        _SQLCommand.CommandText = "AyohaNotificationMaster_RecentlyUsed";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@NotificationMedium", NotificationMedium);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaNotificationMasterModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaNotificationMasterModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.NotificationCode = _SQLDataReader["NotificationCode"].ToString();
                            _result.NotificationTitle = _SQLDataReader["NotificationTitle"].ToString();
                            _result.NotificationBody = _SQLDataReader["NotificationBody"].ToString();
                            _result.NotifcationImage = _SQLDataReader["NotifcationImage"].ToString();
                            _result.NotificationFooterImage = _SQLDataReader["NotificationFooterImage"].ToString();
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
                            _result.NotificationType = _SQLDataReader["NotificationType"].ToString();
                            _result.NotificationStatus = _SQLDataReader["NotificationStatus"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.ModifiedDate = _SQLDataReader["ModifiedDate"].ToString();
                            _result.ModifiedBy = _SQLDataReader["ModifiedBy"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.SendToAudiencesCount = Convert.ToInt32(_SQLDataReader["SendToAudiencesCount"].ToString());
                            _result.AudienceType = _SQLDataReader["AudienceType"].ToString();
                            _result.NotificationMedium = _SQLDataReader["NotificationMedium"].ToString();
                            _result.AccountName = _SQLDataReader["AccountName"].ToString();
                            _result.TypeCRDB = _SQLDataReader["TypeCRDB"].ToString();
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








        public static List<AyohaNotificationMasterModel> AyohaNotificationMaster_PN_Dashboard(string EnterpriseAccNo)
        {
            List<AyohaNotificationMasterModel> _Value = new List<AyohaNotificationMasterModel>();

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
                        _SQLCommand.CommandText = "AyohaNotificationMaster_PN_Dashboard";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AyohaNotificationMasterModel _result;
                        while (_SQLDataReader.Read())
                        {

                            _result = new AyohaNotificationMasterModel();
                            _result.TotalUsed = Convert.ToInt32( _SQLDataReader["TotalUsed"].ToString());
                            _result.Quota = Convert.ToInt32( _SQLDataReader["Quota"].ToString());
                            _result.Balance = Convert.ToInt32( _SQLDataReader["Balance"].ToString());
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











        public static void AyohaNotificationMaster_NotificationImage(string ImgStr, string EnterpriseAccNo, string ImageName)
        {



            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\PushNotificationImage\\" + EnterpriseAccNo + "\\";//Path
            //string NameImg = ImgName;
            //Check if directory exist
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
            }
            // string ImgPath = "";
            if (ImgStr.Contains("data:image"))
            {

                string[] namesArray = ImgStr.Split(',');
                string n = namesArray[1];
                String imgNames = ImageName;
                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }

            
        }


        public static void AyohaNotificationMaster_NotificationImgFooter(string ImgStr, string EnterpriseAccNo, string ImageName)
        {



            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\PushNotificationImgFooter\\" + EnterpriseAccNo + "\\";//Path
            //string NameImg = ImgName;
            //Check if directory exist
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
            }
            // string ImgPath = "";
            if (ImgStr.Contains("data:image"))
            {

                string[] namesArray = ImgStr.Split(',');
                string n = namesArray[1];
                String imgNames = ImageName;
                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }


        }



        public static string NotificationCodeGenerateRandom()
        {

            Random rnd = new Random();
            int month = rnd.Next(1, 999999);

            return month.ToString();

        }




        public static string ModifiedNotificationFooterImage_Check(string jenis, string EnterpriseAccNo, string NotificationFooterImageName, string NotificationFooterImage)
        {
            string val = "";

            if (jenis == "New")
            {
                val = "https://setkita.com/AyohaImgCard/PushNotificationImgFooter/" + EnterpriseAccNo + "/" + NotificationFooterImageName;
            }
            if (jenis == "Recently")
            {
                val = NotificationFooterImage;
            }
            return val;

        }







        public static string ModifiedNotificationImage_Check(string jenis, string EnterpriseAccNo, string NotifcationImageName, string NotificationImage)
        {
            string val = "";

         

            if (jenis == "New")
            {
                val = "https://setkita.com/AyohaImgCard/PushNotificationImage/" + EnterpriseAccNo + "/" + NotifcationImageName;
            }
            if (jenis == "Recently")
            {
                val = NotificationImage;
            }
            return val;

        }


    }
}