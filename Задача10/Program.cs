// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает 2 цифру этого числа.
int rundomNum = new Random().Next(100, 1000); // рандомное число
Console.WriteLine(rundomNum);
//  238
int num = (rundomNum / 10) % 10;
Console.WriteLine(num);
