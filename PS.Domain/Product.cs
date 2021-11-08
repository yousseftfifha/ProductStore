using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PS.Domain
{
    public class Product:Concept
    {
        [Key]
        public int ProductId { get; set; }
        
        [Required(ErrorMessage ="Name Required"),
         MaxLength(50), 
         StringLength(25, ErrorMessage ="Name must have 25 caracters")]
        public string Name { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        
        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }
        
        [DataType(DataType.Date),
         Display(Name="Date de production")]
        public DateTime DateProd { get; set; }
        
        public virtual Category MyCategory { get; set; }
        [ForeignKey("MyCategory")]
        public int? CategoryId { get; set; }

        
        [DataType(DataType.ImageUrl)]
        public string Images { get; set; }
      
        public virtual IList<Provider> ListProviders { get; set; }

        public virtual IList<Invoice> Invoices { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine($"ProductId: {ProductId}\t" +
                              $"Name: {Name}\t" +
                              $"DateProd:{DateProd}\t" +
                              $"Category:{MyCategory.Name}\t" );
           
        }

        public virtual string GetMyType()
        {
            return "UNKNOWN";
        }
    }
}