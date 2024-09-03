﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Tiss.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
    }
}