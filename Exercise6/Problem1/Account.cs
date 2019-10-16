using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class Account
    {
        public int Total;
        public Account(int amount)
        {
            Total = amount;
        }

        public void Deposit(int amount)
        {          
            Total += amount;
        }

        public void WithDraw(int amount)
        {
            if (amount < Total)
                Total -= amount;
            else
                Console.WriteLine("tai khoan khong du so tien de rut ");
        }

        public int Balance()
        {
            
            return Total;
        }
    }
}
