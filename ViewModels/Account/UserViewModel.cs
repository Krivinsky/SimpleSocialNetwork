using Microsoft.AspNetCore.Mvc;
using SimpleSocialNetwork.Models.Users;

namespace SimpleSocialNetwork.ViewModels.Account
{
    public class UserViewModel
    {
        public User User { get; set; }

        public UserViewModel(User user) 
        {
            User = user;
        }
    }
}
