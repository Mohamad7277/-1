char key;

do
{
    do
    {
        key = Console.ReadKey().KeyChar;

    } while (!char.IsDigit(key) && key != 'R');

    if (key !=  'R')
    {
        Console.Write(key);
    }
} while (key != 'R');