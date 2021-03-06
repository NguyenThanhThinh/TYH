﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TYH.Domain.Entities;
using TYH.Utilities;
using TYH.Web.Models.AccountViewModels;

namespace TYH.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger _logger;


        public LoginController(UserManager<User> userManager, SignInManager<User> signInManager
            , ILogger<LoginController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Page login index");

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Authen(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result =
                    await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return new OkObjectResult(new GenericResult(true));
                }

                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return new ObjectResult(new GenericResult(false, "Tài khoản đã bị khoá"));
                }

                return new ObjectResult(new GenericResult(false, "Đăng nhập sai"));
            }

            // If we got this far, something failed, redisplay form
            return new ObjectResult(new GenericResult(false, model));
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return Redirect("/Admin/Login/Index");
        }
    }
}