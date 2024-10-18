using System;
using System.Collections.Generic;
using System.Text;

namespace UnitsLib.Metric.Length
{
    public class Metre : MetricUnitBase
    {
        public override string Name => "metre";

        public override string Description => "SI Unit of Length";

        public override string Symbol => "m";

        public Metre(decimal value)
        {
            Value = value;
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in millimetres
        /// </summary>
        /// <param name="millimetres">Length in millimetres</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromMillimetres(decimal millimetres)
        {
            return new Metre(millimetres / 1000M);
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in centimetres
        /// </summary>
        /// <param name="centimetres">Length in centimetres</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromCentimetres(decimal centimetres)
        {
            return new Metre(centimetres / 100M);
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in decimetres
        /// </summary>
        /// <param name="decimetres">Length in decimetres</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromDecimetres(decimal decimetres)
        {
            return new Metre(decimetres / 10M);
        }
    }
}
