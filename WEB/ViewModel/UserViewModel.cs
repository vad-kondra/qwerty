using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WEB.ViewModel
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Registration Date is required")]
        [JsonConverter(typeof(ShortDateConverter))]
        public DateTime? RegistrationDate { get; set; }
        
        [Required(ErrorMessage = "Registration Date is required")]
        [JsonConverter(typeof(ShortDateConverter))]
        public DateTime? LastActivityDate { get; set; }
    }
}