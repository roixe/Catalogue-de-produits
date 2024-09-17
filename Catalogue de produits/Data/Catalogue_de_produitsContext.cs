using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Catalogue_de_produits.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Catalogue_de_produits.Data
{
    public class Catalogue_de_produitsContext : IdentityDbContext<IdentityUser>
    {
        public Catalogue_de_produitsContext (DbContextOptions<Catalogue_de_produitsContext> options)
            : base(options)
        {
        }

        public DbSet<Catalogue_de_produits.Models.Produit> Produit { get; set; } = default!;
    }
}
