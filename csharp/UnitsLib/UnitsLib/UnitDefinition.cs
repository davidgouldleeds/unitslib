﻿namespace UnitsLib
{
    public interface UnitDefinition<TValue>
    {
        public string Name { get; }

        public string Description { get; }

        public string DefaultSymbol { get; }

        public TValue Value { get; }
    }
}
