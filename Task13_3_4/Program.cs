using System.Collections.Generic;
using Task13_3_4.Classes;

//Напишите метод для нашей телефонной книги, который получает на вход список и новый контакт,
//и добавляет его, только если он уникален.
//После добавления нового контакта метод должен выводить список контактов, отсортированный по имени.

var phoneBook = new List<Contact>();

phoneBook.Add(new Contact("Игорь", 79990000000, "igor@example.com"));
phoneBook.Add(new Contact("Андрей", 79990000001, "andrew@example.com"));

Contact newContact1 = new Contact("Алексей", 8999900000, "alexiss@mail.ru");
Contact newContact2 = new Contact("Андрей", 79990000001, "andrew@example.com");

AddUnique(newContact1, phoneBook);
AddUnique(newContact2, phoneBook);

foreach (var contact in phoneBook)
{
    Console.WriteLine(contact.Name);
}

static void AddUnique(Contact contact, List < Contact > phoneBook)
{

    bool checkContact = false;

    // Проверяем, есть ли в списки контакт с похожим именем.
    foreach (Contact contactForCheck in phoneBook)
    {
        if (contact.Name == contactForCheck.Name)
        // вариант с проверкой на полное совпадение всех полей в пришедшем контакте.
        //if (contact.Name == contactForCheck.Name && contact.Email == contactForCheck.Email && contact.PhoneNumber == contactForCheck.PhoneNumber)
        {
            checkContact = true;
            break;
        }
    }

        // Если контакт с похожим именем не нашелся, то добавляем его в конец телефонной книги и сортируем ее
        if(checkContact == false)
        {
            phoneBook.Add(contact);
            phoneBook.Sort();
        }
    }