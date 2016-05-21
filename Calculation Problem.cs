using System;
class Problem1
    {
        static string codeSum = string.Empty;
        static string[] input;
        static int decSum = 0;

        static void Main()
        {
            Input();
            ConvertToDec();
            Coding();
            Output();
        }

        static void Input()
        {
            input = (Console.ReadLine()).Split(' ');
        }

        static void ConvertToDec()
        {
            int n = input.Length;
            for (int i = 0; i < n; i++)
            {
                char[] array = input[i].ToCharArray();
                int currNr = 0;
                foreach (char bit in array)
                {
                    currNr = bit - 'a' + currNr* 23;
                }
                decSum += currNr;
            }
         }

        static void Coding()
        {
            int reminder = decSum;
            do
            {
                codeSum = (char)(reminder % 23 + 'a') + codeSum;
                reminder /= 23;
            } while (reminder > 0); 
        }

        static void Output()
        {
            Console.WriteLine("{0} = {1}", codeSum, decSum);
        }
}