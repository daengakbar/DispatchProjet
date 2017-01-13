using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AceAdmin.Web.Models
{
    public class WorkerModel
    {
        //Worker : Name, ICnumber, Phone number and salary
        [Key]
        public int nWorkID { get; set; }
        public string cWorkName { get; set; }
        public string cICnumber { get; set; }
        public string cPhoneNum { get; set; }
        public decimal nSalary  { get; set; }
    }
}
