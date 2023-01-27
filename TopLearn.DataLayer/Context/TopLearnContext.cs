using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.DataLayer.Entities.Users;
using TopLearn.DataLayer.Entities.Wallet;

namespace TopLearn.DataLayer.Context
{
    public class TopLearnContext : DbContext
    {
        public TopLearnContext(DbContextOptions<TopLearnContext> opt) : base(opt)
        {
        }

        #region User
        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
        #endregion

        #region Wallet
        public DbSet<Wallet> Wallets { get; set; }

        public DbSet<WalletType> WalletTypes { get; set; }
        #endregion

    }
}
