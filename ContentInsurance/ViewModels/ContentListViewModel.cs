using ContentInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentInsurance.ViewModels
{
    public class ContentListViewModel
    {
        public IEnumerable<Content> Contents { get; set; }
        public int Total { get; set; }
    }
}
