using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class LoginDTO
    { 
        public string Username { get; set; }
        public string Password { get; set; }
    }
}