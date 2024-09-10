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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;



namespace Catalogue_de_produits.Pages.Produits
{
    [Authorize(Roles = "Admin,User")]
    public class IndexModel : PageModel
    {
        private readonly Catalogue_de_produits.Data.Catalogue_de_produitsContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public bool IsAdmin { get; set; }
        public bool IsUser { get; set; }

        public IndexModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, Catalogue_de_produits.Data.Catalogue_de_produitsContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
            var user = await _userManager.GetUserAsync(User);
            IsAdmin = user != null && await _userManager.IsInRoleAsync(user, "Admin");
            IsUser = user != null && await _userManager.IsInRoleAsync(user, "User");
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
