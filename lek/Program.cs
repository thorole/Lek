using System;

namespace lek

{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Choose: '+', '-', '*', or '/' (type 'quit' to exit");
                string valg = Console.ReadLine();



                if (valg == "+")
                {
                    Console.Write("x = ");
                    int x = Convert.ToInt32(Console.ReadLine());


                    Console.Write("y = ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    int sum = (x + y);
                    Console.WriteLine(sum);
                    // goto Start;
                }




                else if (valg == "-")
                {

                    Console.WriteLine("x = ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("y = ");


                    int b = Convert.ToInt32(Console.ReadLine());
                    int sum2 = (a - b);
                    Console.WriteLine(sum2);
                    //  goto Start;

                }

                else if (valg == "*")
                {

                    Console.WriteLine("x = ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.Write("y = ");


                    int d = Convert.ToInt32(Console.ReadLine());
                    int product = (c * d);
                    Console.WriteLine(product);
                    //goto Start;
                }

                else if (valg == "/")
                {

                    Console.WriteLine("x = ");
                    int e = Convert.ToInt32(Console.ReadLine());
                    Console.Write("y = ");
                   
                    int f = Convert.ToInt32(Console.ReadLine());
                    int divident = (e / f);
                    int rest = (e % f);
                    Console.WriteLine(divident);
                    Console.WriteLine("Rest: " + rest);

                    // goto Start;
                }

                else if (valg == "quit")
                {
                    Environment.Exit(0);
                }



                else
                {
                    Console.WriteLine();
                }
            }
            while (true);
        }
    }
}
    
        

