using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SweepCake.Models
{
    public class LoginModel
    {

        [Required(ErrorMessage = "Enter user name")]
        public string ID { set; get; }

        [Required(ErrorMessage = "Enter password")]
        public string Pass { set; get; }

    }
}