using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        
        static void Main(int[] arr, int i,int k, int j, int low, int mid, int high, int eol,int num,int pos)
        {
            int temp = arr[i];
            arr[j] = arr[i - 1];
            arr[j + 1] = temp;
            j = (mid + 1);
            i = low;

            while((i > mid) && (j > high))
            {
                if (arr[i]) <= arr[j])
                {

                }
            }
           

        private int n;
        private object a;

        public object GetA()
        {
            return a;
        }

        public void read(object a)
        {

            while (true)
            {
                Console.Write("Masukkan Banyaknya Elemen Pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray Dapat Mempunyai Maksimal 20 Elemen.\n");

            }
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine(" Masukkan Elemen Array");
            Console.WriteLine("------------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
    }
}
