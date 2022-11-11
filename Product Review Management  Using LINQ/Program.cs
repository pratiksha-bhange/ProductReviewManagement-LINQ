using System;
using System.Collections.Generic;

namespace Product_Review_Management__Using_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problems Using LINQ");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
            new ProductReview() { ProductId = 1, UserId = 1, Rating = 5.5, Review = "Good", isLike=true},
            new ProductReview() { ProductId = 1, UserId = 1, Rating = 4.5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 2, UserId = 1, Rating = 6, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 2, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 4, UserId = 1, Rating = 5, Review = "Nice", isLike=true },
            new ProductReview() { ProductId = 5, UserId = 1, Rating = 5, Review = "Nice", isLike=true },
            new ProductReview() { ProductId = 6, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 7, UserId = 1, Rating = 7.5, Review = "Good", isLike=false},
            new ProductReview() { ProductId = 4, UserId = 1, Rating = 1.5, Review = "Good", isLike=false },
            new ProductReview() { ProductId = 9, UserId = 1, Rating = 6.5, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 10, UserId = 1, Rating = 5, Review = "Bad", isLike=false },
            new ProductReview() { ProductId = 11, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 12, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 13, UserId = 1, Rating = 5, Review = "Bad", isLike=true },
            new ProductReview() { ProductId = 14, UserId = 1, Rating = 5, Review = "Good", isLike=true },
            new ProductReview() { ProductId = 15, UserId = 1, Rating = 5, Review = "Good", isLike=true }
            };
            Console.WriteLine("Rows in the table = ");
            foreach (var list in productReviewList)
            {
                Console.WriteLine("Product id = " + list.ProductId + "User id = " + list.UserId + "Rating is = " + list.Rating + " Review is = " + list.Review + " isLike = " + list.isLike);
            }
            Management management = new Management();
            // UC2
            management.TopRecords(productReviewList);
            // UC3
            management.selectedRecords(productReviewList);
            // UC4
            management.RetrieveCountOfRecords(productReviewList);
        }
    }
}

    
    

        
    

