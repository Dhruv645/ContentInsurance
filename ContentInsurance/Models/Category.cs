using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentInsurance.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Content> Contents { get; set; }
        public int TotalValue
        {
            get
            {
                var totalValue = 0;
                foreach (var content in Contents)
                {
                    totalValue += content.Value;
                }
                return totalValue;
            }
        }
    }
}