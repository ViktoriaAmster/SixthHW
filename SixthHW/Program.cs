// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3


// Console.Write("Введите любое количество ЦЕЛЫХ чисел через пробел. По оканчанию ввода нажмите Enter: ");
// string? Numbers = Console.ReadLine(); //? после названия типа означает, что эта переменная может быть NULL
// // Console.WriteLine(Numbers); //вывела строку
// string [] help = {" ", ", ", "  ", ","}; // массив разделителей строки
// string [] Numnum = Numbers.Split(help, StringSplitOptions.RemoveEmptyEntries);
// //разделила строку на массив со строками-числами


// // foreach (var j in Numnum) //вывела массив со строками-числами для проверки
// // {
// //     Console.WriteLine(j);
// // } 

// int Kolvo = 0;
// for (int i = 0; i < Numnum.Length; i++)
// {
//     if (Convert.ToDouble(Numnum[i]) > 0) Kolvo++;
// }

// Console.WriteLine($"Количество положительных чисел = {Kolvo}");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите коэффициент k1: ");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b1: ");
double B1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент k2: ");
double K2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b2: ");
double B2 = Convert.ToDouble(Console.ReadLine());


double x = ((B2 - B1) / (K1 - K2));
// Console.WriteLine(Math.Round(x,3));
double y = K1 * x + B1;
// Console.WriteLine(Math.Round(y,3));
Console.WriteLine("Точка пересечения прямых будет с координатами { " + Math.Round(x,3) + "; " + Math.Round(y,3) + " }");

