public static class Problem07
{
    public static int[] ArredondarNotas(int[] notas)
    {
        List<int> result = [];

        for (int i = 0; i < notas.Length; i++)
        {
            var nota = notas[i];

            if (nota < 40)
            {
                result.Add(nota);
            }
            else
            {
                var resto = nota % 5;
                var diff = 5 - resto;
                if (diff < 3)
                {
                    result.Add(nota + diff);
                }
                else
                {
                    result.Add(nota);
                }
            }
        }

        return result.ToArray();
    }
}
