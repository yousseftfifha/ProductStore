using System;
using System.Collections.Generic;

namespace PS.Domain
{
    public class Product:Concept
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DateProd { get; set; }
        public Category Category{ get; set; }
        public string ImageName { get; set; }
        public IList<Provider> ListProviders { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine($"ProductId: {ProductId}\t" +
                              $"Name: {Name}\t" +
                              $"Description: {Description}\t" +
                              $"Price: {Price}\t" +
                              $"Quantity: {Quantity}\t" +
                              $"DateProd:{DateProd}\t" );
        }

        public virtual string GetMyType()
        {
            return "UNKNOWN";
        }
    }
}