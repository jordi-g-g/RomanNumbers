namespace RomanNumbers.App;

public class RomanNumbersConverter
{
    public string Convert(int number)
    {
        var output = "";

        while (number >= 5)
        {
            if (number == 5)
            {
                output += "V";
                number -= 5;
                break;
            }
            output += "I";
            number -= 1;
        }
        for (var i = 0; i < number; i++)
        {
            output += "I";
        }
        
        var charArray = output.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}