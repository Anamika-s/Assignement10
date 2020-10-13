using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignement10
{
   public class Product
    {
        string productCode;
        public string productName;
        static string productBrand;
        public int qntInStock;
        public float productPrice;
        public readonly float discountAllowed;
        public Product()
        {
            discountAllowed = 50 / 100;
        }

        public static void DisplayProductName()
        {
            productBrand = "Samsung";
            Console.WriteLine(productBrand);
        }
        public void GetProductDetails()
        {
            Console.WriteLine("Enter Product Code");
            productCode = Console.ReadLine();
            Console.WriteLine("Enter Product Name");
            productName = Console.ReadLine();
            Console.WriteLine("Enter Product Price");
            productPrice =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity in stock");
            qntInStock = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayProductList()
        {
            foreach (Product list in Program.productList)
            {
                Console.Write(list.productCode + "\t");
                Console.Write(list.productName + "\t");
                Console.Write(list.productPrice + "\t");
                Console.WriteLine(list.qntInStock);
            }
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine(" * B I L L * ");
            Console.WriteLine("----------------");
            Console.WriteLine("Product Code:" + productCode);
            Console.WriteLine("Product Name:" + productName);
            Console.WriteLine("Product Price:" + productPrice);
          //  DisplayProductName();
        }


    }
}
