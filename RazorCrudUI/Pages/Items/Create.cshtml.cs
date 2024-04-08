using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorCrudUI.Data;
using RazorCrudUI.Models;
using RazorRepoUI.Data;

namespace RazorCrudUI.Pages.Items
{
    public class CreateModel : PageModel
    {
        private readonly IItemRepository _repo;

        public CreateModel(IItemRepository repo)
        {
            _repo = repo;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ItemModel ItemModel { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repo.insertItem(ItemModel);

            return RedirectToPage("./Index");
        }
    }
}
