// See https://aka.ms/new-console-template for more information
using RomanNumbers.App;

Console.WriteLine("Enter a number to be translated into a Roman Number");

var romanNumbersConverter = new RomanNumbersConverter();
var sentence = romanNumbersConverter.Convert(1);

Console.WriteLine(sentence);
