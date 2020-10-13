using System;


namespace Assignement10
{
    public class Customer
    {
        string productName;
        int productQntOrdered;
        float totalBillAmount = 0;


        public void GetOrder()
        {
            Console.WriteLine("Enter Product Name to be ordered");
            productName = Console.ReadLine();
            foreach (Product list in Assignement10.Program.productList)
            {
                if (productName == list.productName)
                {
                    Console.WriteLine("Enter Product Quantites for Ordered");
                    productQntOrdered = Convert.ToInt32(Console.ReadLine());
                    if (productQntOrdered <= list.qntInStock)
                    {
                        CalculateProductAmount(list, productQntOrdered);

                        //             GetBill(list);
                    }
                }

            }

        }
            void CalculateProductAmount(Product pro, int productQntOrdered)
            {
                totalBillAmount = (pro.productPrice * productQntOrdered) - pro.discountAllowed;
                // Console.WriteLine(totalBillAmount);
                PrintBill(pro);
            }
            public void PrintBill(Product product)
            {
                product.DisplayProductDetails();
                Console.WriteLine("Ordered Qunatities :" + productQntOrdered);
                Console.WriteLine("Total Product Bill Amount:" +  totalBillAmount);
            }
        }
    }

