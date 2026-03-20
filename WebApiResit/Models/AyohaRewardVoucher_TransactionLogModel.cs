using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApiResit.Models
{
    public class AyohaRewardVoucher_TransactionLogModel
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
        public AyohaRewardVoucher_TransactionLogModel() { }
    }
}