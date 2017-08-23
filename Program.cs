using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationsString
{
    class Program
    {
        static void Main(string[] args)
        {


            String input = "MAN";
            char[] charArry = input.ToCharArray();
            Permutations(charArry, 0, 2);
            Console.ReadLine();
        }

        static void Permutations(Char[] arr, int start, int end)
        {


            string str = new string(arr);
            if (start == end)
            {
                Console.WriteLine(arr);
            }
            else
            {


                for (int i = start; i <= end; i++)
                {

                    Swap(ref arr[start], ref arr[i]);
                    Permutations(arr, start + 1, end);
                    Swap(ref arr[start], ref arr[i]);  //backtrack 
                }
            }
        }


      static void Swap(ref char a, ref char b)
        {
            if (a == b) return;
            char temp = b;
            b= a;
            a = temp;

        }

    }
}
