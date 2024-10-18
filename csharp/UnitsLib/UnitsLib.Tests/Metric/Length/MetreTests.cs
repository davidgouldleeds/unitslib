using UnitsLib.Metric.Length;

namespace UnitsLib.Tests.Metric.Length
{
    [TestFixture]
    internal class MetreTests
    {
        [TestCase(1.623, "1.62m")]
        [TestCase(0.532, "0.53m")]
        [TestCase(-1.444, "-1.44m")]
        [TestCase(3.4, "3.40m")]
        public void TestConstructorToString(double value, string display)
        {
            var sut = new Metre((decimal)value);
            
            Assert.That(sut.ToString(), Is.EqualTo(display));
        }

        [TestCase(1_623_000_000_000, 1.623, "1.62m")]
        [TestCase(532_987_416_047, 0.532_987_416_047, "0.53m")]
        [TestCase(-1_444_000_000_000, -1.444, "-1.44m")]
        [TestCase(3_400_000_000_000, 3.4, "3.40m")]
        [TestCase(2, 0.000_000_000_002, "0.00m")]
        public void TestFromPicometres(double picometres, double value, string display)
        {
            var sut = Metre.FromPicometres((decimal)picometres);

            Assert.That(sut.Value, Is.EqualTo((decimal)value));
            Assert.That(sut.ToString(), Is.EqualTo(display));
        }

        [TestCase(1_623_000_000, 1.623, "1.62m")]
        [TestCase(532_987_416, 0.532_987_416, "0.53m")]
        [TestCase(-1_444_000_000, -1.444, "-1.44m")]
        [TestCase(3_400_000_000, 3.4, "3.40m")]
        [TestCase(2, 0.000_000_002, "0.00m")]
        public void TestFromNanometres(double nanometres, double value, string display)
        {
            var sut = Metre.FromNanometres((decimal)nanometres);

            Assert.That(sut.Value, Is.EqualTo((decimal)value));
            Assert.That(sut.ToString(), Is.EqualTo(display));
        }

        [TestCase(1_623_000, 1.623, "1.62m")]
        [TestCase(532_987, 0.532987, "0.53m")]
        [TestCase(-1_444_000, -1.444, "-1.44m")]
        [TestCase(3_400_000, 3.4, "3.40m")]
        [TestCase(2, 0.000_002, "0.00m")]
        public void TestFromMicrons(double microns, double value, string display)
        {
            var sut = Metre.FromMicrons((decimal)microns);

            Assert.That(sut.Value, Is.EqualTo((decimal)value));
            Assert.That(sut.ToString(), Is.EqualTo(display));
        }

        [TestCase(1_623, 1.623, "1.62m")]
        [TestCase(532, 0.532, "0.53m")]
        [TestCase(-1_444, -1.444, "-1.44m")]
        [TestCase(3_400, 3.4, "3.40m")]
        public void TestFromMillimetres(double millimetres, double value, string display)
        {
            var sut = Metre.FromMillimetres((decimal)millimetres);

            Assert.That(sut.Value, Is.EqualTo((decimal)value));
            Assert.That(sut.ToString(), Is.EqualTo(display));
        }

        [TestCase(162.3, 1.623, "1.62m")]
        [TestCase(53.2, 0.532, "0.53m")]
        [TestCase(-144.4, -1.444, "-1.44m")]
        [TestCase(340, 3.4, "3.40m")]
        public void TestFromCentimetres(double centimetres, double value, string display)
        {
            var sut = Metre.FromCentimetres((decimal)centimetres);

            Assert.That(sut.Value, Is.EqualTo((decimal)value));
            Assert.That(sut.ToString(), Is.EqualTo(display));
        }

        [TestCase(16.23, 1.623, "1.62m")]
        [TestCase(5.32, 0.532, "0.53m")]
        [TestCase(-14.44, -1.444, "-1.44m")]
        [TestCase(34, 3.4, "3.40m")]
        public void TestFromDecimetres(double decimetres, double value, string display)
        {
            var sut = Metre.FromDecimetres((decimal)decimetres);

            Assert.That(sut.Value, Is.EqualTo((decimal)value));
            Assert.That(sut.ToString(), Is.EqualTo(display));
        }

        [TestCase(1.623, 1_623, "1,623.00m")]
        [TestCase(0.005_32, 5.32, "5.32m")]
        [TestCase(-14.44, -14_440, "-14,440.00m")]
        [TestCase(34, 34_000, "34,000.00m")]
        public void TestFromKilometres(double kilometres, double value, string display)
        {
            var sut = Metre.FromKilometres((decimal)kilometres);

            Assert.That(sut.Value, Is.EqualTo((decimal)value));
            Assert.That(sut.ToString(), Is.EqualTo(display));
        }
    }
}
