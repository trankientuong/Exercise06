using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class Account
    {
        private int Total;
        public Account(int amount)
        {
            Total = amount;
        }

        public void Deposit(int amount)
        {
            Total = Total + amount;
        }

        public void WithDraw(int amount)
        {
            Total = Total - amount;
        }

        public int Balance()
        {
            
            return Total;
        }
    }
}
