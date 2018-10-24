using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SweepCake.Models
{
    public class RegisterModel
    {



        [Required(ErrorMessage = "Enter your ID")]
        public string UserName { set; get; }


        [StringLength(20, MinimumLength = 6, ErrorMessage = "Độ dài mật khẩu ít nhất 6 ký tự.")]
        [Required(ErrorMessage = "Enter your password")]
        public string Password { set; get; }

        [Compare("Password", ErrorMessage = "ConfirmPassword isn't correct")]
        public string ConfirmPassword { set; get; }

        //[Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Enter your name")]
        public string Name { set; get; }

        //[Display(Name = "Điện thoại")]
        public string Phone { set; get; }

        [Required(ErrorMessage = "Yêu cầu nhập email")]
        //[Display(Name = "Email")]
        public string Email { set; get; }
   
        //[Display(Name = "Địa chỉ")]
        public string Address { set; get; }
    }
}
