﻿using System;
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
           

        private int n;
        public void read()
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
        }
    }
}
