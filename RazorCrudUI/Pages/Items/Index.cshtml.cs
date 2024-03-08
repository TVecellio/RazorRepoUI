using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrudUI.Data;
using RazorCrudUI.Models;

namespace RazorCrudUI.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly RazorCrudUI.Data.ItemsContext _context;

        public IndexModel(RazorCrudUI.Data.ItemsContext context)
        {
            _context = context;
        }

        public IList<ItemModel> ItemModel { get;set; } = default!;


        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }


        public async Task OnGetAsync()
        {


            var items = from item in _context.Items
                        select item;
            if(!string.IsNullOrEmpty(SearchString))
            {
                items = items.Where(s => s.Name.Equals(SearchString));
            }
            
            ItemModel = await _context.Items.ToListAsync();
        }
    }
}


