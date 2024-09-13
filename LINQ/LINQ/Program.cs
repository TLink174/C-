var brands = new List<Brand>()
{
    new Brand { ID = 1, Name = "Samsung" },
    new Brand { ID = 2, Name = "Apple" },
    new Brand { ID = 3, Name = "Huawei" },
    new Brand { ID = 4, Name = "Xiaomi" },
    new Brand { ID = 5, Name = "Nokia" },
};
public class Product
{
    public int ID {set; get;}
    public string Name {set; get;}         // tên
    public double Price {set; get;}        // giá
    public string[] Colors {set; get;}     // các màu sắc
    public int Brand {set; get;}           // ID Nhãn hiệu, hãng
    public Product(int id, string name, double price, string[] colors, int brand)
    {
        ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
    }
    // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
    override public string ToString()
        => $"{ID,3} {Name, 12} {Price, 5} {Brand, 2} {string.Join(",", Colors)}";

}
public class Brand {
    public string Name {set; get;}
    public int ID {set; get;}
    static List<Brand> _brands; 
    public static List<Brand> brands { 
        get {
            if (_brands == null) {
                _brands = new List<Brand>() {
                    new Brand{ID = 1, Name = "Công ty AAA"},
                    new Brand{ID = 2, Name = "Công ty BBB"},
                    new Brand{ID = 4, Name = "Công ty CCC"},
                };
            }
            return _brands;
        }
    } 
}

public class Products
{
    // thành viên biến tĩnh, là danh sách sản phẩm
    public static List<Product> products;

    // Hàm khởi tạo thành viên tĩnh
    static Products()
    {
        // Khởi tạo products với 7 sản phẩm mẫu
        products = new List<Product>()
        {
            new Product(1, "iPhone13", 1000, new string[] { "vang", "do" }, 2),
            new Product(2, "Samsung Galaxy", 500, new string[] { "xanh", "vang" }, 1),
            new Product(3, "Xiaomi Redmi11", 700, new string[] { "xanh", "do" }, 4),
            new Product(4, "Huawei P30", 300, new string[] { "den" }, 3),
            new Product(5, "Nokia 6300", 400, new string[] { "do" }, 5),
            new Product(6, "Xiaomi Redmi10", 400, new string[] { "vang" }, 5),
            new Product(7, "Nokia 6000", 200, new string[] { "do" }, 5),
            new Product(8, "Huawei P40", 400, new string[] { "do" }, 5),
            
        };
    }

    // In ra các sản phẩm có giá 500
    public static void ProductPrice500()
    {
        var products = Products.products;
        var ketqua = from product in products
            where product.Price == 400
            select product;

        foreach (var product in ketqua)
            Console.WriteLine(product.ToString());
    }
}
class Program
    {
        
        static void Main(string[] args)
        {
            Products.ProductPrice500();
            /* 

            var products =  Product.products;
            var brands   =  Brand.brands; 


            // truy vấn cơ bản
            var ketqua = from product in products
                where product.Price == 400
                select product;
            Console.WriteLine("Các sản phẩm giá 400:");
            foreach (var product in ketqua)
                Console.WriteLine(product.ToString());
            Console.WriteLine();    
      
               

            // tạo đối tượng vô danh kết quả trả về
            var ketqua1 = from product in products
                        where product.Price == 400 
                        select new {
                            ten = product.Name,
                            mausac = string.Join(',', product.Colors)
                        };
            Console.WriteLine("Tên, màu sắc sản phẩm có giá 400");
            foreach (var item in ketqua1) Console.WriteLine(item.ten + " - " + item.mausac);
            Console.WriteLine();    
 


            // lọc dữ liệu bằng where
            var ketqua2 = from product in products
                where product.Price >= 500
                where product.Name.StartsWith("Giường")
                select product;
            Console.WriteLine("Sản phẩm có tên bắt đầu là Giường, giá trên 500");
            foreach (var product in ketqua2)
                Console.WriteLine(product.ToString());
            Console.WriteLine();    
      

            //sử dụng from kết hợp để lọc
            var ketqua3 = from product in products
                          from color in product.Colors
                            where product.Price < 500
                            where color == "Vàng"
                            select product;
            Console.WriteLine("Sản phẩm có màu Vàng, giá dưới 500");
            foreach (var product in ketqua3) Console.WriteLine(product.ToString());
            Console.WriteLine();    


            // Sắp xếp bằng orderby
            var ketqua4 = from product in products
                        where product.Price <= 300
                        orderby product.Price descending
                        select product;

            Console.WriteLine("Sản phẩm giá nhỏ hơn bằng 300, sắp xếp theo giá giảm dần");
            foreach (var product in ketqua4) Console.WriteLine($"{product.Name} - {product.Price}");
            Console.WriteLine(); 

            // Nhóm kết quả bằng group
            var ketqua5 = from product in products
            where product.Price >=400 && product.Price <= 500
            group product by product.Price;
            
            Console.WriteLine("Các sản phẩm nhóm theo giá 400, 500");
            foreach (var group in ketqua5)
            {
                Console.WriteLine(group.Key);
                foreach (var product in group)
                {
                    Console.WriteLine($"    {product.Name} - {product.Price}");
                }

            }
            Console.WriteLine(); 

            // dùng biến trong truy vấn
            var ketqua6 = from product in products
            group product by product.Price into gr
            let count = gr.Count()
            select new {
                price = gr.Key,
                number_product = count
            };
            Console.WriteLine("Số sản phẩm theo giá");
            foreach (var item in ketqua6)
            {
                Console.WriteLine($"   Giá {item.price} - có {item.number_product} sp");
            } 
            Console.WriteLine();


            // inner join
            var ketqua7 = from product in products
                        join brand in brands on product.Brand equals brand.ID
                        select new {
                            name  = product.Name,
                            brand = brand.Name,
                            price = product.Price
                        };
            
            Console.WriteLine("Sản phẩm - giá - tên hãng");
            foreach (var item in ketqua7)
            {
                Console.WriteLine($"{item.name,10} {item.price, 4} {item.brand,12}");
            }
            Console.WriteLine();


            // left join
            var ketqua8 = from product in products
                        join brand in brands on product.Brand equals brand.ID into t
                        from brand in t.DefaultIfEmpty()
                        select new {
                            name  = product.Name,
                            brand = (brand == null) ? "NO-BRAND" : brand.Name,
                            price = product.Price
                        };
            Console.WriteLine("Sản phẩm - giá - tên hãng");
            foreach (var item in ketqua8)
            {
                Console.WriteLine($"{item.name,10} {item.price, 4} {item.brand,12}");
            }
            */
        }
    }