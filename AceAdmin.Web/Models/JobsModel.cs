using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace AceAdmin.Web.Models
{
    public class JobsModel
    {
        //Job entity should be able to store these information
        //Job number, location, duration, start date/time, end date/time
        [Key]
        public int nJobID { get; set; }
        public string cJobNum { get; set; }
        public int nWorkID { get; set; }
        public string clocation { get; set; }
        public int cDuration { get; set; }
        public DateTime dStartDate { get; set; }
        public DateTime dEndDate { get; set; }
        public int nVehiID { get; set; }

        
    }
}