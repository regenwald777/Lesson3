double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denumenator = c + d;
    double result = numenator / denumenator;
    return result;
}

double result = CalculateFormula(1, 2, 4, 3);
Console.WriteLine(result);
