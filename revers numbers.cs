int n = 10;
int m = 45;
for (int i = n; i <= m; i++)
{
Console.WriteLine($"{i} is {Reverse(i)}");
}
static int Reverse(int number)
{
        int reversed = 0;
        while (number > 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }
    return reversed;
}