using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TopLearn.Core.DTOs;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Web.Pages.Admin.Users
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;
        private IUserService _userService;

        public Index(ILogger<Index> logger,IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public UsersForAdminViewModel UsersForAdminViewModel { get; set; }

        public void OnGet()
        {
            UsersForAdminViewModel = _userService.GetUsers();
        }
    }
}