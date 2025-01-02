Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
Console.WriteLine("Попробуй угадать число от 1 до 100.");

Random random = new Random();
int randNum = random.Next(1, 101);
int userNum = 0;
int attempts  = 0;

while (userNum != randNum)
{
    Console.Write("Введите ваше число: ");
    string input = Console.ReadLine();

    attempts++;
    if(int.TryParse(input, out userNum))
    {
        if (userNum < randNum)
            Console.WriteLine("Загаданное число больше.");

        else if (userNum > randNum)
            Console.WriteLine("Загаданное число меньше.");
        else
            Console.WriteLine($"Поздравляю! Ты угадал число {randNum}!");
    }
    else
        Console.WriteLine("Пожалуйста, введите корректное число.");   
}

Console.WriteLine($"\nСпасибо за игру! Ваши попытки {attempts}. \nНажмите любую клавишу, чтобы выйти.");
Console.ReadKey();