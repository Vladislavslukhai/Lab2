Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть рік: ");
if (int.TryParse(Console.ReadLine(), out int year))
{
    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        Console.WriteLine($"{year} — високосний рік.");
    else
        Console.WriteLine($"{year} — не високосний рік.");
}
else
{
    Console.WriteLine("Помилка: введіть ціле число.");
}