namespace OHCE.Test.xUnit.Utilities.TestDoubles
{
    internal class LangueMock : ILangue
    {
        /// <inheritdoc />
        public string BienDit { get; }

        public LangueMock(string bienDit)
        {
            BienDit = bienDit;
        }
    }
}