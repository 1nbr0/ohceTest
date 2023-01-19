using OHCE.Test.xUnit.Utilities.TestDoubles;
using Xunit;

namespace OHCE.Test.xUnit;

public class OhceTest
{
    [Fact(DisplayName =
        "QUAND on entre une chaîne de caractères " +
        "ALORS elle est renvoyée en miroir")]
    public void MiroirTest()
    {
        var ohce = new Ohce(new LangueStub());

        // QUAND on entre une chaîne de caractère
        var sortie = ohce.Palindrome("lolo");

        // ALORS elle est renvoyée en miroir
        Assert.Contains("olol", sortie);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "QUAND on entre un palindrome " +
                          "ALORS il est renvoyé " +
                          "ET <bienDit> de cette langue est envoyé")]
    [InlineData(Expressions.BienDit)]
    [InlineData("Well said")]
    public void PalindromeTest(string bienDit)
    {
        var ohce = new Ohce(new LangueMock(bienDit));
        // QUAND on entre un palindrome
        const string palindrome = "sonos";
        var sortie = ohce.Palindrome(palindrome);

        // ALORS il est renvoyé
        // ET <bienDit> en <langue> est envoyé
        Assert.Contains(
            palindrome + bienDit,
            sortie);
    }

    //[Fact(DisplayName = "QUAND l'app démarre " +
    //                "ALORS \"{Expressions.Bonjour}\" est envoyé ")]
    //public void DémarrageTest()
    //{
    //    var ohce = new Ohce();

    //    // QUAND l'app démarre
    //    var sortie = ohce.Palindrome(string.Empty);

    //    // ALORS "Bonjour" est envoyé
    //    Assert.StartsWith(Expressions.Bonjour, sortie);
    //}

    //[Fact(DisplayName = "QUAND l'app se ferme " +
    //                "ALORS \"{Expressions.AuRevoir}\" est envoyé ")]
    //public void FermetureTest()
    //{
    //    var ohce = new Ohce();

    //    // QUAND l'app démarre
    //    var sortie = Ohce.Palindrome(string.Empty);

    //    // ALORS "Au revoir" est envoyé
    //    Assert.EndsWith(Expressions.AuRevoir, sortie);
    //}
}