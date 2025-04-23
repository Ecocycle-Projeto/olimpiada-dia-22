public static class Problem01
{
    public static long Fatorial(int number)
    {
        if (number == 0) return 1;

        if (number == 1) return 1;

        return number * Fatorial(number - 1);
    }
}
