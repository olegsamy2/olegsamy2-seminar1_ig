// Напишите программу, которая принимает на вход трёхзначное число 	
// и на выходе показывает вторую цифру этого числа.	
// 456 -> 5	
// 782 -> 8	
// 918 -> 1	

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondfigure = (number / 10) % 10;

if (number >= 100 & number < 1000)
{
    Console.Write($"Вторая цифра {secondfigure} трехзначного числа {number}");
}
else
{
    Console.WriteLine("Введенное число не трехзначное");
}

