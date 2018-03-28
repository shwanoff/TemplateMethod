using System;
using System.Text;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Создаем два вида пирога.
            var meatPie = new MeatPie();
            var applePie = new ApplePie();

            // Готовим мясной пирог.
            Console.WriteLine(meatPie);
            meatPie.Cook();
            Console.ReadLine();

            // Готовим яблочный пирог.
            Console.WriteLine(applePie);
            applePie.Cook();
            Console.ReadLine();
        }
    }
}
