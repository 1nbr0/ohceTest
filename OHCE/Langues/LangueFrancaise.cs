namespace OHCE.Langues
{
    public class LangueFrancaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.Français.BienDit;

        /// <inheritdoc />
        public string DireBonjour(MomentJournee moment)
        {
            if (moment == MomentJournee.Soir || moment == MomentJournee.Nuit)
            {
                return Expressions.Français.Bonsoir;
            }
            else
            {
                return Expressions.Français.Bonjour;
            }
        }

        /// <inheritdoc />
        public string AuRevoir => Expressions.Français.AuRevoir;

        /// <inheritdoc />
        public string AuRevoirBis(MomentJournee moment) => Expressions.Français.AuRevoir;
    }
}