using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
namespace WebApiResit.Models
{
    public class AdvertisementVideoModel
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
        public string AdvertisementVideo
        {
            get;
            set;
        }
        public string AdvertisementVideoName
        {
            get;
            set;
        }
        public string AdvertisementVideoNote
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }
        public string EnterpriseHQAccNo
        {
            get;
            set;
        }

        public string EnterpriseAccNo
        {
            get;
            set;
        }

        public string CreatedBy
        {
            get;
            set;
        }


        public AdvertisementVideoModel() { }




        public static string AdvertisementVideo_InsertUpdate(int ID, string AdvertisementCode, string AdvertisementVideo,
          string AdvertisementVideoName, string AdvertisementVideoNote, string EnterpriseAccNo, string EnterpriseHQAccNo, string RowStatus, string CreatedBy)
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
                        _SQLCommand.CommandText = "AdvertisementVideo_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementVideo", "https://setkita.com/AyohaImgCard/AdvertisementVideo/" + EnterpriseAccNo + "/" + AdvertisementVideoName);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementImgName", AdvertisementVideoName);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementImgNote", AdvertisementVideoNote);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
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

                        if (AdvertisementVideo != "ExistingVideo")
                        {
                            AdvertisementVideo_CreateVideo(AdvertisementVideo, EnterpriseAccNo, AdvertisementVideoName);
                        }
                    }

                }

            }



            return _value;
        }







        public static List<AdvertisementVideoModel> AdvertisementVideo_loadBy_EnterpriseHQAccNo_AdvertisementCode(string EnterpriseHQAccNo, string AdvertisementCode)
        {
            List<AdvertisementVideoModel> _Value = new List<AdvertisementVideoModel>();

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
                        _SQLCommand.CommandText = "AdvertisementVideo_loadBy_EnterpriseHQAccNo_AdvertisementCode";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementVideoModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementVideoModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.AdvertisementVideo = _SQLDataReader["AdvertisementVideo"].ToString();
                            _result.AdvertisementVideoName = _SQLDataReader["AdvertisementVideoName"].ToString();
                            _result.AdvertisementVideoNote = _SQLDataReader["AdvertisementVideoNote"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.EnterpriseHQAccNo = _SQLDataReader["EnterpriseHQAccNo"].ToString();
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







        public static void AdvertisementVideo_CreateVideo(string ImgStr, string AccountNo, string ImageName)
        {



            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\AdvertisementVideo\\" + AccountNo + "\\";//Path
            //string NameImg = ImgName;
            //Check if directory exist
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
            }
            // string ImgPath = "";
            if (ImgStr.Contains("data:video"))
            {

                string[] namesArray = ImgStr.Split(',');
                string n = namesArray[1];
                // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
                // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";
                String imgNames = ImageName;
                //ImgPath = "https://setkita.com/AyohaImgCard/AyohaUserEnterprisePicProfile/" + AccountNo + "/" + imgNames;



                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }


        }

    }
}