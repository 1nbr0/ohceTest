namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.English.BienDit;

        /// <inheritdoc />
        public string DireBonjour(MomentJournee moment)
        {
            if (moment == MomentJournee.Soir || moment == MomentJournee.Nuit)
            {
                return Expressions.English.Bonsoir;
            } else
            {
                return Expressions.English.Bonjour;
            }
        }

        /// <inheritdoc />
        public string AuRevoir => Expressions.English.AuRevoir;

        /// <inheritdoc />
        public string AuRevoirBis(MomentJournee moment) => Expressions.English.AuRevoir;
    }
}