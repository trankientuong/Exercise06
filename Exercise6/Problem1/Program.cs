using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(200000);
            Console.WriteLine("Nhap so tien ban muon gui vao tai khoan: ");
            int amount = int.Parse(Console.ReadLine());
            acc.Deposit(amount);
            Console.WriteLine("So tien ban vua nap la: "+ amount);
            Console.WriteLine("Tong so tien hien co: "+ acc.Balance());
        }
      
      
    }
}
