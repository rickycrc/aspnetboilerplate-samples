﻿using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;
using Acme.PhoneBook.Authorization.Users;

namespace Acme.PhoneBook.Models.TokenAuth
{
    public class AuthenticateModel
    {
        [Required]
        [MaxLength(AbpUserBase.MaxEmailAddressLength)]
        public string UserNameOrEmailAddress { get; set; }

        [Required]
        [MaxLength(User.MaxPlainPasswordLength)]
        public string Password { get; set; }
        
        public bool RememberClient { get; set; }
    }
}
