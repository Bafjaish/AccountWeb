using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccountWeb.Models
{
    public class AccountModel
    {

        [Key]
        [Required(ErrorMessage ="Required")]
        public string AccountNumber { get; set; }
        [Required(ErrorMessage = "Required")]
        public string AccountHolder { get; set; }
        [Required(ErrorMessage = "Required")]
        public decimal CurrentBalance { get; set; }
        [Required(ErrorMessage = "Required")]
        public string BankName { get; set; }
        [Required(ErrorMessage = "Required")]
        public DateTime OpeningDate { get; set; }
        public Boolean IsActive { get; set; }


    }


}