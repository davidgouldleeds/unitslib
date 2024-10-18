using NUnit.Framework;
using UnitsLib.Metric.Length;

namespace UnitsLib.Tests.Metric.Length
{
    [TestFixture]
    internal class MetreTests
    {
        [TestCase(1.623, "1.623m")]
        [TestCase(0.532, "0.532m")]
        [TestCase(-1.444, "-1.444m")]
        [TestCase(3.4, "3.4m")]
        public void TestConstructorToString(double value, string display)
        {
            var sut = new Metre((decimal)value);
            
            Assert.That(sut.ToString(), Is.EqualTo(display));
        }

        [TestCase(1623000, 1.623, "1.623m")]
        [TestCase(532987, 0.532987, "0.532987m")]
        [TestCase(-1444000, -1.444, "-1.444m")]
        [TestCase(3400000, 3.4, "3.4m")]
        [TestCase(2, 0.000_002, "0.000002m")]
        public void TestFromMicrons(double microns, double value, string display)
        {
            var sut = Metre.FromMicrons((decimal)microns);

            Assert.That(sut.Value, Is.EqualTo((decimal)value));
            Assert.That(sut.ToString(), Is.EqualTo(display));
        }

        [TestCase(1623, 1.623, "1.623m")]
        [TestCase(532, 0.532, "0.532m")]
        [TestCase(-1444, -1.444, "-1.444m")]
        [TestCase(3400, 3.4, "3.4m")]
        public void TestFromMillimetres(double millimetres, double value, string display)
        {
            var sut = Metre.FromMillimetres((decimal)millimetres);

            Assert.That(sut.Value, Is.EqualTo((decimal)value));
            Assert.That(sut.ToString(), Is.EqualTo(display));
        }

        [TestCase(162.3, 1.623, "1.623m")]
        [TestCase(53.2, 0.532, "0.532m")]
        [TestCase(-144.4, -1.444, "-1.444m")]
        [TestCase(340, 3.4, "3.4m")]
        public void TestFromCentimetres(double centimetres, double value, string display)
        {
            var sut = Metre.FromCentimetres((decimal)centimetres);

            Assert.That(sut.Value, Is.EqualTo((decimal)value));
            Assert.That(sut.ToString(), Is.EqualTo(display));
        }

        [TestCase(16.23, 1.623, "1.623m")]
        [TestCase(5.32, 0.532, "0.532m")]
        [TestCase(-14.44, -1.444, "-1.444m")]
        [TestCase(34, 3.4, "3.4m")]
        public void TestFromDecimetres(double decimetres, double value, string display)
        {
            var sut = Metre.FromDecimetres((decimal)decimetres);

            Assert.That(sut.Value, Is.EqualTo((decimal)value));
            Assert.That(sut.ToString(), Is.EqualTo(display));
        }
    }
}
