using OHCE.Test.xUnit.Utilities.Builders;
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
        var ohce = OhceBuilder.Default;

        // QUAND on entre une chaîne de caractère
        var sortie = ohce.Palindrome("lolo");

        // ALORS elle est renvoyée en miroir
        Assert.Contains("olol", sortie);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "QUAND on entre un palindrome " +
                          "ALORS il est renvoyé " +
                          "ET <bienDit> de cette langue est envoyé")]
    [InlineData(Expressions.Français.BienDit)]
    [InlineData(Expressions.English.BienDit)]
    public void PalindromeTest(string bienDit)
    {
        // ETANT DONNE un utilisateur parlant une <langue>
        var ohce = new Ohce(new LangueMock { BienDit = bienDit });
        // QUAND on entre un palindrome
        const string palindrome = "sonos";
        var sortie = ohce.Palindrome(palindrome);

        // ALORS il est renvoyé
        // ET <bienDit> en <langue> est envoyé
        Assert.Contains(
            palindrome + bienDit,
            sortie);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "QUAND l'app démarre " +
                          "ALORS <bonjour> de cette langue est envoyé")]
    [InlineData("Bonjour")]
    [InlineData("Hello")]
    public void DémarrageTest(string bonjour)
    {
        // ETANT DONNE un utilisateur parlant une <langue>
        var ohce = new Ohce(new LangueMock { Bonjour = bonjour });

        // QUAND l'app démarre
        var sortie = ohce.Palindrome(string.Empty);

        // ALORS "Bonjour" est envoyé
        Assert.StartsWith(bonjour, sortie);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "QUAND l'app se ferme " +
                          "ALORS <auRevoir> dans cette langue est envoyé")]
    [InlineData("Au revoir")]
    [InlineData("Goodbye")]
    public void FermetureTest(string auRevoir)
    {
        // ETANT DONNE un utilisateur parlant une <langue>
        var ohce = new Ohce(new LangueMock { AuRevoir = auRevoir });

        // QUAND l'app démarre
        var sortie = ohce.Palindrome(string.Empty);

        // ALORS "Au revoir" est envoyé
        Assert.EndsWith(auRevoir, sortie);
    }
}