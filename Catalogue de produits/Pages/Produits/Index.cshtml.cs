using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Catalogue_de_produits.Data;
using Catalogue_de_produits.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Name { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? PoduitName { get; set; }

        public async Task OnGetAsync()
        {
            var produits = from p in _context.Produit
                         select p;

            if (!string.IsNullOrEmpty(SearchString))
            {
                produits = produits.Where(s => s.Name.Contains(SearchString));
            }

            Produit = await produits.ToListAsync();
        }
    }
}
