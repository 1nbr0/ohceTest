using OHCE.Langues;
using OHCE.Test.xUnit.Utilities;
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
    [MemberData(nameof(LanguesSeules))]
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

    private static readonly IEnumerable<ILangue> Langues = new ILangue[]
    {
        new LangueAnglaise(),
        new LangueFrancaise()
    };

    private static readonly IEnumerable<MomentJournee> Moments = new MomentJournee[]
    {
        MomentJournee.Matin,
        MomentJournee.AprèsMidi,
        MomentJournee.Soir,
        MomentJournee.Nuit,
        MomentJournee.Defaut
    };

    public static IEnumerable<object[]> LanguesSeules => new CartesianData(Langues);

    public static IEnumerable<object[]> LanguesEtMoments => new CartesianData(Langues, Moments);

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "ET que le moment de la journée est <moment>" +
                          "QUAND l'app démarre " +
                          "ALORS <bonjour> de cette langue à ce moment est envoyé")]
    [MemberData(nameof(LanguesEtMoments))]
    public void DémarrageTest(ILangue langue, MomentJournee moment)
    {
        // ETANT DONNE un utilisateur parlant une <langue>
        // ET que le moment de la journée est <moment>
        var ohce = new OhceBuilder().AyantPourLangue(langue).AyantPourMomentDeLaJournée(moment).Build();

        // QUAND l'app démarre
        var sortie = ohce.Palindrome(string.Empty);

        // ALORS <bonjour> de cette langue à ce moment est envoyé
        Assert.StartsWith(langue.DireBonjour(moment), sortie);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "QUAND l'app se ferme " +
                          "ALORS <auRevoir> dans cette langue est envoyé")]
    [MemberData(nameof(LanguesSeules))]
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