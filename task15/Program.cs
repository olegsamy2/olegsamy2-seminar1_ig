﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.	
// 6 -> да	
// 7 -> да	
// 1 -> нет	
	
	
Console.WriteLine("Введите цифру, соответствующую дню недели:");	
int number = Convert.ToInt32(Console.ReadLine());	
	
if (number==6 || number==7)	
{	
    Console.WriteLine("  -> Да, этот день выходной");	
}	
else if (number>0 && number<6)	
{	
    Console.WriteLine("  -> Нет, это день невыходной");	
}	
else
{	
    Console.WriteLine("  -> Такой цифры, соответствующей дню недели, не существует");	
}	
