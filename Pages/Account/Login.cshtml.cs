using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace DanceBreaker.Pages.Account
{
    public class LoginModel : PageModel
    {

        [BindProperty]
        public Credentail Credentails { get; set; } 
        public void OnGet()
        {
            
        }

        public void OnPost() {

            if (!ModelState.IsValid) return;

            if()
        }
        public class Credentail
        {
            [Required]
            [Display(Name = "Podaj numer telefonu")]
            public int Number { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name ="Podaj PIN")]
            public string Password { get; set; }
        }
    }
}
