using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Product_Review_Management__Using_LINQ
{
    class Management
    {
        // Retrieve Top 3 records from list.--UC2--
        public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview orderby productReviews.Rating descending select productReviews).Take(3);
            Console.WriteLine("\n Top 3 records = ");
           
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
            }
        }
        // Selects the record with rating grater than 3 and with product id = 1,4,9.--UC3--
        public void selectedRecords(List<ProductReview> listProductReviews)
        {
            var recordedData = from productReviews in listProductReviews
                               where (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9) && productReviews.Rating > 3
                               select productReviews;
            Console.WriteLine("\n Rating grater than 3 with product id 1,4,9 = ");

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
            }
        }
        
    }
}
    

