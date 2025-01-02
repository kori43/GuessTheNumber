Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
bool play = true;
while (play)
{
    Console.WriteLine("\nВведите 'quit' чтобы выйти.");
    Console.WriteLine("Попробуй угадать число от 1 до 100.");
    
    Random random = new Random();
    int randNum = random.Next(1, 101);
    int userNum = 0;
    int attempts = 0;

    while (randNum != userNum)
    {
        Console.Write("Введите ваше число: ");
        string input = Console.ReadLine();

        if (input == "quit")
        {
            play = false;
            break;
        }           
        else
        {            
            if (int.TryParse(input, out userNum))
            {
                attempts++;
                if (userNum < randNum)
                    Console.WriteLine("Загаданное число больше.");                
                else if (userNum > randNum)
                    Console.WriteLine("Загаданное число меньше.");            
                else
                {
                    Console.WriteLine($"\nПоздравляю! Ты угадал число {randNum}!\nВаши попытки {attempts}.");
                    break;
                }               
            }
            else
                Console.WriteLine("Пожалуйста, введите корректное число.");
        }
    } 
}