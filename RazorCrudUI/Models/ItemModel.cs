using System.ComponentModel.DataAnnotations;

namespace RazorCrudUI.Models;
    public class ItemModel
    {
    public int Id { get; set; }

    [Display(Name = "Item Name")]
    public String Name { get; set; }

    public String Description { get; set; }

    public decimal Price { get; set; }
}

