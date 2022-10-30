using HRProjectApplication.Models.VMs;
using HRProjectApplication.Services.DashboardService;
using HRProjectDomain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProjectUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDashboardService _dashboardService;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(IDashboardService dashboardService, UserManager<AppUser> userManager)
        {
            _dashboardService = dashboardService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            AppUser signedUser = await _userManager.GetUserAsync(User); //Signed user seçildi
            if (User.IsInRole("Manager"))
            {
                DashboardVM model = await _dashboardService.GetDashboardManager(signedUser.CompanyId.ToString());
                return View(model);          

            }
            else if (User.IsInRole("Admin"))
            {
                DashboardVM model = await _dashboardService.GetDashboardAdmin();
                return View(model);
            }
            else
            {
                DashboardVM model = await _dashboardService.GetDashboardEmployee(signedUser.Id);
                return View(model);
            }
        }
    }
}
