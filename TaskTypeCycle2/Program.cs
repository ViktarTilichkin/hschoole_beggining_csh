﻿// 1. Пользователь вводит границы интервала из которого программа загадывает число.
// Написать программу про поиску данного числа. Пользователь пишит число в консоль,
// программа отвечает.

{
    Console.WriteLine("Задача 1");
    Console.WriteLine("ввидите границы для загадываемого числа (мин-макс): ");
    int numberMin = Convert.ToInt32(Console.ReadLine());
    int numberMax = Convert.ToInt32(Console.ReadLine());
    int result = new Random().Next(numberMin, numberMax);
    int numberlucky;
    int attempt = 0;
    do
    {
        Console.WriteLine("угадайте число загаданое компьютером");
        bool input = int.TryParse(Console.ReadLine(), out numberlucky);
        if (result > numberlucky) Console.WriteLine("загаданное число больше");
        else if (result < numberlucky) Console.WriteLine("загаданное число меньше");
        attempt++;
    }
    while (result != numberlucky);
    Console.WriteLine($"Вы угадали число {result}, колличество попыток {attempt}");
}

// 2. Написать программу, которая подсчитывает количество в строке букв, пробелов, цифр и
// остальных символов.

{
    Console.WriteLine("Задча 2");
    Console.WriteLine("введите строку");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        int resultLetter = 0, resultNumber = 0, resultSpace = 0, resultSimbol = 0;
        foreach (char item in text)
        {
            if (char.IsLetter(item))
            {
                resultLetter++;
            }
            else if (char.IsDigit(item))
            {
                resultNumber++;
            }
            else if (item.ToString() == " ")
            {
                resultSpace++;
            }
            else
            {
                resultSimbol++;
            }
        }
        Console.WriteLine($"В строке содержится : букв {resultLetter}, цифр {resultNumber}, пробелов {resultSpace} и остальных символов {resultSimbol}");
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }

}


// 3. Пользователь вводит символ. Записать все позиции данного данного символа в строке в
// массив и вывести через символ, который кажет пользователь.

{
    Console.WriteLine("Задача 3");
    Console.WriteLine("Введите строку");
    string? text = Console.ReadLine();
    Console.WriteLine("Какой символ будем искать?");
    string? symbol = Console.ReadLine();
    if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(symbol))
    {
        int j = 0;
        string[] symbolNumbers = new string[j];
        for (int i = 0; i < text.Length; i++)
        {
            if (string.Equals(symbol, text[i].ToString()))
            {
                symbolNumbers[j] += i.ToString();
                j++;
            }
        }
        Console.WriteLine(string.Join(", ", symbolNumbers));
    }
    else
    {
        Console.WriteLine("error input");
    }

}

// 4. Пользователь вводит число N, которое является индексом последнего элемента ряда
// Фиббоначи. Вывести весь этот ряд записанный в массив.


{
    Console.WriteLine("задача 4");
    Console.WriteLine("Введите индекс числа фибонначи:  ");
    string? input = Console.ReadLine();
    if (int.TryParse(input, out int number))
    {
        int[] result = new int[2];
        result[0] = 0;
        result[1] = 1;
        for (int i = 2; i < number; i++)
        {
            result[i] = result[i - 1] + result[i - 2];
        }
        Console.WriteLine(string.Join(", ", result));
        int number0 = 0;
        int number1 = 1;
        for (int i = 2; i < number; i++)
        {
            int sum = number0 + number1;
            number0 = number1;
            number1 = sum;
        }
    }
    else
    {
        Console.WriteLine("error");
    }
}


// 5. У пользователя есть строка, удалить из неё все числа и символы ‘.’, ‘-’, ‘,’ , ‘*’ и тд. Заменить
// пробелы символом ‘/’. Если пользователь ввел символ вопрос ‘?’ он может быть только один
// и после него пробелы должны заменены на ‘=‘, все большие буквы заменить на маленькую и
// перед ней поставить ‘-’, но результирующая строка не может начинаться с ‘-’
// ПриветМир, я Пишу код*который не ВсегдаХороший)Но я?Учусь и у Меня?Все получится
// привет-мир/я/-пишу/кодкоторый/не/-всегда-хороший-но/я?-учусь=и=у=-менявсе=получится

{
    Console.WriteLine("Задача 5");
    string input = "ПриветМир, я Пишу код*который не ВсегдаХороший)Но я?Учусь и у Меня?Все получится";
    if (!string.IsNullOrEmpty(input))
    {
        string result = "";
        bool symbolSearch = true;
        bool symbolFirst = true;
        foreach (char item in input)
        {
            if (char.IsUpper(item) && symbolFirst)
            {
                result += char.ToLower(item);
                symbolFirst = false;
            }
            else if (char.IsUpper(item) && !symbolFirst)
            {
                result += char.ToLower(item);
                symbolFirst = false;
            }
            else if (char.IsLetter(item))
            {
                result += item;
            }
            else if (item.Equals(' ') && symbolSearch)
            {
                result += '/';
            }
            else if (item.Equals('?') && symbolSearch)
            {
                result += item;
                symbolSearch = false;
            }
            else if (item.Equals(' ') && !symbolSearch)
            {
                result += '=';
            }
        }
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("error");
    }
}

// 6. Праработать 7 раздличных методов char и описать через коментарий, что делает данный
// метод, его входные параметры и выходные данные

{
    Console.WriteLine("Задача 6");
    char test = 'G';
    char testSecond = '5';
    Console.WriteLine(char.IsDigit(testSecond));
    Console.WriteLine(char.IsLetter(test));
    Console.WriteLine(char.IsUpper(test));
    Console.WriteLine(char.IsWhiteSpace(test));
    Console.WriteLine(char.ToLower(test));
    Console.WriteLine(test.Equals(testSecond));
    Console.WriteLine(char.GetUnicodeCategory(testSecond));
}


// 7. Праработать 10 раздличных методов string и описать через коментарий, что делает данный
// метод, его входные параметры и выходные данные

{
    Console.WriteLine("Задача 7");
    string test = "Hello world";
    string testSecond = "   My name   ";
    Console.WriteLine(string.Concat(test, testSecond));
    Console.WriteLine(string.Format("first message - {0}, second message - {1}", test, testSecond));
    Console.WriteLine(string.Join(";", test.Split(" "), testSecond.Split(" ")));
    Console.WriteLine(string.IsNullOrEmpty(test));
    Console.WriteLine(test.Equals(testSecond));
    Console.WriteLine(testSecond.Length);
    Console.WriteLine(test.Contains(testSecond));
    Console.WriteLine(testSecond.ToUpper());
    Console.WriteLine(testSecond.Trim());
}