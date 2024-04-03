using Microsoft.AspNetCore.Identity;

namespace Clinic_ManagementSystem.Models
{
    
    public static class LoginSeed
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<Login>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string[] roleNames = { "Administrator", "Doctor" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            var adminUser = new Login
            {
                UserName = "admin@example.com",
                Password = "admin@example.com",
                // Add other properties as needed
            };

            var doctorUser = new Login
            {
                UserName = "doctor@example.com",
                Password = "doctor@example.com",
                // Add other properties as needed
            };

            await userManager.CreateAsync(adminUser, "YourPassword");
            await userManager.AddToRoleAsync(adminUser, "Administrator");

            await userManager.CreateAsync(doctorUser, "YourPassword");
            await userManager.AddToRoleAsync(doctorUser, "Doctor");
        }
    }
}
