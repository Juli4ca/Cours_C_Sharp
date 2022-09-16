// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void CountPosNum ()
{
    string res = "";
    int count = 0;
    string end = "end";
    while (true)
    {
        Console.Write("Введите любую строку и нажмите клавишу Enter (для выхода введете 'end'): ");
        
        res = Console.ReadLine();
        if (res == end) break;
        int intValue = Convert.ToInt32(res);
        if (intValue > 0) count++;
        
    }
    Console.WriteLine($"Вы ввели {count} положительных чисел.");
}

CountPosNum();
