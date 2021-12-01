using System.Collections.Generic;
using System.Linq;
using PS.Data.Infrastructures;
using PS.Domain;

namespace PS.Service
{
    public class InvoiceService:Service<Invoice>,IInvoiceService
    {
        public InvoiceService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}