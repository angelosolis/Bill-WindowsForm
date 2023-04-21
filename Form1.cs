using Bill_Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BillWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            typebox.DataSource = Enum.GetValues(typeof(BillNum));
            typebox.DisplayMember = "ToString";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtxt.Text);
            string name = nametxt.Text;
            double amount = double.Parse(billTxt.Text);
            BillNum type = (BillNum)typebox.SelectedIndex;

            Bill_Console.Bill bill = new billinterface(id, name, amount);
            totallabel.Text = $" TOTAL AMOUNT: Php{bill.ComputeTotal().ToString("N")}";
        }

        

    }
}
