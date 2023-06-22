// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
int index = -number;
while(index <= number)
{
    System.Console.Write(index + " ");
    index++; // "++" аналог команды "index += 1" или "index = index + 1"
}

// // Вариант решения 2 (используется локально, только в рамках цикла {})
// System.Console.WriteLine("Введите число: ");
// int number = Math.Abs (Convert.ToInt32(Console.ReadLine()));
// // Math.Abs () делает из отрицательных чисел положительные, а положительные оставляет положительными
// for(int i = -number; i <= number; i++)
// {
//     System.Console.Write(i + " ");
// }

// // Вариант решения 3 (усложненный)
// System.Console.WriteLine("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int index = -number;
// while(index <= number)
// {
//     System.Console.Write(index + " ");
//     index++; // " index++" аналог команды "index += 1" или "index = index + 1"
// }
