using System.Text;

namespace OHCE;

public class Ohce
{
    private readonly ILangue _langue;

    public Ohce(ILangue langue)
    {
        _langue = langue;
    }

    public string Palindrome(string input)
    {
        var stringBuilder =
            new StringBuilder(Expressions.Bonjour);

        var reversed = new string(
            input.Reverse().ToArray()
        );

        stringBuilder.Append(reversed);

        if (reversed.Equals(input))
            stringBuilder.Append(_langue.BienDit);

        stringBuilder.Append(Expressions.AuRevoir);

        return stringBuilder.ToString();
    }
}