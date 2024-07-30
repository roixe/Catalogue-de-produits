using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Catalogue_de_produits.Models;

namespace Catalogue_de_produits.Data
{
    public class Catalogue_de_produitsContext : DbContext
    {
        public Catalogue_de_produitsContext (DbContextOptions<Catalogue_de_produitsContext> options)
            : base(options)
        {
        }

        public DbSet<Catalogue_de_produits.Models.Produit> Produit { get; set; } = default!;
    }
}
