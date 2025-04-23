public static class Problem02
{
    public static bool Palindromo(string message)
    {
        for (int i = 0; i < message.Length / 2; i++)
        {
            if (message[i] != message[message.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
