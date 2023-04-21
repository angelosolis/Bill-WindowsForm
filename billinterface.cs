using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bill_Console.Bill;

namespace Bill_Console
{
    internal class billinterface : Bill, Bill.IBillDetails
    {
        private const double INTEREST = 0.10;

        public billinterface(int id, string billname, double amount) : base(id, billname, amount, BillNum.INSURANCE)
        {
        }

        public override double ComputeTotal()
        {
            return GetAmount() * (1 + INTEREST);
        }

        public void DisplayBillDetails()
        {
            Console.WriteLine("BILL ID: " + GetId());
            Console.WriteLine("BILL NAME: " + GetBillName());
            Console.WriteLine("BILL TYPE: " + BillNum.INSURANCE);
            Console.WriteLine("BILL AMOUNT: Php" + GetAmount());
            Console.WriteLine("TOTAL AMOUNT: Php" + ComputeTotal().ToString("N"));
        }

        public static implicit operator BillNum(billinterface v)
        {
            throw new NotImplementedException();
        }
    }
}
