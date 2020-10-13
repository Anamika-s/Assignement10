using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignement10
{
   public class Products
    {
        public string productCode, productName;
        static string productBrand;
         public int qntInStock;
        public float productPrice;
        public readonly float discountAllowed;
        public Products()
        {
            discountAllowed = 50 / 100;
        } 
       
       public static void DisplayProductname()
        {
            productBrand = "Samsung";
            Console.WriteLine(productBrand);
        } 
         public void GetProductInfo()
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
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Code:"+productCode);
            Console.WriteLine("Product Name:" + productName);
            Console.WriteLine("Product Price:" + productPrice);
        }
        
       
    }
}
