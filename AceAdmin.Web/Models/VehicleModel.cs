using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AceAdmin.Web.Models
{
    public class VehicleModel
    {
        //Vehicle entity should be able to store these information
        //License plate number, type of vehicle(truck, lorry, etc...), 
        //start address, end address, default driver

        [Key]
        public int nVehiID { get; set; }
        public string cLicensePNum { get; set; }
        public string cType { get; set; }
        public string cStaAdd { get; set; }
        public string cEndAdd { get; set; }
        public string cDriver { get; set; }


       
    }
}