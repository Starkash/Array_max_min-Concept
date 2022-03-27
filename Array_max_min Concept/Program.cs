using System;

namespace Array_max_min_Concept
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] ar = { 1, 12, 10, 115, 10, 12, 1, 10, 1000001 };

            int max = ar[0];
            int Min = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if(max<ar[i])
                {
                    max = ar[i];
                }
                if (Min > ar[i])
                {
                    Min = ar[i];
                }

            }
            Console.WriteLine("maximum is:"+max);
            Console.WriteLine("Minimum is:" + Min);

        }
    }
}
