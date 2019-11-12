using System;
namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x < 10)
            {
                IHomework05 con = new homewark();
                String ledNo = Console.ReadLine();
                string sum = con.DisplayLEDOnScreen(ledNo);
                Console.WriteLine(sum);
            }
        }
    }
}