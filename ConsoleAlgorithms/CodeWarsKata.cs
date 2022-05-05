using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
            
            public double[] Tribonacci(double[] a, int n)
            {
                var res = new System.Collections.Generic.List<double>(a);
                for (int i = 3; i < n; i++)
                    res.Add(res[i - 1] + res[i - 2] + res[i - 3]);
                return (n == 0) ? new double[] { 0.0d } : res.GetRange(0, n).ToArray();
            }
            */
        }
        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> anagrams = new List<string>();
            char[] wd = word.ToCharArray();
            foreach (string w in words)
            {
                char[] x = w.ToCharArray();
                var xNotWd = x.Except(wd).ToList();
                var wdNotX = wd.Except(x).ToList();

                var compare = !wdNotX.Any() && !xNotWd.Any();

                if (compare == true && x.Length == wd.Length)
                {
                    anagrams.Add(w);
                }
            }
            return anagrams;
            /*
            var pattern = word.OrderBy(p => p).ToArray();
            return words.Where(item => item.OrderBy(p => p).SequenceEqual(pattern)).ToList();
            */
        }
        public static bool IsPangram(string str)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            char[] lettersList = letters.ToUpper().ToCharArray();
            for (int i = 0; i <26; i++)
            {
                Console.WriteLine(lettersList[i]);
            }
            char[] arrayToString = str.ToUpper().ToCharArray();
            Array.Sort(arrayToString);
            var arrayInAZ = lettersList.Except(arrayToString); //basically checking the first list against the second list, and printing out the stuff in the first list that is not in the second list
            Console.WriteLine(arrayInAZ);
            foreach (char i in arrayInAZ)
            {
                Console.WriteLine(i);
            }
            //return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;

            return !arrayInAZ.Any();
        }

        public static bool comp(int[] a, int[] b)
        {
            // your code
            if ((a?.Length != 0 && b?.Length == 0) || a?.Length != b?.Length)
                return false;

            int[] c = new int[a.Count()];
            bool[] e = new bool[a.Count()];
            bool[] d = new bool[a.Count()];
            Array.Sort(a);
            Array.Sort(b);
            for (int i = 0; i < a.Count(); i++)
            {
                c[i] = c[i] = (a[i] * a[i]);
                e[i] = true;
                if (c[i] == b[i])
                {
                    d[i] = true;
                }
                else
                    d[i] = false;
            }
            if (d.Count() != e.Count())
                return false;
            var check = d.Except(e);
            //var check2 = c.Except(b);
            return !check.Any();
            /*
            public static bool comp(int[] a, int[] b)
            {
                if ((a == null) || (b == null)) return false;
                int[] aa = a.Select(s => s * s).ToArray();
                Array.Sort(aa);
                Array.Sort(b);
                return aa.SequenceEqual(b);
            }
            */
            /*
            public static bool comp(int[] a, int[] b)
            {
                return a == null || b == null ? false : a.Sum() == b.Sum(x => Math.Sqrt(x));
            }*/

        }
        public static string OrderHackedSolution(string words)
        {
            List<string> wordList = words.Split(" ").ToList();
            List<char> moreWords = new List<char>();
            
            char[] numList = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //var wordd = moreWords.OrderBy(p => p);
            List<string> wordOrder = new List<string>();

            while(wordOrder.Count < wordList.Count)
            {
                foreach (var i in numList)
                {
                    foreach (var word in wordList)
                    {
                        moreWords = word.ToCharArray().ToList();
                        foreach (var w in moreWords)
                        {
                            if (w == i)
                            {
                                wordOrder.Add(word);
                            }
                        }
                    }
                }
            }
            
            return string.Join(" ", wordOrder);//organizedWords.Remove(organizedWords.Length - 1, 1).ToString(); //string.Join(" ", organizedWords);
        }
        
        public static string Order(string words)
        {
            /*
            List<string> wordList = words.Split(" ").ToList();
            List<char> moreWords = new List<char>();//words.Split(" ").ToList();
            foreach (var word in wordList)
            {
                moreWords = word.ToCharArray().ToList();
            }
            var isDigit = moreWords.Where(x => char.IsDigit(x)).Any();
            */
            List<string> wordList = words.Split(" ").ToList();
            string[] arrangedWords = new string[words.Length];
            foreach (string word in wordList)
            {
                string number = string.Concat(word.Where(char.IsNumber)).Trim();
                int num;
                bool isInteger = int.TryParse(number, out num);
                if (isInteger == true)
                {
                    arrangedWords[num] = word;
                }
            }
            return string.Join(" ", arrangedWords).Trim();

            //return string.Join(" ", words.Split().OrderBy(w => w.SingleOrDefault(char.IsDigit)));
        }
        public static int Solution(int value)
        {
            int a = 0;
            // Magic Happens
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    a += i;
                }
            }
            return a;

            //return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }
        public static string BreakCamelCase(string str)
        {
            //complete the function
            //return string.Join("", )

            var strings = (from s in str.ToCharArray()
                          where char.IsUpper(s)
                          select string.Join($" {s}", str.Split(s))).ToArray();
            
            foreach (var i in strings)
            {
                Console.WriteLine(i);
            }
            

            return string.Join(" ", strings);
            //return string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
        }
        public static bool IsPrime(int n)
        {
            // TODO
            int floor = (int)(Math.Floor(Math.Sqrt(n)));
            if (n == 2)
            {
                return true;
            }
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= floor; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }

            }
            return true;

        }
        public static string SpinWords(string sentence)
        {
            
            List<string> sentenceList = sentence.Split(" ").ToList();
            Console.WriteLine(sentenceList);

            for (int i = 0; i < sentenceList.Count(); i++)
            {
                StringBuilder reversedWord = new StringBuilder();
                char[] splitWord = sentenceList[i].ToCharArray();
                Console.WriteLine(splitWord.Length);
                if (splitWord.Length >= 5)
                {
                    for (int j = splitWord.Length - 1; j > -1; j--)
                    {
                        reversedWord.Append(splitWord[j].ToString());
                    }
                    sentenceList[i] = reversedWord.ToString();
                }
                
            }
            return string.Join(" ", sentenceList);

            //return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
        }

        public static int FindUnsortedSubarray(int[] nums)
        {
            //From LeetCode. Find the smallest unsorted subarray.
            if (nums.Count() < 2)
            {
                return 0;
            }

            List<int> numbers = nums.ToList();
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] == numbers.Min())
                {
                    numbers.RemoveAt(i--);
                }
            
                else
                {
                    break;
                }
                
            }
            for (int n = numbers.Count() - 1; n > -1; n--)
            {
                if (numbers[n] == numbers.Max())
                {
                    numbers.RemoveAt(n);
                }
                else
                {
                    break;
                }
            }

            
            return numbers.Count();
        }
    }
}

