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
        var sortie = ohce.Palindrome("toto");

        // ALORS elle est renvoyée en miroir
        Assert.Contains("otot", sortie);
    }
}