using OHCE;
using OHCE.Console;

var ohce = new Ohce(new SystemLangue());

Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));