using OHCE.Test.xUnit.Utilities.TestDoubles;

namespace OHCE.Test.xUnit.Utilities.Builders
{
    internal class OhceBuilder
    {
        private MomentJournee _momentJournee = MomentJournee.Defaut;

        private ILangue _langue = new LangueMock();

        public static Ohce Default => new OhceBuilder().Build();

        public Ohce Build() => new Ohce(_langue, _momentJournee);

        public OhceBuilder AyantPourLangue(ILangue langue)
        {
            _langue = langue;
            return this;
        }

        public OhceBuilder AyantPourPériodeDeLaJournée(MomentJournee moment)
        {
            _momentJournee = moment;
            return this;
        }
    }
}