using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace HiersEmployeeApplication.Areas.Admin.Models
{
    public class SmallButtonModel
    {
        public string Action { get; set; }
        public string Text { get; set; }
        public string Glyph { get; set; }
        public string ButtonType { get; set; }

        //public int? EmployeeId { get; set; }

        //public string ActionParameter { get {
        //        var Param = new StringBuilder("");

        //        if(EmployeeId !=null&& EmployeeId > 0)
        //        {
        //            Param.Append(String.Format("{0}={1}", "EmployeeId", EmployeeId));
        //        }

        //        return Param.ToString();
        //    } }
    }
}