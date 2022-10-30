using AutoMapper;
using HRProjectApplication.Models.VMs;
using HRProjectApplication.Services.AppUserService;
using HRProjectApplication.Services.CompanyService;
using HRProjectApplication.Services.LeaveService;
using HRProjectDomain.Entities;
using Microsoft.AspNetCore;
using HRProjectDomain.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;


namespace HRProjectApplication.Services.DashboardService
{
    public class DashboardService : IDashboardService
    {
        private readonly IAppUserService _appUserService;
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;
        private readonly ILeaveService _leaveService;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;


        public DashboardService(IAppUserService appUserService, IMapper mapper, ICompanyService companyService, ILeaveService leaveService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _appUserService = appUserService;
            _mapper = mapper;
            _companyService = companyService;
            _leaveService = leaveService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<DashboardVM> GetDashboardManager(string id)
        {
            var dashboardVM = new DashboardVM()
            {
                Employees = await _appUserService.GetAppUserEmployeesTake(5, id)
            };
            return dashboardVM;
        }

        public async Task<DashboardVM> GetDashboardAdmin()
        {
            var dashboardVM = new DashboardVM()
            {
                Companies = await _companyService.GetCompanies(),
                Managers = await _appUserService.GetAppUserManagersTake(5)
            };
            return dashboardVM;
        }

        public async Task<DashboardVM> GetDashboardEmployee(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var dashboardVM = new DashboardVM()
            {
                Leaves = await _leaveService.GetLeavesById(user.Id)
            };
            return dashboardVM;
        }
    }
}



