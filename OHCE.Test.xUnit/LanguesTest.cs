using OHCE.Langues;
using Xunit;

namespace OHCE.Test.xUnit
{
    public class LanguesTest
    {
        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "ET que le moment de la journée est <moment>" +
                          "QUAND l'app démarre " +
                          "ALORS <salutationAttendue> de cette langue à ce moment est envoyé avant tout")]
        [InlineData(MomentJournee.Soir, Expressions.Français.Bonsoir)]
        [InlineData(MomentJournee.Matin, Expressions.Français.Bonjour)]
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

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "ET que le moment de la journée est <moment>" +
                          "QUAND l'app démarre " +
                          "ALORS <salutationAttendue> de cette langue à ce moment est envoyé avant tout")]
        [InlineData(MomentJournee.Soir, Expressions.English.Bonsoir)]
        [InlineData(MomentJournee.Matin, Expressions.English.Bonjour)]
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
    }
}