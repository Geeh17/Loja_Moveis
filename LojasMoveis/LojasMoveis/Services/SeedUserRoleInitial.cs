using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace LojasMoveis.Services
{
    public class SeedUserRoleInitial : ISeedUserRoleInitial
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public SeedUserRoleInitial(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        public void SeedRoles()
        {
            if (!_roleManager.RoleExistsAsync("Member").Result)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "Member",
                    NormalizedName = "MEMBER"
                };
                _roleManager.CreateAsync(role).Wait();
            }

            if (!_roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                };
                _roleManager.CreateAsync(role).Wait();
            }
        }

        public void SeedUsers()
        {
            var userEmail = _configuration["SeedSettings:UserEmail"] ?? "usuario@localhost";
            var userPassword = _configuration["SeedSettings:UserPassword"]
                ?? throw new InvalidOperationException("SeedSettings:UserPassword não configurado.");

            var adminEmail = _configuration["SeedSettings:AdminEmail"] ?? "admin@localhost";
            var adminPassword = _configuration["SeedSettings:AdminPassword"]
                ?? throw new InvalidOperationException("SeedSettings:AdminPassword não configurado.");

            if (_userManager.FindByEmailAsync(userEmail).Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = userEmail,
                    Email = userEmail,
                    NormalizedUserName = userEmail.ToUpper(),
                    NormalizedEmail = userEmail.ToUpper(),
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                IdentityResult result = _userManager.CreateAsync(user, userPassword).Result;
                if (result.Succeeded)
                    _userManager.AddToRoleAsync(user, "Member").Wait();
            }

            if (_userManager.FindByEmailAsync(adminEmail).Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    NormalizedUserName = adminEmail.ToUpper(),
                    NormalizedEmail = adminEmail.ToUpper(),
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                IdentityResult result = _userManager.CreateAsync(user, adminPassword).Result;
                if (result.Succeeded)
                    _userManager.AddToRoleAsync(user, "Admin").Wait();
            }
        }
    }
}
