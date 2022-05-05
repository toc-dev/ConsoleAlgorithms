// See https://aka.ms/new-console-template for more information
using ConsoleAlgorithms;

Console.WriteLine("Hello, World!");
CodeWarsKata codeWarsKata = new CodeWarsKata();
//var list = CodeWarsKata.GetIntegersFromList(new List<object>() { 1, 2, "a", "b" });
//Console.WriteLine(list);
/*
int[][] jArray = new int[1][]
{
    new int[] [ [ 18, 20 ], [ 45, 2 ], { 61, 12 }, { 37, 6 }, { 21, 21 }, { 78, 9 } } 
};
*/
//var openSenior = CodeWarsKata.OpenOrSenior((jArray);
//Console.WriteLine(op);
/*
string[] walk = { "n", "s", "e", "w" };
Console.WriteLine(CodeWarsKata.IsValidWalk(walk));
double[] signature = {13,15,19}; //{5, 1, 1, 1, 3};
var two = codeWarsKata.Tribonacci(signature, 1);
foreach (int i in two)
{
    Console.WriteLine(i);
}
string word = "abba";
var wordd = "laser";
List<string> words = new List<string> { "aabb", "abcd", "bbaa", "dada"};
List<string> moreWords = new List<string> {"lazing", "lazy", "lacer", "lasser"};

var ana = CodeWarsKata.Anagrams(wordd, moreWords);
foreach(string s in ana)
{
    Console.WriteLine(s);
}
string wordy = "abcdefghijklmnopqrstuvwnandnsnyzx";
Console.WriteLine(CodeWarsKata.IsPangram(wordy));
*/
/*
int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
Console.WriteLine(CodeWarsKata.comp(a, b) );

string ap = "4of Fo1r pe6ople g3ood th5e the2"; //"is2 Thi1s T4est 3a";
//Console.WriteLine(CodeWarsKata.Order(ap));
Console.WriteLine(CodeWarsKata.Order(ap));
string cC = "camelCasingTest";
Console.WriteLine(CodeWarsKata.BreakCamelCase(cC));
*/
string w = "Ah finesse if I Welcome";
Console.WriteLine(CodeWarsKata.SpinWords(w));

int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
int[] b = new int[] {4, 121, 144, 19, 161, 19, 19, 11, 900 };
int[] c = new int[] { 1, 2, 3, 4, 5,4, 5, 6,8,9 };

Console.WriteLine(CodeWarsKata.FindUnsortedSubarray(c));