

//eg in below invoice class if we have a new invoice type we will have to modify the class and retest again  
//   public class Invoice
//     {        
//         public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
//         {
//             double finalAmount = 0;
//             if (invoiceType == InvoiceType.FinalInvoice)
//             {
//                 finalAmount = amount - 100;
//             }
//             else if (invoiceType == InvoiceType.ProposedInvoice)
//             {
//                 finalAmount = amount - 50;
//             }
//             return finalAmount;
//         }
//     }
//     public enum InvoiceType
//     {
//         FinalInvoice,
//         ProposedInvoice
//     };


//Solution: Above class Can be restructured as below

 public class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
    }
    
    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }
    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }
    public class RecurringInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }