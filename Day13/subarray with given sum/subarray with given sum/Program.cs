﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program

{

    static void Main(string[] args)

    {

        int[] arr = { 1,2,3,7,5};

        int n = arr.Length;

        int sum = 12;

        subArraySum(arr, n, sum);

    }

    public static void subArraySum(int[] arr, int n, int sum)

    {

        for (int i = 0; i < n; i++)

        {

            int currentSum = arr[i];

            if (currentSum == sum)

            {

                Console.WriteLine("sum found at indexe" + i);

                return;

            }

            else

            {

                for (int j = i + 1; j < n; j++)

                {

                    currentSum += arr[j];

                    if (currentSum == sum)

                    {

                        Console.WriteLine("Sum found between indexes" + i + "and" + j);

                        return;

                    }

                }

            }

        }

        Console.WriteLine("No subarray found");

        return;

    }

}

