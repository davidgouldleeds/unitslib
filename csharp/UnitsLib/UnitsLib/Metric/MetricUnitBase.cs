namespace UnitsLib.Metric
{
    public abstract class MetricUnitBase : UnitDefinition<decimal>
    {
        public abstract string Name { get;}

        public abstract string Description { get; }

        public abstract string DefaultSymbol { get; }

        public decimal Value { get; protected set; }

        public override string ToString()
        {
            return string.Format("{0:N}{1}", Value, DefaultSymbol);
        }
    }
}
