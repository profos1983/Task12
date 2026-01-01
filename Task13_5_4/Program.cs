Stack<string> words = new Stack<string>();

while (true)
{
    Console.Write("Введете слово, для добавления его в стек, или введете exit для выхода из программы: ");
    Console.WriteLine("\nВведите: pop - для того, чтобы удалить первый элемент из стека.\n         peek - для просмотрта первого элемента в стеке.");
    var input = Console.ReadLine();

    switch (input)
    {
        case "exit": return;
        case "pop":
            {
                Console.WriteLine("Из стека удалено слово: " + words.Pop());
                break;
            }
        case "peek":
            {
                Console.WriteLine("Первый элемент в стеке: " + words.Peek());
                break;
            }


        default:
            {
                words.Push(input); // Изменить здесь

                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
                break;
            }
    }


}


