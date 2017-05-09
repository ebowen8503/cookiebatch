using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieBatch
{
    class Program
    {
        static void Main(string[] args)
        {
            BatchCookie batchcookies = new BatchCookie();

            batchcookies.createCookies("Gingerbread","Thick","Medium","CreamCheese","Vanilla");
            batchcookies.createCookies("ChocolateChip", "Thick", "Large", "Chocolate", "Chocolate");
            batchcookies.createCookies("Sugar", "Thin", "Small", "Strawberry", "Buttercream");
            batchcookies.createCookies("Peanutbutter", "Thick", "Medium", "CreamCheese", "Vanilla");
            batchcookies.createCookies("Toffee", "Thick", "Medium", "CreamCheese", "Vanilla");
            batchcookies.createCookies("Macadamia", "Thick", "Medium", "CreamCheese", "Vanilla");
            batchcookies.createCookies("Tripe Chocolate", "Thick", "Large", "Chocolate", "Chocolate");
            batchcookies.createCookies("SnickerDoodle", "Thick", "Large", "Chocolate", "Buttercream");
            batchcookies.createCookies("Oatmeal", "Thick", "Large", "Chocolate", "Vanilla");
            batchcookies.createCookies("Cranberry", "Thin", "Small", "Strawberry", "Chocolate");
            batchcookies.createCookies("ButterScotch", "Thin", "Small", "CreamCheese", "Buttercream");
            batchcookies.createCookies("M&M", "Thin", "Small", "Chocolate", "Vanilla");

            int b;

            for (b = 1; b <= batchcookies.cookieCount; b++)
            {
                Console.WriteLine(" " + batchcookies.batches[b - 1].cookieName + " " + batchcookies.batches[b - 1].cookieShape + " " + batchcookies.batches[b - 1].cookieSize + " " + batchcookies.batches[b - 1].cookieFilling+ " "+batchcookies.batches[b - 1].cookieIcing);
            }
            Console.ReadKey();
           

        }
    }
}
