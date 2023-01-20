using OHCE.Langues;
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
    [MemberData(nameof(Langues))]
    public void PalindromeTest(ILangue langue)
    {
        // ETANT DONNE un utilisateur parlant une <langue>
        var ohce = new OhceBuilder().AyantPourLangue(langue).Build();

        // QUAND on entre un palindrome
        const string palindrome = "sonos";
        var sortie = ohce.Palindrome(palindrome);

        // ALORS il est renvoyé
        // ET <bienDit> en <langue> est envoyé
        Assert.Contains(
            palindrome + langue.BienDit,
            sortie);
    }

    public static IEnumerable<object[]> Langues => new List<object[]>
    {
        new object[]{ new LangueAnglaise() },
        new object[]{ new LangueFrancaise() },
    };

    public static IEnumerable<object[]> LanguesEtPériodes => new List<object[]>
    {
        new object[] { new LangueAnglaise(), MomentJournee.Matin },
        new object[] { new LangueFrancaise(), MomentJournee.Matin },
        new object[] { new LangueAnglaise(), MomentJournee.AprèsMidi },
        new object[] { new LangueFrancaise(), MomentJournee.AprèsMidi },
        new object[] { new LangueAnglaise(), MomentJournee.Soir },
        new object[] { new LangueFrancaise(), MomentJournee.Soir },
        new object[] { new LangueAnglaise(), MomentJournee.Nuit },
        new object[] { new LangueFrancaise(), MomentJournee.Nuit },
        new object[] { new LangueAnglaise(), MomentJournee.Defaut },
        new object[] { new LangueFrancaise(), MomentJournee.Defaut },
    };

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "ET que la période de la journée est <période>" +
                          "QUAND l'app démarre " +
                          "ALORS <bonjour> de cette langue à ce moment est envoyé")]
    [MemberData(nameof(LanguesEtPériodes))]
    public void DémarrageTest(ILangue langue, MomentJournee moment)
    {
        // ETANT DONNE un utilisateur parlant une <langue>
        var ohce = new OhceBuilder().AyantPourLangue(langue).AyantPourPériodeDeLaJournée(moment).Build();

        // QUAND l'app démarre
        var sortie = ohce.Palindrome(string.Empty);

        // ALORS <bonjour> de cette langue à ce moment est envoyé
        Assert.StartsWith(langue.DireBonjour(moment), sortie);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "QUAND l'app se ferme " +
                          "ALORS <auRevoir> dans cette langue est envoyé")]
    [MemberData(nameof(Langues))]
    public void FermetureTest(ILangue langue)
    {
        // ETANT DONNE un utilisateur parlant une <langue>
        var ohce = new OhceBuilder().AyantPourLangue(langue).Build();

        // QUAND l'app démarre
        var sortie = ohce.Palindrome(string.Empty);

        // ALORS <auRevoir> dans cette langue est envoyé
        Assert.EndsWith(langue.AuRevoir, sortie);
    }
}