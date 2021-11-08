using System;

namespace PS.Domain
{
    public class Invoice
    {
        public string clientFk  { get; set; }
        public DateTime dateAchat { get; set; }
        public double Prix { get; set; }
        public int ProductFK { get; set; }

        public virtual Client MyClient { get; set; }

        public virtual Product Product { get; set; }
    }
}