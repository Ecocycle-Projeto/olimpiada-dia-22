public static class Problem03
{
    public static int[] Fibonatti(int number)
    {
        if (number == 1) return [1];

        if (number == 2) return [1, 1];

        List<int> result = [1, 1];
        for (int i = 2; i < number; i++)
        {
            var next = result[i-2] + result[i-1];
            result.Add(next);
        }

        return result.ToArray();
    }
}
