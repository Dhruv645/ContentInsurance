using ContentInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContentInsurance.Repository
{
    public class MockContentRepository : IContentRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Content> AllContents => new List<Content>
        {
            new Content{ContentId=1,Name="TV",Value=2000,CategoryId=1,Category=_categoryRepository.AllCategories.ToList()[0]},
            new Content{ContentId=2,Name="Playstation",Value=400,CategoryId=1,Category=_categoryRepository.AllCategories.ToList()[0]},
            new Content{ContentId=3,Name="Stereo",Value=1600,CategoryId=1,Category=_categoryRepository.AllCategories.ToList()[0]},
            new Content{ContentId=4,Name="Shirts",Value=1100,CategoryId=2,Category=_categoryRepository.AllCategories.ToList()[1]},
            new Content{ContentId=5,Name="Jeans",Value=1100,CategoryId=2,Category=_categoryRepository.AllCategories.ToList()[1]},
            new Content{ContentId=6,Name="Pots and Pans",Value=3000,CategoryId=3,Category=_categoryRepository.AllCategories.ToList()[2]},
            new Content{ContentId=7,Name="Flatware",Value=500,CategoryId=3,Category=_categoryRepository.AllCategories.ToList()[2]},
            new Content{ContentId=8,Name="Knife Set",Value=500,CategoryId=3,Category=_categoryRepository.AllCategories.ToList()[2]},
            new Content{ContentId=9,Name="Misc",Value=1000,CategoryId=3,Category=_categoryRepository.AllCategories.ToList()[2]},
        };

        public bool AddContent(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetContentById(int contentId)
        {
            return AllContents.FirstOrDefault(c => c.CategoryId == contentId);
        }

        public int GetContentTotalByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public int GetTotalForAllContentItems(IEnumerable<Content> contents)
        {
            throw new NotImplementedException();
        }

        public bool RemoveContentById(int contentId)
        {
            throw new NotImplementedException();
        }
    }
}
