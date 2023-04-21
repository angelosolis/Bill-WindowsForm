using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Console
{
    public class Bill
    {
        private int id;
        private string billname;
        private double amount;
        private BillNum type;

        public Bill(int id, string billname, double amount, BillNum type)
        {
            this.id = id;
            this.billname = billname;
            this.amount = amount;
            this.type = type;
        }

        public int GetId()
        {
            return id;
        }

        public string GetBillName()
        {
            return billname;
        }

        public double GetAmount()
        {
            return amount;
        }

        public virtual double ComputeTotal()
        {
            return 0.0;
        }

        public interface IBillDetails
        {
            void DisplayBillDetails();
        }
    }
}
