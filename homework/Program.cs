//task1 Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

//v.1 С использованием метода

int CheckNumberEven(int number) // Метод проверки числа на четность
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    Console.WriteLine(sum);
    return sum;

    /*int digit_length = (int)Math.Log10(number) + 1;
    // for (int i = digit_length; i >= 0; i--)
    // {
    //     int first_digit = number / (int)Math.Pow(10, i);            Зачем пошел по такому пути? Наверно, чтобы найти проще.
    //     sum = sum + first_digit;
    //     number = number - first_digit * (int)Math.Pow(10, i);
    //     //Console.WriteLine(sum);
        
    // }
    // Console.WriteLine(sum);
    // return sum;*/
}
Console.Clear();
int sum = 0;
while (true) // true == true
{
    Console.Write("Введите текст: ");
    string text = Console.ReadLine()!;
    if (text == "q")
    {
        break;
    }
    /*int sum = 0;*/
    int number; // Число или 0 (0 - если в строчке были буквы)
    if (int.TryParse(text, out number)) // == true, строчка состоит из цифр
    {
        CheckNumberEven(number);
    
        if (sum % 2 == 0 /*&& sum != 0*/) //Если прописать, что переменная sum не равна 0, то программа работает, за исключение если введен 0. В программе есть ошибка с инициализацие переменной sum!
        {
            break;
        }
    }
    
}

//v.2 без использования метода (рабочая версия)

// Console.Clear();
// while (true) // true == true
// {
//     Console.Write("Введите текст: ");
//     string text = Console.ReadLine()!;
//     if (text == "q")
//     {
//         break;
//     }
//     int sum = 0;
//     int number; // Число или 0 (0 - если в строчке были буквы)
//     if (int.TryParse(text, out number)) // == true, строчка состоит из цифр
//     {
//         while (number > 0)
//         {
//             sum = sum + number % 10;
//             number = number / 10;
//         }

//         /*int digit_length = (int)Math.Log10(number) + 1;
//         for (int i = digit_length; i >= 0; i--)
//         {
//             int first_digit = number / (int)Math.Pow(10, i);         Зачем пошел по такому пути? Наверно, чтобы найти проще.
//             sum = sum + first_digit;
//             number = number - (first_digit * (int)Math.Pow(10, i));
//         }*/

//         Console.WriteLine(sum); //Вывод числа sum для контроля

//         if (sum % 2 == 0)
//         {
//             break;
//         }
//     }
// }

//task2 Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size]; // Массив на size элементов
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000); // Заполнение массива трехзначными числами
//     }
//     return array;
// }
// int CheckNumberEven(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             result++;
//         }
//     }
//     return result;
// }
// Console.Clear();
// Console.Write("Введите размер массива: ");
// int N = /*Convert.ToInt32*/int.Parse(Console.ReadLine());  //использование Parse вместо Convert
// int[] res = CreateArray(N); 
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
// Console.WriteLine($"Число четных чисел в массиве: {CheckNumberEven(res)}");

//task3 Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

//v.1 Решение через создание второго массива и заполнение его в обратной последовательности.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size]; // Создание массива на size элементов
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-99, 100); // Заполнение исходного массива
//     }
//     return array;
// }
// int[] ArrayReverse(int[] array)
// {
//     int[] array_reverse = new int[array.Length]; // Создание массива на size элементов
//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         array_reverse[j] = array[i];
//     }
//     return array_reverse;
// }
// Console.Clear();
// Console.Write("Massive size:\t\t ");
// int N = int.Parse(Console.ReadLine()!);  //использование Parse вместо Convert
// int[] arr = CreateArray(N);
// int[] arr_reverse = ArrayReverse(arr);
// Console.WriteLine($"Massive:\t\t [ {string.Join("; ", arr)} ]");
// Console.WriteLine($"Massive reverse:\t [ {string.Join("; ", arr_reverse)} ]");

//v.2 Решение через печать исходного массива в обратной последовательности.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size]; // Создание массива на size элементов
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-99, 100); // Заполнение исходного массива
//     }
//     return array;
// }
// void PrintArrayReverse(int[] array)
// {
//     for (int i = array.Length -1; i >= 0; i--)
//     {
//         if (i == array.Length -1)
//         {
//             Console.Write($"Massive reverse: [{array[i]}, ");
//         }
//         else if (i < array.Length -1 && i > 0)
//         {
//             Console.Write($"{array[i]}, ");
//         }
//         else if (i == 0)
//         {
//             Console.Write($"{array[i]}] ");
//         }
//     }
//     return;
// }
// Console.Clear();
// Console.Write("Massive size:\t ");
// int N = int.Parse(Console.ReadLine()!);  //использование Parse вместо Convert
// int[] arr = CreateArray(N);
// Console.WriteLine($"Massive:\t [ {string.Join("; ", arr)} ]");
// PrintArrayReverse(arr);

