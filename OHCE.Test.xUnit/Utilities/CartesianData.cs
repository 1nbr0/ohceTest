﻿using System.Collections;

namespace OHCE.Test.xUnit.Utilities
{
    internal class CartesianData : IEnumerable<object[]>
    {
        private readonly IEnumerable[] _parameters;

        public CartesianData(params IEnumerable[] parameters)
        {
            _parameters = parameters;
        }

        private object[][] InlineData => _parameters
            .Select(p => p.Cast<object>().ToArray())
            .ToArray();

        private IEnumerable<object[]> AddParameter(
            object[][] combinaisons,
            object[] parameter)
        {
            foreach (var value in parameter)
                foreach (var combinaison in combinaisons)
                    yield return combinaison.Append(value).ToArray();
        }

        /// <inheritdoc />
        public IEnumerator<object[]> GetEnumerator()
        {
            var combinaisons = InlineData
                .First()
                .Select(value => new object[] { value })
                .ToArray();

            foreach (var additionalParameters in InlineData.Skip(1))
                combinaisons = AddParameter(combinaisons, additionalParameters).ToArray();

            return combinaisons.Cast<object[]>().GetEnumerator();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
