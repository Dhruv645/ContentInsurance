using ContentInsurance.Infrastructure;
using ContentInsurance.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ContentInsurance.Repository
{
    public class ContentRepository : IContentRepository
    {
        private readonly AppDbContext _appDbContext;

        public ContentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Content> AllContents
        {
            get
            {
                return _appDbContext.Contents.Include(c => c.Category);
            }
        }

        public Content GetContentById(int contentId)
        {
            return _appDbContext.Contents.FirstOrDefault(c => c.ContentId == contentId);
        }

        public int GetContentTotalByCategoryId(int categoryId)
        {
           return _appDbContext.Contents.Where(f => f.CategoryId == categoryId).Sum(f => f.Value);
        }

        public List<Content> GetContentByCategoryId(int categoryId)
        {
            return _appDbContext.Contents.Where(f => f.CategoryId == categoryId).ToList();
        }

        public bool AddContent(Content content)
        {
            try
            {
                _appDbContext.Add(content);
                _appDbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveContentById(int contentId)
        {
            try
            {
                _appDbContext.Remove(GetContentById(contentId));
                _appDbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
