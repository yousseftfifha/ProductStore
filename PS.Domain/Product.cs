using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PS.Domain
{
    public class Product:Concept
    {
        public int ProductId { get; set; }
        
        [Required(ErrorMessage = "Name est Obligatoire")]
        [MaxLength(25,ErrorMessage = "Name ne doit pas depasser 25 caractere ")]
        [StringLength(50,ErrorMessage = "Name ne doit pas depasser 50 caractere dans la BDD")]
        public string Name { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        
        
        public int Quantity { get; set; }
        
        [DisplayFormat(DataFormatString ="Production Date")]
        
        public DateTime DateProd { get; set; }
        public Category Category{ get; set; }
        public string Images { get; set; }
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