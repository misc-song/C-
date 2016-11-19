using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetModel
{
    public class PetCategory
    {
        public PetCategory(string categoryId, string name, string descn)
        {
            this.CategoryId = categoryId;
            this.Descn = descn;
            this.Name = name;
        }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string Descn { get; set; }
    }
    public class PetProduct
    {
        public PetProduct(string productId, string name, string descn, string image, PetCategory petCategory)
        {
            this.Image = image;
            this.Descn = descn;
            this.Name = name;
            this.PetCategory = petCategory;
            this.ProductId = productId;
        }
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Descn { get; set; }
        public string Image { get; set; }
        public PetCategory PetCategory { get; set; }
    }
    public class PetModel
    {
    }
}
