using System.Text;

namespace OHCE;

public class Ohce
{
    public static string Palindrome(string input)
    {
        var stringBuilder = new StringBuilder();

        var reversed = new string(
            input.Reverse().ToArray()
        );

        stringBuilder.Append(reversed);

        if (reversed.Equals(input))
            stringBuilder.Append(Expressions.BienDit);

        return stringBuilder.ToString();
    }
}