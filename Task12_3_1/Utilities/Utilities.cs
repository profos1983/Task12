using System;
using System.Collections.Generic;
using System.Text;

namespace Task12_3_1.Utilities
{
    static class Utilities
    {
        public static void BinarySearch(int[] arrayForSearch, int numberForSearch)
        {
            // определяем длину массива
            int arrayLenght = arrayForSearch.Length;
            Console.WriteLine($"Длина массива: {arrayLenght}");

            // задаем начильные индексы первого элемента и последнего
            int count = 0;

            int left = 0;
            int right = arrayLenght - 1;

            int midle = right / 2;
            Console.WriteLine($"Вычислили середину массива: {midle}");

            Console.WriteLine($"Начальное значение левого индекса: {left}");
            Console.WriteLine($"Начальное значение правого индекса: {right}");

            // Запускаем цикл поиска
            while (left <= right)
            {
                
                Console.WriteLine($"Проход номер {count}");
                count++;
                

                if (arrayForSearch[midle] == numberForSearch) 
                {
                    Console.WriteLine($"Элемент массива равный {numberForSearch} имеет индекс {midle}");
                    break;
                }

                if(arrayForSearch[midle] < numberForSearch)
                {
                    left = midle + 1;
                    midle = (left + right) / 2;
                    
                }

                if (arrayForSearch[midle] > numberForSearch)
                {
                    right = midle - 1;
                    midle = (left + right) / 2;

                }

                
            }





        }
    }
}
