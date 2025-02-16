using System.Collections;
using static System.Console; 

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["book"] = "책";
            ht["cook"] = "요리사";
            ht["look"] = "보다";
            ht["tweet"] = "지저귀다";

            Console.WriteLine(ht["book"]);
            Console.WriteLine(ht["cook"]);
            Console.WriteLine(ht["look"]);
            Console.WriteLine(ht["tweet"]);
		}
    }
}
