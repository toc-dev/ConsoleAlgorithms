﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlgorithms
{
    internal class CodeWarsKata
    {
        // In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            
            List<int> IntegerList = new List<int>();
            for (int i = 0; i < (listOfItems.Count); i++)
            {
                if (listOfItems[i] is int)
                {
                    IntegerList.Add((int)listOfItems[i]);
                };
                continue;
            };
            return IntegerList;

            //return listOfItems.OfType<int>();
        }

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            //your code here
            List<string> openOrSenior = new List<string>();
            string open = "Open";
            string senior = "Senior";
            foreach (int[] row in data)
            {
                if (row[0] >= 55 && row[1] > 7)
                {
                    openOrSenior.Add(senior);
                }
                else
                {
                    openOrSenior.Add(open);
                }
            }
            return openOrSenior;

            //return data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open").ToList();
        }
        public static bool IsValidWalk(string[] walk)
        {
            //insert brilliant code here
            var n = 0;
            var e = 0;
            var w = 0;
            var s = 0;
            for (int i = 0; i < walk.Length; i++)
            {
                if (walk[i] == "n")
                    n++;
                if (walk[i] == "e")
                    e++;
                if (walk[i] == "w")
                    w++;
                if (walk[i] == "s")
                    s++;

            }
            if (walk.Length == 10 && e==w && n==s)
                return true;
            else
                return false;
            //return walk.Count(x => x == "n") == walk.Count(x => x == "s") && walk.Count(x => x == "e") == walk.Count(x => x == "w") && walk.Length == 10;
        }

        public double[] Tribonacci(double[] signature, int n)
        {
            double[] list1 = new double[signature.Length];
            for(int i=0; i<signature.Length; i++)
                list1[i] = signature[i];
            Array.Sort(list1); 
            
            if (n < 3)
            {
                Array.Resize(ref signature, n);
                return signature;
            }

            for (int i = signature.Length; i < n; i++)
            {
                //int sigCount = signature.Count();
                double nextElement = (signature[i - 1] + signature[i - 2] + signature[i - 3]);
                Array.Resize(ref signature, n);
                Array.Resize(ref list1, n);
                
                signature[i] = nextElement;
                list1[i] = nextElement;
            }
            return signature;
            /*
            public double[] Tribonacci(double[] s, int n)
            {
                double[] res = new double[n];
                Array.Copy(s, res, Math.Min(3, n));

                for (int i = 3; i < n; i++)
                    res[i] = res[i - 3] + res[i - 2] + res[i - 1];

                return n == 0 ? new double[] { 0 } : res;
            }
            */
        }

    }
}

