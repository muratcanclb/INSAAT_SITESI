using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace clbinsaat.Data
{
    public class user
    {
        public int userID { get; set; }

        [DisplayName("KULLANICI ADI")]
        [Required(ErrorMessage ="Hatalı Kullanıcı ADI")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Hatalı ŞİFRE")]
        [DisplayName("ŞİFRE")]
        [DataType(DataType.Password)]
        public string userPass { get; set; }


    }

   

}