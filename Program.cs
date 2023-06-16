// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число"); 

// int num = Convert.ToInt32(Console.ReadLine());

// int startNum=1;

// Console.WriteLine(PrintNumbers(num,startNum));

// string PrintNumbers(int num1, int num2) {

//     if(num2>=num1)
//     {
//         return num2.ToString();
//     }    

//     return (num1+ ", " + PrintNumbers(num1-1,num2)); 
// }




// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int m = InputInt("Введите M:");
// int n = InputInt("Введите N:");


// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// int CountNaturalSum(int m, int n)
// {
//     if (m == n)
//         return n;
//     return n + CountNaturalSum(m, n - 1);
// }

// Console.WriteLine(CountNaturalSum(m, n));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int akkerman(int m, int n)
// {
// if (m == 0) {

// return n + 1;
// }


// else if (n == 0) 
// {
//     return akkerman(m - 1, 1);
// }

// else {

//     return akkerman(m - 1, akkerman(m, n - 1));

//     }
// }

// Console.Write($"A(m,n) = {akkerman(m, n)} ");