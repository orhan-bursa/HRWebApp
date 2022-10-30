﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProjectApplication.Models.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Must to type UserName")]
        [MinLength(3, ErrorMessage = "Minimun lenght is 3")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Must to type Password")]
        [MinLength(3, ErrorMessage = "Minimun lenght is 3")]
        public string Password { get; set; }
    }
}
