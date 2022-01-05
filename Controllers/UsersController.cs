using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentLance.Data;
using StudentLance.Models.DbModels.User;
using StudentLance.Models.ViewModels.User;
using Microsoft.AspNetCore.DataProtection;

namespace StudentLance.Controllers
{
    public class UsersController : Controller
    {
        private readonly StudentLanceDataContext _context;
        private readonly IDataProtector _dataProtector;
        Guid AuthorityId = Guid.Empty;
        string ControllerName = String.Empty;

        public UsersController(
            StudentLanceDataContext context,
            IDataProtectionProvider dataProtectionProvider)
        {
            _context = context;
            _dataProtector = dataProtectionProvider.CreateProtector("PasswordProtector");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.User.FirstOrDefaultAsync(u => u.UserName == userLoginViewModel.UserName);

                if (user is null || _dataProtector.Unprotect(user.Password) != userLoginViewModel.Password)
                {
                    userLoginViewModel.IsConfirmed = false;
                    ModelState.ClearValidationState(nameof(UserLoginViewModel));
                }

                if (TryValidateModel(userLoginViewModel))
                {
                    try
                    {
                        switch (user.UserType)
                        {
                            case Enumerations.UserType.Student:
                                ControllerName = "Students";
                                AuthorityId = (await _context.Student.FirstOrDefaultAsync(s => s.User.Id == user.Id)).Id;
                                break;
                            case Enumerations.UserType.Employer:
                                ControllerName = "Employers";
                                AuthorityId = (await _context.Employer.FirstOrDefaultAsync(s => s.User.Id == user.Id)).Id;
                                break;
                            default:
                                break;
                        }
                        return RedirectToAction("Index", ControllerName, new { Id = AuthorityId });
                    }
                    catch (NullReferenceException e)
                    {
                        return RedirectToAction("Register", ControllerName);
                    }
                    finally
                    {

                    }
                }
            }
            return View(userLoginViewModel);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(
            [Bind("UserName", "Password", "FirstName", "LastName", "BirthDate", "Email", "PhoneNumber", "UserType")]
            UserModel user)
        {
            if (ModelState.IsValid)
            {
                user.Password = _dataProtector.Protect(user.Password);
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            return View(user);
        }
    }
}
