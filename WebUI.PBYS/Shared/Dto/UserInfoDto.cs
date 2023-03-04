using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.PBYS.Shared.Dto
{
    public class UserInfoDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid userkey { get; set; }
        public string? Role { get; set; }
        public bool status { get; set; }
    }
}
