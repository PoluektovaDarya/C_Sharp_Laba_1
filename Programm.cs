static void Main(string[] args)
{
    Console.Write("Введите Х: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double result = 0;
    for(int i = 0; i < n; i++)
    {
        result = result + (Math.Pow(-1, i) * Math.Pow(x, 2 * i)) / Factorial(2 * i + 1);
    }
    Console.WriteLine(result);
}
static int Factorial(int num)
{
    if(num == 1) { return 1; }
    return num * Factorial(num-1);
}
