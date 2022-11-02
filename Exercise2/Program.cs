using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        
        static void Main(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[j] = arr[i - 1];
            arr[j + 1] = temp;

        }
    }
}
