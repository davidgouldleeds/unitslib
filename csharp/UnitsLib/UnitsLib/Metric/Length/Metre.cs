using System;

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
        public const string KilometreSymbol = "km";

        public static decimal PicometreMultiplier => 0.000_000_000_001M;
        public static decimal NanometreMultiplier => 0.000_000_001M;
        public static decimal MicronMultiplier => 0.000_001M;
        public static decimal MillimetreMultiplier => 0.001M;
        public static decimal CentimetreMultiplier => 0.01M;
        public static decimal DecimetreMultiplier => 0.1M;
        public static decimal MetreMultiplier => 1M;
        public static decimal KilometreMultiplier => 1_000M;

        public override string Name => "metre";

        public override string Description => "SI Unit of Length";

        public override string DefaultSymbol => MetreSymbol;

        public Metre(decimal value)
        {
            Value = value;
        }

        public string FormatValue(string unit, int decimalPlaces = 3)
        {
            return string.Format("{0:N" + decimalPlaces.ToString() + "}{1}",
                Value * unit switch
                {
                    PicometreSymbol => PicometreMultiplier,
                    NanometreSymbol => NanometreMultiplier,
                    MicronSymbol => MicronMultiplier,
                    MillimetreSymbol => MillimetreMultiplier,
                    CentimetreSymbol => CentimetreMultiplier,
                    DecimetreSymbol => DecimetreMultiplier,
                    MetreSymbol => MetreMultiplier,
                    KilometreSymbol => KilometreMultiplier,
                    _ => throw new InvalidOperationException("Invalid symbol: " + unit)
                },
                unit
            );
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in picometres
        /// </summary>
        /// <param name="picometres">Length in picometres</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromPicometres(decimal picometres)
        {
            return new Metre(picometres * PicometreMultiplier);
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in nanometres
        /// </summary>
        /// <param name="nanometres">Length in nanometres</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromNanometres(decimal nanometres)
        {
            return new Metre(nanometres * NanometreMultiplier);
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in microns
        /// </summary>
        /// <param name="microns">Length in microns</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromMicrons(decimal microns)
        {
            return new Metre(microns * MicronMultiplier);
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in millimetres
        /// </summary>
        /// <param name="millimetres">Length in millimetres</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromMillimetres(decimal millimetres)
        {
            return new Metre(millimetres * MillimetreMultiplier);
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in centimetres
        /// </summary>
        /// <param name="centimetres">Length in centimetres</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromCentimetres(decimal centimetres)
        {
            return new Metre(centimetres * CentimetreMultiplier);
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in decimetres
        /// </summary>
        /// <param name="decimetres">Length in decimetres</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromDecimetres(decimal decimetres)
        {
            return new Metre(decimetres * DecimetreMultiplier);
        }

        /// <summary>
        /// Return a Metric Length (metre) given a length in kilometres
        /// </summary>
        /// <param name="kilometres">Length in kilometres</param>
        /// <returns>A Metre object with the given value</returns>
        public static Metre FromKilometres(decimal kilometres)
        {
            return new Metre(kilometres * KilometreMultiplier);
        }
    }
}
