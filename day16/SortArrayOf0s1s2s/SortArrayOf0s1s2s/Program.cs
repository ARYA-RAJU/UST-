﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOf0s1s2s
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("enter the array size:");
            N=int.Parse(Console.ReadLine());
            int[] A=new int[N];
            Console.WriteLine("Enter the array elements");
            for(int i=0; i<N; i++) 
            {
                A[i]=int.Parse(Console.ReadLine());
            }
            SortNumber(A);
        }
        static void SortNumber(int[] A)
        {
                int count0 = 0;
                int count1 = 0;
                for(int i=0;i<A.Length;i++)
                {
                    if (A[i]==0)
                        count0++;

                    if (A[i]==1)
                        count1++;
                }
                for(int i=0;i<count0;i++)
                {
                    A[i] = 0;
                }
                for(int i=count0;i<(count0+count1);i++)
                {
                    A[i] = 1;
                }
                for(int i=(count0+count1);i<A.Length;i++)
                {
                    A[i] = 2;
                }
                Console.WriteLine("Array after sorting :");
                for(int i=0;i<A.Length;i++)
                {
                    Console.WriteLine(A[i]);
                }
            }

        }
}
