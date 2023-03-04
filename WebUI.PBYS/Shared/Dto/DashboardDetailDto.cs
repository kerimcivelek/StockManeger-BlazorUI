using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.PBYS.Shared.Dto
{
    public class DashboardDetailDto : DashBoardTotalDto
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
    }
}
