using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.PBYS.Shared.Dto;

namespace WebUI.PBYS.Shared.Services.Abstract
{
    public interface IDashboardService
    {
        Task<DashBoardTotalDto[]> DashboardTotalDay();

        Task<DashboardDetailDto[]> DashboardDetailDay(int EntryOut);
    }
}
