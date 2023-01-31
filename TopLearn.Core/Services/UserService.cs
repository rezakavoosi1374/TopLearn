using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TopLearn.Core.Convertors;
using TopLearn.Core.DTOs;
using TopLearn.Core.Generator;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.Users;
using TopLearn.DataLayer.Entities.Wallet;

namespace TopLearn.Core.Services
{
    public class UserService : IUserService
    {
        private TopLearnContext _context;

        public UserService(TopLearnContext context)
        {
            _context = context;
        }

        #region Panel
        public int BalanceUserWallet(string username)
        {
            int userId = GetUserIdByUserName(username);

            var deposit = _context.Wallets.Where(i => i.UserId == userId && i.TypeID == 1 && i.IsPay == true).Select(i => i.Amount).ToList();

            var withdraw = _context.Wallets.Where(i => i.UserId == userId && i.TypeID == 2).Select(i => i.Amount).ToList();

            return (deposit.Sum() - withdraw.Sum());
        }

        public void ChangeUserPassword(string newPassword, string username)
        {
            var user = GetUserByUserName(username);

            user.Password = PasswordHelper.EncodePasswordMd5(newPassword);

            UpdateUser(user);
        }

        public void EditProfile(string username, EditProfileViewModel model)
        {
            if (model.UserAvatar != null)
            {
                string imagePath = "";
                if (model.AvatarName != "Defult.jpg")
                {
                    imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/UserAvatar", model.AvatarName);
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }
                }

                model.AvatarName = NameGenerator.GenerateUniqueCode() + Path.GetExtension(model.UserAvatar.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/UserAvatar", model.AvatarName);

                using (var str = new FileStream(imagePath, FileMode.Create))
                {
                    model.UserAvatar.CopyTo(str);
                }

            }
            var user = GetUserByUserName(username);

            user.UserName = model.UserName;
            user.Email = model.Email;
            user.UserAvatar = model.AvatarName;

            UpdateUser(user);
        }

        public EditProfileViewModel GetDataForEditProfileUser(string username)
        {
            return _context.Users.Where(i => i.UserName == username).Select(i =>
            new EditProfileViewModel()
            {
                UserName = i.UserName,
                AvatarName = i.UserAvatar,
                Email = i.Email
            }).Single();
        }

        public int ChargeWallet(string username, int amount, string describtion, bool isPay = false)
        {
            Wallet wallet = new Wallet()
            {
                Amount = amount,
                CreateDate = DateTime.Now,
                Describtion = describtion,
                IsPay = isPay,
                TypeID = 1,
                UserId = GetUserIdByUserName(username),
            };
            return AddWallet(wallet);

        }

        public SideBarUserPanelViewModel GetSideBarUserPanelData(string username)
        {
            var user = _context.Users.SingleOrDefault(i => i.UserName == username);

            SideBarUserPanelViewModel sideBar = new SideBarUserPanelViewModel()
            {
                UserName = user.UserName,
                ImageName = user.UserAvatar,
                RegisterDate = user.RegisterDate,
            };

            return sideBar;
        }

        public UsersForAdminViewModel GetUsers(int pageId = 1, string filterEmail = "", string username = "")
        {
            IQueryable<User> result = _context.Users;

            if(!string.IsNullOrEmpty(filterEmail))
            {
                result = result.Where(i => i.Email.Contains(filterEmail));
            }

            if(!string.IsNullOrEmpty(username))
            {
                result = result.Where(i => i.UserName.Contains(username));
            }

            //Show Item In Page
            int take = 20;

            int skip = (pageId - 1) * take;

            UsersForAdminViewModel list = new UsersForAdminViewModel();
            list.CurrentPage = pageId;
            list.PageCount = result.Count() / take;
            list.Users = result.OrderBy(i => i.RegisterDate).Skip(skip).Take(take).ToList();
            return list;
        }
        #endregion

        #region Wallet
        public int AddWallet(Wallet wallet)
        {
            _context.Wallets.Add(wallet);
            _context.SaveChanges();

            return wallet.WalletId;
        }

        public List<WalletViewModel> GetWalletUser(string username)
        {
            int userId = GetUserIdByUserName(username);

            return _context.Wallets.Where(i => i.UserId == userId && i.IsPay == true)
                .Select(i => new WalletViewModel()
                {
                    Amount = i.Amount,
                    DateTime = i.CreateDate,
                    Describtion = i.Describtion,
                    Type = i.TypeID
                }).ToList();
        }

        public Wallet GetWalletByWalletId(int id)
        {
            return _context.Wallets.Find(id);
        }

        public void UpdateWallet(Wallet wallet)
        {
            _context.Wallets.Update(wallet);
            _context.SaveChanges();
        }
        #endregion

        #region User/Account
        public User GetUserByActiveCode(string activeCode)
        {
            return _context.Users.SingleOrDefault(i => i.ActiveCode == activeCode);
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(i => i.Email == email);
        }

        public User GetUserByUserName(string userName)
        {
            return _context.Users.SingleOrDefault(i => i.UserName == userName);
        }

        public int GetUserIdByUserName(string userName)
        {
            return _context.Users.Single(i => i.UserName == userName).UserId;
        }

        public InformationUserViewModel GetUserInformation(string username)
        {
            var user = GetUserByUserName(username);

            InformationUserViewModel information = new InformationUserViewModel()
            {
                UserName = user.UserName,
                Email = user.Email,
                RegisterDate = user.RegisterDate,
                Wallet = BalanceUserWallet(username)
            };

            return information;
        }

        public bool IsExistEmail(string email)
        {
            return _context.Users.Any(i => i.Email == email);
        }

        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(i => i.UserName == userName);
        }

        public User LoginUser(LoginViewModel login)
        {
            string hashPassword = PasswordHelper.EncodePasswordMd5(login.Password);
            string email = FixedText.FixEmail(login.Email);

            return _context.Users.SingleOrDefault(i => i.Password == hashPassword && i.Email == email);
        }

        public void UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }

        public bool CompareOldPassword(string oldPassword, string username)
        {
            string hashOldPassword = PasswordHelper.EncodePasswordMd5(oldPassword);

            return _context.Users.Any(i => i.UserName == username && i.Password == hashOldPassword);
        }

        public bool ActiveAccount(string activeCode)
        {
            var user = _context.Users.SingleOrDefault(i => i.ActiveCode == activeCode);

            if (user == null || user.IsActive)
            {
                return false;
            }

            user.IsActive = true;
            user.ActiveCode = NameGenerator.GenerateUniqueCode();
            _context.SaveChanges();
            return true;
        }

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }

      




        #endregion
















    }
}
