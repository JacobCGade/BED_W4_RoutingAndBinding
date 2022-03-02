using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BED_W4_Exercise.Services;

namespace BED_W4_Exercise.Pages.Contact
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public InputModel? Input { get; set;} = null;
        public StoreContactInfo Service {get; set; }
        public DetailsModel(StoreContactInfo service) {
            Service = service;
        }
        public void OnGet(int index) 
        {
            if(index < Service.Contacts.Count) {
                var contact = Service.Contacts[index];
                Input = new InputModel {
                    Email = contact.Email,
                    Name = contact.Name,
                    PhoneNumber = contact.PhoneNumber
                };        
            }
        }
        public class InputModel {
            [Required]
            public String? Email { get; set; } 
            [Required]
            public String? Name { get; set; }
            [Required]
            public String? PhoneNumber { get; set; }
        }
    }
}
