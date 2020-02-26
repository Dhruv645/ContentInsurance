using ContentInsurance.Models;
using ContentInsurance.Repository;
using ContentInsurance.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContentInsurance.Controllers
{
    public class ContentController : Controller
    {
        private readonly IContentRepository _contentRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ContentController(IContentRepository contentRepository, ICategoryRepository categoryRepository)
        {
            _contentRepository = contentRepository;
            _categoryRepository = categoryRepository;
        }

        public ActionResult Edit()
        {
            Content content = new Content();
            ContentAddViewModel contentAddViewModel = new ContentAddViewModel
            {
                Content = content
            };
            var categories = _categoryRepository.AllCategories;
            contentAddViewModel.CategoryList = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();
            foreach (var category in categories)
            {
                contentAddViewModel.CategoryList.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem() { Text = category.Name, Value = category.CategoryId.ToString() });
            }
            contentAddViewModel.Contents = _contentRepository.AllContents;
            return View(contentAddViewModel);
        }

        [HttpPost]
        public ActionResult Edit(ContentAddViewModel contentListItem)
        {
            _contentRepository.AddContent(contentListItem.Content);
            return RedirectToAction("Edit");
        }

        public ActionResult Delete(int? id)
        {
            _contentRepository.RemoveContentById(id.Value);
            return RedirectToAction("Edit");
        }
    }
}
