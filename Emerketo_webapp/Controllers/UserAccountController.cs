using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Emerketo_webapp.Controllers
{
    public class UserAccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserAccountController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> MyAccount()
        {
            // Get the current user
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                // User not found, redirect to the login page.
                // Not sure if this is the best method, but the 
                // RedirectToPage() wasn't working as expected.
                return Redirect("/Identity/Account/Login");
            }

            // Get the role for the user
            var role = (await _userManager.GetRolesAsync(user)).FirstOrDefault();

            // Set the role in ViewBag
            ViewBag.Role = role;

            // Pass the user object to the view
            return View(user);
        }
        public async Task<IActionResult> AllAccounts()
        {
            var users = await _userManager.Users.ToListAsync();
            var roles = await _roleManager.Roles.ToListAsync();

            var usersWithRoles = new List<dynamic>();

            foreach (var user in users)
            {
                var userRole = (await _userManager.GetRolesAsync(user)).FirstOrDefault();
				var userWithRoles = new
                {
                    User = user,
                    Role = userRole
                };
                usersWithRoles.Add(userWithRoles);
            }

            ViewBag.UsersWithRoles = usersWithRoles;
            ViewBag.AllRoles = roles;

            return View();
        }

    }
}
