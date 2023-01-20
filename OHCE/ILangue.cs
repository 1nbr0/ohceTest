namespace OHCE
{
    public interface ILangue
    {
        string BienDit { get; }
        string DireBonjour(MomentJournee moment);
        string AuRevoir { get; }
    }
}