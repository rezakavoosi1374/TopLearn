using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.Core.DTOs;
using TopLearn.DataLayer.Entities.Users;
using TopLearn.DataLayer.Entities.Wallet;

namespace TopLearn.Core.Services.Interfaces
{
    public interface IUserService
    {
        bool IsExistUserName(string userName);

        bool IsExistEmail(string email);

        int AddUser(User user);

        User LoginUser(LoginViewModel login);

        bool ActiveAccount(string activeCode);

        User GetUserByEmail(string email);

        User GetUserByUserName(string userName);

        User GetUserByActiveCode(string activeCode);

        void UpdateUser(User user);

        int GetUserIdByUserName(string userName);

        #region User Panel
        InformationUserViewModel GetUserInformation(string username);

        SideBarUserPanelViewModel GetSideBarUserPanelData(string username);

        EditProfileViewModel GetDataForEditProfileUser(string username);

        void EditProfile(string username, EditProfileViewModel model);

        bool CompareOldPassword(string oldPassword, string username);

        void ChangeUserPassword(string newPassword,string username);
        #endregion

        #region Wallet
        int BalanceUserWallet(string username);

        List<WalletViewModel> GetWalletUser(string username);

        int ChargeWallet(string username,int amount,string describtion, bool isPay=false);

        int AddWallet(Wallet wallet);

        Wallet GetWalletByWalletId(int id);

        void UpdateWallet(Wallet wallet);
        #endregion


    }
}
