using System;
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Enter number to create polygon: ");
        int n = int.Parse(Console.ReadLine());

        CreatePolygon(n);
        Console.ReadKey();
    }
        public static void CreatePolygon(int n)
        {
        for (int i = 0; i<n; i++)
        {
            for (int i_Sp = 0; i_Sp < n - i - 1; i_Sp++)
            {
                Console.Write(" ");
            }
            for (int i_Ast = 0; i_Ast < 2 * i + 1; i_Ast++)
            {
                Console.Write((char)9632);

            }
            //Console.Write("\n");
            Console.WriteLine();
        }
        for (int i = 1; i < n; i++)
        {
            for (int i_Sp = 0; i_Sp < i; i_Sp++)
            {
                Console.Write(" ");
            }

            for (int i_Ast = 0; i_Ast < 2 * n - 2 * i - 1; i_Ast++)
            {
                Console.Write((char)9632);

            }
              Console.WriteLine();
         }
       }
    }