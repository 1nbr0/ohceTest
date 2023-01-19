using Xunit;

namespace OHCE.Test.xUnit;

public class OhceTest
{
    [Fact(DisplayName =
        "QUAND on entre une chaîne de caractères " +
        "ALORS elle est renvoyée en miroir")]
    public void MiroirTest()
    {
        var ohce = new Ohce();

        // QUAND on entre une chaîne de caractère
        var sortie = Ohce.Palindrome("lolo");

        // ALORS elle est renvoyée en miroir
        Assert.Contains("olol", sortie);
    }

    [Fact(DisplayName = "QUAND on saisi un palindrome " +
                        "ALORS celui-ci est renvoyé " +
                        "ET \"{Expressions.BienDit}\" est envoyé ensuite")]
    public void PalindromeTest()
    {
        var ohce = new Ohce();
        // QUAND on entre un palindrome
        const string palindrome = "sonos";
        var sortie = Ohce.Palindrome(palindrome);

        // ALORS il est renvoyé
        // ET "Bien dit" est envoyé
        Assert.Contains(
            palindrome + Expressions.BienDit,
            sortie);
    }

    [Fact(DisplayName = "QUAND l'app démarre " +
                    "ALORS \"{Expressions.Bonjour}\" est envoyé ")]
    public void DémarrageTest()
    {
        var ohce = new Ohce();

        // QUAND l'app démarre
        var sortie = Ohce.Palindrome(string.Empty);

        // ALORS "Bonjour" est envoyé
        Assert.StartsWith(Expressions.Bonjour, sortie);
    }

    [Fact(DisplayName = "QUAND l'app se ferme " +
                    "ALORS \"{Expressions.AuRevoir}\" est envoyé ")]
    public void FermetureTest()
    {
        var ohce = new Ohce();

        // QUAND l'app démarre
        var sortie = Ohce.Palindrome(string.Empty);

        // ALORS "Au revoir" est envoyé
        Assert.EndsWith(Expressions.AuRevoir, sortie);
    }
}