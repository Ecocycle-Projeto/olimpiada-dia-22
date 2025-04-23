public static class Problem05
{
    public static bool Anagrama(string messageA, string messageB)
    {
        if (messageA.Length != messageB.Length) return false;

        messageA = messageA.ToLower();
        messageB = messageB.ToLower();

        var dictA = new Dictionary<char, int>();
        var dictB = new Dictionary<char, int>();

        for (int i = 0; i < messageA.Length; i++)
        {
            if (dictA.ContainsKey(messageA[i]))
            {
                dictA[messageA[i]]++;
            }
            else
            {
                dictA.Add(messageA[i], 1);
            }

            if (dictB.ContainsKey(messageB[i]))
            {
                dictB[messageB[i]]++;
            }
            else
            {
                dictB.Add(messageB[i], 1);
            }
        }

        foreach (var item in dictA)
        {
            if (!dictB.ContainsKey(item.Key)) return false;

            if (item.Value != dictB[item.Key]) return false;
        }

        return true;
    }
}
