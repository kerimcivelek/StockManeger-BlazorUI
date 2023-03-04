using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.PBYS.Shared.Dto;

namespace WebUI.PBYS.Shared.Services.Abstract
{
    public interface ICategoryService
    {
        Task CategoryAdd(CategoryDto model);
        Task<CategoryDto[]> GetAllCategory();
        Task<CategoryDto[]> GetCategoryById(int id);
        Task<BaseCategoryDto[]> BaseCategory();

        Task<CategoryBrandModelDto[]> ModelList();
        Task BrandAdd(BrandDto model);
        Task ModelAdd(ModelDto model);
        Task BrandRemove(int id);
        Task<BrandDto[]> Brands(int categoryId);
        Task<ModelDto[]> Models(int BrandId);
        Task<CategoryBrandDto[]> CategoryBrandList();
    }
}
