double counter = 1;
double answer = 0;

while (true)
{
    char[] counterDigits = counter.ToString().ToCharArray();
    if (HasTheSameDigits(counterDigits, counter * 2) &&
        HasTheSameDigits(counterDigits, counter * 3) &&
        HasTheSameDigits(counterDigits, counter * 4) &&
        HasTheSameDigits(counterDigits, counter * 5) &&
        HasTheSameDigits(counterDigits, counter * 6))
        answer = counter;
    if(answer > 0)
        break;
    counter++;
}

Console.WriteLine("The smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits is: " + answer);

bool HasTheSameDigits(Char[] digits, double number)
{
    char[] thisNumDigits = number.ToString().ToCharArray();
    Dictionary<char, int> digitCount = new();
    digitCount.Add('0', 0);
    digitCount.Add('1', 0);
    digitCount.Add('2', 0);
    digitCount.Add('3', 0);
    digitCount.Add('4', 0);
    digitCount.Add('5', 0);
    digitCount.Add('6', 0);
    digitCount.Add('7', 0);
    digitCount.Add('8', 0);
    digitCount.Add('9', 0);

    if(digits.Length != thisNumDigits.Length)
        return false;

    foreach (char c in digits)
    {
        digitCount[c]++;
    }
    foreach (char c in thisNumDigits)
    {
        digitCount[c]--;
    }
    foreach(char c in digitCount.Keys)
    {
        if(digitCount[c] != 0)
            return false;
    }
    return true;
}