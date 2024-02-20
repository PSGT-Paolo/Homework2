using System;
using TransType;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace CAtrans
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get data
            Console.WriteLine("Input the nominal of the trade:");
            string userInput = Console.ReadLine();
            int nominal = Int32.Parse(userInput);

            Console.WriteLine("Input the price of the trade:");
            userInput = Console.ReadLine();
            double price = Double.Parse(userInput);

            Console.WriteLine("Input the transaction type:\n0 for Buy\n1 for Sell\n(default is Buy)");
            TransactionType trcType;
            userInput = Console.ReadLine();
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            // Calculate Current Value (CV)
            sbyte sign = sbyte.Parse(trcType == TransactionType.Buy ? "1" : "-1");
            double curval = sign * nominal * price;

            // Print data recap
            Console.WriteLine($"\nTransaction type: {trcType}\nNominal: {nominal}\nPrice: {price}");
            Console.WriteLine($"Transaction Current Value: {curval}");

            Console.ReadKey();
        }
    }
}
