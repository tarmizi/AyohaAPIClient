using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class VehiclesModel
    {

        public int VehicleId
        {
            get;
            set;
        }
        public string PlateNumber
        {
            get;
            set;
        }

        public int VehicleModelId
        {
            get;
            set;
        }
        public int CustomerId
        {
            get;
            set;
        }
        public string VehicleImage
        {
            get;
            set;
        }
    }
}