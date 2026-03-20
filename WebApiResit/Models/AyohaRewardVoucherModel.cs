using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaRewardVoucherModel
    {
        public int ID
        {
            get;
            set;
        }



        public string VoucherCode
        {
            get;
            set;
        }
        public string VoucherName
        {
            get;
            set;
        }



        public string VoucherImgPath
        {
            get;
            set;
        }
        public string VoucherImgName
        {
            get;
            set;
        }
        public string VoucherAmount
        {
            get;
            set;
        }

        public string VoucherTermAndCondition
        {
            get;
            set;
        }
        public string RowStatus
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
        public string EnterpriseAccNo
        {
            get;
            set;
        }

        public string VoucherType
        {
            get;
            set;
        }

        public AyohaRewardVoucherModel() { }
    }
}