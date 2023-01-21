namespace OHCE.Console
{
    internal static class SystemTimeMomentJournee
    {
        public static MomentJournee MomentActuelle
            => DateTime.Now.Hour switch
            {
                < 6 => MomentJournee.Nuit,
                < 12 => MomentJournee.Matin,
                < 18 => MomentJournee.AprèsMidi,
                < 21 => MomentJournee.Soir,
                _ => MomentJournee.Nuit
            };
    }
}
