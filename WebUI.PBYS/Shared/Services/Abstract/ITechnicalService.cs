using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.PBYS.Shared.Dto;

namespace WebUI.PBYS.Shared.Services.Abstract
{
    public interface ITechnicalService
    {
        Task Add(TechnicalServiceDto model);
        Task<TechnicalServiceDto> GetById(int ProductId);
        Task<TechnicalServiceDto[]> GetAll();
    }
}
