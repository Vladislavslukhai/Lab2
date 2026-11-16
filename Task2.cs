Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть висоту трикутника: ");
int height = int.Parse(Console.ReadLine());

for (int i = 1; i <= height; i++)
{
    for (int space = 0; space < height - i; space++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < i; j++)
    {
        Console.Write($"{i} ");
    }

    Console.WriteLine();
}