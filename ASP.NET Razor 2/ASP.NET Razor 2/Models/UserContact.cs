using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP.NET_Razor_2.Models
{
    public class UserContact
    {
        [BindProperty]
        [DisplayName("ID của bạn:")]
        [Range(10, 100, ErrorMessage = "Nhap sai")]
        public int UserID { get; set; }

        [BindProperty]
        [DisplayName("Email của bạn:")]
        [Range(10, 100, ErrorMessage = "Nhap sai")]
        public string Email { get; set; }

        [BindProperty]
        [DisplayName("UserNam của bạn:")]
        [Range(10, 100, ErrorMessage = "Nhap sai")]
        public string UserName { get; set; }
    }
}
