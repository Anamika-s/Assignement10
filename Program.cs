using System;
using System.Collections.Generic;


namespace Assignement10
{
    class Program
    {
        public static List<Product> productList;
        static void Main(string[] args)
        {
            Product.DisplayProductName();
            Product product = new Product();
            productList = new List<Product>();

            for(int i = 0; i < 3; i++)
            {
                product = new Product();
                product.GetProductDetails();
                productList.Add(product);
            }

            product.DisplayProductList();
            //foreach (Products list in productList)
            //{
            //    Console.Write(list.productCode + "\t");
            //    Console.Write(list.productName + "\t");
            //    Console.Write(list.productPrice + "\t");
            //    Console.Write(list.qntInStock + "\t");
            //}
            Customer customer = new Customer();
            customer.GetOrder();
        
            /*
            List<Products> productlist = new List<Products>()
            {
                new Products() {productCode="M001",productName="Mobile",productPrice=600,qntInStock=100},
                new Products() {productCode="PC001",productName="Computer",productPrice=6000,qntInStock=100},
                new Products() {productCode="L001",productName="Laptop",productPrice=3400,qntInStock=100},
                new Products() {productCode="F001",productName="Freeze",productPrice=6400,qntInStock=100},
                new Products() {productCode="LE001",productName="LED",productPrice=6000,qntInStock=100},
            };
            */


        }
    }
}
