// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// Console.WriteLine("Введите число А: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int result = numberA;
// for(int index = 1;index < numberB;index++)
// {
// result = result * numberA;
 
// }
// Console.WriteLine(result);




Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
 int index = 1;
int result = numberA;
while(index < numberB)
{
result = result * numberA;
 
index++;
}
Console.WriteLine(result);
