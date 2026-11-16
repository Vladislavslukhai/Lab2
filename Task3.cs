Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] questions =
{
    "Питання 1, які кольори у прапора України?",
    "Питання 2, в якому місті знаходиться ДТЕУ?",
    "Питання 3, який тип даних у C# зберігає true або false?",
    "Питання 4, скільки бітів в одному байті?",
    "Питання 5, який оператор повертає остачу від ділення?"
};

string[,] options =
{
    { "1. жовтий і блакитний", "2. червоний і зелений", "3. чорний і жовтий", "4. зелений і фіолетовий" },
    { "1. Вінниця", "2. Київ", "3. Львів", "4. Одеса" },
    { "1. int", "2. string", "3. bool", "4. char" },
    { "1. 4", "2. 8", "3. 16", "4. 32" },
    { "1. /", "2. *", "3. #", "4. %" }
};

int[] correctAnswers = { 1, 2, 3, 2, 4 };
int score = 0;

for (int i = 0; i < questions.Length; i++)
{
    Console.WriteLine($"Current User Score: {score}");
    Console.WriteLine(questions[i]);

    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine(options[i, j]);
    }

    Console.Write("І користувач вводить: ");
    int answer = int.Parse(Console.ReadLine());

    if (answer == correctAnswers[i])
    {
        Console.WriteLine("Correct answer");
        score += 100;
    }
    else
    {
        Console.WriteLine("Wrong Answer");
        Console.WriteLine("кінець програми.");
        return;
    }
}

Console.WriteLine($"Вітаємо! Фінальний рахунок: {score}");