using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BED_W4_Exercise.Services;

namespace BED_W4_Exercise.Pages.Contact
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public Models.Contact Contact { get; set; }
        public StoreContactInfo Service {get; set; }
        public DetailsModel(StoreContactInfo service) {
            Service = service;
        }
     
        public void OnGet(int index) 
        {
            Contact = Service.Contacts[index];
        }
    }
}
