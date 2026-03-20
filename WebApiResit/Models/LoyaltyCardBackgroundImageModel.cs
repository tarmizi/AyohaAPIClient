using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class LoyaltyCardBackgroundImageModel
    {

        public int ID
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }
        public string StampCampaignCode
        {
            get;
            set;
        }
        public string ImgName
        {
            get;
            set;
        }
        public string ImgPath
        {
            get;
            set;
        }
        public string RowStatus
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

        public string ImageBase64
        {
            get;
            set;
        }

        public string ShowHide
        {
            get;
            set;
        }

        public string isAnimated
        {
            get;
            set;
        }

        public int AnimatedInterval
        {
            get;
            set;
        }
        public LoyaltyCardBackgroundImageModel() { }
      

        public static List<LoyaltyCardBackgroundImageModel> LoyaltyCardBackgroundImage_LoadByEnterpriseAccNo_StampCampaignCode(string EnterpriseAccNo, string StampCampaignCode)
        {
            List<LoyaltyCardBackgroundImageModel> _Value = new List<LoyaltyCardBackgroundImageModel>();

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
                        _SQLCommand.CommandText = "LoyaltyCardBackgroundImage_LoadByEnterpriseAccNo_StampCampaignCode";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyCardBackgroundImageModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new LoyaltyCardBackgroundImageModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.ImgName = _SQLDataReader["ImgName"].ToString();
                            _result.ImgPath = _SQLDataReader["ImgPath"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ShowHide = _SQLDataReader["ShowHide"].ToString();
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

        public static List<LoyaltyCardBackgroundImageModel> LoyaltyCardBackgroundImage_LoadByEnterpriseAccNo_StampCampaignCode_BackgroundImageAnim(string EnterpriseAccNo, string StampCampaignCode)
        {
            List<LoyaltyCardBackgroundImageModel> _Value = new List<LoyaltyCardBackgroundImageModel>();

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
                        _SQLCommand.CommandText = "LoyaltyCardBackgroundImage_LoadByEnterpriseAccNo_StampCampaignCode_BackgroundImageAnim";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        LoyaltyCardBackgroundImageModel _result;
                        while (_SQLDataReader.Read())
                        {
                            _result = new LoyaltyCardBackgroundImageModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.EnterpriseAccNo = _SQLDataReader["EnterpriseAccNo"].ToString();
                            _result.StampCampaignCode = _SQLDataReader["StampCampaignCode"].ToString();
                            _result.ImgName = _SQLDataReader["ImgName"].ToString();
                            _result.ImgPath = _SQLDataReader["ImgPath"].ToString();
                            _result.RowStatus = _SQLDataReader["RowStatus"].ToString();
                            _result.CreatedBy = _SQLDataReader["CreatedBy"].ToString();
                            _result.CreatedDate = _SQLDataReader["CreatedDate"].ToString();
                            _result.ShowHide = _SQLDataReader["ShowHide"].ToString();
                            _result.isAnimated = _SQLDataReader["isAnimated"].ToString();
                            _result.AnimatedInterval = Convert.ToInt32(_SQLDataReader["AnimatedInterval"].ToString());

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
      

        public static bool LoyaltyCardBackgroundImage_InsertUpdate(int ID, string EnterpriseAccNo, string StampCampaignCode, string ImgName, string ImgPath, string RowStatus, string CreatedBy, string ImgBase64, string ShowHide)
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
                        _SQLCommand.CommandText = "LoyaltyCardBackgroundImage_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseAccNo", EnterpriseAccNo);
                        _SQLCommand.Parameters.AddWithValue("@StampCampaignCode", StampCampaignCode);
                        _SQLCommand.Parameters.AddWithValue("@ImgName", ImgName);
                        _SQLCommand.Parameters.AddWithValue("@ImgPath", "https://setkita.com/AyohaImgCard/BackgroundImgCard/" + EnterpriseAccNo + "/" + ImgName);
                      //  _SQLCommand.Parameters.AddWithValue("@EnterpriseLogoPath", "http://42.1.63.57/AyohaImgCard/Logo/" + EnterpriseAccNo + "/" + EnterpriseLogoName);
                        _SQLCommand.Parameters.AddWithValue("@RowStatus", RowStatus);
                        _SQLCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        _SQLCommand.Parameters.AddWithValue("@ShowHide", ShowHide);
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
                        if (ImgBase64 != "ExistingImage")
                        {
                            LoyaltyCardBackgroundImage_AddbackgroundImage(ImgBase64, EnterpriseAccNo, ImgName);
                        }


                    }

                }

            }



            return _value;
        }



        public static void LoyaltyCardBackgroundImage_AddbackgroundImage(string ImgStr, string EnterpriseAccNo, string ImageName)
        {
            //String dirPath = HttpContext.Current.Server.MapPath("~/ImageStorage"); //Path
            ////string NameImg = ImgName;
            ////Check if directory exist
            //if (!System.IO.Directory.Exists(dirPath))
            //{
            //    System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
            //}

            //String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\BackgroundImgCard\\" + EnterpriseAccNo + "\\";//Path
            //string ContentCardImgPath = ImgStr;
            //if (ImgStr.Contains("data:image"))
            //{

            //    string[] namesArray = ImgStr.Split(',');
            //    string n = namesArray[1];
            //    // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
            //   // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\BackgroundImgCard\\" + EnterpriseAccNo + "\\";
            //    String imgNames = ImageName;
            //    ContentCardImgPath = "/AyohaImgCard/BackgroundImgCard/" + EnterpriseAccNo + "/" + imgNames;



            //    byte[] imgByteArray = Convert.FromBase64String(n);
            //    File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            //}



            ////////////////
            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\BackgroundImgCard\\" + EnterpriseAccNo + "\\";//Path
            //string NameImg = ImgName;
            //Check if directory exist
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
            }
            string ImgPath = "";
            if (ImgStr.Contains("data:image"))
            {

                string[] namesArray = ImgStr.Split(',');
                string n = namesArray[1];
                // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
                // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";
                String imgNames = ImageName;
                ImgPath = "https://setkita.com/AyohaImgCard/BackgroundImgCard/" + EnterpriseAccNo + "/" + imgNames;



                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }



        }
        
    }
}