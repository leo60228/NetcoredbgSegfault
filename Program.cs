using System;
using System.Threading.Tasks;

namespace NetcoredbgSegfault
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Run(async () => await Method(1));
            await Task.Run(async () => await Method(2));
        }

        static async Task Method(int num) {
            Console.WriteLine("Sleeping...");
            await Task.Delay(500);
            Console.WriteLine(num);
        }
    }
}
