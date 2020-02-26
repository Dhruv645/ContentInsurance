using ContentInsurance.Models;
using System.Collections.Generic;

namespace ContentInsurance.Repository
{
    public interface IContentRepository
    {
        Content GetContentById(int contentId);

        IEnumerable<Content> AllContents { get; }
        
        int GetContentTotalByCategoryId(int categoryId);
        
        bool AddContent(Content content);
        
        bool RemoveContentById(int contentId);

        int GetTotalForAllContentItems(IEnumerable<Content> contents);
    }
}
