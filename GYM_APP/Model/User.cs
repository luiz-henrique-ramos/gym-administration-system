﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace GYM.Model
{
    public class User 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Username { get; set; }
        public string Password { get; set; }
        public string? FirstName { get; set; }
        public User(){ }
        

    } 
}

