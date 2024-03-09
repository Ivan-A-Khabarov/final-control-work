using System;
using static System.Console;

Clear(); // Очистка консоли.

string[] array = AskArray(); // Получение массива от пользователя.
string[] result = FindLessThan(array, 3); // Фильтрация массива.

// Вывод исходного и отфильтрованного массивов на экран.
Write($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

// Функция для фильтрации строк в массиве, длина которых меньше или равна n.
string[] FindLessThan(string[] input, int n)
{
    // Создание нового массива для хранения отфильтрованных строк.
    string[] output = new string[CountLessThan(input, n)];

    // Перебор исходного массива и добавление строк, удовлетворяющих условию, в новый массив.
    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output; // Возвращение отфильтрованного массива.
}

// Функция для подсчета строк в массиве, длина которых меньше или равна n.
int CountLessThan(string[] input, int n)
{
    int count = 0; // Инициализация счетчика.

    // Перебор массива и подсчет строк, удовлетворяющих условию.
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++; // Увеличение счетчика.
        }
    }

    return count; // Возвращение количества отфильтрованных строк.
}

// Функция для запроса массива значений от пользователя.
string[] AskArray()
{
    while (true)
    {
        try
        {
            Write("Введите значения через пробел: "); // Подсказка пользователю.
            string input = ReadLine(); // Чтение ввода пользователя.

            // Проверка на пустой ввод.
            if (string.IsNullOrWhiteSpace(input))
            {
                WriteLine("Пожалуйста, введите хотя бы одно значение.");
                continue; // Возвращение к запросу значения.
            }

            return input.Split(' '); // Разделение введенной строки на массив значений.
        }
        catch (Exception ex)
        {
            WriteLine($"Ошибка: {ex.Message}"); // Вывод сообщения об ошибке.
        }
    }
}