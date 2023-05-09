using ASP.NET_Razor_2.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Razor_2.Pages
{
    public class ContactRequestModel : PageModel
    {
        //[BindProperty]
        //public UserContact userContact { get; set; }
        [BindProperty]
        [DisplayName("ID của bạn:")]
        [Range(10, 100, ErrorMessage = "Nhap sai")]
        public int UserID { get; set; }

        [BindProperty]
        [DisplayName("Email của bạn:")]
        [EmailAddress(ErrorMessage = "Nhap sai")]
        public string Email { get; set; }


        [BindProperty]
        [DisplayName("UserName của bạn:")]
      
        public string UserName { get; set; }


        private readonly ILogger<ContactRequestModel> _logger;



        public ContactRequestModel(ILogger<ContactRequestModel> logger)
        {
            _logger = logger;
            _logger.LogInformation("Init contact...");

        }

        public double Tong(double a, double b)
        {
            return a + b;
        }

        public void OnPost()
        {
            Console.WriteLine(this.Email);
        }
    }
}
