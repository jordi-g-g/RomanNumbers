using NUnit.Framework;
using RomanNumbers.App;

namespace RomanNumbers
{
    [TestFixture]
    public class RomanNumbersConverterShould
    {
        [Test]
        public void convert_Arabic_numbers_into_their_Roman_numeral_equivalents()
        {
            var romanNumbersConverter = new RomanNumbersConverter();
        
            Assert.That("I", Is.EqualTo(romanNumbersConverter.Convert(1)));
            Assert.That("II", Is.EqualTo(romanNumbersConverter.Convert(2)));
            Assert.That("III", Is.EqualTo(romanNumbersConverter.Convert(3)));
            Assert.That("IV", Is.EqualTo(romanNumbersConverter.Convert(4)));
            Assert.That("V", Is.EqualTo(romanNumbersConverter.Convert(5)));
            Assert.That("VI", Is.EqualTo(romanNumbersConverter.Convert(6)));
            Assert.That("VII", Is.EqualTo(romanNumbersConverter.Convert(7)));
            Assert.That("VIII", Is.EqualTo(romanNumbersConverter.Convert(8)));
            Assert.That("IX", Is.EqualTo(romanNumbersConverter.Convert(9)));
            Assert.That("X", Is.EqualTo(romanNumbersConverter.Convert(10)));
            Assert.That("XI", Is.EqualTo(romanNumbersConverter.Convert(11)));
        }
    }
}