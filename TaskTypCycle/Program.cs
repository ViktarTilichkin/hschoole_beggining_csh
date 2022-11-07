﻿// 1. Выведите столбец чисел от 1 до 50. for, while

{
    Console.WriteLine("for");
    for (int i = 1; i <= 50; i++)
    {
        Console.WriteLine(i);
    }
    int number = default;
    Console.WriteLine("while");
    while (number < 50)
    {
        Console.WriteLine(++number);
    }
}

// 2. [1, 2, 3, 4, 5]. Выведите каждый элемент массива 3 любыми циклами

{
    int[] number = new int[] { 1, 2, 3, 4, 5 };
    for (int i = 0; i < number.Length; i++)
    {
        Console.WriteLine(number[i]);
    }
    int index = 0;
    while (index < number.Length)
    {
        Console.WriteLine(number[index++]);
    }
    foreach (int items in number)
    {
        Console.WriteLine(items);
    }
}

// 3. Дан массив с элементами [2, 3, 4, 5]. С помощью 3 циклов найдите произведение
// элементов этого массива.

{
    int[] number = new int[] { 2, 3, 4, 5 };
    int result = 1;
    int i = 0;
    while (i < number.Length)
    {
        result = result * number[i];
        i++;
    }
    Console.WriteLine(result);
    result = 1;
    for (int j = 0; j < number.Length; j++)
    {
        result *= number[j];
    }
    Console.WriteLine(result);
    result = 1;
    foreach (int item in number)
    {
        result *= item;
    }
    Console.WriteLine(result);
}

// 4. Выведите столбец чисел от 11 до 33 циклом while
{
    for (int i = 11; i <= 33; i++)
    {
        Console.WriteLine(i);
    }
    int number = 11;
    while (number < 33)
    {
        Console.WriteLine(++number);
    }

}

// 5. Выведите столбец четных чисел в промежутке от 0 до 100 (for)

{
    Console.WriteLine("Задача 5");
    for (int i = 0; i < 101; i++)
    {
        if (i % 2 == 0)
            Console.WriteLine(i);
    }
}

// 6. С помощью цикла while найдите сумму чисел от 1 до 100.

{
    Console.WriteLine("Задача 6");
    int number = 0;
    int result = 0;
    while (number < 100)
    {
        number += 1;
        result += number;
    }
    Console.WriteLine(result);
}

// 7. Дан массив с элементами [1, 2, 3, 4, 5]. С помощью цикла foreach in найдите сумму
// элементов этого массива

{
    Console.WriteLine("Задача 7");
    int[] number = { 1, 2, 3, 4, 5 };
    int result = 0;
    foreach (int numbers in number)
    {
        result += numbers;
    }
    Console.WriteLine(result);
}

// 8. Дан массив 2, 5, 9, 15, 0, 4. Выведите все числа кратные 3 циклом foreach in

{
    Console.WriteLine("задача 8");
    int[] number = { 2, 5, 9, 15, 0, 4 };
    foreach (int result in number)
    {
        if (result % 3 == 0 && result != 0)
            Console.WriteLine(result);
    }
}

// 9. Дан массив с элементами [1, 2, 2, 3, 4, 4, 3, 4, 5]. Выведите только уникальные
// значения массива -> [1, 5] (for)

{
    Console.WriteLine("Задача 9");
    int[] number = { 1, 2, 2, 3, 4, 4, 3, 4, 5 };
    int number1 = 0, number2 = 0, number3 = 0, number4 = 0, number5 = 0;
    string result = "Уникальные числа ";
    for (int i = 0; i < number.Length; i++)
    {
        switch (number[i])
        {
            case 1:
                number1++;
                break;
            case 2:
                number2++;
                break;
            case 3:
                number3++;
                break;
            case 4:
                number4++;
                break;
            case 5:
                number5++;
                break;
        }
    }
    result += number1 == 1 ? " число 1 уникально" : "";
    result += number2 == 1 ? " число 2 уникально" : "";
    result += number3 == 1 ? " число 3 уникально" : "";
    result += number4 == 1 ? " число 4 уникально" : "";
    result += number5 == 1 ? " число 5 уникально" : "";
    Console.WriteLine(result);
}

// 10. Дан массив 2, 5, 9, 15, 0, 4. Выведите все числа кратные 5 циклом while

{
    Console.WriteLine("задача 10");
    int[] number = { 2, 5, 9, 15, 0, 4 };
    int i = 0;
    while (i < number.Length)
    {
        if (number[i] % 5 == 0 && number[i] != 0)
        {
            Console.WriteLine(number[i]);
        }
        i++;
    }
}
// 11. Дан массив с числами. Числа могут быть положительными и отрицательными.
// Найдите сумму всех положительных элементов массива циклом foreach in

{
    Console.WriteLine("задача 11");
    Console.Write("Введите массив чисел  ");
    string? number = Console.ReadLine();
    int result = 0;
    if (!string.IsNullOrEmpty(number))
    {
        string[] numbers = number.Split(" ");
        foreach (string items in numbers)
        {
            if (int.TryParse(items, out int numberA))
            {
                Console.WriteLine(numberA);
                if (numberA > 0)
                {
                    result += numberA;
                }
            }
        }
    }
    Console.WriteLine(result);
}

// 12. Дан массив числами, например: [10, 20, 30, 50, 235, 3000]. Выведите на экран только
// те числа из массива, которые начинаются на цифру 1, 2 или 5 -> 10, 20, 50, 235

// 13. Дан массив с элементами 1, 2, 3, 4, 5, 6, 7, 8, 9. С помощью цикла for создайте строку
// '-1-2-3-4-5-6-7-8-9-‘

// 14. Дано число 7, найдите все числа кратные 7 до 100

// 15. Дано предложение и количество раз которое его надо повторить. Напишите
// программу, которая повторяет данное предложение нужное количество раз.

// 16. Пользователь вводит число, явдяющееся количеством элементов будущего
// массива и выбирает тип данных массива. Напишите код заполнения массива
// выбранным типом данных.

// 17. Пользователь вводит число, явдяющееся количеством элементов будущего
// массива. Напишите код заполнения массива. Записать в массив только числа.

// 18. Пользователь вводит многозначное число. Необходимо вставить двоеточие
// между двумя нечетными числами. Работать с числом как с массивом.
// Использовать for
// 55639217 -> 5:563:921:7.