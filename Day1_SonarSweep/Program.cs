using System;
using System.Collections.Generic;
using System.IO;


namespace Day1_SonarSweep
{
    class Program
    {








        static void Main(string[] args)
        {
            //int[] my_array = new int[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
            //int counter = 0; ;
            //for (int i = 1; i < my_array.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        Console.WriteLine($"{my_array[i]} not applicable");

            //    }
            //    else if (my_array[i] < my_array[i - 1])
            //    {
            //        Console.WriteLine($"{my_array[i]} Decreased");
            //    }

            //    else if (my_array[i] > my_array[i - 1])

            //    {
            //        counter++;
            //        Console.WriteLine($"{my_array[i]} Increased"); }


            //}
            //Console.WriteLine($"you have {counter} increases");
        

        //Now we read from a file and do the same

        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\sahar\OneDrive\Dokument\Visual Studio 2019\Development\Adventofcode\input.txt");
            List<int> int_lines = new List<int>();
            //string line;
            foreach ( string line in lines)
            {
                
                int int_line = Convert.ToInt32(line);
                int_lines.Add(int_line);
                //Console.WriteLine(int_line);
            }
            int counter1 = 0; ;
            for (int i = 1; i < int_lines.Count ; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"{int_lines[i]} not applicable");

                }
                else if (int_lines[i] < int_lines[i - 1])
                {
                    Console.WriteLine($"{int_lines[i]} Decreased");
                }

                else if (int_lines[i] > int_lines[i - 1])

                {
                    counter1++;
                    Console.WriteLine($"{int_lines[i]} Increased");
                }


            }
            Console.WriteLine($"you have {counter1} increases");
        }
	

	}
    
}

