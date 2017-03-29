using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_DataStructure
{
    class Program
    {


        static Stack  stackOfNumberA = new Stack();
        static Stack  stackOfNumberB = new Stack();

        /**
         * @param args the command line arguments
         */


        public static int solution(int A, int B)
        {
           

            String theDecimalZip = null;
            int finalDecimalZip = 0;

            long sizeOfA = 0;
            long sizeOfB = 0;

            StringBuilder sb = new StringBuilder();

            int digit = -1;

            //Stack A
            while (A >= 10)
            {
                digit = A % 10;
                stackOfNumberA.Push(digit);
                A = A / 10;
            }

            stackOfNumberA.Push(A);


            //Stack B
            while (B >= 10)
            {
                digit = B % 10;
                stackOfNumberB.Push(digit);
                B = B / 10;
            }

            stackOfNumberB.Push(B);

            long max = 0;

            if (stackOfNumberA.Count > stackOfNumberB.Count)
            {
                max = stackOfNumberA.Count;

            }
            else
            {
                max = stackOfNumberB.Count;

            }

            sizeOfA = stackOfNumberA.Count;
            sizeOfB = stackOfNumberB.Count;

            for (int j = 0; j < max; j++)
            {
                if (sizeOfA > 0)
                {
                    theDecimalZip = stackOfNumberA.Pop().ToString();
                    sb = sb.Append(theDecimalZip);
                    sizeOfA--;
                }

                if (sizeOfB > 0)
                {
                    theDecimalZip = stackOfNumberB.Pop().ToString();
                    sb = sb.Append(theDecimalZip);
                    sizeOfB--;
                }
            }

            finalDecimalZip = Int32.Parse(sb.ToString());

            if (finalDecimalZip > 100000000)
                finalDecimalZip = -1;

            return finalDecimalZip;
        }
        static void Main(string[] args)
        {
            int A = 12345;
            int B = 67892;

            long zipDecimalFinal = solution(A, B);

            Console.WriteLine("The Final zip Decimal is " + zipDecimalFinal);

            Console.ReadKey();
        }
    }
}
