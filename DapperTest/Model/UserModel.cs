using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DapperTest.Model
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required]
        public string Account { get; set; }

        public string Password { get; set; }
    }
}
