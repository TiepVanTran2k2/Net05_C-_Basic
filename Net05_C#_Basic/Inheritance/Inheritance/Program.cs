using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class PaymentInformation : IOder
    {
        private int _paymentNo = 10000;

        public void CancelOrder()
        {
        }

        public void GetOrder()
        {
        }

        public virtual int GetPaymentNo()
        {
            return _paymentNo;
        }

        public void PlaceOrder()
        {
        }
    }

    internal interface IOder
    {
        void PlaceOrder();
        void CancelOrder();
        void GetOrder();
    }
    class PizzaOrder : PaymentInformation,IOder
    {
        private int _price = 500000;
        private int amount = 0;
        private bool isOrdered = false;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public PizzaOrder(int Amount)
        {
            amount = Amount;
        }
        public void PlaceOrder()
        {
            if(amount == 0)
            {
                Console.WriteLine("Initialization Amount > 0 for PizzaOrder");
            }
            else if(isOrdered == true)
            {
                Console.WriteLine("You ordered");
            }
            else
            {
                Console.WriteLine("Payment: {0}",GetPaymentNo());
                Console.WriteLine("Total: {0}", _price * amount);
                isOrdered = true;
            }
        }
        public void CancelOrder()
        {
            if(isOrdered == true)
            {
                Console.WriteLine("Cancel order success");
                isOrdered = false;
            }
            else
            {
                Console.WriteLine("You are not order");
            }
        }
        public void GetOrder()
        {
            Console.WriteLine("\nDetail order: \nPayment: {0} \nTotal: {1}", GetPaymentNo(), _price * amount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PizzaOrder pizzaOrder = new PizzaOrder(3);
            Console.WriteLine("Place order: ");
            pizzaOrder.PlaceOrder();
            Console.WriteLine("\nCancel order: ");
            pizzaOrder.CancelOrder();
            pizzaOrder.GetOrder();
            Console.ReadKey();
        }
    }
}
