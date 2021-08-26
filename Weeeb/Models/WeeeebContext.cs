using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Weeeb.Models
{
    public class WeeeebContext
    {
        public WeeeebContext()
        {

        }
        public string ConnectionString { get; set; }
        public WeeeebContext (string connectionstring)
        {
            this.ConnectionString = connectionstring;
        }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<Products> GetSanPham1()
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE product_id BETWEEN 71 AND 77", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Products> GetSanPham2()
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE product_id BETWEEN 4 AND 9", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public Products GetProByMa(int id)
        {
            Products s = new Products();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from products where product_id=@masach";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("masach", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        s.product_id = int.Parse(reader["product_id"].ToString());
                        s.product_cat = int.Parse(reader["product_cat"].ToString());
                        s.product_brand = int.Parse(reader["product_brand"].ToString());
                        s.product_title = reader["product_title"].ToString();
                        s.product_price = int.Parse(reader["product_price"].ToString());
                        s.product_desc = reader["product_desc"].ToString();
                        s.product_image = reader["product_image"].ToString();
                        s.product_keywords = reader["product_keywords"].ToString();
                    }

                }
            }
            return s;
        }
        public List<Products> GetSanPham3()
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products,categories WHERE product_cat=cat_id AND product_id BETWEEN $product_id AND $product_id+3", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Products> GetSanPhamCat(int cat)
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE product_cat =@cat", conn);
                cmd.Parameters.AddWithValue("cat", cat);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Products> GetSanPhamBrand(int cat)
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE product_brand =@cat", conn);
                cmd.Parameters.AddWithValue("cat", cat);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Products> GetSanPham()
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<User_Info> GetTaiKhoan()
        {
            List<User_Info> list = new List<User_Info>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM user_info", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User_Info()
                        {
                            user_id = int.Parse(reader["user_id"].ToString()),
                            first_name = reader["first_name"].ToString(),
                            last_name = reader["last_name"].ToString(),
                            email = reader["email"].ToString(),
                            password = reader["password"].ToString(),
                            mobile = reader["mobile"].ToString(),
                            address1 = reader["address1"].ToString(),
                            address2 = reader["address2"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Email_Info> GetEmail()
        {
            List<Email_Info> list = new List<Email_Info>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM email_info", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Email_Info()
                        {
                            email_id = int.Parse(reader["email_id"].ToString()),
                            email = reader["email"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Categories> GetCat()
        {
            List<Categories> list = new List<Categories>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM categories", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Categories()
                        {
                            cat_id = int.Parse(reader["cat_id"].ToString()),
                            cat_title = reader["cat_title"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Brands> GetBra()
        {
            List<Brands> list = new List<Brands>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM brands", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Brands()
                        {
                            brand_id = int.Parse(reader["brand_id"].ToString()),
                            brand_title = reader["brand_title"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public int AddUser(User_Info s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into user_info(first_name, last_name,email,password,mobile,address1,address2) values (@first_name,@last_name,@email,@password,@mobile,@address1,@address2)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("first_name", s.first_name);
                cmd.Parameters.AddWithValue("last_name", s.last_name);
                cmd.Parameters.AddWithValue("email", s.email);
                cmd.Parameters.AddWithValue("password", s.password);
                cmd.Parameters.AddWithValue("mobile", s.mobile);
                cmd.Parameters.AddWithValue("address1", s.address1);
                cmd.Parameters.AddWithValue("address2", s.address2);

                return (cmd.ExecuteNonQuery());

            }
        }
        public int AddPro(Products s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into products(product_cat, product_brand,product_title,product_price,product_desc,product_image,product_keywords) values (@a,@b,@c,@d,@e,@f,@g)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s.product_cat);
                cmd.Parameters.AddWithValue("b", s.product_brand);
                cmd.Parameters.AddWithValue("c", s.product_title);
                cmd.Parameters.AddWithValue("d", s.product_price);
                cmd.Parameters.AddWithValue("e", s.product_desc);
                cmd.Parameters.AddWithValue("f", s.product_image);
                cmd.Parameters.AddWithValue("g", s.product_keywords);

                return (cmd.ExecuteNonQuery());

            }
        }
        public int UpdatePro(Products kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update products set product_cat = @a, product_brand = @b, product_title = @c, product_price = @d, product_desc = @e, product_image = @f, product_keywords = @g where product_id = @h";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", kh.product_cat);
                cmd.Parameters.AddWithValue("b", kh.product_brand);
                cmd.Parameters.AddWithValue("c", kh.product_title);
                cmd.Parameters.AddWithValue("d", kh.product_price);
                cmd.Parameters.AddWithValue("e", kh.product_desc);
                cmd.Parameters.AddWithValue("f", kh.product_image);
                cmd.Parameters.AddWithValue("g", kh.product_keywords);
                cmd.Parameters.AddWithValue("h", kh.product_id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int UpdateUser(User_Info kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update user_info set first_name = @first_name, last_name = @last_name, email = @email, password = @password, mobile = @mobile, address1 = @address1, address2 = @address2 where user_id = @idi";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("first_name", kh.first_name);
                cmd.Parameters.AddWithValue("last_name", kh.last_name);
                cmd.Parameters.AddWithValue("email", kh.email);
                cmd.Parameters.AddWithValue("password", kh.password);
                cmd.Parameters.AddWithValue("mobile", kh.mobile);
                cmd.Parameters.AddWithValue("address1", kh.address1);
                cmd.Parameters.AddWithValue("address2", kh.address2);
                cmd.Parameters.AddWithValue("idi", kh.user_id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public User_Info GetTaiKhoanByMa(int Id)
        {
            User_Info tk = new User_Info();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from user_info where user_id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tk.user_id = int.Parse(reader["user_id"].ToString());
                        tk.first_name = reader["first_name"].ToString();
                        tk.last_name = reader["last_name"].ToString();
                        tk.email = reader["email"].ToString();
                        tk.password = reader["password"].ToString();
                        tk.mobile = reader["mobile"].ToString();
                        tk.address1 = reader["address1"].ToString();
                        tk.address2 = reader["address2"].ToString();
                    }
                }
            }
            return tk;
        }
        public int XoaUser(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from user_info where user_id=@user_id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("user_id", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaUserOrd(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from orders where user_id=@user_id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("user_id", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaUserOrdIn(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from order_info where user_id=@user_id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("user_id", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaPro(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from products where product_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public Categories GetCatByMa(int id)
        {
            Categories s = new Categories();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from categories where cat_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        s.cat_id = int.Parse(reader["cat_id"].ToString());
                        s.cat_title = reader["cat_title"].ToString();
                    }

                }
            }
            return s;
        }
        public int AddCat(Categories s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into categories(cat_id, cat_title) values (@a,@b)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s.cat_id);
                cmd.Parameters.AddWithValue("b", s.cat_title);
                return (cmd.ExecuteNonQuery());

            }
        }
        public int UpdateCat(Categories kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update categories set cat_title = @a where cat_id = @b";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", kh.cat_title);
                cmd.Parameters.AddWithValue("b", kh.cat_id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int UpdateEmail(Email_Info kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update email_info set email = @a where email_id = @b";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", kh.email);
                cmd.Parameters.AddWithValue("b", kh.email_id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaCat(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from categories where cat_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int Login(string email, string password)
        {
            List<User_Info> list = new List<User_Info>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from user_info ", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User_Info()
                        {
                            user_id = int.Parse(reader["user_id"].ToString()),
                            first_name = reader["first_name"].ToString(),
                            last_name = reader["last_name"].ToString(),
                            email = reader["email"].ToString(),
                            password = reader["password"].ToString(),
                            mobile = reader["mobile"].ToString(),
                            address1 = reader["address1"].ToString(),
                            address2 = reader["address2"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            foreach (User_Info tk in list)
            {
                if (string.Compare(email, tk.email, false) == 0)
                {
                    if (string.Compare(password, tk.password, false) == 0)
                    {
                        if (tk.email == "admin@gmail.com")
                        {
                            return 1;
                        }
                        else if (tk.email == "staff@gmail.com")
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            return -1;
        }
        public string GetFname(string email, string password)
        {
            string a = "";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select first_name from user_info where email=@a and password=@b", conn);
                cmd.Parameters.AddWithValue("a", email);
                cmd.Parameters.AddWithValue("b", password);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a = reader["first_name"].ToString();
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return a;
        }
        public List<Products> GetSanPhamSearch(string searchString)
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from products where product_title like @tensach ", conn);
                cmd.Parameters.AddWithValue("tensach", "%" + searchString + "%");
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from products where product_keywords like @tacgia ", conn);
                cmd.Parameters.AddWithValue("tacgia", "%" + searchString + "%");
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Products> PriceBetween(string min, string max)
        {
            List<Products> list = new List<Products>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from products where product_price BETWEEN @min and @max ", conn);
                cmd.Parameters.AddWithValue("min", int.Parse(min));
                cmd.Parameters.AddWithValue("max", int.Parse(max));
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Products()
                        {
                            product_id = int.Parse(reader["product_id"].ToString()),
                            product_cat = int.Parse(reader["product_cat"].ToString()),
                            product_brand = int.Parse(reader["product_brand"].ToString()),
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            product_desc = reader["product_desc"].ToString(),
                            product_image = reader["product_image"].ToString(),
                            product_keywords = reader["product_keywords"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public Brands GetBraByMa(int id)
        {
            Brands s = new Brands();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from brands where brand_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        s.brand_id = int.Parse(reader["brand_id"].ToString());
                        s.brand_title = reader["brand_title"].ToString();
                    }

                }
            }
            return s;
        }
        public int AddBra(Brands s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into brands(brand_id, brand_title) values (@a,@b)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s.brand_id);
                cmd.Parameters.AddWithValue("b", s.brand_title);
                return (cmd.ExecuteNonQuery());

            }
        }
        public int UpdateBra(Brands kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update brands set brand_title = @a where brand_id = @b";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", kh.brand_title);
                cmd.Parameters.AddWithValue("b", kh.brand_id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaBra(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from brands where brand_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public List<Orders> GetOrd()
        {
            List<Orders> list = new List<Orders>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM orders", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Orders()
                        {
                            order_id = int.Parse(reader["order_id"].ToString()),
                            user_id = int.Parse(reader["user_id"].ToString()),
                            order_date = System.DateTime.Parse(reader["order_date"].ToString()),
                            quantity = int.Parse(reader["quantity"].ToString()),
                            total = int.Parse(reader["total"].ToString()),
                            paid_status = int.Parse(reader["paid_status"].ToString()),
                            status = int.Parse(reader["status"].ToString()),
                        });;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<Orders> GetOrdByMaUser(int cat)
        {
            List<Orders> list = new List<Orders>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from orders where user_id=@cat", conn);
                cmd.Parameters.AddWithValue("cat", cat);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Orders()
                        {
                            order_id = int.Parse(reader["order_id"].ToString()),
                            user_id = int.Parse(reader["user_id"].ToString()),
                            order_date = System.DateTime.Parse(reader["order_date"].ToString()),
                            quantity = int.Parse(reader["quantity"].ToString()),
                            total = int.Parse(reader["total"].ToString()),
                            paid_status = int.Parse(reader["paid_status"].ToString()),
                            status = int.Parse(reader["status"].ToString()),
                    }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public Email_Info GetEmailByMa(int id)
        {
            Email_Info s = new Email_Info();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from email_info where email_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        s.email_id = int.Parse(reader["email_id"].ToString());
                        s.email = reader["email"].ToString();
                    }

                }
            }
            return s;
        }
        public int XoaOrder(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from orders_info where order_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaEmail(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from email_info where email_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int AddEmail(Email_Info s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into email_info values (@a,@b)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s.email_id);
                cmd.Parameters.AddWithValue("b", s.email);
                return (cmd.ExecuteNonQuery());

            }
        }
        /*
        public int AddOrd(Orders_Info s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into orders_info (user_id,f_name,email,address,city,state,zip,cardname,cardnumber,expdate,prod_count,total_amt,cvv) values (@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m,@n)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("b", s.user_id);
                cmd.Parameters.AddWithValue("c", s.f_name);
                cmd.Parameters.AddWithValue("d", s.email);
                cmd.Parameters.AddWithValue("e", s.address);
                cmd.Parameters.AddWithValue("f", s.city);
                cmd.Parameters.AddWithValue("g", s.state);
                cmd.Parameters.AddWithValue("h", s.zip);
                cmd.Parameters.AddWithValue("i", s.cardname);
                cmd.Parameters.AddWithValue("j", s.cardnumber);
                cmd.Parameters.AddWithValue("k", s.expdate);
                cmd.Parameters.AddWithValue("l", s.prod_count);
                cmd.Parameters.AddWithValue("m", s.total_amt);
                cmd.Parameters.AddWithValue("n", s.cvv);
                return (cmd.ExecuteNonQuery());
            }
        }
        */
        public long CountC(long s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); 
                var str ="select COUNT(product_id) from products where product_cat = @a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        public long CountB(long s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select COUNT(product_id) from products where product_brand = @a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        public List<Reviews> GetReByMa(int cat)
        {
            List<Reviews> list = new List<Reviews>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT review_id, product_id, reviews.user_id, comment, first_name FROM reviews,user_info WHERE reviews.user_id = user_info.user_id and reviews.product_id =@cat", conn);
                cmd.Parameters.AddWithValue("cat", cat);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Reviews()
                        {
                            review_id = int.Parse(reader["review_id"].ToString()),
                            product_id = int.Parse(reader["product_id"].ToString()),
                            user_id = int.Parse(reader["user_id"].ToString()),
                            comment = reader["comment"].ToString(),
                            name = reader["first_name"].ToString(),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public int GetIdByFname(string name)
        {
            int a = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select user_id from user_info where first_name=@name", conn);
                cmd.Parameters.AddWithValue("name", name);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a = int.Parse(reader["user_id"].ToString());
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return a;
        }
        public int AddRv(Reviews s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into reviews (product_id, user_id, comment) values (@a,@b,@c)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s.product_id);
                cmd.Parameters.AddWithValue("b", s.user_id);
                cmd.Parameters.AddWithValue("c", s.comment);
                return (cmd.ExecuteNonQuery());

            }
        }
        public int AddOrd(int uid, int quan, int total)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into orders values (NULL, @a, NULL, @b, @c, 0, 0)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", uid);
                cmd.Parameters.AddWithValue("b", quan);
                cmd.Parameters.AddWithValue("c", total);
                return (cmd.ExecuteNonQuery());

            }
        }
        public int AddOrd1(int a, System.DateTime b, int c, int d)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into orders values (NULL, @a, @b, 0, 0, @c, @d)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", a);
                cmd.Parameters.AddWithValue("b", b);
                cmd.Parameters.AddWithValue("c", c);
                cmd.Parameters.AddWithValue("d", d);
                return (cmd.ExecuteNonQuery());

            }
        }
        public int AddOrdIn(int oid, int uid, string name, string phone, string email, string address, string note)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "INSERT INTO order_info VALUES (NULL, @a, @b, @c, @d, @e, @f, @g)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", oid);
                cmd.Parameters.AddWithValue("b", uid);
                cmd.Parameters.AddWithValue("c", name);
                cmd.Parameters.AddWithValue("d", phone);
                cmd.Parameters.AddWithValue("e", email);
                cmd.Parameters.AddWithValue("f", address);
                cmd.Parameters.AddWithValue("g", note);
                return (cmd.ExecuteNonQuery());

            }
        }
        public int AddOrdIt(int oid, int pid, int quan, int total)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "INSERT INTO order_items VALUES (NULL, @a, @b, @c, @d)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", oid);
                cmd.Parameters.AddWithValue("b", pid);
                cmd.Parameters.AddWithValue("c", quan);
                cmd.Parameters.AddWithValue("d", total);
                return (cmd.ExecuteNonQuery());

            }
        }
        public int GetOrd(int uid)
        {
            int a = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT max(order_id) FROM orders WHERE user_id=@a", conn);
                cmd.Parameters.AddWithValue("a", uid);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a = int.Parse(reader["max(order_id)"].ToString());
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return a;
        }
        public int GetId(string a, string b)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select user_id from user_info where email=@a and password=@b";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", a);
                cmd.Parameters.AddWithValue("b", b);
                int count = (int)cmd.ExecuteScalar();
                return count;
            }
        }
        public ViewModel5 GetOrdByMa(int Id)
        {
            ViewModel5 tk = new ViewModel5();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT * FROM orders o, order_info oi WHERE o.order_id = oi.order_id and o.order_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tk.order_id = int.Parse(reader["order_id"].ToString());
                        tk.name = reader["name"].ToString();
                        tk.phone = reader["phone"].ToString();
                        tk.email = reader["email"].ToString();
                        tk.order_date = System.DateTime.Parse(reader["order_date"].ToString());
                        tk.quantity = int.Parse(reader["quantity"].ToString());
                        tk.total = int.Parse(reader["total"].ToString());
                        tk.address = reader["address"].ToString();
                        tk.note = reader["note"].ToString();
                        tk.paid_status = int.Parse(reader["paid_status"].ToString());
                        tk.status = int.Parse(reader["status"].ToString());
                    }
                }
            }
            return tk;
        }
        public int UpdateOrd(int a, System.DateTime b, int c, int d, int e, int f)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "UPDATE orders set paid_status=@a, order_date=@b, quantity=@c, total=@d, status=@e WHERE order_id=@f";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", a);
                cmd.Parameters.AddWithValue("b", b);
                cmd.Parameters.AddWithValue("c", c);
                cmd.Parameters.AddWithValue("d", d);
                cmd.Parameters.AddWithValue("e", e);
                cmd.Parameters.AddWithValue("f", f);
                return (cmd.ExecuteNonQuery());
            }
        }
        public List<ViewModel6> GetOrdIt(int Id)
        {
            List<ViewModel6> list = new List<ViewModel6>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM order_items oi, products p WHERE oi.product_id=p.product_id and order_id=@a", conn);
                cmd.Parameters.AddWithValue("a", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ViewModel6()
                        {
                            product_title = reader["product_title"].ToString(),
                            product_price = int.Parse(reader["product_price"].ToString()),
                            quantity = int.Parse(reader["quantity"].ToString()),
                            unit_price = int.Parse(reader["unit_price"].ToString()),
                            stock = int.Parse(reader["stock"].ToString()),
                    }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public int XoaOrd(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from orders where order_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaOrdIn(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from order_info where order_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaOrdIt(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from order_items where order_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public string GetPass(int Id)
        {
            var a = "";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select password from user_info where user_id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a = reader["password"].ToString();
                    }
                }
            }
            return a;
        }
        public int UpdatePass(int Id, string pass)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update user_info set password=@new where user_id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("new", pass);
                cmd.Parameters.AddWithValue("id", Id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int PriceFromId(int Id)
        {
            var a = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT product_price FROM products WHERE product_id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a = int.Parse(reader["product_price"].ToString());
                    }
                }
            }
            return a;
        }
        public List<ViewModel9> GetTopUser()
        {
            List<ViewModel9> list = new List<ViewModel9>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT email, count(o.order_id) as sl FROM user_info ui, orders o WHERE ui.user_id = o.user_id GROUP BY o.user_id ORDER BY COUNT(o.order_id) DESC LIMIT 3", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ViewModel9()
                        {
                            email = reader["email"].ToString(),
                            count = int.Parse(reader["sl"].ToString()),
                        }); ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public long CountOrder0()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select count(order_id) from orders where status=0";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        public long CountOrderU(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select count(order_id) from orders where user_id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", Id);
                long count = (long)cmd.ExecuteScalar();
                return count;

            }
        }
        public int CountTongOU(int Id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select COALESCE(SUM(total),0) from orders where user_id=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", Id);
                int count = 0;

                count = int.Parse(cmd.ExecuteScalar().ToString());
                
                return count;

            }
        }

        public long CountOrder1()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select count(order_id) from orders where status=1";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        public long CountPro()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select count(product_id) from products p, categories c, brands b where p.product_cat=c.cat_id and p.product_brand=b.brand_id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        public long CountProSto5()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select count(product_id) from products p, categories c, brands b where p.product_cat=c.cat_id and p.product_brand=b.brand_id and stock <= 5";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        public long CountProSto0()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select count(product_id) from products p, categories c, brands b where p.product_cat=c.cat_id and p.product_brand=b.brand_id and stock <= 5";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        public long CountOrderAll()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select count(order_id) from orders";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        public int CountSoldPro()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select sum(quantity) from order_items";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int count = int.Parse(cmd.ExecuteScalar().ToString());
                return count;

            }
        }
        public long CountRev()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select count(review_id) from reviews";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        public int Sum()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select sum(total) from orders";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int count = int.Parse(cmd.ExecuteScalar().ToString());
                return count;

            }
        }
        public long CountU()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select count(user_id) from user_info";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        public long CountProAll()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select count(product_id) from products";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        public long CountBrand()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select count(brand_id) from brands";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                System.Int64 count = (System.Int64)cmd.ExecuteScalar();
                return count;

            }
        }
        public int UpdateOrd1(int id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "UPDATE orders set status=1 WHERE order_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int UpdateStock(int id, int quantity)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "UPDATE products set stock = stock - @b WHERE product_id=@a";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", id);
                cmd.Parameters.AddWithValue("b", quantity);
                return (cmd.ExecuteNonQuery());
            }
        }
        /*
        public int AddOrd(Orders_Info s)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into orders_info values (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m,@n)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("a", s.order_id);
                cmd.Parameters.AddWithValue("b", s.user_id);
                cmd.Parameters.AddWithValue("c", s.f_name);
                cmd.Parameters.AddWithValue("d", s.email);
                cmd.Parameters.AddWithValue("e", s.address);
                cmd.Parameters.AddWithValue("f", s.city);
                cmd.Parameters.AddWithValue("g", s.state);
                cmd.Parameters.AddWithValue("h", s.zip);
                cmd.Parameters.AddWithValue("i", s.cardname);
                cmd.Parameters.AddWithValue("j", s.cardnumber);
                cmd.Parameters.AddWithValue("k", s.expdate);
                cmd.Parameters.AddWithValue("l", s.prod_count);
                cmd.Parameters.AddWithValue("m", s.total_amt);
                cmd.Parameters.AddWithValue("n", s.cvv);
                return (cmd.ExecuteNonQuery());

            }
        }
        */
    }
    }
   
