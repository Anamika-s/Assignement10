using System;


namespace Assignement10
{
   public  class Customer
    {
        string productName;
        int productQntOrdered;
        float totalBillAmount = 0;


         public void GetOrdered()
        {
            Console.WriteLine("Enter Product Name for Ordered");
            productName = Console.ReadLine();
            foreach (Products list in Assignement10.Program.productList)
            {
                if (productName == list.productName)
                {
                    Console.WriteLine("Enter Product Quantites for Ordered");
                    productQntOrdered =Convert.ToInt32( Console.ReadLine());
                    if (productQntOrdered <= list.qntInStock)
                    {
                        GetBill(list, productQntOrdered);
                    }
                }

            }

        }
        void CalculateProductAmount(Products pro)
        {
            totalBillAmount = (pro.productPrice * productQntOrdered)-pro.discountAllowed;
            
        }
      public  void GetBill(Products product, int productQntOrederd)
        {
            product.DisplayProductDetails();
            Console.WriteLine("Ordered Qunatities :",productQntOrederd);
            Console.WriteLine("Total Product Bill Amount:",totalBillAmount);
        }
    }
}
