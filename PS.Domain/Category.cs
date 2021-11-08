using System;
using System.Collections.Generic;

namespace PS.Domain
{
    public class Category:Concept
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual IList<Product> ListProducts { get; set; }
        public override void GetDetails()
        {
            Console.WriteLine($"Name : {Name}" );
        }
        
    }
}