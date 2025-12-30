using System.Collections;

var months = new[]
{
   "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
};

var numbers = new[]
{
   1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
};

// Сохраните их значения в ArrayList так, чтобы после строкового названия месяца шёл его числовой номер.

var arrayList = new ArrayList();

foreach(var month in months)
{
    arrayList.Add(month);
    arrayList.Add(numbers[arrayList.Count/2]);
}

foreach (var element in arrayList)
{
    Console.WriteLine(element.ToString());
}