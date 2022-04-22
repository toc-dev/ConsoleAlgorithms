// See https://aka.ms/new-console-template for more information
using ConsoleAlgorithms;

Console.WriteLine("Hello, World!");
CodeWarsKata codeWarsKata = new CodeWarsKata();
var list = CodeWarsKata.GetIntegersFromList(new List<object>() { 1, 2, "a", "b" });
Console.WriteLine(list);
/*
int[][] jArray = new int[1][]
{
    new int[] [ [ 18, 20 ], [ 45, 2 ], { 61, 12 }, { 37, 6 }, { 21, 21 }, { 78, 9 } } 
};
*/
//var openSenior = CodeWarsKata.OpenOrSenior((jArray);
//Console.WriteLine(op);
string[] walk = { "n", "s", "e", "w" };
Console.WriteLine(CodeWarsKata.IsValidWalk(walk));