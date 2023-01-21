namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.English.BienDit;

        /// <inheritdoc />
        public string DireBonjour(MomentJournee moment)
        {
            return moment == MomentJournee.Matin
                ? Expressions.English.Bonjour
                : Expressions.English.Bonsoir;
        }

        /// <inheritdoc />
        public string AuRevoir => Expressions.English.AuRevoir;
    }
}