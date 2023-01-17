using System;
using System.Text;

namespace OHCE;

public class Ohce
{

    public Ohce()
    {
    }

    public string Palindrome(string input)
    {
        var stringBuilder = new StringBuilder();

        var reversed = new string(
            input.Reverse().ToArray()
        );

        stringBuilder.Append(reversed + '\n');

        return stringBuilder.ToString();
    }
}