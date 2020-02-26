using ContentInsurance.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentInsurance.ViewModels
{
    public class ContentAddViewModel
    {
        public Content Content { get; set; }
        public List<SelectListItem> CategoryList { get; set; }
        public IEnumerable<Content> Contents { get; set; }
    }
}
