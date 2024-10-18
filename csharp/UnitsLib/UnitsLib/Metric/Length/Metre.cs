using System;
using System.Collections.Generic;
using System.Text;

namespace UnitsLib.Metric.Length
{
    public class Metre : MetricUnitBase
    {
        public const string PicometreSymbol = "pm";
        public const string NanometreSymbol = "nm";
        public const string MicronSymbol = "µm";
        public const string MillimetreSymbol = "mm";
        public const string CentimetreSymbol = "cm";
        public const string DecimetreSymbol = "dm";
        public const string MetreSymbol = "m";

        public override string Name => "metre";

        public override string Description => "SI Unit of Length";

        public override string DefaultSymbol => "m";

        public Metre(decimal value)
        {
            Value = value;
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in picometres
        /// </summary>
        /// <param name="picometres">Length in picometres</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromPicometres(decimal picometres)
        {
            return new Metre(picometres / 1_000_000_000_000M);
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in nanometres
        /// </summary>
        /// <param name="nanometres">Length in nanometres</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromNanometres(decimal nanometres)
        {
            return new Metre(nanometres / 1_000_000_000M);
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in microns
        /// </summary>
        /// <param name="microns">Length in microns</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromMicrons(decimal microns)
        {
            return new Metre(microns / 1_000_000M);
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in millimetres
        /// </summary>
        /// <param name="millimetres">Length in millimetres</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromMillimetres(decimal millimetres)
        {
            return new Metre(millimetres / 1_000M);
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
