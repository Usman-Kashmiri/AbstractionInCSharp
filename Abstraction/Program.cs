using System;

namespace Abstraction
{
    class billing
    {
        int bill_id;
        public string consumer_name;
        public int bill;
        double bill_tax = 0.1;
        public double total_bill;

        public billing(string c_name, int bill_p)
        {
            this.consumer_name = c_name;
            this.bill = bill_p;
        }

        private void CalculateBill()
        {
            if (bill >= 500)
            {
                total_bill = bill + (bill * bill_tax);
                Console.WriteLine("Your billing amount is {0}", total_bill);
            } else
            {
                total_bill = bill;
                Console.WriteLine("Your billing amount is {0}", total_bill);
            }
        }

        public void ShowBill()
        {
            this.CalculateBill();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            billing billobj = new billing("Ahmed",500);
            billobj.ShowBill();
            Console.ReadLine();
        }
    }
}
