using OHCE.Test.xUnit.Utilities;
using OHCE.Test.xUnit.Utilities.Builders;
using Xunit;

namespace OHCE.Test.xUnit;

public class OhceTest
{
    [Fact(DisplayName =
        "QUAND on entre une chaîne de caractères " +
        "ALORS elle est renvoyée en miroir")]
    public void MiroirTest()
    {
        var ohce = OhceBuilder.Default;

        // QUAND on entre une chaîne de caractère
        var sortie = ohce.Palindrome("lolo");

        // ALORS elle est renvoyée en miroir
        Assert.Contains("olol", sortie);
    }

    [Fact(DisplayName = "QUAND on saisi un palindrome " +
                        "ALORS celui-ci est renvoyé " +
                        "ET \"Bien dit\" est envoyé ensuite")]
    public void PalindromeTest()
    {
        // QUAND on entre un palindrome

        // ALORS il est renvoyé

        // ET "Bien dit" est envoyé
    }
}