namespace OHCE.Langues
{
    public class LangueFrancaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.Français.BienDit;

        /// <inheritdoc />
        public string DireBonjour(MomentJournee moment) => Expressions.Français.Bonjour;

        /// <inheritdoc />
        public string AuRevoir => Expressions.Français.AuRevoir;
    }
}