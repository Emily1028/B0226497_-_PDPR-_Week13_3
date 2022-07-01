using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week13_3
{
    struct Product2
    {
        public string No, Name;
        public int Price, Amount, Sum;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week13_3");
            Product2[] products = new Product2[5];
            int i;
            for (i = 0; i < products.GetLength(0); i++)
            {
                products[i].Name = "段昱如_" + (i + 1);
                products[i].Price = 1000* (i + 1);
                products[i].No = "B0226497_" + (i + 1);
                products[i].Amount = 10 * (i + 1);
                products[i].Sum = (products[i].Price * products[i].Amount);
                Console.WriteLine($"產品:{i + 1}\t編號:{products[i].No}\t品名:{products[i].Name}\t單價:{products[i].Price}\t數量:{products[i].Amount}\t總價:{products[i].Sum}");
            }
            Console.WriteLine($"總價值:{products[0].Sum+products[1].Sum+products[2].Sum+products[3].Sum+products[4].Sum}");
            Console.ReadLine();
        }
    }
}
