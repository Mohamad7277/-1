char key;

do
{
    do
    {
        key = Console.ReadKey().KeyChar;

    } while (!char.IsDigit(key) && key != '5');

    if (key != '5')
    {
        Console.Write(key);
    }
} while (key != '5');