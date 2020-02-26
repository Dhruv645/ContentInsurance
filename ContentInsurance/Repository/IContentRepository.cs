using ContentInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentInsurance.Repository
{
    public interface IContentRepository
    {
        Content GetContentById(int contentId);
        IEnumerable<Content> AllContents { get; }
        int GetContentTotalByCategoryId(int categoryId);
        bool AddContent(Content content);
        bool RemoveContentById(int contentId);
    }
}
