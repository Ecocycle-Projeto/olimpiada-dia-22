public static class Problem04
{
    public static bool QuadradoMagico(int[][] matriz)
    {
        var soma = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; i++)
            {
                soma += matriz[i][j];
            }
        }

        return false;
    }
}
