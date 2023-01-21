using OHCE.Langues;
using Xunit;

namespace OHCE.Test.xUnit
{
    public class LanguesTest
    {
        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue " +
                          "ET que le moment de la journée est <moment> " +
                          "QUAND l'app démarre " +
                          "ALORS <salutationAttendue> de cette langue à ce moment est envoyé avant tout")]
        [InlineData(MomentJournee.Matin, Expressions.Français.Bonjour)]
        [InlineData(MomentJournee.AprèsMidi, Expressions.Français.Bonjour)]
        [InlineData(MomentJournee.Soir, Expressions.Français.Bonsoir)]
        [InlineData(MomentJournee.Nuit, Expressions.Français.Bonsoir)]
        public void DireBonjourTestFrancais(MomentJournee moment, string salutationAttendue)
        {
            // ETANT DONNE un utilisateur parlant la langue française
            // ET que le moment de la journée est <moment>
            var langue = new LangueFrancaise();

            // QUAND l'app démarre
            var salutation = langue.DireBonjour(moment);

            // ALORS <salutationAttendue> de cette langue à ce moment est envoyé avant tout
            Assert.Equal(salutationAttendue, salutation);
        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue " +
                          "ET que le moment de la journée est <moment> " +
                          "QUAND l'app démarre " +
                          "ALORS <salutationAttendue> de cette langue à ce moment est envoyé avant tout")]
        [InlineData(MomentJournee.Matin, Expressions.English.Bonjour)]
        [InlineData(MomentJournee.AprèsMidi, Expressions.English.Bonjour)]
        [InlineData(MomentJournee.Soir, Expressions.English.Bonsoir)]
        [InlineData(MomentJournee.Nuit, Expressions.English.Bonsoir)]
        public void DireBonjourTestAnglais(MomentJournee moment, string salutationAttendue)
        {
            // ETANT DONNE un utilisateur parlant la langue anglaise
            // ET que le moment de la journée est <moment>
            var langue = new LangueAnglaise();

            // QUAND l'app démarre
            var salutation = langue.DireBonjour(moment);

            // ALORS <salutationAttendue> de cette langue à ce moment est envoyé avant tout
            Assert.Equal(salutationAttendue, salutation);
        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue " +
                          "ET que le moment de la journée est <moment> " +
                          "QUAND l'app démarre " +
                          "ALORS <auRevoir> de cette langue à ce moment est envoyé en dernier")]
        [InlineData(MomentJournee.Matin, Expressions.Français.AuRevoir)]
        [InlineData(MomentJournee.AprèsMidi, Expressions.Français.AuRevoir)]
        [InlineData(MomentJournee.Soir, Expressions.Français.AuRevoir)]
        [InlineData(MomentJournee.Nuit, Expressions.Français.AuRevoir)]
        public void DireAuRevoirTestFrancais(MomentJournee moment, string AuRevoirAttendue)
        {
            // ETANT DONNE un utilisateur parlant la langue française
            // ET que le moment de la journée est <moment>
            var langue = new LangueFrancaise();

            // QUAND l'app démarre
            var auRevoir = langue.AuRevoirBis(moment);

            // ALORS <salutationAttendue> de cette langue à ce moment est envoyé avant tout
            Assert.Equal(AuRevoirAttendue, auRevoir);
        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue " +
                          "ET que le moment de la journée est <moment> " +
                          "QUAND l'app démarre " +
                          "ALORS <auRevoir> de cette langue à ce moment est envoyé en dernier")]
        [InlineData(MomentJournee.Matin, Expressions.English.AuRevoir)]
        [InlineData(MomentJournee.AprèsMidi, Expressions.English.AuRevoir)]
        [InlineData(MomentJournee.Soir, Expressions.English.AuRevoir)]
        [InlineData(MomentJournee.Nuit, Expressions.English.AuRevoir)]
        public void DireAuRevoirTestAnglais(MomentJournee moment, string AuRevoirAttendue)
        {
            // ETANT DONNE un utilisateur parlant la langue française
            // ET que le moment de la journée est <moment>
            var langue = new LangueAnglaise();

            // QUAND l'app démarre
            var auRevoir = langue.AuRevoirBis(moment);

            // ALORS <salutationAttendue> de cette langue à ce moment est envoyé avant tout
            Assert.Equal(AuRevoirAttendue, auRevoir);
        }
    }
}