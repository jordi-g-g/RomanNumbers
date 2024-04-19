namespace RomanNumbers.App;

public class RomanNumbersConverter
{
    public string Convert(int number)
    {
        var output = "";

        if (number >= 5)
        {
            output += "V";
            number -= 5;
        }

        for (var i = 0; i < number; i++)
        {
            output += "I";
        }

        return output;
    }
}