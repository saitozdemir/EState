
using System.ComponentModel.DataAnnotations;

namespace Estate.UI.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "It is required")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "It is required")]
        [DataType(DataType.Password, ErrorMessage = "It is not a password")] 
        public string Password { get; set; }
    }
}
