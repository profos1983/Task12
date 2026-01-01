
while (true)
{
    Console.Write("Введите строку, для выхода из программы наберите exit: ");
    string proposal = Console.ReadLine();
    if(proposal == "exit")
    {
        break;
    }

    // Список, для заполнения уникальными символами.
    var uniqueChar = new HashSet<char>();

    // Список, с цифрами.
    var numberChar = new HashSet<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

    // Список, с символами.
    var signChar = new HashSet<char>() { ',', '.', ' ' };

    // Получаем массив, состоящий из уникальных символов всего предложения.
    foreach (char ch in proposal)
    {
        uniqueChar.Add(ch);
    }

    Console.WriteLine(uniqueChar.Count);

    //сообщала, есть ли в предложении цифры;
    bool checkForNumber = uniqueChar.Overlaps(numberChar);
    if (checkForNumber == false)
    {
        Console.WriteLine("Список не содержит цифры.");
    }
    else
    {
        Console.WriteLine("Список содержит цифры.");
    }

    //подсчитывала количество уникальных символов без знаков препинания (пробел считать знаком препинания).
    int countOfUniqueSymbol = 0;
    foreach (char ch in uniqueChar)
    {
        if (!signChar.Contains(ch))
        {
            countOfUniqueSymbol++;
        }
    }

    Console.WriteLine("Количество уникальных символов без знаков препинания: " + countOfUniqueSymbol);

}