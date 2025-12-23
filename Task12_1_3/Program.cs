
string[] array = WriteArray();

static string[] WriteArray() {
    Console.WriteLine("Сколько элементо будет в массиве?");
    int count = int.Parse(Console.ReadLine());
    string[] array = new string[count];

    for (int i = 0; i < count; i++)
    {
        array[i] = Console.ReadLine();
    }

    Console.WriteLine("Все элементы записаны");
    
    return array;
}