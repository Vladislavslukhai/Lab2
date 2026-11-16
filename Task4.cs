Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть вираз (через пробіл): ");
string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

List<double> numbers = new List<double>();
List<string> operators = new List<string>();

for (int i = 0; i < parts.Length; i++)
{
    if (i % 2 == 0)
        numbers.Add(double.Parse(parts[i]));
    else
        operators.Add(parts[i]);
}

for (int i = 0; i < operators.Count; i++)
{
    if (operators[i] == "*" || operators[i] == "/")
    {
        numbers[i] = operators[i] == "*"
            ? numbers[i] * numbers[i + 1]
            : numbers[i] / numbers[i + 1];

        numbers.RemoveAt(i + 1);
        operators.RemoveAt(i);
        i--;
    }
}

double result = numbers[0];
for (int i = 0; i < operators.Count; i++)
{
    result = operators[i] == "+"
        ? result + numbers[i + 1]
        : result - numbers[i + 1];
}

Console.WriteLine($"Відповідь програми: {result}");