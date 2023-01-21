using System.Text;

namespace OHCE;

public class Ohce
{
    private readonly ILangue _langue;
    private readonly MomentJournee _momentJournee;

    public Ohce(ILangue langue, MomentJournee momentJournee)
    {
        _langue = langue;
        _momentJournee = momentJournee;
    }

    public string Greet()
    {
        return _langue.DireBonjour(_momentJournee);
    }

    public string InputPalindrome()
    {
        return _langue.InputPalindrome;
    }

    public string Palindrome(string input)
    {
        var stringBuilder =
            new StringBuilder(_langue.DireBonjour(_momentJournee));

        var reversed = new string(
            input.Reverse().ToArray()
        );

        stringBuilder.Append(reversed);

        if (reversed.Equals(input))
            stringBuilder.Append(_langue.BienDit);

        stringBuilder.Append(_langue.AuRevoir);

        return stringBuilder.ToString();
    }
}