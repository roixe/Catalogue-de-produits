using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Catalogue_de_produits.Models;
using Catalogue_de_produits.Data;
using Catalogue_de_produits.Pages.Produits;
using Microsoft.EntityFrameworkCore;


namespace Catalogue_de_produits.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Catalogue_de_produits.Data.Catalogue_de_produitsContext _context;


        public IndexModel(ILogger<IndexModel> logger, Catalogue_de_produits.Data.Catalogue_de_produitsContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IList<Produit> Produit { get; set; } = default!;


        public async Task OnGetAsync()
        {
            var produits = from p in _context.Produit
                           select p;
            Produit = await produits.ToListAsync();

        }
    }
}