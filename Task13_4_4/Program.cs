using System.Diagnostics;
using Task13_4_4.Classes;

// Запускаем новый таймер:
var stopWatch = Stopwatch.StartNew();

// 1. Создаем новый словарь:
var contacts = new Dictionary<string, Contact>
{
    [ "Алексей" ] = new Contact (7899999999, "test1@mail.ru"),
    [ "Иван" ] = new Contact(78990000, "test2@mail.ru")
};

// 2. Добавляем новый контакт:
contacts.Add("Сергей", new Contact(7899999999, "test1@mail.ru"));

// 3. Выводим обновленный список:
Console.WriteLine("Выводим телефонную книгу: ");
foreach (var contact in contacts)
{
    Console.WriteLine(contact.Key + ": Телефонный номер - " + contact.Value.PhoneNumber + ". E-mail: " + contact.Value.Email);
    //foreach (var contactValue in contacts.Values)
    //{
    //    Console.WriteLine(contact.Key + ": Телефонный номер - " + contactValue.PhoneNumber + ". E-mail: " + contactValue.Email);
    //}
}

// 4. Изменение одного из элементов списка.
contacts["Алексей"] = new Contact(889999999, "test1@mail.ru");

// 5. Выводим список список повторно:
Console.WriteLine("Выводим телефонную книгу: ");
foreach (var contact in contacts)
{
    Console.WriteLine(contact.Key + ": Телефонный номер - " + contact.Value.PhoneNumber + ". E-mail: " + contact.Value.Email);
    //foreach (var contactValue in contacts.Values)
    //{
    //    Console.WriteLine(contact.Key + ": Телефонный номер - " + contactValue.PhoneNumber + ". E-mail: " + contactValue.Email);
    //}
}

Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);