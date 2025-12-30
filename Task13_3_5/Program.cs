using System.Collections;

//Дан строковый список месяцев (некоторые отсутствуют):
var months = new List<string>()
{
   "Jan", "Feb", "Mar", "Apr", "May"
};

//Также дан ArrayList, в котором содержатся недостающие строки:
var missing = new ArrayList()
{
   1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
};

//Напишите метод, который примет на вход обе коллекции, вырежет из второй недостающие 
//месяцы и добавит в наш список. Затем выведет результат в консоль.

SumLists(months, missing);

static void SumLists(List<string> list, ArrayList arrayList)
{
    // инициируем новый массив из семи позиций:
    var helpArray = new string[7];

    // заполняем его данными о месяцах из ArrayList:
    for(int i=0; i < 7; i++)
    {
        helpArray[i] = arrayList[i + 4].ToString() ;
    }

    // добавляем в список данные из вырезанного массива:
    for(int i=0;i < 7; i++)
    {
        list.Add(helpArray[i]);
    }

    Console.WriteLine("Список после добавления новых позиций: ");
    foreach (var item in list) 
    {
        Console.WriteLine(item);
    }
}