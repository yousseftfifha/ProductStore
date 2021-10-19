using System;
using System.Collections.Generic;

namespace PS.Domain
{
    public class Category:Concept
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public IList<Product> ListProducts { get; set; }
        public override void GetDetails()
        {
            Console.WriteLine($"CategoryId : {CategoryId}" +
                              $"Name : {Name}" );
        }
        
    }
}