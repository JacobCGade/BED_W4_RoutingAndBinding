using BED_W4_Exercise.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BED_W4_Exercise.Pages.Contact
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Models.Contact ContactModel { get; set; }

        public StoreContactInfo Service { get; set; }

        public IndexModel(StoreContactInfo service)
        {
            Service = service;
        }

        public void OnGet()
        {

        }

        public IActionResult OnGetDetails(string contact) {
            return RedirectToPage("/Contact/Details", new { Contact = contact });
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Service.Contacts.Add(ContactModel);
            return Page();
        }
    }
}
