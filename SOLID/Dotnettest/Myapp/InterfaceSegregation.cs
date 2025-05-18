

//Imagine a restaurant system with different entities like OnlineOrder, InHouseOrder, and PhoneOrder.
//Creating a universal interface like one below for all order types leads to unnecessary implementations.

//   public interface IOrder
//     {
//         void ProcessOnlinePayment();
//         void PrintTicket();
//         void ConfirmOverPhone();
//     }
//     public class OnlineOrder : IOrder
//     {
//         public void ProcessOnlinePayment()
//         {
//             // Implementation for processing online payment.
//         }
//         public void PrintTicket()
//         {
//             throw new NotImplementedException("Online orders do not print tickets.");
//         }
//         public void ConfirmOverPhone()
//         {
//             throw new NotImplementedException("Online orders do not confirm over the phone.");
//         }
//     }



//Solution:  segregate interfaces

 public interface IOnlineOrder
    {
        void ProcessOnlinePayment();
        void GenerateReceipt();
    }
    public interface IInHouseOrder
    {
        void PrintTicket();
    }
    public interface IPhoneOrder
    {
        void ConfirmOverPhone();
    }
    // Implementing segregated interfaces
    public class OnlineOrder : IOnlineOrder
    {
        public void ProcessOnlinePayment()
        {
            // Implementation for processing online payment.
            Console.WriteLine("Processing Online Payment");
        }
        public void GenerateReceipt()
        {
            // Implementation for generating a receipt.
            Console.WriteLine("Generating Receipt");
        }
    }
    public class InHouseOrder : IInHouseOrder
    {
        public void PrintTicket()
        {
            // Implementation for printing a ticket.
            Console.WriteLine("Printing Ticket");
        }
    }
    public class PhoneOrder : IPhoneOrder
    {
        public void ConfirmOverPhone()
        {
            // Implementation to confirm order over the phone.
            // Implementation for printing a ticket.
            Console.WriteLine("Confirming order over the phone");
        }
    }