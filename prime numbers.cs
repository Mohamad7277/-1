int n = 2;
int m = 200;
for (int i = n; i <= m; i++)
{
if (i < 2) continue;
bool isPrime = true;
for (int j = 2; j * j <= i; j++)
{
if (i % j == 0) isPrime = false;
}
if (isPrime) Console.WriteLine(i);
}