using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrudUI.Data;
using RazorCrudUI.Models;
using RazorRepoUI.Data;

namespace RazorCrudUI.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly IItemRepository  _repo;

        public IndexModel(IItemRepository repo)
        {
            _repo = repo;
        }

        public IList<ItemModel> ItemModel { get;set; } = default!;


        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }


        public async Task OnGetAsync()
        {
            ItemModel = (IList<ItemModel>)_repo.GetItems(SearchString);
        }
    }
}


