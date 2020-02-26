using ContentInsurance.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ContentInsurance.ViewModels
{
    public class ContentAddViewModel
    {
        public Content Content { get; set; }

        public List<SelectListItem> CategoryList { get; set; }

        public IEnumerable<Content> Contents { get; set; }

        public int Total { get; set; }
    }
}
