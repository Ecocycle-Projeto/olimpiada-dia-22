public static class Problem06
{
    public static int MigratoryBirds(int[] birds)
    {
        var dict = new Dictionary<int, Bird>();

        for (int i = 0; i < birds.Length; i++)
        {
            if (dict.ContainsKey(birds[i]))
            {
                dict[birds[i]].Total++;
            }
            else
            {
                dict.Add(birds[i], new() { Index = i, Total = 1 });
            }
        }

        var orderedDict = dict.OrderByDescending(x => x.Value.Total).ThenBy(x => x.Value.Index);

        return orderedDict.First().Key;
    }
}

public class Bird
{
    public int Index { get; set; }
    public int Total { get; set; }
}

