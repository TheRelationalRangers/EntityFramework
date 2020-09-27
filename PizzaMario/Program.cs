using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaMario.Models;

namespace PizzaMario
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var hash = "y7c1Pm2VPvNguvlgwSI0YnbG4yA=";

            if (hash == Customer.GetPasswordHash("patrick"))
            {
                Console.WriteLine("jeeh");
            }
        }
    }
}