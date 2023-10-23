using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAGedcom.Data.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please enter your username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }
    }
}
