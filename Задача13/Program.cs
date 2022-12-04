// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int rundomNum = new Random().Next(100, 1000); // рандомное число
Console.WriteLine(rundomNum);
//  238
string num = rundomNum.ToString();
char result = num[2];

Console.WriteLine(result);
