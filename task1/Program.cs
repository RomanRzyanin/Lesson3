// int n = 11;
// int i = 1;

// while (i <= n)
// {
//     Console.Write($"{i * i} ");
//     i++;
// }

// task1

double calculateFormula(int a, int b, int c, int d)
{
    double numerator = a * b;
    int denomenator = c + d;
    double result = numerator / denomenator;
    return result;
}
//calculateFormula(1, 2, 3, 4);
double result = calculateFormula(1, 2, 3, 4);
Console.WriteLine(result);