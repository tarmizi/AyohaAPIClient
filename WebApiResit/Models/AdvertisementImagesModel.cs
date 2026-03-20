using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
namespace WebApiResit.Models
{
    public class AdvertisementImagesModel
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
        public string AdvertisementImgNote
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

      
        

        public AdvertisementImagesModel() { }




        public static string AdvertisementImages_InsertUpdate(int ID, string AdvertisementCode, string AdvertisementImg,
            string AdvertisementImgName, string AdvertisementImgNote, string EnterpriseAccNo, string EnterpriseHQAccNo, string RowStatus, string CreatedBy)
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
                        _SQLCommand.CommandText = "AdvertisementImages_InsertUpdate";
                        _SQLCommand.Parameters.AddWithValue("@ID", ID);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementImg", "https://setkita.com/AyohaImgCard/AdvertisementImage/" + EnterpriseAccNo + "/" + AdvertisementImgName);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementImgName", AdvertisementImgName);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementImgNote", AdvertisementImgNote);
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

                        if (AdvertisementImg != "ExistingImage")
                        {
                            AdvertisementImages_CreateImg(AdvertisementImg, EnterpriseAccNo, AdvertisementImgName, AdvertisementImgNote);
                        }
                    }

                }

            }



            return _value;
        }






        public static List<AdvertisementImagesModel> AdvertisementImages_loadBy_EnterpriseHQAccNo_AdvertisementCode(string EnterpriseHQAccNo, string AdvertisementCode)
        {
            List<AdvertisementImagesModel> _Value = new List<AdvertisementImagesModel>();

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
                        _SQLCommand.CommandText = "AdvertisementImages_loadBy_EnterpriseHQAccNo_AdvertisementCode";
                        _SQLCommand.Parameters.AddWithValue("@EnterpriseHQAccNo", EnterpriseHQAccNo);
                        _SQLCommand.Parameters.AddWithValue("@AdvertisementCode", AdvertisementCode);
                        _DBConnection.Open();
                        SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();
                        AdvertisementImagesModel _result;
                        while (_SQLDataReader.Read())
                        {



                            _result = new AdvertisementImagesModel();
                            _result.ID = Convert.ToInt32(_SQLDataReader["ID"].ToString());
                            _result.AdvertisementCode = _SQLDataReader["AdvertisementCode"].ToString();
                            _result.AdvertisementImg = _SQLDataReader["AdvertisementImg"].ToString();
                            _result.AdvertisementImgName = _SQLDataReader["AdvertisementImgName"].ToString();
                            _result.AdvertisementImgNote = _SQLDataReader["AdvertisementImgNote"].ToString();
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











        public static void AdvertisementImages_CreateImg(string ImgStr, string AccountNo, string ImageName, string ImgNote)
        {



            //String dirPath = HttpContext.Current.Server.MapPath("~/AyohaImgCard/ContentCard/" + EnterpriseAccNo + "/"); //Path
            String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\AdvertisementImage\\" + AccountNo + "\\";//Path
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
                // String dirPath = @"C:\inetpub\wwwroot\SMC\resources\UploadImg\";
                // String dirPath = "C:\\inetpub\\wwwroot\\AyohaImgCard\\ContentCard\\" + EnterpriseAccNo + "\\";
                String imgNames = ImageName;
                //ImgPath = "http://42.1.63.57/AyohaImgCard/AyohaUserEnterprisePicProfile/" + AccountNo + "/" + imgNames;



                byte[] imgByteArray = Convert.FromBase64String(n);
                File.WriteAllBytes(dirPath + imgNames, imgByteArray);
            }

            AdvertisementImages_CreateMetaTagHtml(AccountNo, ImageName, ImgNote);
        }


        public static void AdvertisementImages_CreateMetaTagHtml(string AccNo, string ImgName,string Notes)
        {
            string AccountNo = AccNo;
            string ImageName = ImgName;
            string CombineAccountNoAndImageName = AccountNo + "/" + ImageName;
            string modifiedImageName = ImgName.Replace(".", string.Empty)+".html";
            String dirPath = "C:\\inetpub\\wwwroot\\AdvertisementImageTag\\" + AccountNo + "\\";//Path





            char quote = '"';




            string TitleMetaTag = ImgName;
            string DescMetaTag = Notes;
            string HostMetaTag = "https://setkita.com/";
            string HostImageUrlTag = "https://setkita.com/AyohaImgCard/AdvertisementImage/" + CombineAccountNoAndImageName;
            string htmlTxt = "<html>" +
"<head>" +
"<meta property="+quote+"og:title"+quote+"  content="+quote+TitleMetaTag+quote+ "/>" +
   "<meta property="+quote+"og:description"+quote+"  content="+quote+DescMetaTag+quote+ "/>" +
      "<meta property="+quote+"og:url"+quote+"  content="+quote+HostMetaTag +quote+ "/>" +
            "<meta property="+quote+"og:image"+quote+"  content="+quote+HostImageUrlTag+quote+ " />" +
            "<style type ='text/css'> html, body {" +
            "height: 100%; background-color: #C72CB4;} </style>" +
"<script type = 'text/javascript' > function ExtractQS(){" +
                    "const urlParams = new URLSearchParams(window.location.search); const myParam = urlParams.get('ImgId'); var img1 = document.getElementById('img1'); img1.src = 'https://setkita.com/AyohaImgCard/AdvertisementImage/" + AccountNo + "/' + myParam;" +
                    "target = document.getElementById('img1');" +
                    "target.style.width = '100%';" +
                    "target.style.height = '100%';}" +
                "</script>" +
                "</head>" +
                "<body onload = ExtractQS()>" +
                     "<img id = img1 width=100% height =100%/>" +
                        "<div style = 'width:100%;text-align:center;margin:-100px 0px 0px 0px;' ><font size=20 color=white> Ayoha Reward Pro v 1.0 </font ></div>" +
                                   "</body>" +
                                   "</html>";



            //return decodeURIComponent(window.location.search.replace(new RegExp("^(?:.*[&\\?]" + encodeURIComponent(key).replace(/[\.\+\*]/g, "\\$&") + "(?:\\=([^&]*))?)?.*$", "i"), "$1"));   

            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath); //Create directory if it doesn't exist
            }

            string fileName = dirPath + "\\" + modifiedImageName;
            //Check if the file exists
            if (!File.Exists(fileName))
            {
                // Create the file and use streamWriter to write text to it.
                //If the file existence is not check, this will overwrite said file.
                //Use the using block so the file can close and vairable disposed correctly
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    writer.WriteLine(htmlTxt);
                }
            }


        }

    }
}