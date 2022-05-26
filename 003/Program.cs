void Cube(int N)
{
    Console.Write($"{N} -> ");
    for (int i = 1; i < N; i++)
    {
        Console.Write($"{Math.Pow(i, 3)},");
    }
}
Cube(6);