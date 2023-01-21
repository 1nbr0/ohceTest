namespace OHCE.Langues
{
    public class LangueFrancaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.Français.BienDit;

        /// <inheritdoc />
        public string DireBonjour(MomentJournee moment)
        {
            return moment == MomentJournee.Matin
                ? Expressions.Français.Bonjour
                : Expressions.Français.Bonsoir;
        }

        /// <inheritdoc />
        public string AuRevoir => Expressions.Français.AuRevoir;
    }
}