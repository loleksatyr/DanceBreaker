using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace DanceBreaker.Pages.Account
{
    public class LoginModel : PageModel
    {

        [BindProperty]
        public Credentail Credentails { get; set; } 
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync() {

            if (!ModelState.IsValid) return Page();

            if (Credentails.Number == 997997997 && Credentails.Password == "1234")
            {
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, "Name"), new Claim(ClaimTypes.Email, "123@website.com") };

                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
                return RedirectToPage("/Index");


            }
            return Page();
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
