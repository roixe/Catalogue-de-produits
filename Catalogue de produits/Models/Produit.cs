using System.ComponentModel.DataAnnotations;

namespace Catalogue_de_produits.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //set the value on the current Currency
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
    }

   
}
