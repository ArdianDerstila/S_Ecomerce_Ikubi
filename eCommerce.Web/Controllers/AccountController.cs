using eCommerce.Data;
using eCommerce.Repository;
using eCommerce.Service.Interfaces;
using eCommerce.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Web.Controllers
{

    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IBaseService _baseService;
        private readonly ILogger<AccountController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(ILogger<AccountController> logger, IUnitOfWork unitOfWork, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager/*, IAuthorizationService autorizationService*/, AppDbContext context, IBaseService baseService)
        {


            _logger = logger;

            _userManager = userManager;
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
            _roleManager = roleManager;
            _context = context;
            _baseService = baseService;

            //_autorizationService = autorizationService;
        }

        public IActionResult Login()
        {
            var model = new LoginRegisterModel
            {
                Login = new Login(),
                Register = new Register()
            };
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {

            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Register(Register register)
        {
            try
            {
                ApplicationUser model = new ApplicationUser();

                model.UserName = register.Username;
                model.Email = register.Email;
                model.FirstName = register.FirstName;
                model.LastName = register.LastName;
                model.BirthDate = register.BirthDate;


                IdentityResult result = _userManager.CreateAsync(model, register.Password).Result;

                var deletedRoles = _userManager.GetRolesAsync(model).Result;

                if (deletedRoles.Count > 0)
                    result = _userManager.RemoveFromRolesAsync(model, deletedRoles).Result;


                //if (!string.IsNullOrEmpty(user.RoleId))
                //{
                var newrole = _roleManager.FindByIdAsync("ca4865aa-c86d-4dda-bc4e-8d91930e0c2b").Result;

                result = _userManager.AddToRoleAsync(model, newrole.Name).Result;
                // }


                return RedirectToAction("Index", "Home");
           
             
            }
            catch (Exception ex)
            {
                return RedirectToAction("Login");


            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.FindByNameAsync(login.Username);
                if (user != null)
                {
                    await _signInManager.SignOutAsync();
                    var result = await _signInManager.PasswordSignInAsync(user, login.Password, false, false);

                    if (result.Succeeded)
                    {
                        // Config.Permission_Order_View = _autorizationService.AuthorizeAsync(User, Permissions.Order.View).Result.Succeeded;
                        return RedirectToAction("Index", "Home");
                    }


                    //if (string.IsNullOrEmpty(user.HomePage))
                    //        return RedirectToAction("Index", "Home");
                    //    else 
                    //        return Redirect(user.HomePage);

                    //return Redirect(login.ReturnUrl ?? "/");
                }

                return RedirectToAction("Login", "Account");
            //   ModelState.AddModelError(nameof(login.Username), "Login Failed: Invalid Email or password");
            }
            return View(login);
        }




    }
}
