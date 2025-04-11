namespace Task_1;

public class NumberTransformer
{
    public int swapDigits(int number)
    {
        int absNumber = Math.Abs(number);

        if (absNumber >= 10 && absNumber < 100)
        {
            int tens = absNumber / 10;
            int ones = absNumber % 10;
            int swapped = ones * 10 + tens;

            return swapped;
        }

        return number;
    }
}