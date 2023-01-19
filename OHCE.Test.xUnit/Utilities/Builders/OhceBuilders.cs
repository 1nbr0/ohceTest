using OHCE.Test.xUnit.Utilities.TestDoubles;

namespace OHCE.Test.xUnit.Utilities.Builders
{
    internal class OhceBuilder
    {
        private LangueMock _langue = new LangueMock();

        public static Ohce Default => new OhceBuilder().Build();

        public Ohce Build() => new Ohce(_langue);

        public OhceBuilder AyantPourFormuleDeBienDit(string bienDit)
        {
            _langue = _langue with { BienDit = bienDit };
            return this;
        }

        public OhceBuilder AyantPourFormuleDeSalutations(string bonjour)
        {
            _langue = _langue with { Bonjour = bonjour };
            return this;
        }

        public OhceBuilder AyantPourFormuleDAdieu(string auRevoir)
        {
            _langue = _langue with { AuRevoir = auRevoir };
            return this;
        }
    }
}