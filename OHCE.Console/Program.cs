using OHCE;
using OHCE.Console;

var ohce = new Ohce(new SystemLangue(), SystemTimeMomentJournee.MomentActuelle);

Console.WriteLine(ohce.Greet());

Console.WriteLine(ohce.InputPalindrome());

Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));