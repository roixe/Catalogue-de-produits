using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Catalogue_de_produits.Data;
using Catalogue_de_produits.Models;

namespace Catalogue_de_produits.Pages.Produits
{
    public class IndexModel : PageModel
    {
        private readonly Catalogue_de_produits.Data.Catalogue_de_produitsContext _context;

        public IndexModel(Catalogue_de_produits.Data.Catalogue_de_produitsContext context)
        {
            _context = context;
        }

        public IList<Produit> Produit { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Produit = await _context.Produit.ToListAsync();
        }
    }
}
