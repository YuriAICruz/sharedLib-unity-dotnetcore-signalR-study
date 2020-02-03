﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using UnityEditor.UIElements;

namespace Graphene.SharedModels.ModelView
{
    public class LoginModelView
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsPersistent { get; set; }
        
        public LoginModelView(string userName, string password, bool isPersistent = false)
        {
            UserName = userName;
            password = password;
            IsPersistent = isPersistent;
        }

        public override string ToString()
        {
            return $"UserName: {UserName}";
        }
    }
}