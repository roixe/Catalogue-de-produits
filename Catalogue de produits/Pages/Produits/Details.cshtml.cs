using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Catalogue_de_produits.Data;
using Catalogue_de_produits.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Catalogue_de_produits.Pages.Produits
{
    [Authorize(Roles = "Admin,User")]
    
    public class DetailsModel : PageModel
    {
        private readonly Catalogue_de_produits.Data.Catalogue_de_produitsContext _context;
       
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public bool IsAdmin { get; set; }
        public bool IsUser { get; set; }


        public DetailsModel(Catalogue_de_produits.Data.Catalogue_de_produitsContext context)
        {
            _context = context;
        }
        

        public Produit Produit { get; set; } = default!;
        


        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var produit = await _context.Produit.FirstOrDefaultAsync(m => m.Id == id);
            if (produit == null)
            {
                return NotFound();
            }
            else
            {
                Produit = produit;
            }
            return Page();
        }
    }
}
