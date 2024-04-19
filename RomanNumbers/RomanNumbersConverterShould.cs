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
        }
    }
}