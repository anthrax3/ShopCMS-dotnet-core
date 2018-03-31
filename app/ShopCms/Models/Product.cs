using System.Collections.Generic;

namespace ShopCms.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
        public List<Category> Categories { get; set; }
        public List<Variant> Variants { get; set; }
    }
}
