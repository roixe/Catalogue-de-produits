using Catalogue_de_produits.Data;
using Microsoft.AspNetCore.Identity;

namespace Catalogue_de_produits.Models
{
    public class SeedDataRoles
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            string[] roleNames = { "Admin", "User"};
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            var user = await userManager.FindByEmailAsync("eliottcheminal@gmail.com");
            if (user == null)
            {
                var adminUser = new IdentityUser
                {
                    UserName = "eliottcheminal@gmail.com",
                    Email = "eliottcheminal@gmail.com",
                    EmailConfirmed = true,
                };
                string adminPassword = "Eroixe3*3";
                var createAdmin = await userManager.CreateAsync(adminUser, adminPassword);
                if (createAdmin.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}
