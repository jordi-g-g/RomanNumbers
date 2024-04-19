namespace RomanNumbers.App;

public class RomanNumbersConverter
{
    public string Convert(int number)
    {
        var output = "";

        if (number == 10 - 1)
        {
            output += "XI";
            number -= 10 - 1;
        }
        while (number >= 10)
        {
            if (number == 10)
            {
                output += "X";
                number -= 10;
                break;
            }
            output += "I";
            number -= 1;
        }
        if (number == 5 - 1)
        {
            output += "VI";
            number -= 5 - 1;
        }
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