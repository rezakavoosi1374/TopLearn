using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.DataLayer.Entities.Users;

namespace TopLearn.Core.DTOs
{
    public class UsersForAdminViewModel
    {
        public List<User> Users { get; set; }

        public int CurrentPage { get; set; }

        public int PageCount { get; set; }
    }
}
