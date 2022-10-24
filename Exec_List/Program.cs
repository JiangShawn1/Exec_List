using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_List
{
    internal class Program
    {
        static void Main(string[] args)
        {//宣告一個 List<Product> 變數, 存放多筆購買商品

            List<Product> fruit = new List<Product>
            {
                new Product{Id=1,Name="apple"},
                new Product{Id=2,Name="banana"},
                new Product{Id=3,Name="cherry"},
                new Product{Id=4,Name="lemon"},

            };         

        }
        
    }
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }


}
