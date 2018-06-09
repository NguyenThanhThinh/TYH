using System;
using System.Collections.Generic;
using System.Text;
using TYH.Services.ViewModels.Category;

namespace TYH.Services.Interfaces
{
    public interface ICategoryService
    {
        CategoryViewModel Add(CategoryViewModel productCategoryVm);

        void Update(CategoryViewModel productCategoryVm);

        void Delete(int id);

        List<CategoryViewModel> GetAll();

        List<CategoryViewModel> GetAll(string keyword);

        List<CategoryViewModel> GetAllByParentId(int parentId);

        CategoryViewModel GetById(int id);

        void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items);
        void ReOrder(int sourceId, int targetId);

        List<CategoryViewModel> GetHomeCategories(int top);

        void Save();
    }
}
