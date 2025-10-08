using System.Collections.Generic;
using test.Models;

namespace test.Models
{
    public class DI
    {
        public static List<Category> Categories { get; private set; }
        public static List<Product> Products { get; private set; }

        // Hàm khởi tạo dữ liệu tĩnh (DI gán sẵn)
        static DI()
        {
            // Danh mục sản phẩm
            Categories = new List<Category>
            {
                new Category { Id = 1, Name = "Giày Thể Thao" },
                new Category { Id = 2, Name = "Giày Da" },
                new Category { Id = 3, Name = "Sandal" }
            };

            // Sản phẩm
            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Giày Nike Air", CategoryId = 1, Price = 1200000, Image = "/images/nike.jpg" },
                new Product { Id = 2, Name = "Giày Adidas Ultraboost", CategoryId = 1, Price = 2000000, Image = "/images/adidas.jpg" },
                new Product { Id = 3, Name = "Giày Da Nam LV", CategoryId = 2, Price = 3500000, Image = "/images/lv.jpg" },
                new Product { Id = 4, Name = "Sandal Nữ", CategoryId = 3, Price = 450000, Image = "/images/sandal.jpg" }
            };

            // Gắn tên danh mục cho sản phẩm (kết bảng thủ công)
            foreach (var p in Products)
            {
                var cat = Categories.Find(c => c.Id == p.CategoryId);
                if (cat != null)
                    p.CategoryName = cat.Name;
            }
        }

        // Hàm lấy danh sách sản phẩm
        public static List<Product> GetProducts()
        {
            return Products;
        }

        // Hàm lấy danh mục
        public static List<Category> GetCategories()
        {
            return Categories;
        }
    }
}
