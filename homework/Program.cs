//task1 Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

//  Console.Clear();
//     int sum = 0;
//     int CheckNumberEven(int number) // Метод проверки числа на четность
//     {
//         /*int sum = 0;*/
//         int digit_length = (int)Math.Log10(number) + 1;
//         for (int i = digit_length; i >= 0; i--)
//         {
//             int first_digit = number / (int)Math.Pow(10, i);
//             sum = sum + first_digit;
//             number = number - first_digit * (int)Math.Pow(10, i);
//         }
//         return sum;
//     }

//     while (true) // true == true
//     {
//         Console.Write("Введите текст: ");
//         string text = Console.ReadLine()!;
//         if (text == "q")
//         {
//             break;
//         }
//         /*int sum = 0;*/
//         int number; // Число или 0 (0 - если в строчке были буквы)
//         if (int.TryParse(text, out number)) // == true, строчка состоит из цифр
//         {  

//             CheckNumberEven(number);
                    
//             if(sum % 2 == 0)
//             {
//                 break;
//             }
        
//         }
//     }

// int sum = 0;
            // int digit_length = (int)Math.Log10(number) + 1;
            // for (int i = digit_length; i >= 0; i--)
            //     {
            //         int first_digit = number / (int)Math.Pow(10, i);
            //         sum = sum + first_digit;
            //         number = number - (first_digit * (int)Math.Pow(10, i));
            //     }

//task2 Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size)
{
    int[] array = new int[size]; // Массив на size элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000); // Заполнение массива трехзначными числами
    }
    return array;
}
int ConvertArrayToInteger(int[] array)
{
    int result = 0;
    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    {
        result = result + array[i] * (int)Math.Pow(10, j);
    }
    return result;
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
// int size = N, int minRange = 10, int maxRange = 90
int[] res = CreateArray(N); // Массив на N элементов , эл: [0,9]
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
if (N > 8)
{
    Console.WriteLine("Размер > 8 элементов");
    return; // Ломает программу, если размер > 8 эл
}
Console.WriteLine($"Число: {ConvertArrayToInteger(res)}");

//task3 Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
