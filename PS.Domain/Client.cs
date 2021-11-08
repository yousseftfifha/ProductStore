using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PS.Domain
{
    public class Client
    {
        [Key]
        public string Cin { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Mail { get; set; }
        public string Nom { get; set; }
        public string Name { get; set; }
        public IList<Invoice> Invoices{ get; set; }
    }
}