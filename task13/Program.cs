// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.	
// 645 -> 5	
// 78 -> третьей цифры нет	
// 32679 -> 6	
	
Console.WriteLine("Введите число: ");	
int number = Convert.ToInt32(Console.ReadLine());	
	
if (number < -99)	
{	
 	Console.WriteLine("В числе " + number + " третья цифра  -> " + number.ToString()[3] );
}	
else if (number > 99)	
{	
    	
    Console.WriteLine("В числе " + number + " третья цифра  -> " + number.ToString()[2] );	
}	
	
else	
{	
    Console.WriteLine("В числе " + number + " нет третьей цифры");	
}	
	
