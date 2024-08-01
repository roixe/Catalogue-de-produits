using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Catalogue_de_produits.Data;
using Catalogue_de_produits.Models;
using RazorPagesMovie.Models;
using Microsoft.AspNetCore.Identity;


namespace Catalogue_de_produits
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Catalogue_de_produitsContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Catalogue_de_produitsContext") ?? throw new InvalidOperationException("Connection string 'Catalogue_de_produitsContext' not found.")));

           
            builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<Catalogue_de_produitsContext>();
            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                SeedData.Initialize(services);
            }
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}