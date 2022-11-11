using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Product_Review_Management__Using_LINQ
{
    class Management
    {
      //UC1--
        public readonly DataTable dataTable = new DataTable();

        // --UC2-- Retrieve Top 3 records from list.
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview orderby productReviews.Rating descending select productReviews).Take(3);
            Console.WriteLine("\n Top 3 records = ");
           
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
            }
        }
        // --UC3-- Selects the record with rating grater than 3 and with product id = 1,4,9.
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
        // --UC4-- Retrieves the count of record with  the help of group by id.
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            Console.WriteLine("\nProduct id and count = ");

            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + " = " + list.Count);
            }
        }
        // --UC5-- Retrieves the productId and review.
        public void RetrieveProductIdAndReview(List<ProductReview> listProductReviews)
        {
            //lambda syntax
            var recordData = listProductReviews.Select(x => new { ProductId = x.ProductId, Review = x.Review });
            Console.WriteLine("\nProduct id and review = ");

            foreach (var list in recordData)
            {
                Console.WriteLine(list.ProductId + "------" + list.Review);
            }
        }
        // --UC6-- Skips the top five records.
        public void SkipTopFiveRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReview in listProductReview select productReview).Skip(5);
            Console.WriteLine("\nTop 5 records from list = ");

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " UserId:-" + list.UserId + " Ratings:-" + list.Rating + " Review:-" + list.Review + " IsLike:-" + list.isLike);
            }
        }
        // --UC7-- Retrieves the productId and review.
        public void RetrieveProductIdAndReviews(List<ProductReview> listProductReviews)
        {
            //lambda syntax
            var recordData = listProductReviews.Select(x => new { ProductId = x.ProductId, Review = x.Review });
            Console.WriteLine("\nProduct id and review = ");

            foreach (var list in recordData)
            {
                Console.WriteLine(list.ProductId + "------" + list.Review);
            }
        }
        // UC8- Creates the table.
        public DataTable CreateTable(List<ProductReview> listProductReview)
        {
            dataTable.Columns.Add("ProductId");
            dataTable.Columns.Add("UserId");
            dataTable.Columns.Add("Rating");
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("isLike");
            return dataTable;

         
        }
        // --UC9-- Retrieve Records with is value true.
        public void RetrieveRecordsWithIsLikeValueTrue(DataTable table)
        {
            var recordData = from productReview in table.AsEnumerable()
                             where (productReview.Field<string>("isLike") == true.ToString())
                             select productReview;
            //lambda syntax
            var recordedData = table.AsEnumerable().Where(x => x.Field<string>("isLike") == true.ToString());
            Console.WriteLine("\nRecords with isLike value is true = ");
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.Field<string>("ProductId") + " UserId:-" + list.Field<string>("UserId") + " Ratings:-" + list.Field<string>("Rating") + " Review:-" + list.Field<string>("Review") + " IsLike:-" + list.Field<string>("isLike"));
            }
        }
        // UC10- Finds the avrage rating.
        public void FindAvrageRating(List<ProductReview> listProductReviews)
        {
            //lambda syntax
            var recordedData = listProductReviews.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Average = x.Average(y => y.Rating) });
            Console.WriteLine("\nAverage rating of ProductId = ");

            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + "------" + list.Average);
            }
        }
        // UC11- Records with nice review message.
        public void RecordsWithNiceReview(List<ProductReview> listProductReview)
        {
            var recordData = (from productReview in listProductReview where (productReview.Review.Equals("Nice"))select productReview).ToList();
            Console.WriteLine("\nRecords with nice review message = ");

            foreach (var list in recordData)
            {
                Console.WriteLine("Product id = " + list.ProductId + "User id = " + list.UserId + "Rating is = " + list.Rating + " Review is = " + list.Review + " isLike = " + list.isLike);
            }
        }

    }
}
    

